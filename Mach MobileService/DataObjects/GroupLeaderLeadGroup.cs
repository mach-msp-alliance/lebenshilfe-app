using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mach_MobileService.DataObjects
{
    public class GroupLeaderLeadGroup : EntityData
    {
        public Group Group { get; set; }

        public GroupLeader GroupLeader { get; set; }
    }
}
