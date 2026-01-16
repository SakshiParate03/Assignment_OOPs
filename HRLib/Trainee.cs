using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class Trainee : Employee
    {
        private int noOfDays;
        private double ratePerDay;
        double salary;
        public int NoOfDays
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }

        public double RatePerDay
        { 
         get { return ratePerDay; }
         set { ratePerDay = value; }
        }

        public Trainee() : base()
        {
            noOfDays = 30;
            ratePerDay = 500;
            salary = noOfDays * ratePerDay;
        }

        public Trainee(string Name, string Address, int NoOfDays, double RatePerDay) : base(Name, Address)
        {
           NoOfDays = noOfDays;
           RatePerDay = ratePerDay;
           salary = NoOfDays * RatePerDay;
        }
        

        public sealed override double CalculateSalary()
        {
        
            Console.WriteLine($"Salary is: {salary}");
            return salary;
            // github testing.
        }
        public override string ToString()
        {
            return base.ToString() + $", No of Days : {NoOfDays}, Rate Per Day: {RatePerDay}";
        }
    }
}
