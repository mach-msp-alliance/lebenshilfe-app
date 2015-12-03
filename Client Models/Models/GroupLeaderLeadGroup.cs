using System;
using System.Collections.Generic;
using System.Text;

namespace Client_Models.Models
{
    public class GroupLeaderLeadGroup : ModelBase
    {
        public Group Group { get; set; }

        public GroupLeader GroupLeader { get; set; }
    }
}
