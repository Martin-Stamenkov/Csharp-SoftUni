using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Hospital
{
    public class Hospital
    {
        public Hospital()
        {
            Departments = new List<Departments>();
            Doctors = new List<Doctor>();
        }

        public List<Departments> Departments { get; set; }

        public List<Doctor> Doctors { get; set; }

        public void AddDoctors(string firstName , string lastName)
        {
            if (!Doctors.Any(d => d.FirstName == firstName && d.LastName == lastName))
            {
                var doctor = new Doctor(firstName, lastName);
                Doctors.Add(doctor);
            }
        }

        public void AddDepartaments(string department)
        {
            if (!Departments.Any(de=>de.Name == department))
            {
                var departament = new Departments(department);
                Departments.Add(departament);
            }
        }

        public void AddPatient(string nameDepartaments , string nameDoctor , string name)
        {
            var departament = Departments.FirstOrDefault(de => de.Name == nameDepartaments);
            var doctors = Doctors.FirstOrDefault(d => d.FullName == nameDoctor);

            Patient patient = new Patient(name);

            departament.AddPatient(patient);
            doctors.Patients.Add(patient);
        }

    }
}
