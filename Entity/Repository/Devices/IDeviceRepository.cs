using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repository.Devices
{
   public interface IDeviceRepository
    {
        IEnumerable<Device> GetAll();
    }
}
