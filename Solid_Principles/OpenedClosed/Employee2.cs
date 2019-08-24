//using System;
//using System.Collections.Generic;
//using System.Text;

//// Now we add an Employee Type 

//namespace Solid_Principles.OpenedClosed
//{
//    class Employee
//    {
//        public Employee()
//        {

//        }

//        public int ID { get; set; }
//        public String Name { get; set; }

//        public string EmployeeStype { get; set; } // New !!

//        public Employee(int id, string name , String employeeType)
//        {
//            ID = id;
//            Name = name;
//            EmployeeStype = employeeType;  // New !!
//        }

//        public decimal CalculateBonus(decimal salary)
//        {

//            if (this.EmployeeStype.Equals("Permanent"))
//            {
//                return salary * .1M; // Old !!
//            }
//            else
//            {
//                return salary * .05M; // New !!
//            }
//        }

//        public override string ToString()
//        {
//            return String.Format("ID {0} , Name {1}", this.ID, this.Name);
//        }
//    }
//}