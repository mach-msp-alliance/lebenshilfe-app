using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mach_MobileService.DataObjects
{
    public class Protocol : EntityData
    {
        public Employee Employee { get; set; }

        public string Evaluation { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}
