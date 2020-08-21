using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharp_task2
{
    [Serializable]
    [XmlInclude(typeof(Master))]
    public class Bachelor
    {
        public string Name { get; set; }
        public string Surname { get; set;}
        public string Faculty { get; set; }
        public Bachelor(string name, string surname, string faculty)
        {
            Name = name;
            Surname = surname;
            Faculty = faculty;
        }
        public Bachelor() { }
    }
}
