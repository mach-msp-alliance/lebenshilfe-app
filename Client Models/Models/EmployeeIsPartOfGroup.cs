using System;
using System.Collections.Generic;
using System.Text;

namespace Client_Models.Models
{
    public class EmployeeIsPartOfGroup : ModelBase
    {
        public Employee Employee { get; set; }

        public Group Group { get; set; }

    }
}
