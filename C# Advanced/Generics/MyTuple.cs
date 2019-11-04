using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MyTuple<T1,T2>
    {
        public T1 Item1 { get; set; }

        public T2 Item2 { get; set; }

        public MyTuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}".ToString();
        }
    }
}
