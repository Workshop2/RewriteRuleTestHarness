using System.Linq;

namespace RewriteRuleTestHarness.Models
{
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRoot("rules", IsNullable = false)]
    public class InboundRules
    {
        [System.Xml.Serialization.XmlElement("rule")]
        public Rule[] Rules { get; set; }

        public Rule this[string ruleName] => Rules.FirstOrDefault(x => x.Name.Equals(ruleName));
        public Rule this[int index] => Rules[index];
    }
}