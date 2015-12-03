using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mach_MobileService.DataObjects
{
    public class EmployeeIsPartOfGroup : EntityData
    {
        public Employee Employee { get; set; }

        public Group Group { get; set; }

    }
}
