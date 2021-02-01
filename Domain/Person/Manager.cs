using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Person
{
    class Manager: Staff
    {
        public decimal BonusSalary => 20000;
        public Manager(string name,List<TimeRecord>timeRecords) : base(name,150000,timeRecords)
        {
            decimal PayPerHour = MonthSalary / Setttings.WorkHoursInMonth;
            decimal TotalPay = 0;
            decimal BonusPerDay = (BonusSalary / Setttings.WorkHoursInMonth) * Setttings.DayHours;
            
            foreach(var timeRecord in timeRecords)
            {
                if (timeRecord.Hours <= Setttings.DayHours)
                {
                    TotalPay += timeRecord.Hours * PayPerHour;
                }
                else//overload
                {
                    TotalPay += Setttings.DayHours * PayPerHour+BonusPerDay;
                }
            }

        }
    }
}
