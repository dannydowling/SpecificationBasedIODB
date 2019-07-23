using ElectricIO_DB_Logic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricIO_DB_Logic.Devices
{
    public class Device : Entity
    {
        public virtual string Name { get; }
        public virtual DateTime ReleaseDate { get; }
        public virtual Manufacturer Manufacturer { get; }
        public virtual string Model { get; }
        public virtual double Subversion { get; }
        public virtual Maintainer Maintainer { get; }

        protected Device()
        {

        }
    }
}
