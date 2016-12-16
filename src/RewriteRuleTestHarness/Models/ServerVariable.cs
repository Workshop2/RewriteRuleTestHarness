namespace RewriteRuleTestHarness.Models
{
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ServerVariable
    {
        [System.Xml.Serialization.XmlAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlAttribute("value")]
        public string Value { get; set; }
    }
}