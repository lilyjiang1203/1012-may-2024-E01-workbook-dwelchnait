// See https://aka.ms/new-console-template for more information
using EnumDemo;

Console.WriteLine("\n\t The Enum World!\n");

string firstName = Prompt("Enter student first name");
string lastName = Prompt("Enter student first name");
string menuChoice = DisplayProgramMenu();

//create a variable using an enum programmer-defined datatype
ProgramStream programStream = ProgramStream.Gaming;

switch (menuChoice.ToUpper())
{
    case "A":
        {
            //assign a value to an enum variable
            //use the enumname.enumvlaue
            programStream = ProgramStream.CSD;
            break;
        }
    default:
        {
            Console.WriteLine($"\nYour selection of {menuChoice} is invalid.\n");
            break;
        }
}

Console.WriteLine($"\nName: {firstName} {lastName} belongs to the program {programStream}");

/******************** methods ******************/
static string Prompt(string prompt)
{
    Console.Write($"{prompt}:\t");
    return Console.ReadLine();
}

static string DisplayProgramMenu()
{
    Console.WriteLine("\na) Computer System Development");
    Console.WriteLine("b) Business Analysis");
    Console.WriteLine("c) System Administration");
    Console.WriteLine("d) Visual Communications");
    Console.WriteLine("e) Game Development");
    Console.WriteLine("f) Video Media");
    Console.Write("Enter your program choice:\t");
    return Console.ReadLine();
}