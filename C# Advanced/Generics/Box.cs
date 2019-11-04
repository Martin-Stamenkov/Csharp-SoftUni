using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Box<T>
        where T : IComparable
    {

        public Box()
        {
            this.Values = new List<T>();
        }

        public List<T> Values { get; set; }



        public int IsGreater(T targetItem)
        {
            int count = 0;

            foreach (var value in Values)
            {
                if (value.CompareTo(targetItem) > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var value in Values)
            {
                sb.AppendLine($"{value.GetType()}: {value}");
            }
            return sb.ToString().Trim();
        }
        void CheckIndex(int a)
        {
            bool isInRange = a >= 0 && a < Values.Count;

            if (!isInRange)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
