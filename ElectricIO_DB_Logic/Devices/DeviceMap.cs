using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricIO_DB_Logic.Devices
{
    public class DeviceMap : ClassMap<Device>
    {
        public DeviceMap()
        {
            Id(x => x.Id);

            Map(x => x.Name);
            Map(x => x.ReleaseDate);
            Map(x => x.Manufacturer).CustomType<int>();
            Map(x => x.Model);
            Map(x => x.Subversion);

            References(x => x.Maintainer);
        }
    }
}
