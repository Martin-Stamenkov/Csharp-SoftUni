using MXGP.Models.Riders.Contracts;
using MXGP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXGP.Repositories
{
    public class RiderRepository : Repository<IRider>
    {
        public override IRider GetByName(string name)
        {
            return data.FirstOrDefault(x => x.Name == name);
        }
    }
}
