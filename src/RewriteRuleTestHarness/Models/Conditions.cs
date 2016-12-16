namespace RewriteRuleTestHarness.Models
{
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Conditions
    {
        [System.Xml.Serialization.XmlElement("add")]
        public Condition[] ConditionList { get; set; }
        
        [System.Xml.Serialization.XmlAttribute("logicalGrouping")]
        public LogicalGroupingType LogicalGrouping { get; set; }
        
        [System.Xml.Serialization.XmlAttribute("trackAllCaptures")]
        public bool TrackAllCaptures { get; set; }
    }
}