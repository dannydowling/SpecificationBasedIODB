using CSharpFunctionalExtensions;
using ElectricIO_DB_Logic.Utils;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricIO_DB_Logic.Devices
{
    public class DeviceRepository
    {
        public Maybe<Device> GetOne(long id)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                return session.Get<Device>(id);
            }
        }

        public IReadOnlyList<DeviceDto> GetList(
            Specification<Device> specification,
            double minimumRating,
            int page = 0,
            int pageSize = 20)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                return session.Query<Device>()
                    .Where(specification.ToExpression())
                    .Where(x => x.Subversion >= minimumRating)
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .Fetch(x => x.Maintainer)
                    .ToList()
                    .Select(x => new DeviceDto
                    {
                        Name = x.Name,
                        Maintainer = x.Maintainer,
                        Model = x.Model,
                        Id = x.Id,
                        Manufacturer = x.Manufacturer,
                        Subversion = x.Subversion,
                        ReleaseDate = x.ReleaseDate
                    })
                    .ToList();
            }
        }
    }
}
