namespace RewriteRuleTestHarness.Models
{
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Action
    {
        [System.Xml.Serialization.XmlAttribute("type")]
        public ActionType Type { get; set; }
        
        [System.Xml.Serialization.XmlAttribute("logRewrittenUrl")]
        public bool LogRewrittenUrl { get; set; }
        
        [System.Xml.Serialization.XmlAttribute("url")]
        public string Url { get; set; }
        
        [System.Xml.Serialization.XmlAttribute("appendQueryString")]
        public bool AppendQueryString { get; set; }
        
        [System.Xml.Serialization.XmlAttribute("redirectType")]
        public RedirectType RedirectType { get; set; }
        
        [System.Xml.Serialization.XmlAttribute("statusCode")]
        public ushort StatusCode { get; set; }
        
        [System.Xml.Serialization.XmlAttribute("statusReason")]
        public string StatusReason { get; set; }
        
        [System.Xml.Serialization.XmlAttribute("statusDescription")]
        public string StatusDescription { get; set; }
    }
}