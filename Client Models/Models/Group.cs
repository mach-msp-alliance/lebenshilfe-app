using System;
using System.Collections.Generic;
using System.Text;

namespace Client_Models.Models
{
    public class Group : ModelBase
    {
        public string Name { get; set; }

        public Location Location { get; set; }
    }
}
