using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mach_MobileService.DataObjects
{
    public class Employee : EntityData
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string PIN { get; set; }

        public byte[] Image { get; set; }
    }
}
