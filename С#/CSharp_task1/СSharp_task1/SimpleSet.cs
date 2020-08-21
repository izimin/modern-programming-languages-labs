using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSharp_task1
{
    class SimpleSet : Set
    {
        bool[] simpleSet;
        public SimpleSet(int max)
        {
            this.MaxElem = max;
            simpleSet = new bool[max + 1];
            for (int i = 0; i < simpleSet.Length; i++)
                simpleSet[i] = false;
        }

        public override void Add(int elem)
        {
            if (elem >= simpleSet.Length) throw new OutOfBoundSetException("Выход за пределы множества!");
            simpleSet[elem] = true;
        }

        public override bool InSet(int elem)
        {
            return (elem >= simpleSet.Length) || simpleSet[elem] == false ? false : true;
        }

        public override void Delete(int elem)
        {
            simpleSet[elem] = false;
        }

        public static SimpleSet operator +(SimpleSet set1, SimpleSet set2)
        {
            var set = new SimpleSet(Math.Max(set1.MaxElem, set2.MaxElem) + 1);
            for (int i = 1; i <= set.MaxElem; i++)
                if (set1.InSet(i) || set2.InSet(i))
                    set.Add(i);
            return set;
        }

        public static SimpleSet operator *(SimpleSet set1, SimpleSet set2)
        {
            var set = new SimpleSet(Math.Min(set1.MaxElem, set2.MaxElem) + 1);
            for (int i = 1; i <= set.MaxElem; i++)
                if (set1.InSet(i) && set2.InSet(i))
                    set.Add(i);
            return set;
        }
    }
}
