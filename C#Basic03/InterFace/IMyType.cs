using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic03.InterFace
{
    internal interface IMyType
    {
        public int Age { get; set; }

        public void MyFinc();

        public void Print() 
        {
            Console.WriteLine("Default implemnted method");
        }
    }
}
