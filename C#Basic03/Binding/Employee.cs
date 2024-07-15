using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic03.Binding
{
    internal class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int? Age { get; set; }

        public void MyFunc01()
        {
            Console.WriteLine("I am Employee");
        }
        public virtual void MyFunc02()
        {
            Console.WriteLine($"Id :  {Id} , Name : {Name} ,Age : {Age} ");
        }

    }
}
