using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repository.Devices
{
    public class DeviceRepository : IDeviceRepository
    {
        protected readonly TASKEntities _context;
        public DeviceRepository(TASKEntities context)
        {
            _context = context;
        }
        public IEnumerable<Device> GetAll()
        {
            return _context.Devices.ToList();
        }
    }
}
