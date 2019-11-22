using System;
using System.Collections.Generic;
using System.Text;

namespace Explicit_Interface
{
    public interface IPerson
    {
        string Name { get; }

        int Age { get; }

        string GetName();
    }
}
