﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Hospital
{
    public class Doctor
    {
        public Doctor(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patients = new List<Patient>();
        }

        public List<Patient> Patients;
            
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => FirstName + " " +  LastName;

        public void AddPAtient(Patient name)
        {
            Patients.Add(name);
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
