using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Person
{
    public class Employee:Staff
    {
        public decimal BonusSalary => 20000;
        public decimal TotalSalary { get; }
        public Employee(string name,List<TimeRecord>timeRecords) : base(name, 100000,timeRecords)
        {
            decimal PayPerHour = MonthSalary / Settings.WorkHoursInMonth;
            decimal TotalPay = 0;
            decimal BonusPerDay = (BonusSalary / Settings.WorkHoursInMonth) * Settings.DayHours;

            foreach (var timeRecord in timeRecords)
            {
                if (timeRecord.Hours <= Settings.DayHours)
                {
                    TotalPay += timeRecord.Hours * PayPerHour;
                }
                else//overload
                {
                    TotalPay += Settings.DayHours * PayPerHour + BonusPerDay;
                }
            }
            TotalSalary = TotalPay;
        }
    }
}


