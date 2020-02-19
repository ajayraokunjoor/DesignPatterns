using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Ajay";
            emp1.Department = "IT";

#if code
            Employee emp2 = emp1;
#else
            Employee emp2 = emp1.GetClone();
#endif

            emp2.Name = "Rao";
            emp2.Department = "Sales";
            
            Console.WriteLine("Employee 1 : " + emp1.Name + " Department :" + emp1.Department);
            Console.WriteLine("Employee 2 : " + emp2.Name + " Department :" + emp2.Department);

            Console.ReadLine();


        }
    }
}
