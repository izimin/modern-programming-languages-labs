using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSharp_task1
{
    class BitSet : Set
    {
        int[] bitSet;
        public BitSet(int max)
        {
            this.MaxElem = max;
            bitSet = new int[max / 32 + 1];
            for (int i = 0; i < bitSet.Length; i++)
                bitSet[i] = 0;
        }

        public override void Add(int bit)
        {
            if (bit > MaxElem)  throw new OutOfBoundSetException("Выход за пределы множества!");
            var elem = bit / 32;
            bitSet[elem] |= (1 << bit % 32);
        }

        public override bool InSet(int bit)
        {
            var elem = bit / 32;
            return (elem >= bitSet.Length) || (bitSet[elem] & (1 <<(bit % 32))) == 0 ? false : true;
        }

        public override void Delete(int bit)
        {
            var elem = bit / 32;
            bitSet[elem] &= ~(1 << bit % 32);
        }

        public static BitSet operator +(BitSet set1, BitSet set2)
        {
            var set = new BitSet(Math.Max(set1.MaxElem, set2.MaxElem) + 1);
            for (int i = 1; i <= set.MaxElem; i++)
                if (set1.InSet(i) || set2.InSet(i))
                    set.Add(i);         
            return set;
        }

        public static BitSet operator *(BitSet set1, BitSet set2)
        {
            var set = new BitSet(Math.Min(set1.MaxElem, set2.MaxElem) + 1);
            for (int i = 1; i <= set.MaxElem; i++)
                if (set1.InSet(i) && set2.InSet(i))
                    set.Add(i);
            return set;
        }
    }
}