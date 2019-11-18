using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Hospital
{
    public class Room
    {
        public List<Patient> Patients;

        public bool IsFull => Patients.Count == 3;

        public Room()
        {
            this.Patients = new List<Patient>();
          
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var patient in Patients.OrderBy(p=>p.Name))
            {
                sb.AppendLine(patient.Name);
            }

            return sb.ToString().TrimEnd();
        }


    }
}
