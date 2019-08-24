using System;
using Solid_Principles.OpenedClosed;

namespace Solid_Principles
{

    // Employee1

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee emp = new Employee(123 , "Jack");
    //        Console.WriteLine(String.Format("Employee {0} , Bonus {1}" , 
    //            emp.ToString() , emp.CalculateBonus(1000000).ToString()));
    //    }
    //}


    // Employee2

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Employee emp = new Employee(123, "Jack");       // Old
    //        Employee emp = new Employee(123, "Jack" , "Permanent");  // New
    //        Employee emp2 = new Employee(123, "Jonas", "Temp");  // New
    //        Console.WriteLine(String.Format("Employee {0} , Bonus {1}",
    //            emp.ToString(), emp.CalculateBonus(1000000).ToString()));

    //        Console.WriteLine(String.Format("Employee {0} , Bonus {1}",
    //            emp2.ToString(), emp2.CalculateBonus(1000000).ToString()));


    //        // Now we can see that we didn't follow the Open Closed Principle 
    //        // since we had to change the Employee class - BAD !!!

    //        // We'll see how to fix this in Employee3 class
    //    }
    //}


    // Employee 3 

    public class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee(123, "Jack");       // Old
            //Employee emp = new Employee(123, "Jack", "Permanent");  // Old
            //Employee emp2 = new Employee(123, "Jonas", "Temp");  // Old


            Employee emp = new PermanentEmployee(123, "Jack");  // New
            Employee emp2 = new TemporaryEmployee(123, "Jonas");  // New

            Console.WriteLine(String.Format("Employee {0} , Bonus {1}",
                emp.ToString(), emp.CalculateBonus(1000000).ToString()));

            Console.WriteLine(String.Format("Employee {0} , Bonus {1}",
                emp2.ToString(), emp2.CalculateBonus(1000000).ToString()));
        }
    }
}
