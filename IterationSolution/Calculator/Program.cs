// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tBasic Calculator\n\n");

string inputValue = "";
string menuChoice = "";
int firstNumber = 0;
int secondNumber = 0;
double calculationResult = 0.0;
double userGuess = 0.0;
Random rnd = new Random(); //to generate 2 numbers for the calculation
bool validFlag = true;

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
                do
                {
                    validFlag =true;
                    try
                    {
                        Console.Write($"\nWhat is the answer to {firstNumber} + {secondNumber}:\t");
                        inputValue = Console.ReadLine();
                        userGuess = double.Parse(inputValue);
                    }
                   catch(Exception ex)
                    {
                        Console.WriteLine($"System Error: {ex.Message}");
                        validFlag = false;
                    }
                } while (!validFlag);
               
                calculationResult = firstNumber + secondNumber;
                break;
            }
        case "B":
            {
                Console.Write($"\nWhat is the answer to {firstNumber} - {secondNumber}:\t");
                inputValue = Console.ReadLine();
                calculationResult = firstNumber - secondNumber;
               
                break;
            }
        case "C":
            {
                Console.Write($"\nWhat is the answer to {firstNumber} X {secondNumber}:\t");
                inputValue = Console.ReadLine();
                calculationResult = firstNumber * secondNumber;
                break;
            }
        case "D":
            {
                Console.Write($"\nWhat is the answer to {firstNumber} / {secondNumber}:\t");
                inputValue = Console.ReadLine();
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

    //responsive error handling means that you will respond to the system when an
    //  Exception is thrown. 
    //An exception is a problem that the system/your code can not properly process
    //There are several types of exceptions that can happen in your code
    //Responsive error handling surrounds your code with logic that captures the
    //   exception and allows you to "gentle" land your code in a survial fashion
    //This error handling is often reffered to as "user friendly error handling"

    //how to you code to capture an unexpected expection
    //
    //use the try/catch structure

    //syntax:
    //   try
    //   {
    //         logic to attempt to execute
    //   }
    //   catch(Exception ex)
    //   {
    //         logic to handle your exception
    //   }

    if (menuChoice.ToUpper() == "A" || menuChoice.ToUpper() == "B" || menuChoice.ToUpper() == "C" || menuChoice.ToUpper() == "D")
    {
        try
        {
            //         logic to attempt to execute

            userGuess = double.Parse(inputValue);
            if (userGuess == calculationResult)
            {
                Console.WriteLine($"\nYes, you answer of {userGuess} is correct");
            }
            else
            {
                Console.WriteLine($"\nNo, you answer of {userGuess} is incorrect. The correct answer is {calculationResult}");
            }
        }
        catch (Exception ex)
        {
            //         logic to handle your exception
            // the logic here depends on what you wish to do if your program
            //      has done something to cause it to abort
            //a) put out a message
            //b) do additional logic, whatever it may be
            //c) you code just ignore the error (NOT a good plan)
            Console.WriteLine($"The calculator cannot handle your answer. Try again with a correct input answer.");
            Console.WriteLine($"System Error: {ex.Message}");
        }
    }
} while(menuChoice.ToUpper() != "X"); //menuChoice != "X" || menuChoice != "x"

