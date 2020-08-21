using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_task2
{
    [Serializable]
    public class Master : Bachelor
    {
        public int GraduationYear { get; set; }
        public string TypeDegree { get; set; }
        public Master(string name, string surname, string faculty, int graduationYear, string typeDegree) : base(name, surname, faculty)
        {
            GraduationYear = graduationYear;
            TypeDegree = typeDegree;
        }

        public Master() { }
    }
}
