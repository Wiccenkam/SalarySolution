using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Person
{
    public class Staff:Person
    {
        public decimal MonthSalary { get; set; }
        public Staff(string name,decimal monthsalary,List<TimeRecord> timeRecords) : base(name,timeRecords)
        {
            MonthSalary = monthsalary;
        }
    }
}
