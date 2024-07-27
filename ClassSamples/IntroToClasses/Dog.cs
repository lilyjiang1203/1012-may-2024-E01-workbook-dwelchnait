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
        private int _Age;
        private Breed _dogBreed;
        private string _FirstName;
        private string _LastName;

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
            set 
            {
                //testing that the incoming data (localed in the key word: value) has something in it
                //the test is against a string: use IsNullOrWhitespace
                //if the incoming data is null, empty or just contains blank characeters
                //      then don't accept the value, instead, raise an error to the user

                //NEVER EVER EVER EVER EVER DISPLAY A MESSAGE FROM YOUR CLASS TO THE CONSOLE
                //NO CONSOLE.WRITELINE!!!!!!!!!!!!!!!!!!!!!!

                //Raised errors will terminate the creation of your instance.
                //Raised errors will immediately exit your class code execute and return to the
                //  calling code (your main program)
                //In your main program use "user friendly error handling (try/catch) to catch the
                //  error and display the thrown message

                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Name","Your dog's name is required");

                //sanitatize string data
                //use the .Trim() string method
                _Name = value.Trim(); 
            }
        }

        public int Age
        {
            //Age must be 0 or greater
            get { return _Age; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Age must be 0 or greater", "Age");
                _Age = value; 
            }
        }

        public Breed DogBreed
        {
            get { return _dogBreed; }
            set { _dogBreed = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("First Name", "Your first name is required");

                _FirstName = value;
            }
        }

        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Last Name", "Your first name is required");

                _LastName = value;
            }
        }

        //Read only properties DO NOT have a set component
        //Read only properties uses a get to combine information ALREADY contained on the instance
        //  to return a value that is computed
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }

        public override string ToString()
        {
            //{Name} {Age} is using the getter of the property Name
            return $"{Name},{Age},{DogBreed}";
        }
    }
}
