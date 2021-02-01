using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Person
{
    public class Employee:Staff
    {
        public Employee(string name,List<TimeRecord>timeRecords) : base(name, 100000,timeRecords)
        {

        }
    }
}

