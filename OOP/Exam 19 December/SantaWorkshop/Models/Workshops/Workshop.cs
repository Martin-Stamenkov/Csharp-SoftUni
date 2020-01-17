using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Models.Workshops.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantaWorkshop.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        //public IReadOnlyCollection<IInstrument> BrokenInstruments => brokenInstruments.AsReadOnly();
        //private readonly List<IInstrument> brokenInstruments;
        public void Craft(IPresent present, IDwarf dwarf)
        {
            while (dwarf.Energy > 0 || present.EnergyRequired > 0)
            {
                //var notBrokenInstruments = dwarf.Instruments.Where(x => x.IsBroken() == false);
                var currentInstrument = dwarf.Instruments.FirstOrDefault(x => x.IsBroken() == false);

                if (currentInstrument == null)
                {
                    break;
                }
                present.GetCrafted();
                currentInstrument.Use();
               //if (currentInstrument.IsBroken())
               //{
               //    brokenInstruments.Add(currentInstrument);
               //}
            }
        }
    }
}
