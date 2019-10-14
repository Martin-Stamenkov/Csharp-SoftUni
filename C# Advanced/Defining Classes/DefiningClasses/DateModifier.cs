using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class DateModifier
    {
        public void DifferenceBetweenTwoDates(string firstDate, string secondDate)
        {
          
            DateTime startDate = DateTime.Parse(firstDate);
            DateTime endDate = DateTime.Parse(secondDate);

            double result = (startDate - endDate).TotalDays;

            Console.WriteLine(Math.Abs(result)); 

        }
    }
}
