using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantaWorkshop.Repositories
{
    public class PresentRepository : IRepository<IPresent>
    {
        private readonly List<IPresent> presents;
        public PresentRepository()
        {
            presents = new List<IPresent>();
        }
        public IReadOnlyCollection<IPresent> Models => presents.AsReadOnly();

        public void Add(IPresent model)
        {
            presents.Add(model);
        }

        public IPresent FindByName(string name)
        {
            return presents.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(IPresent model)
        {
            return presents.Remove(model);
        }
    }
}
