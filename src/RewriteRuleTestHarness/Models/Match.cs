namespace RewriteRuleTestHarness.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Match
    {
        [System.Xml.Serialization.XmlAttribute("url")]
        public string Url { get; set; }
        
        [System.Xml.Serialization.XmlAttribute("ignoreCase")]
        public bool IgnoreCase { get; set; } = true;
    }
}