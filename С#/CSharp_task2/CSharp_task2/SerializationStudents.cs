using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CSharp_task2
{
    class SerializationStudents
    {
        [XmlAttribute] public List<Bachelor> Students { get; set; }
        public string FileName { get; set; } = "";
        FileStream stream;

        public void CreateList()
        {
            Students = new List<Bachelor>();
        }

        public void Save(string fName)
        {
            FileName = fName;
            Save();
        }
        public void Save()
        {
            stream = new FileStream(FileName, FileMode.Create);
            var XML = new XmlSerializer(typeof(List<Bachelor>));
            XML.Serialize(stream, Students);
            stream.Close();
        }

        public void OpenList(string fName)
        {
            FileName = fName;
            Students = new List<Bachelor>();
            stream = new FileStream(FileName, FileMode.Open);
            var XML = new XmlSerializer(typeof(List<Bachelor>));
            Students = (List<Bachelor>)XML.Deserialize(stream);
            stream.Close();
        }
    }
}
