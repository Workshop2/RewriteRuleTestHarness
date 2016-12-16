namespace RewriteRuleTestHarness.Models
{
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Condition
    {
        [System.Xml.Serialization.XmlAttribute("input")]
        public string Input { get; set; }

        [System.Xml.Serialization.XmlAttribute("pattern")]
        public string Pattern { get; set; }

        [System.Xml.Serialization.XmlAttribute("negate")]
        public bool Negate { get; set; }

        [System.Xml.Serialization.XmlAttribute("ignoreCase")]
        public bool IgnoreCase { get; set; } = true;
    }
}