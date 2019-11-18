using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control
{
    public class Robot : Iidentifible
    {
        public Robot(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; }

        public string Id { get; }
    }
}
