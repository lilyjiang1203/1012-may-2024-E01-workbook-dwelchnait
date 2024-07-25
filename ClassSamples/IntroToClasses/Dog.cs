using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClasses
{
    public class Dog
    {
        //declare the characteristics of a Pet
        //the characteristics are variables that will carry a data value for the instance
        //  of the dog
        //note the a class can have various datatypes within its definition as long
        //  as it is a valid C# datatype including any programmer-defined datatype

        //these variables are referred to as data members

        //by default all items in a class have an access type of private
        //if you wish outside users (any code outside of Dog) to have access to
        //  items declared within the class definition, you MUST make them public
        
        //data members
        // a general style seen in classes using data members and properties
        //     will have the same name BUT the data member will have a starting
        //     underscore
        private string _Name; 
        public int age;
        public Breed breed;

        //property members
        //a property is an interface to private data within your class definition
        //a property is associated with a SINGLE piece of data
        //a property is public
        //a property must have an accessor (getter)
        //  the getter returns a piece of data
        //  the getter is public
        //a property may have a mutator (setter)
        //  the setter assigns a value to your private data member
        //  a setter may be either public (default) or private
        //  if the setter is private, it can be used from within the class
        //      it cannot be used by an outside user
        //properties DO NOT have any parameters
        //properties use a special key word to refer to the incoming data value
        //  that key word is -> value

        //Don's Rule: wherever possible within the class coding, use the property
        //              to access your data

        //there are two ways to code a property
        //  a) auto-implemented
        //  b) fully- implemented

        // fully-implemented  properties
        // the get and set are code my the designer and reference a data member
        // the setter may have logic within the code to validate the incoming data

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        public override string ToString()
        {
            //{Name} is using the getter of the property Name
            return $"{Name},{age},{breed}";
        }
    }
}
