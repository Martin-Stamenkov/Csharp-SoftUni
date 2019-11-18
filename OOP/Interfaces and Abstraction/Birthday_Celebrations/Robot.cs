using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations
{
    public class Robot : Iidentifible
    {
        public Robot(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; private set; }

        public string Id { get; }
    }
}
