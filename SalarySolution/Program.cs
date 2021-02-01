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

            Console.WriteLine(manager.TotalSalary);
        }
    }
}