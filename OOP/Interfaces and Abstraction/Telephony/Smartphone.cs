using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        public string Model { get; private set; }

        public Smartphone(string model)
        {
            Model = model;
        }

        public string Number(string number)
        {
            if (number.Any(char.IsLetter))
            {
                return "Invalid number!";
            }
            return $"Calling... {number}";
        }

        public string Site(string site)
        {
            if (site.Any(char.IsDigit))
            {
                return "Invalid URL!";
           
            }
            return $"Browsing: {site}!";
        }
    }
}
