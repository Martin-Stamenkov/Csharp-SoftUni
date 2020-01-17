using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantaWorkshop.Repositories
{
    public class DwarfRepository : IRepository<IDwarf>
    {
        private readonly List<IDwarf> dwarfs;
        public DwarfRepository()
        {
            this.dwarfs = new List<IDwarf>();
        }

        public IReadOnlyCollection<IDwarf> Models => dwarfs.AsReadOnly();

        public void Add(IDwarf model)
        {
            dwarfs.Add(model);
        }

        public IDwarf FindByName(string name)
        {
            return dwarfs.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(IDwarf model)
        {
            return dwarfs.Remove(model);
        }
    }
}
