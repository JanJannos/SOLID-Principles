using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_Principles.Liskov
{
    // The Liskov principle 
    // Reference : https://www.britannica.com/list/8-birds-that-cant-fly

    // Substitutability is a principle in object-oriented programming stating
    // that, in a computer program, if S is a subtype of T, then objects of
    // type T may be replaced with objects of type S


    // A Bad example

    public class Bird1
    {
        public void Fly()
        {
            // ... 
        }
    }
    public class Duck1 : Bird1 { }        // can fly
    public class Ostrich1 : Bird1 { }     // can't fly


    // A Good example
    public class Bird2
    {
        // ... 
    }

    public class FlyingBirds : Bird2
    {
        public void Fly()
        {
            // ... 
        }
    }
    public class Duck2 : FlyingBirds { }
    public class Ostrich2 : Bird2 { }



    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
