using System;
using System.Collections.Generic;
using System.Text;

namespace Program11
{
    class Person
    {
        //唯一标识
        public Guid ID { get; set; }

        public string EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"(FirstName)(LastName)";
        public bool Sex { get; set; } = true;
        public DateTime BirthDay { get; set; } = DateTime.Today;
        public string PhoneNumber { get; set; }

    }
}
