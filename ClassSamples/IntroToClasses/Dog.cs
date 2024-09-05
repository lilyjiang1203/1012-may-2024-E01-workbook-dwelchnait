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

        //fully implemented version of the property
        //public Breed DogBreed
        //{
        //    get { return _dogBreed; }
        //    set { _dogBreed = value; }
        //}

        //Auto-implemented property
        //DOES NOT use a data member
        //auto implemented properties lefts the data storage to the system to handle
        //auto implemented properties have NO validation code
        //typically used when data just needs to be held in the instance
        //this is a quick short form of hanging on to data within an instance
        //any data held by a auto-implemented property can ONLY be accessed via that property
        //why not do all properties like this?
        //answer: who will be responsible for the data validation? the coder, the constructor, the method
        public Breed DogBreed { get; set; }

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

        //constructors
        //  these are used during the creation of an instance (occurance) of your
        //    class durig your program execution

        //a class DOES NOT need a constructor physically code for it
        //if a class DOES NOT have a physically code constructor method then
        //      the system will create the instance of your class
        //      using the system default values for your field datatype

        //HOWEVER!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //IF YOU CODE A CONSTRUCTOR PHYSCIALLY FOR YOUR CLASS, YOU ARE TOTALLY
        //      RESPONSIBLE FOR ANY AND ALL CONSTRUCTORS OF THE CLASS
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        //how many constructors can a class have? Many

        //the purpose of the constructor is to ensure that the user of the class
        //  gets a expected usable valid instance of the class

        //there is generally two types of constructors coded for a class
        //you DO NOT need to code both!!!

        //syntax for a general constructor
        //   public className( [list of parameters] ) { coding block }

        //access: public
        //NO RETURN DATATYPE
        //name: is your class name
        //parameters: are optional
        //coding block: is C# code

        //Default constructor
        //this constructor will not have any parameters
        //the assumption is the data will have either
        //  a) the system datatype defualts
        //  b) any assigned literal values to ensure property validation is meet

        public Dog()
        {
            //this is a default constructor
            //SINCE our properties have business rules (validation)
            //  our "default" constructor should ensure that data members within
            //  our class instance passes any validation

            //Consideration!!!!
            //does the property have any validation htat would be violated
            //  by just using the system datatype defaults?

            //in this example Name, FirstName and LastName cannot be null, empty or jsut blanks
            //thus, a literal value was assigned that would pass the valdiation

            //Age has a validation but the system datatype default would survice

            Name = "unknown";
            FirstName = "unknown";
            LastName = "unknown";
            Age = 0; //this is optional as the system datatype value is also 0
            DogBreed = Breed.Poodle; //this is optional as the system default also uses the first enum value

        }

        // Greedy Constructor
        //this constructor will receive a set of values for the data within the class
        //the parameters list is a complete list of values to cover all data members
        //  within the class
        //the constructor will assign the incoming values to the appropriate
        //  data members.
        //BEST PRACTICE: ASSIGN THE INCOMING VALUES TO THE DATA MEMBERS VIA THEIR PROPERTY
        //Why: the data will be validated 

        public Dog(string name, int age, Breed breed, string firstname, string lastname)
        {
            //it is possible to include validation for your incoming data within
            //  the greed constructor 
            //you might do this IF your properties do NOT contain validation
            //                  IF you have additional validation that is no within the property
            //                  IF your setter is private (not part of this course)
            //REMEMBER that once the instance is created using the constructor ANY alternations
            //  to you data via properties or methods, should, contain validation
            //Question? Why have the same code in multiple places
            //Solution:
            //  a) create a method that could be called from anywhere in the class defintion
            //      (Modular approach)
            //  b) if you use the practice of accessing your data via the properties
            //      within the class definition, then the validation could be placed
            //      in one location: properties. (Don's Rule)

            Name = name;
            Age = age;
            DogBreed = breed;
            FirstName = firstname;
            LastName = lastname;
        }





        //methods (behaviours)
        //what "things" do I wish the class to be able to do
        //just like methods you have created before.
        //they can be used to store data into the object instance
        //they can be used to retrieve data from the object instance
        //they can do both at the same time

        public override string ToString()
        {
            //{Name} {Age} is using the getter of the property Name
            return $"{Name},{Age},{DogBreed}";
        }

        //code that similates a property
        public string GetFirstName()
        {

            // this would replace the getter used in a method
            return _FirstName;
        }
    
        public void SetFirstName(string value)
        {
            // this would replace the setter used in a method
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("First Name", "Your first name is required");

            _FirstName = value;
        }
    }
}
