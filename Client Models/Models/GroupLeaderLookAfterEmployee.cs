using System;
using System.Collections.Generic;
using System.Text;

namespace Client_Models.Models
{
    public class GroupLeaderLookAfterEmployee : ModelBase
    {
        public GroupLeader GroupLeader { get; set; }

        public Employee Employee { get; set; }
    }
}
