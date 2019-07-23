using ElectricIO_DB_Logic.Utils;
using FluentNHibernate.Mapping;


namespace ElectricIO_DB_Logic.Devices
{
    public class Manufacturer : Entity
    {
       public virtual string Name { get; }
    }

    public class ManufacturerMap : ClassMap<Maintainer>
    {
        public ManufacturerMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }

}
