using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using VDS.RDF.Ontology;
using VDS.RDF.Parsing;
using VDS.RDF;
using Microsoft.Office.Interop.Excel;
using VDS.RDF.Writing;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace RdfTranslationAddIn
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }

        private void loadOntologyButton_Click(object sender, RibbonControlEventArgs e)
        {
            // Displays an OpenFileDialog so the user can select an ontology.  
            OpenFileDialog openOntologyFileDialog = new OpenFileDialog();
            openOntologyFileDialog.Filter = "RDF/XML (*.rdf)|*.rdf|Turtle (*.ttl)|*.ttl|JSON-LD (*.jsonld)|*.jsonld|NTriples (*.nt)|*.nt|NQuads (*.nq)|*.nq|TriG (*.trig)|*.trig";
            openOntologyFileDialog.Title = "Select an ontology file";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and an OWL file was selected, open it.  
            if (openOntologyFileDialog.ShowDialog() == DialogResult.OK)
            {
                OntologyGraph g = new OntologyGraph();
                FileLoader.Load(g, openOntologyFileDialog.FileName);

                // Iterate through the named bottom classes; generate one worksheet for each (named from URI fragment)
                foreach (OntologyClass oClass in g.OwlClasses)
                {
                    if (oClass.IsBottomClass && oClass.Resource.NodeType == NodeType.Uri)
                    {
                        Worksheet newWorksheet = Globals.ThisAddIn.Application.Worksheets.Add();
                        
                        UriNode classAsUriNode = (UriNode)oClass.Resource;
                        string classFragment = classAsUriNode.Uri.Fragment.TrimStart('#');
                        newWorksheet.Name = classFragment;

                        // Start iterating from the first column
                        int column = 1;

                        // Add column for the IRI identifier
                        // <IRI> is a special identifier used for this purpose, signaling that a) the IRI shall
                        // be minted from this column, and b) the subsequent row will contain the OWL class for all minted entities
                        string identifierColumnName = GetExcelColumnName(column);
                        string identifierColumnHeaderCellIdentifier = String.Format("{0}1", identifierColumnName);
                        Range identifierColumnHeaderCell = newWorksheet.get_Range(identifierColumnHeaderCellIdentifier);
                        identifierColumnHeaderCell.Value = "Identifier";
                        string identifierNote = "<IRI>";
                        identifierNote += String.Format("\n<{0}>", classAsUriNode.Uri.ToString());
                        identifierColumnHeaderCell.NoteText(identifierNote);
                        column++;

                        // Iterate through the properties for which this class is in the domain; 
                        // generate one column for each property (named from IRI fragment)
                        // Order the columns by type, with datatype properties coming before object properties, 
                        // then by string representation
                        foreach (OntologyProperty oProperty in oClass.IsDomainOf.OrderBy(o => o.Types.First()).OrderBy(o => o.ToString()))
                        {
                            if (oProperty.Resource.NodeType == NodeType.Uri)
                            {
                                UriNode propertyAsUriNode = (UriNode)oProperty.Resource;

                                // This is because Excel uses strange adressing, i.e., "A1" instead of something 
                                // numeric and zero-indexed such as "0,0".
                                string headerColumnName = GetExcelColumnName(column);
                                string headerCellIdentifier = String.Format("{0}1", headerColumnName);
                                Range headerCellRange = newWorksheet.get_Range(headerCellIdentifier);

                                // Find and assign label
                                string propertyLabel;
                                if (oProperty.Label.Count() > 0)
                                {
                                    ILiteralNode labelNode = oProperty.Label.First();
                                    propertyLabel = labelNode.Value;
                                }
                                else
                                {
                                    propertyLabel = propertyAsUriNode.Uri.Fragment.TrimStart('#');
                                }
                                headerCellRange.Value = propertyLabel;

                                // Assign property IRI
                                string noteText = String.Format("<{0}>", propertyAsUriNode.Uri.ToString());

                                // Asign property type hinting
                                string propertyType = oProperty.Types.First().ToString();
                                noteText += String.Format("\n<{0}>", propertyType);

                                // Assign range hinting IRI (provided simple )
                                OntologyClass[] namedRanges = oProperty.Ranges.Where(o => o.Resource.NodeType == NodeType.Uri).ToArray();
                                if (namedRanges.Count() > 0)
                                {
                                    UriNode rangeAsUriNode = (UriNode)namedRanges.First().Resource;
                                    string rangeUri = rangeAsUriNode.Uri.ToString();
                                    noteText += String.Format("\n<{0}>", rangeUri);
                                }

                                // Assign note text
                                // TODO: Split into multiple calls if length > 256 chars
                                headerCellRange.NoteText(noteText);
                                column++;
                            }
                        }

                        // Bold the header row and fit the columns so things look nice
                        Range headerRow = newWorksheet.get_Range("A1").EntireRow;
                        headerRow.Font.Bold = true;
                        headerRow.Columns.AutoFit();
                    }
                }
            }
        }

        private struct HeaderFields
        {
            public IUriNode propertyIri;
            public Uri propertyType;
            public Uri propertyRange;
        }

        private Uri ConcatenateAsUri(Uri rootUri, string endFragment)
        {
            string combined = string.Format("{0}{1}", rootUri.ToString(), endFragment);
            return new Uri(combined);
        }

        HashSet<Uri> getNamespaceUrisFromComments(Range sourceRange)
        {
            // Used for filtering spurious hits out later
            List<string> wellknownNamespaces = new List<String> { NamespaceMapper.OWL, NamespaceMapper.RDF, NamespaceMapper.RDFS, NamespaceMapper.XMLSCHEMA };

            HashSet<Uri> retVal = new HashSet<Uri>();
            // Iterate through range
            foreach (Range cell in sourceRange.Cells)
            {
                // If there are notes, read them
                if (cell.NoteText().Count() > 0)
                {
                    string noteText = cell.NoteText();
                    // Parse notes by line
                    foreach (string noteTextComponent in noteText.Split('\n'))
                    {
                        // Trim enclosure and see if we get a URI out
                        Char[] trimUrisChars = new Char[] { '<', '>' };
                        if (Uri.TryCreate(noteTextComponent.Trim(trimUrisChars), UriKind.Absolute, out Uri noteTextComponentUri) == true)
                        {
                            // Yay, we have a Uri! Now let's figure out which type. Start by removing any query data if it exists
                            string nameSpaceUri = noteTextComponentUri.GetLeftPart(UriPartial.Path);
                            if (noteTextComponentUri.Fragment.Equals(""))
                            {
                                // There's no fragment, i.e., this is a slash URI; strip everything after the last slash.
                                nameSpaceUri = nameSpaceUri.Substring(0, nameSpaceUri.LastIndexOf('/') + 1);
                            }
                            else
                            {
                                // There is a fragment, i.e., this is a hash URI; build the namespace from the
                                // path and add back the closing hash
                                nameSpaceUri = nameSpaceUri + "#";
                            }
                            // Finally, if the resulting name space URI is not in the default mappings already, add it to the list
                            if (!wellknownNamespaces.Contains(nameSpaceUri)) {
                                retVal.Add(new Uri(nameSpaceUri));
                            }
                        }
                    }
                }
            }
            return retVal;
        }

        private void exportRdfButton_Click(object sender, RibbonControlEventArgs e)
        {
            // Generate candidate list of namespaces to map, for the export dialog to consume
            HashSet<Uri> candidateNamespaces = new HashSet<Uri>();
            foreach (Worksheet worksheet in Globals.ThisAddIn.Application.Worksheets)
            {
                int lastUsedColumnIndex = worksheet.UsedRange.Columns.Count;
                string lastUsedColumnName = GetExcelColumnName(lastUsedColumnIndex);
                Range headerRange = worksheet.get_Range(String.Format("A1:{0}1", lastUsedColumnName));
                candidateNamespaces.UnionWith(getNamespaceUrisFromComments(headerRange));
            }
            Globals.ThisAddIn.candidateNamespacesToMap = candidateNamespaces;

            ExportOptionsForm exportOptionsForm = new ExportOptionsForm();
            if (exportOptionsForm.ShowDialog() == DialogResult.OK)
            {
                // Get the Uri set in the dialog
                Uri exportNamespace = Globals.ThisAddIn.exportNamespace;

                // Set up save file UI
                SaveFileDialog saveRdfFileDialog = new SaveFileDialog();
                saveRdfFileDialog.Filter = "RDF/XML (*.rdf)|*.rdf|Turtle (*.ttl)|*.ttl|NTriples (*.nt)|*.nt";
                saveRdfFileDialog.Title = "Save RDF file";
                if (saveRdfFileDialog.ShowDialog() == DialogResult.OK)
                {

                    // Initiate DotNetRdf Graph and shared IRI:s
                    IGraph g = new Graph();
                    IUriNode rdfType = g.CreateUriNode(UriFactory.Create(RdfSpecsHelper.RdfType));

                    // Assign namespace mappings from export dialog
                    foreach (KeyValuePair<string, Uri> entry in Globals.ThisAddIn.exportPrefixMappings)
                    {
                        g.NamespaceMap.AddNamespace(entry.Key, entry.Value);
                    }

                    // Used to trim URI:s
                    Char[] trimUrisChars = new Char[] { '<', '>' };

                    // Iterate over all worksheets
                    foreach (Worksheet worksheet in Globals.ThisAddIn.Application.Worksheets)
                    {
                        // Which bits of the sheet are being used
                        Range usedRange = worksheet.UsedRange;
                        int lastUsedRow = usedRange.Row + usedRange.Rows.Count - 1;
                        int lastUsedColumn = usedRange.Column + usedRange.Columns.Count - 1;

                        // Identifier column metadata
                        int identifierColumn = 0;

                        // Class name is tentatively in the data namespace until the identifier column is found
                        Uri className = ConcatenateAsUri(exportNamespace, worksheet.Name);

                        // Set up lookup table. Note that we use 1-indexing to simplify mapping to/from Excel
                        // ranges. The 0:th column will thus be empty and should not be adressed, as will the
                        // identifier column.
                        HeaderFields[] headerLookupTable = new HeaderFields[lastUsedColumn + 1];

                        // Parse the header row.
                        string lastUsedColumnName = GetExcelColumnName(lastUsedColumn);
                        Range headerRange = worksheet.get_Range(String.Format("A1:{0}1", lastUsedColumnName));
                        foreach (Range headerCell in headerRange.Cells)
                        {
                            int column = headerCell.Column;

                            // If there is an embedded note, proceed
                            if (headerCell.NoteText().Count() > 0)
                            {
                                string noteText = headerCell.NoteText();
                                string[] noteTextComponents = noteText.Split('\n');

                                string iriComponent = noteTextComponents[0];
                                if (iriComponent.Equals("<IRI>"))
                                {
                                    // This is the identifier column; update worksheet metadata accordingly
                                    identifierColumn = headerCell.Column;
                                    if (noteTextComponents.Count() > 1)
                                    {
                                        string classComponent = noteTextComponents[1];
                                        string classComponentTrimmed = classComponent.Trim(trimUrisChars);
                                        className = new Uri(classComponentTrimmed);
                                    }
                                }
                                else
                                {
                                    HeaderFields hf = new HeaderFields();
                                    hf.propertyIri = g.CreateUriNode(UriFactory.Create(iriComponent.Trim(trimUrisChars)));
                                    if (noteTextComponents.Count() > 1)
                                    {
                                        string propertyTypeComponent = noteTextComponents[1];
                                        hf.propertyType = new Uri(propertyTypeComponent.Trim(trimUrisChars));
                                    }
                                    if (noteTextComponents.Count() > 2)
                                    {
                                        string propertyRangeComponent = noteTextComponents[2];
                                        hf.propertyRange = new Uri(propertyRangeComponent.Trim(trimUrisChars));
                                    }
                                    headerLookupTable[column] = hf;
                                }
                            }
                        }

                        // Now, assuming an identifier column has been found, we can finally start parsing the rows
                        if (identifierColumn != 0)
                        {
                            // All entities will have the same class
                            IUriNode worksheetClass = g.CreateUriNode(className);

                            // For every row in the spreadsheet..
                            for (int rowIndex = 2; rowIndex <= lastUsedRow; rowIndex++)
                            {
                                string rowRangeIdentifier = String.Format("{0}{1}:{2}{3}", GetExcelColumnName(1), rowIndex, GetExcelColumnName(lastUsedColumn), rowIndex);
                                Range row = worksheet.get_Range(rowRangeIdentifier);

                                // Set subject node ID. 
                                string identifierCellIdentifier = String.Format("{0}{1}", GetExcelColumnName(identifierColumn), rowIndex);
                                Range identifierCell = worksheet.get_Range(identifierCellIdentifier);
                                Uri subjectUri = ConcatenateAsUri(exportNamespace, identifierCell.Text);
                                IUriNode subjectNode = g.CreateUriNode(subjectUri);
                                g.Assert(new Triple(subjectNode, rdfType, worksheetClass));

                                // Iterate over remaining columns, i.e., property instances, skipping the identifier column if it reappears
                                foreach (Range dataCell in row.Cells)
                                {
                                    if (dataCell.Column == identifierColumn)
                                    {
                                        continue;
                                    }

                                    HeaderFields hf = headerLookupTable[dataCell.Column];
                                    IUriNode predicateNode = hf.propertyIri;

                                    // Get out and parse object. 
                                    // "Raw" cell value, will need treatment (TODO!)
                                    INode objectNode;
                                    string cellValue = dataCell.Text;

                                    if (hf.propertyType.ToString().Equals(OntologyHelper.OwlDatatypeProperty))
                                    {
                                        objectNode = g.CreateLiteralNode(cellValue, hf.propertyRange);
                                    }
                                    else
                                    {
                                        Uri objectUri = ConcatenateAsUri(exportNamespace, cellValue);
                                        objectNode = g.CreateUriNode(objectUri);
                                    }
                                    g.Assert(new Triple(subjectNode, predicateNode, objectNode));

                                }
                            }
                            String saveFileExtension = Path.GetExtension(saveRdfFileDialog.FileName);
                            IRdfWriter writer = MimeTypesHelper.GetWriterByFileExtension(saveFileExtension);
                            writer.Save(g, saveRdfFileDialog.FileName);
                        }
                    }
                }
            }
        }
    }
}
