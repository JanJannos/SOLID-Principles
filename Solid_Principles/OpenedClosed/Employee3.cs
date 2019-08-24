using System;
using System.Collections.Generic;
using System.Text;

// Now we fix the problem that we saw on Employee2 
// and create an abstract class

namespace Solid_Principles.OpenedClosed
{
    public abstract class Employee
    {
        public Employee()
        {

        }

        public int ID { get; set; }
        public String Name { get; set; }

      

        public Employee(int id, string name)
        {
            ID = id;
            Name = name;
           
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return String.Format("ID {0} , Name {1}", this.ID, this.Name);
        }
    }


    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {
            
        }

        public PermanentEmployee(int id, string name) : base(id, name) { }


        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }



    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        {

        }

        public TemporaryEmployee(int id, string name) : base(id, name) { }


        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}