using System;
using System.Collections.Generic;
using System.Text;

namespace Client_Models.Models
{
    public class GroupLeader : ModelBase
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Username { get; set; }

        public string PIN { get; set; }

        public byte[] Image { get; set; }
    }
}
