using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mach_MobileService.DataObjects
{
    public class Group : EntityData
    {
        public string Name { get; set; }

        public Location Location { get; set; }
    }
}
