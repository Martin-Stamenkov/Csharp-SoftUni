namespace Collection_Hierarchy.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using Collection_Hierarchy.Contracts;

    public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
    {
        private const int IndexToRemove = 0;

        public IReadOnlyCollection<T> Used => Data;

        public override T Remove()
        {
            var returnElement = Data.First(); 
            Data.RemoveAt(IndexToRemove);
            return returnElement;
        }
    }
}
