namespace Collection_Hierarchy.Models
{
    using Collection_Hierarchy.Contracts;
    using System.Collections.Generic;

    public class AddCollection<T> : IAddCollection<T>
    {
        public AddCollection()
        {
            this.Data = new List<T>();
        }

        public virtual int Add(T element)
        {
            Data.Add(element);
            var indexOfAddedElement = Data.Count - 1;
            return indexOfAddedElement;
        }
        protected List<T> Data { get; set; }
    }
}
