using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDS.RDF;
using VDS.RDF.Ontology;

namespace ExcelRDF
{
    static class DotNetRdfExtensions
    {
        public static bool IsTopNamedClass(this OntologyClass cls)
        {
            return cls.IsNamed() && !cls.DirectSuperClasses.Any(superCls => superCls.IsNamed() && !superCls.Resource.ToString().Equals("http://www.w3.org/2002/07/owl#Thing"));
        }

        public static bool IsNamed(this OntologyResource ontResource)
        {
            return ontResource.Resource.IsUri();
        }

        public static bool IsUri(this INode node)
        {
            return node.NodeType.Equals(NodeType.Uri);
        }

        public static IUriNode GetUriNode(this OntologyResource ontResource)
        {
            if (!ontResource.IsNamed())
            {
                throw new RdfException($"Ontology resource {ontResource} does not have an IRI.");
            }
            return ontResource.Resource.AsUriNode();
        }

        public static IUriNode AsUriNode(this INode node)
        {
            if (!node.IsUri())
            {
                throw new RdfException($"Node {node} is not an URI node.");
            }
            return node as IUriNode;
        }

        public static Uri GetIri(this OntologyResource ontResource)
        {
            return ontResource.GetUriNode().Uri;
        }

        public static bool IsOwlThing(this OntologyClass cls)
        {
            Uri owlThing = new Uri("http://www.w3.org/2002/07/owl#Thing");
            return cls.IsNamed() && cls.GetIri().Equals(owlThing);
        }
    }
}
