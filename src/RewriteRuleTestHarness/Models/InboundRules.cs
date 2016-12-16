namespace RewriteRuleTestHarness.Models
{
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRoot("rules", IsNullable = false)]
    public class InboundRules
    {
        [System.Xml.Serialization.XmlElement("rule")]
        public Rule[] Rules { get; set; }
    }
}