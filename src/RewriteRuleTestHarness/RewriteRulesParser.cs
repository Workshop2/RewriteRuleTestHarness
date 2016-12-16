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

        public InboundRules ParseInboundRules(string pathToXmlRules)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(InboundRules));

            using (var stream = _fileStreamerer.ReadFile(pathToXmlRules))
            {
                return serializer.Deserialize(stream) as InboundRules;
            }
        }
    }
}