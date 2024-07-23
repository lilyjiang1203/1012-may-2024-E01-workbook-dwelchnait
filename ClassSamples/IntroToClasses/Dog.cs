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
        public string name;
        public int age;
        public Breed breed;
    }
}
