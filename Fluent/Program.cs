using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee obj = new FluentEmployee();

            obj.NameOfTheEmployee("Ajay Rao Kunjoor")
                .WorksFor("IT department")
                .Born("10/17/1985")
                .StaysAt("Bangalore-India");

            Employee employee;

            System.Console.WriteLine(employee.); ;

            System.Console.Read();
        }
    }
}
