using System;
using System.Collections.Generic;
using System.Text;

namespace Client_Models.Models
{
    public class Protocol : ModelBase
    {
        public Employee Employee { get; set; }

        public string Evaluation { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}
