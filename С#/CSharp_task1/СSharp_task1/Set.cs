using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSharp_task1
{
    abstract class Set : Form1
    {
        int maxElem;
        protected int MaxElem
        {
            get { return maxElem; }
            set { maxElem = value; }
        }
        public abstract void Add(int elem);
        public abstract bool InSet(int elem);
        public abstract void Delete(int elem);

        public void FillSet(string str)
        {
            var arrSet = str.Split(' ').Select(x => int.Parse(x));
            foreach (var item in arrSet)
                Add(item);
        }

        public void FillSet(int[] arrSet)
        {
            foreach (var item in arrSet)
                Add(item);
        }

        public string PrintSet()
        {
            string output = "";
            for (int i = 1; i <= maxElem; i++)
                if (InSet(i))
                     output += i + " ";
            return output;
        }
    }
}
