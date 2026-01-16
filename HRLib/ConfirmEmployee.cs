using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        internal double basic;
        internal string designation;

        public double Basic
        {
            get { return basic; }
            set {
                if (value < 5000)
                {
                    throw new MinimumBasicException("\n Basic is less than minimum value.");
                }
                basic = value; }
             
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        public ConfirmEmployee() : base()
        {
            Basic = 8000;
            Designation = "Developer";
        }

        public ConfirmEmployee(string Name, string Address, double Basic, string Designation) : base(Name, Address)
        {
            Basic = basic;
            Designation = designation;
           // github testing.
        }

        public override string ToString()
        {
            return base.ToString() + $", Basic : {Basic}, Designation : {Designation}";
        }

        double hra;
        double conv;
        double pf;

        public sealed override double CalculateSalary()
        {
            if (Basic >= 30000)
            {
                hra = 30 / 100 * Basic;
                conv = 30 / 100 * Basic;
                pf = 10 / 100 * Basic;
            }
            else if (Basic >= 20000)
            {
                hra = 20 / 100 * Basic;
                conv = 20 / 100 * Basic;
                pf = 10 / 100 * Basic;

            }
            else
            {
                hra = 10 / 100 * Basic;
                conv = 10 / 100 * Basic;
                pf = 10 / 100 * Basic;

            }
            double netSalary = Basic + hra + conv - pf;
            return netSalary;
        }

    }
    }

