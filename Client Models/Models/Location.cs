using System;
using System.Collections.Generic;
using System.Text;

namespace Client_Models.Models
{
    public class Location : ModelBase
    {
        public string Name { get; set; }

        public byte[] Image { get; set; }
    }
}
