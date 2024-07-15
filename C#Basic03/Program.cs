using C_Basic03.Binding;
using C_Basic03.InterFace;
using C_Basic03.Overriding;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace C_Basic03
{
    internal class Program
    {
        #region Overloading

        public static int Sum(int x , int y)
        {
           return x + y;
        }
        public static int Sum(int x, int y , int z)
        {
            return x + y + z;
        }
        public static int Sum(int x, int y, int z , int o)
        {
            return x + y + z + o;
        }
        #endregion

        #region NoOverloading

        public static int Sum2Number(int x, int y)
        {
            return x + y ;
        }
        public static int Sum3Number(int x, int y, int z)
        {
            return x + y + z;
        }
        public static int Sum4Number(int x, int y, int z , int o)
        {
            return x + y + z + o;
        }
        #endregion

        #region Overloding-Binding

        public static void processEmployee1(FullTimeEmployee employee)
        {
            if (employee != null) 
            {
                employee.MyFunc01();
                employee.MyFunc02();
            }
        }
        public static void processEmployee1(PartTimeEmployee employee)
        {
            if (employee != null)
            {
                employee.MyFunc01();
                employee.MyFunc02();
            }
        }
        #endregion

        #region 1
        public static void processEmployee(Employee employee)
        {
            if (employee != null)
            {
                employee.MyFunc01();
                employee.MyFunc02();
            }
        }
        #endregion
        static void Main()
        {
           
            #region Overloading
            int result = Sum(1, 2 );
            Console.WriteLine( result );
            int result3 = Sum(1 , 2, 3 );
            Console.WriteLine( result3 );
            #endregion

            #region NoOverloding
            int result2 = Sum3Number( 1 , 2  , 3);
            Console.WriteLine( result2 );
            int result4 = Sum4Number(1, 2, 3 , 4);
            Console.WriteLine(result4);
            #endregion

            #region Overriding

            TypeA typeA = new TypeA( 1 );
            typeA.A = 10;
            typeA.MyFunc01();
            typeA.MyFunc02();


            TypeB typeB = new TypeB( 1 , 2 );
            typeB.A = 3;
            typeB.B = 3;
            typeB.MyFunc01();
            typeB.MyFunc02();

            #endregion

            #region Binding

            TypeA refBase = new TypeB(1, 4);
            refBase.A = 7;
            //refBase.B;
            refBase.MyFunc01();
            refBase.MyFunc02();
            #endregion

            #region NoBinding
            
            TypeA typeA1 = new TypeB( 1 , 2);
            typeA1 = new TypeA(1);

            TypeB typeB1 = (TypeB)typeA1;


            #endregion

            #region RealExampleOfBinding

            Employee fulltime = new FullTimeEmployee()
            {
                Id = 1,
                Age = 19,
                Name = "Abdo",
                Salary = 1000,
            };
            
            fulltime.Id = 1;
            fulltime.Age = 19;
            fulltime.Name = "Abdo";
            //fulltime.Salary = 1000;

            processEmployee(fulltime);


            Employee partTime = new PartTimeEmployee()
            {
                Id = 1,
                Name = "Ahmed",
                Age = 19,
                HourRate = 800,

            };

            processEmployee(partTime);


            Employee employee = new Employee();
            FullTimeEmployee fulltimeEmployee = new FullTimeEmployee();
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            Employee employee1 = new FullTimeEmployee();
            Employee employee2 = new PartTimeEmployee();
            
            processEmployee(employee1);
            processEmployee(employee2);
            processEmployee(fulltimeEmployee);

            #endregion


            #region MorePractiseOnBinding
            TypeA typeA2 = new TypeC(1, 2, 3);
            typeA.A = 10;
            //typeA.B = 10;
            //typeA.C = 10;

            typeA.MyFunc01();
            typeA.MyFunc02();
            
            TypeB typeA3 = new TypeC(1, 2, 3);
            typeA3.A = 10;
            typeA3.B = 10;
            //typeA3.C = 10;

            typeA3.MyFunc01();
            typeA3.MyFunc02();



            TypeA typeAE = new TypeE(1, 2, 3 , 4 , 5);
            TypeB typeBE = new TypeE(1, 2, 3 , 4 , 5);
            TypeC typeCE = new TypeE(1, 2, 3 , 4 , 5);

            typeAE.MyFunc01();
            typeAE.MyFunc02();
           
            typeBE.MyFunc02();
            typeCE.MyFunc02();


            TypeD typeDE = new TypeE(1, 2, 3 , 4 , 5);
            typeDE.MyFunc02();



            #endregion

            #region interface

            IMyType myType = new MyType();

            myType.MyFinc(); 
            myType.Print();
            #endregion
        }
    }
}


// commet + push
//pull request
//
