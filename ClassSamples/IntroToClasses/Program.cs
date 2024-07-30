// See https://aka.ms/new-console-template for more information
using IntroToClasses;

Console.WriteLine("\n\tHello, World of Classes\n");

//declare a variable capable of holding an instance (occurance) of the datatype Dog
//default values for objects is null
Dog myPet = null;

//to reference an item within your instance, you will use the . (dot) operator
//if your variable does not contain an instance of the class, it will abort your program

//Since the class can possible throw an exception, any action involving the instance
//  needs to be place within a try/catch
try
{
    //obtain an instance of your class
    //this is called a class instance
    //use the new operator to obtain an instance of the specified class
    //the result of the new execution is getting a physical memory allocated instance of your class
    myPet = new Dog();  //default  constructor

    //the following line is using the class property Name to store the user's
    //      data value
    //since Name is receiving a value, the property's setter is being used
    //myPet.Name = "No";
    //myPet.Age = 4;
    //myPet.DogBreed = Breed.Poodle;
    //myPet.FirstName = "Don"; //uses the property
    //myPet.SetFirstName = "Don"; //uses the method technique to store data within the instance
    //myPet.LastName = "Welch";

    //myPet = new Dog("No", 4, Breed.Collie, "Don", "Welch");  //greedy constructor


    // myPet.Name is using the property's getter
    // myPet.FullName is a read-only properties which returns a concatenation of LastName and FirstName
    Console.WriteLine($"{myPet.FullName}: your pet characteristics are; Name: {myPet.Name} Age: {myPet.Age} Breed: {myPet.DogBreed}");

    Console.WriteLine($"\n{myPet.ToString()}");
}
catch(ArgumentNullException ex)
{
    //this is a very specific error message
    Console.WriteLine($"Data Missing: {ex.Message}");
}
catch (ArgumentException ex)
{
    //this is a very specific error message
    Console.WriteLine($"Data Invalid: {ex.Message}");
}
catch (Exception ex)
{
    //top level generic catch-all Exception
    Console.WriteLine($"System error: {ex.Message}");
}



