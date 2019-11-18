namespace Collection_Hierarchy.Models
{
    using Collection_Hierarchy.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
    {
        private const int IndexToAdd = 0;

        public virtual T Remove()
        {
            var removedElement = Data.Last();
            var removedIndex = Data.Count - 1;
            Data.RemoveAt(removedIndex);
            return removedElement;
        }

        public override int Add(T element)
        {
            Data.Insert(IndexToAdd, element);
            return IndexToAdd;
        }
    }
}
