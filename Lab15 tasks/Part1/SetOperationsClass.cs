using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part1
{
    class SetOperationsClass<T>
    {
        private T[] set1;
        private T[] set2;

        public SetOperationsClass(T[] setA, T[] setB)
        {
            set1 = setA;
            set2 = setB;
        }

        IEnumerable<T> SetsUnion()
        {
            IEnumerable<T> res = from el in set1.Union(set2)
                select el;
            return res;
        }

        IEnumerable<T> SetsIntersection()
        {
            IEnumerable<T> res = from el in set1.Intersect(set2)
                select el;
            return res;
        }

        IEnumerable<T> SetsDiff()
        {
            IEnumerable<T> res = from el in set1.Except(set2)
                select el;
            return res;
        }
    }
}
