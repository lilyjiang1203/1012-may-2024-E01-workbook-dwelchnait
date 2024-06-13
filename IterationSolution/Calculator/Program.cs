// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tBasic Calculator\n\n");

string inputValue = "";
string menuChoice = "";
int firstNumber = 0;
int secondNumber = 0;
double calculationResult = 0.0;
double userGuess = 0.0;
Random rnd = new Random(); //to generate 2 numbers for the calculation


//we need a menu to choice what calculation we wish to demonstrate
// a) Addition
// b) Subtration
// c) Multiplication
// d) Division
// x) exit

do
{
    Console.WriteLine("\nYour choices for a calculation are:");
    Console.WriteLine("a): Addition");
    Console.WriteLine("b): Subtration");
    Console.WriteLine("c): Multiplication");
    Console.WriteLine("d): Division");
    Console.WriteLine("x): Exit");
    Console.Write("\nEnter your calculation choice.\t");
    menuChoice = Console.ReadLine();
    firstNumber = rnd.Next(1, 100);
    secondNumber = rnd.Next(1, 100);
    switch (menuChoice.ToUpper())
    {
        case "A":
            {
                Console.WriteLine($"\nyou entered {menuChoice}\n");
                break;
            }
        case "B":
            {
                Console.WriteLine($"\nyou entered {menuChoice}\n");
                break;
            }
        case "C":
            {
                Console.WriteLine($"\nyou entered {menuChoice}\n");
                break;
            }
        case "D":
            {
                Console.WriteLine($"\nyou entered {menuChoice}\n");
                break;
            }
        case "X":
            {
                Console.WriteLine("\n thank you for using the great calculator\n");
                break;
            }
        default:
            {
                Console.WriteLine("\nInvalid menu choice. Try again.\n");
                break;
            }
    }//eos
} while(menuChoice.ToUpper() != "X"); //menuChoice != "X" || menuChoice != "x"

