using System;
using System.Collections.Generic;
using System.Text;

namespace StackClassImplementation
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public override string ToString() => $"{FirstName} {LastName}| {Department} Department.";
    }
}
