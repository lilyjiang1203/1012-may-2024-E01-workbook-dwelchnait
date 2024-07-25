// See https://aka.ms/new-console-template for more information
using IntroToClasses;

Console.WriteLine("\n\tHello, World of Classes\n");

//declare a variable capable of holding an instance (occurance) of the datatype Dog
//default values for objects is null
Dog myPet = null;

//to reference an item within your instance, you will use the . (dot) operator
//if your variable does not contain an instance of the class, it will abort your program

//obtain an instance of your class
//this is called a class instance
//use the new operator to obtain an instance of the specified class
//the result of the new execution is getting a physical memory allocated instance of your class
myPet = new Dog();

//the following line is using the class property Name to store the user's
//      data value
//since Name is receiving a value, the property's setter is being used
myPet.Name = "No";
myPet.age = 4;
myPet.breed = Breed.Poodle;

// myPet.Name is using the property's getter
Console.WriteLine($"My pet characteristics are; Name: {myPet.Name} Age: {myPet.age} Breed: {myPet.breed}");

Console.WriteLine($"\n{myPet.ToString()}");



