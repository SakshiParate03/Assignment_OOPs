using System.Net;
using System.Xml.Linq;

namespace HRLib
{
    public abstract class Employee
    {
        internal string name;

        internal string address;

        private static int count = 0;
        private int empNo;  
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        { 
            get { return address; }
            set { address = value; }
        }

        public Employee()
        {
            //this.name = name;
            //this.address = address;
            name = "Sakshi";
            address = "Pune";
           count++;
            this.empNo = count;
        }

        public Employee(string Name, string Address)
        {
            Name = name;
            Address = address;
        }

        abstract public double CalculateSalary();

        public override string ToString()
        {
            return $"EmpNo: {empNo} Name : {Name}, Address : {Address}";
            // github testing.
        }

    }

    

        

}
 