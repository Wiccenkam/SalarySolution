using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Person
{
    public class Freelancer:Person
    {
        public Freelancer(string name,  List<TimeRecord> timeRecords) : base(name, timeRecords)
        {
           
        }
    }
}
