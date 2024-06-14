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

//remember with the do-while you will do your logic at least once.

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

                Console.Write($"\nWhat is the answer to {firstNumber} + {secondNumber}:\t");
                calculationResult = firstNumber + secondNumber;
                break;
            }
        case "B":
            {
                Console.Write($"\nWhat is the answer to {firstNumber} - {secondNumber}:\t");
                calculationResult = firstNumber - secondNumber;
                break;
            }
        case "C":
            {
                Console.Write($"\nWhat is the answer to {firstNumber} X {secondNumber}:\t");
                calculationResult = firstNumber * secondNumber;
                break;
            }
        case "D":
            {
                Console.Write($"\nWhat is the answer to {firstNumber} / {secondNumber}:\t");
                calculationResult = firstNumber / secondNumber;
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

    //common logic just once
    inputValue = Console.ReadLine();
    userGuess = double.Parse(inputValue);
    if (userGuess == calculationResult)
    {
        Console.WriteLine($"\nYes, you answer of {userGuess} is correct");
    }
    else
    {
        Console.WriteLine($"\nNo, you answer of {userGuess} is incorrect. The correct answer is {calculationResult}");
    }
} while(menuChoice.ToUpper() != "X"); //menuChoice != "X" || menuChoice != "x"

