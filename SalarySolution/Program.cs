using Domain.Person;
using Domain;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SalarySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Test name", new List<TimeRecord>(){
                    new TimeRecord(DateTime.Now.AddDays(-3),"test",8,"message test"),
                    new TimeRecord(DateTime.Now.AddDays(-3),"test",8,"message test"),
                    new TimeRecord(DateTime.Now.AddDays(-3),"test",8,"message test")
            });
             Employee employee = new Employee("Test name", new List<TimeRecord>(){
                    new TimeRecord(DateTime.Now.AddDays(-3),"test",8,"message test"),
                    new TimeRecord(DateTime.Now.AddDays(-3),"test",5,"message test"),
                    new TimeRecord(DateTime.Now.AddDays(-3),"test",7,"message test")
            });
            Console.WriteLine(manager.TotalSalary);
            Console.WriteLine(employee.TotalSalary);
        }
    }
}