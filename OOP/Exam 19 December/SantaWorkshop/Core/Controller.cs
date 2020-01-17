using SantaWorkshop.Core.Contracts;
using SantaWorkshop.Models.Dwarfs;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Models.Presents;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Models.Workshops;
using SantaWorkshop.Models.Workshops.Contracts;
using SantaWorkshop.Repositories;
using SantaWorkshop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantaWorkshop.Core
{
    public class Controller : IController
    {
        private DwarfRepository dwarfs;
        private PresentRepository presents;

        IDwarf dwarf;
        IInstrument instrument;
        IPresent present;
        IWorkshop workshop;

        int countCraftedPresents = 0;
        int brokenOnes = 0;

        public Controller()
        {
            dwarfs = new DwarfRepository();
            presents = new PresentRepository();
            workshop = new Workshop();
        }

        public string AddDwarf(string dwarfType, string dwarfName)
        {
            if (dwarfType == "HappyDwarf")
            {
                dwarf = new HappyDwarf(dwarfName);
            }
            else if (dwarfType == "SleepyDwarf")
            {
                dwarf = new HappyDwarf(dwarfName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDwarfType);
            }
            dwarfs.Add(dwarf);
            return string.Format(OutputMessages.DwarfAdded, dwarfType, dwarfName);
        }

        public string AddInstrumentToDwarf(string dwarfName, int power)
        {
            dwarf = dwarfs.FindByName(dwarfName);
            instrument = new Instrument(power);
            if (dwarf == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InexistentDwarf);
            }
            dwarf.AddInstrument(instrument);
            return string.Format(OutputMessages.InstrumentAdded, power, dwarfName);        
        }

        public string AddPresent(string presentName, int energyRequired)
        {
            present = new Present(presentName, energyRequired);
            presents.Add(present);

            return string.Format(OutputMessages.PresentAdded, presentName);
        }

        public string CraftPresent(string presentName)
        {
            var readyToWorkdwarfs = new List<IDwarf>();
            foreach (var dwarf in dwarfs.Models)
            {
                if (dwarf.Energy >= 50 && dwarf.Instruments.Any(x=>x.IsBroken() == false))
                {
                    readyToWorkdwarfs.Add(dwarf);
                }
            }
            if (readyToWorkdwarfs == null)
            {
                throw new InvalidOperationException(ExceptionMessages.DwarfsNotReady);
            }
            present = presents.FindByName(presentName);
            foreach (var currentDwarf in readyToWorkdwarfs)
            {
                //readyToWorkdwarfs = dwarfs.Models.Where(x => x.Energy >= 50);
                currentDwarf.Work();
                var currentInstrument = currentDwarf.Instruments.FirstOrDefault(x=>x.IsBroken() == false);
                //currentInstrument.Use();
                if (currentInstrument.IsBroken())
                {
                    brokenOnes++;
                }
                present.GetCrafted();
                workshop.Craft(present, currentDwarf);
                if (currentDwarf.Energy == 0)
                {
                    dwarfs.Remove(currentDwarf);
                }
                if (present.IsDone())
                {
                    countCraftedPresents++;
                    return string.Format(OutputMessages.PresentIsDone, presentName);
                }
            }
            return string.Format(OutputMessages.PresentIsNotDone, presentName);
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{countCraftedPresents} presents are done!");
            sb.AppendLine("Dwarfs info:");
            foreach (var currentDwarf in dwarfs.Models)
            {
                sb.AppendLine($"Name: {currentDwarf.Name}");
                sb.AppendLine($"Energy: {currentDwarf.Energy}");
                sb.AppendLine($"Instruments {brokenOnes} not broken left");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
