using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mach_MobileService.DataObjects
{
    public class GroupLeaderLookAfterEmployee : EntityData
    {
        public GroupLeader GroupLeader { get; set; }

        public Employee Employee { get; set; }
    }
}
