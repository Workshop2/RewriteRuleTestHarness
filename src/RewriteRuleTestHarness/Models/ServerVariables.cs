namespace RewriteRuleTestHarness.Models
{
    public class ServerVariables
    {
        [System.Xml.Serialization.XmlElement("set")]
        public ServerVariable[] ServerVariablesList { get; set; }
    }
}