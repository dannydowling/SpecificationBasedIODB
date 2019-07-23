using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricIO_DB_Logic.Devices
{
    public class DeviceDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual string Model { get; set; }
        public virtual double Subversion { get; set; }
        public virtual Maintainer Maintainer { get; set; }
    }
}