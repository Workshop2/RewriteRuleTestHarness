using System.Xml.Serialization;
using RewriteRuleTestHarness.Models;

namespace RewriteRuleTestHarness
{
    public class RewriteRulesParser
    {
        private readonly IFileStreamerer _fileStreamerer;

        public RewriteRulesParser() : this(new FileStreamerer())
        { }

        internal RewriteRulesParser(IFileStreamerer fileStreamerer)
        {
            _fileStreamerer = fileStreamerer;
        }

        public InboundRules ParseRules(string pathToXmlRules)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(InboundRules));
            return serializer.Deserialize(_fileStreamerer.ReadFile(pathToXmlRules)) as InboundRules;
        }
    }
}