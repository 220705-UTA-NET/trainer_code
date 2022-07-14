using System;

namespace School
{
    abstract class Person
    {
        // Fields
        protected string name;
        protected int Id;
        protected string email;
        protected string phone;
        protected string address1;
        protected string address2;
        protected string city;
        protected string state;
        protected string zip;
        protected int age;
        protected static int MaxId = 1; // we need to make sure this gets updated every time the program starts.
        
        // NO CONSTRUCTOR - no need for a constructor

        // Methods
    }
}