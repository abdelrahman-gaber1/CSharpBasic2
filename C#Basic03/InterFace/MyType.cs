using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic03.InterFace
{
    internal class MyType : IMyType
    {
        public int Age { get; set; } 

        public void MyFinc()
        {
            Console.WriteLine("Hello World");
        }
        public void MyTypeFinc()
        {
            Console.WriteLine("Hello ");
        }
    }
}
