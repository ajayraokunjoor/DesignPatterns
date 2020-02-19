using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
#if NotThereadSafe
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");

            System.Console.ReadLine();

            Singleton.DerivedSingleton derivedSingleton = new Singleton.DerivedSingleton();
            derivedSingleton.PrintDetails("From Derived");

            System.Console.ReadLine();
#elif true
            //Thread safe Singleton invoke
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintTeacherDetails1(),
                () => PrintStudentDetails(),
                () => PrintStudentDetails1()
                );
            Console.ReadLine();
        }

        private static void PrintTeacherDetails()
        {
            ThreadSafeSingleton fromTeacher = ThreadSafeSingleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentDetails()
        {
            ThreadSafeSingleton fromStudent = ThreadSafeSingleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
        private static void PrintTeacherDetails1()
        {
            LazySingleton fromTeacher = LazySingleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentDetails1()
        {
            LazySingleton fromStudent = LazySingleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
#endif
    }
}
