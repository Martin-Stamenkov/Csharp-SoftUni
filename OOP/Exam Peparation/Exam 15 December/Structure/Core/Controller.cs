using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private List<IAquarium> aquariums;
        IAquarium aquarium;
        IDecoration decoration;
        IFish fish;

        public Controller()
        {
            this.aquariums = new List<IAquarium>();
            decorations = new DecorationRepository(); 
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType == "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
                aquariums.Add(aquarium);
                return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                aquarium = new SaltwaterAquarium(aquariumName);
                aquariums.Add(aquarium);
                return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }
        }
        public string AddDecoration(string decorationType)
        {
            if (decorationType == "Ornament")
            {
                decoration = new Ornament();
                decorations.Add(decoration);
                return string.Format(OutputMessages.SuccessfullyAdded, decorationType);
            }
            else if (decorationType == "Plant")
            {
                decoration = new Plant();
                decorations.Add(decoration);
                return string.Format(OutputMessages.SuccessfullyAdded, decorationType);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            var aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            if (fishType == "FreshwaterFish" && aquarium.GetType().Name == "FreshwaterAquarium")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
                aquarium.AddFish(fish);
            }
            else if (fishType == "SaltwaterFish" && aquarium.GetType().Name == "SaltwaterAquarium")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
                aquarium.AddFish(fish);
            }
            if (fishType != "SaltwaterFish" && fishType != "FreshwaterFish")
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);

            }
            
            if (fish == null)
            {
                return OutputMessages.UnsuitableWater;
            }
            return string.Format(OutputMessages.FishAdded, fish.GetType().Name, aquariumName);
        }

        public string CalculateValue(string aquariumName)
        {
            var sumDecorations = decorations.Models.Sum(d => d.Price);
            var sumFishes = aquariums.Sum(f => f.Fish.Sum(x => x.Price));
            var totalSum = sumDecorations + sumFishes;
            return string.Format(OutputMessages.AquariumValue, aquariumName, totalSum);
        }

        public string FeedFish(string aquariumName)
        {
            aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            aquarium.Feed();
            return string.Format(OutputMessages.FishFed, aquarium.Fish.Count);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
             aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);
             decoration = decorations.Models.FirstOrDefault(a => a.GetType().Name == decorationType);
            if (decoration == null)
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }
            aquarium.AddDecoration(decoration);
            decorations.Remove(decoration);

            return string.Format(OutputMessages.DecorationAdded, decorationType, aquariumName);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var aquarium in aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
