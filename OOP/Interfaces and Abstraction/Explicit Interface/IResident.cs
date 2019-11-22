using System;
using System.Collections.Generic;
using System.Text;

namespace Explicit_Interface
{
    public interface IResident
    {
         string Name { get; }

         string Coutry { get; }

         string GetName();
    }
}
