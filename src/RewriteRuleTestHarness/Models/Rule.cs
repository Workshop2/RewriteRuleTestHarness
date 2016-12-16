namespace RewriteRuleTestHarness.Models
{
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Rule
    {
        [System.Xml.Serialization.XmlAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlAttribute("stopProcessing")]
        public bool StopProcessing { get; set; }


        [System.Xml.Serialization.XmlElement("match")]
        public Match Match { get; set; }

        [System.Xml.Serialization.XmlElement("conditions")]
        public Conditions Conditions { get; set; }

        [System.Xml.Serialization.XmlElement("serverVariables")]
        public ServerVariables ServerVariables { get; set; }

        [System.Xml.Serialization.XmlElement("action")]
        public Action Action { get; set; }
    }
}