using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSharp_task1
{
    class MultiSet : Set
    {
        int[] multiSet;
        public MultiSet(int max)
        {
            this.MaxElem = max;
            multiSet = new int[max + 1];
            for (int i = 0; i < multiSet.Length; i++)
                multiSet[i] = 0;
        }

        public override void Add(int elem)
        {
            if (elem >= multiSet.Length) throw new OutOfBoundSetException("Выход за пределы множества!");
            multiSet[elem]++;
        }

        public override bool InSet(int elem)
        {
            return (elem >= multiSet.Length) || multiSet[elem] == 0 ? false : true;
        }

        public override void Delete(int elem)
        {
            if (multiSet[elem] > 0)
              multiSet[elem]--;
        }
    }
}
