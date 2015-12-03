using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mach_MobileService.DataObjects
{
    public class GroupLeader : EntityData
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Username { get; set; }

        public string PIN { get; set; }

        public byte[] Image { get; set; }
    }
}
