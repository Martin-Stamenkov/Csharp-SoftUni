using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Hospital
{
    public class Departments
    {
        public string Name { get; set; }

        public List<Room> Rooms { get; set; }

        public Departments(string name)
        {
            this.Name = name;
            this.Rooms = new List<Room>();
            CreateRooms();
        }

        private void CreateRooms()
        {
            for (int room = 0; room < 20; room++)
            {
                Rooms.Add(new Room());
            }
        }

        public void AddPatient(Patient namePatient)
        {
            var currRoom = Rooms.FirstOrDefault(r => !r.IsFull);
            if (currRoom != null)
            {
                currRoom.Patients.Add(namePatient);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var room in Rooms)
            {
                foreach (var patient in room.Patients)
                {
                    sb.AppendLine(patient.Name);
                }
            }

            return sb.ToString().TrimEnd();
        }

    }
}
