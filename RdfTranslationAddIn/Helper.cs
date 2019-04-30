using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDS.RDF;
using VDS.RDF.Ontology;

namespace RdfTranslationAddIn
{
    internal static class Helper
    {
        internal static string GetExcelColumnName(int columnNumber)
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

        /// <summary>
        ///  Get a label for an ontology resource, if it exists; else get the full URI.
        /// </summary>
        /// <param name="ontologyResource"></param>
        /// <returns></returns>
        internal static string GetLabel(OntologyResource ontologyResource)
        {
            string enLabel = "";
            // Iterate over all resource labels
            foreach (ILiteralNode label in ontologyResource.Label)
            {
                // If a language-agnostic label is found, return it immediately
                if (label.Language == "")
                {
                    return label.Value;
                }
                // If an english-language label is found, store it for later
                if (label.Language == "en")
                {
                    enLabel = label.Value;
                }
            }
            // Fallback option -- use the English label
            if (enLabel != "")
            {
                return enLabel;
            }
            else
            {
                // Fallback to the fallback option -- use resource IRI, either by extracting local name 
                // (if it is a URI node) or using whatever representation the resource provides
                if (ontologyResource.Resource.NodeType == NodeType.Uri)
                {
                    IUriNode uriNode = (IUriNode)ontologyResource.Resource;
                    return GetLocalName(uriNode.Uri);
                }
                else
                {
                    return ontologyResource.ToString();
                }
            }
        }

        internal static string GetLocalName(Uri uri)
        {
            if (uri.Fragment.Equals(""))
            {
                // There's no fragment, i.e., this is a slash URI; return substring after the last slash.
                string uriString = uri.ToString();
                return uriString.Substring(uriString.LastIndexOf("/") + 1);
            }
            else
            {
                // There is a fragment, i.e., this is a hash URI; so return the fragment (minus hash) as local name.
                return uri.Fragment.TrimStart('#');
            }
        }

        internal static HashSet<Uri> getNamespaceUrisFromComments(Range sourceRange)
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
                            if (!wellknownNamespaces.Contains(nameSpaceUri))
                            {
                                retVal.Add(new Uri(nameSpaceUri));
                            }
                        }
                    }
                }
            }
            return retVal;
        }
    }
}
