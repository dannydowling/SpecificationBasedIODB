using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ElectricIO_DB_Logic.Devices;

namespace ElectricIO_DB_Logic.Utils
{
    // example classifiers

    public sealed class DevicesByManufacturer : Specification<Device>
    {
        private readonly string _Manufacturer;

        public DevicesByManufacturer(string Manufacturer)
        {
            _Manufacturer = Manufacturer;
        }

        public override Expression<Func<Device, bool>> ToExpression()
        {
            return device => device.Manufacturer.Name == _Manufacturer;
        }
    }
}
