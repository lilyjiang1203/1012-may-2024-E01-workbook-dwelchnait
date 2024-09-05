// See https://aka.ms/new-console-template for more information
using IntroToClasses;
using System.ComponentModel;
Console.WriteLine("\n\tHello, World of Classes\n");

//SingleClassDemo();
ListCollection();

static void SingleClassDemo()
{
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
    catch (ArgumentNullException ex)
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

}

static void ListCollection()
{

    //there are different types of collections within C#
    //Arrays
    //List<T>
    //generic collections such as IEnumerable<T>, IQueryable<T>
    //the <T> represents a valid C# datatype INCLUDING program defined datatypes

    //List<T> vs Array
    //both can be handled with indexes
    //both can be used in iterations
    //both hold a specific datatype
    //both need to be declare and created
    //in C# both have built in methods to apply against the data

    //major difference
    //Arrays are fixed size
    //List<T> is dynamic in size

    int logicalSize = 0;

    //think of our collection as a kennel of dogs
    Dog[] arrayOfDogs = new Dog[5];
    Dog someDog;
    someDog = new Dog("No", 4, Breed.Collie, "Pat", "Downe");
    arrayOfDogs[logicalSize] = someDog;
    logicalSize++;
    arrayOfDogs[logicalSize] = new Dog("Boo", 2, Breed.Lab, "Iam", "Stew-Dent");
    logicalSize++;
    arrayOfDogs[logicalSize] = new Dog("Bad", 7, Breed.Poodle, "Lowand", "Behold");
    logicalSize++;
   
    DisplayArray(arrayOfDogs,logicalSize);

    //this sort uses the entire array whether you have data in all elements or not.
    //we have two elements with no data
    //the default for an instance of a class (not create) is null
    //therefore this command will abort when it attempts to access the elements in the array
    //      that are empty (value of element is null)
    //Array.Sort(arrayOfDogs, (x, y) => x.Name.CompareTo(y.Name));

    //int startindex = 0;
    //Array.Sort(arrayOfDogs, startindex, logicalSize, new Comparison<Dog>((x, y) => x.Name.CompareTo(y.Name)));
    //DisplayArray(arrayOfDogs, logicalSize);


    //lets do the same with a List<T> collection

    //create the list
    List<Dog> listOfDogs = new List<Dog>();

    Console.WriteLine("\n\nPlaying with List<T> where <T> is the class Dog\n\n");

    Console.WriteLine($"\nThe number of entries in the list is currently {listOfDogs.Count}\n");

    //Add an instance of dog to the list
    //NOTE: there is NO logical size to track for a list
    //      there is NO need to increment a counter (logicalSize)
    someDog = new Dog("No", 4, Breed.Collie, "Pat", "Downe");
    listOfDogs.Add(someDog);

    Console.WriteLine($"\nThe number of entries in the list is currently {listOfDogs.Count}\n");

    //add the rest of the dogs to the list
    listOfDogs.Add(new Dog("Boo", 2, Breed.Lab, "Iam", "Stew-Dent"));
    listOfDogs.Add(new Dog("Bad", 7, Breed.Poodle, "Lowand", "Behold"));

    Console.WriteLine($"\nThe number of entries in the list is currently {listOfDogs.Count}\n");

    DisplayList(listOfDogs);

    //sort the list of instance on a data item within the class
    //ascending: (x, y) => x.Name.CompareTo(y.Name)
    //descending: (x, y) => y.Name.CompareTo(x.Name)
    listOfDogs.Sort((x, y) => y.Name.CompareTo(x.Name));

    DisplayList(listOfDogs);
}

static void DisplayArray(Dog[] kennel, int logicalSize)
{
    Console.WriteLine("\nDon's Kennel\n");
    Console.WriteLine("{0,-10} {1,5} {2,-10} {3,15} {4,-15}\n","Name","Age","Breed","Owner","");

    for(int i = 0; i < logicalSize; i++)
    {
        Console.WriteLine("{0,-10} {1,5} {2,-10} {3,15} {4,-15}",
                    kennel[i].Name, kennel[i].Age, kennel[i].DogBreed,
                    kennel[i].FirstName, kennel[i].LastName);
    }
}

static void DisplayList(List<Dog> kennel)
{
    Console.WriteLine("\nDon's Kennel List using index access\n");
    Console.WriteLine("{0,-10} {1,5} {2,-10} {3,15} {4,-15}\n", "Name", "Age", "Breed", "Owner", "");

    for (int i = 0; i < kennel.Count; i++)
    {
        Console.WriteLine("{0,-10} {1,5} {2,-10} {3,15} {4,-15}",
                    kennel[i].Name, kennel[i].Age, kennel[i].DogBreed,
                    kennel[i].FirstName, kennel[i].LastName);
    }

    Console.WriteLine("\nDon's Kennel List using the foreach iternation\n");
    Console.WriteLine("{0,-10} {1,5} {2,-10} {3,15} {4,-15}\n", "Name", "Age", "Breed", "Owner", "");

    //the foreach iternation 
    //  starts at the beginning of your collection
    //  looks at each item in your collection
    //  move automatically to the next item in the collection
    //  repreats until all item accessed
    //  then terminates the iteration
    //There is NO manual incrementing of a counter to move through the iteration
    //this is a pre-test loop structure

    //NOTE: you will often see the datatype "var" used in this loop
    //      it would replace Dog
    //      the datatype of "var" is resolved at run-time whereas if you used a
    //          actual datatype (Dog) it is resoved at compile-time

    //foreach(Dog item in kennel)
    foreach (var item in kennel)
    {
        Console.WriteLine("{0,-10} {1,5} {2,-10} {3,15} {4,-15}",
                    item.Name, item.Age, item.DogBreed,
                    item.FirstName, item.LastName);
    }
}

