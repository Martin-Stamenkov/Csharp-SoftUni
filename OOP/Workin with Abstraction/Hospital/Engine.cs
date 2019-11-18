using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Hospital
{
    public class Engine
    {
        private Hospital hospital;

        public Engine()
        {
            this.hospital = new Hospital();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] tokens = command.Split();
                var departament = tokens[0];

                var firstName = tokens[1];
                var lastName = tokens[2];

                var patient = tokens[3];

                var fullName = firstName + " " + lastName;
                hospital.AddDepartaments(departament);
                hospital.AddDoctors(firstName, lastName);
                hospital.AddPatient(departament, fullName, patient);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                var arguments = command.Split(" ");

                if (arguments.Length == 1)
                {
                    var departamentName = arguments[0];
                    var departament = hospital.Departments.FirstOrDefault(d => d.Name == departamentName);
                    Console.WriteLine(departament);

                }
                else
                {
                    bool isRoom = int.TryParse(arguments[1], out int result);

                    if (isRoom)
                    {
                        var departamentName = arguments[0];
                        var departament = hospital.Departments.FirstOrDefault(d => d.Name == departamentName);

                        var currentRoom = departament.Rooms[result - 1];

                        Console.WriteLine(currentRoom);
                    }
                    else
                    {
                        var firsName = arguments[0];
                        var lastName = arguments[1];

                        var fullName = firsName + " " + lastName;

                        var doctor = hospital.Doctors.FirstOrDefault(d => d.FullName == fullName);

                        Console.WriteLine(doctor);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
