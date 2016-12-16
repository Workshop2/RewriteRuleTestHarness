using System.Linq;

namespace RewriteRuleTestHarness.Models
{
    public class ServerVariables
    {
        [System.Xml.Serialization.XmlElement("set")]
        public ServerVariable[] ServerVariablesList { get; set; }

        public ServerVariable this[int index] => ServerVariablesList[index];
        public ServerVariable this[string name] => ServerVariablesList.FirstOrDefault(x => x.Name.Equals(name));
    }
}