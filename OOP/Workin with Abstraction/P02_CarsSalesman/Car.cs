using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CarsSalesman
{
    public class Car
    {
        private const string offset = "  ";

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color{ get; set; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = -1;
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, int weight)
            :this(model,engine)
        {
            this.Weight = weight;
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, string color)
            : this(model,engine)
        {
            this.Weight = -1;
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this (model,engine)
        {
            this.Weight = weight;
            this.Color = color;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine(this.Engine.ToString());
            if (Weight != -1)
            {
                sb.AppendLine($"{offset}Weight: {this.Weight}");
            }
            else
            {
                sb.AppendLine($"{offset}Weight: n/a");
            }

            sb.AppendLine($"{offset}Color: {this.Color}");

            return sb.ToString().TrimEnd();
        }
    }
}
