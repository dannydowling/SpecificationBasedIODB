using ElectricIO_DB_Logic.Utils;
using FluentNHibernate.Mapping;


namespace ElectricIO_DB_Logic.Devices
{
    public class Maintainer : Entity
    {
       public virtual string Name { get; }
    }

    public class MaintainerMap : ClassMap<Maintainer>
    {
        public MaintainerMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }

}
