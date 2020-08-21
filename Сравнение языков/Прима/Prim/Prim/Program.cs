using System;
using System.Collections.Generic;
using System.Linq;
using MyTuple = System.Tuple<int, int, double>;
namespace Prim
{
    class Program
    {
        private delegate void Work(int v);
        private delegate bool CheckEdge(int u, int v);
        public static void PrimAlg(int numberV, List<MyTuple> e, List<MyTuple> mst)
        {
            var notUsedE = new List<MyTuple>(e);
            var usedV = new List<int>();
            var notUsedV = new List<int>();
            for (var i = 0; i < numberV; i++)
                notUsedV.Add(i);

            var addAndRemove = new Work( (v) => {usedV.Add(v);  notUsedV.Remove(v);} );
            var isEdge = new CheckEdge((u, v) => usedV.IndexOf(u) != -1 && notUsedV.IndexOf(v) != -1);
            addAndRemove(0);

            while (notUsedV.Count > 0)
            {
                var min = -1;
                for (var i = 0; i < notUsedE.Count; i++)
                {
                    var curEdge = notUsedE[i];
                    if (isEdge(curEdge.Item1, curEdge.Item2) || isEdge(curEdge.Item2, curEdge.Item1))
                        min = min == -1 ? i : curEdge.Item3 < notUsedE[min].Item3 ? i : min;
                }

                var curMinE = notUsedE[min];
                addAndRemove(usedV.IndexOf(curMinE.Item1) != -1 ? curMinE.Item2 : curMinE.Item1);

                mst.Add(curMinE);
                notUsedE.RemoveAt(min);
            }
        }

        private delegate MyTuple Create(int u, int v, double w);
        public static void Main()
        {
            var e = new Create(Tuple.Create);
            var listEdge1 = new List<MyTuple>() { e(0, 1, 5), e(0, 2, 3), e(1, 2, 1) };
            var listEdge2 = new List<MyTuple>() { e(0, 1, 5), e(0, 2, 1), e(0, 4, 2), e(1, 2, 3), e(2, 3, 4), e(3, 4, 11) };
            var listEdge3 = new List<MyTuple>() {e(0, 1, 6), e(0, 2, 8), e(0, 3, 5), e(0, 4, 5), e(0, 5, 4), e(1, 2, 7), e(1, 3, 7), e(1, 4, 6),
                                                 e(1, 5, 2), e(2, 3, 5), e(2, 4, 10), e(2, 5, 10), e(3, 4, 7), e(3, 5, 10), e(4, 5, 3)};
            var listEdge4 = new List<MyTuple>() {e(0, 1, 5),e(0,6,3),e(0,5,9),e(1,6,4),e(1,7,2),e(1,2,9),e(2,7,9),e(2,8,7),e(2,9,5),
                                                 e(2,3,4),e(3,9,1),e(3,4,4),e(4,9,3),e(4,8,10),e(4,5,18),e(5,8,8),e(5,6,9),e(6,7,2),e(6,8,9),e(7,8,8),e(8,9,9)};
            var listEdge5 = new List<MyTuple>() {e(0, 1, 3),e(1,2,4),e(1,19,12),e(19,20,13),e(1,18,7),e(15,18,1),e(2,3,5),e(3,17,8),e(17,16,7),e(3,4,3),e(4,5,4),
                                                 e(5,6,1),e(6,7,8),e(7,8,7),e(8,9,6),e(9,10,5),e(8,11,4),e(11,12,1),e(12,13,8),e(13,14,9) };
            var l = new List<MyTuple>() {e(0, 1, 1),e(1, 4, 2), e(0, 3, 7),e(0, 5, 4),e(0, 4, 3),e(2, 3, 9),e(2, 5, 5),e(2, 4, 6),e(3, 4, 8),e(3, 5, 10)};
            var mst = new List<MyTuple>();
            var n = l.Select((x) => Math.Max(x.Item1, x.Item2)).ToList().Max()+1;
            PrimAlg(n, l, mst);
            foreach (var edge in mst)
                Console.WriteLine("(" +  edge.Item1 + "-" + edge.Item2 + ")" + " " + edge.Item3);
        }
    }
}