using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic03.Binding
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public new void MyFunc01()
        {
            Console.WriteLine("I am Full Time Employee");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"Id :  {Id} , Name : {Name} ,Age : {Age}  , Salary : {Salary}");

        }
    }
}
