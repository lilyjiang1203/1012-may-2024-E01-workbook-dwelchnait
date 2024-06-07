// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tGames! Games! Games!\n\n");

string inputValue = "";
Random rnd = new Random();
int machineChoice = 0; //set to the default choice of scissors
int userChoice = 0; //set to the default choice of scissors

//get the machine choice
machineChoice = rnd.Next(0, 3); //will return 0, 1 or 2

//get the users choice
Console.WriteLine("Choices: Scissors (0), Rock (1), Paper (2)");
Console.Write("Enter the number representing your choice:\t");

//we are not going to assume that a valid value was entered
inputValue = Console.ReadLine();

//validate that the value is correct
//if not correct, put out aa appropriate message to the user, DO NO further processing
//if correct, we can continue with the game processing

//to convert a string to another datatype (numeric) you have use datatype.Parse()
//the result is either the data has been converted OR your program crashes

//you can use another parsing method to "attempt" the conversion and
//  depending on the attempt, make a decission to do either (a) or (b)

//syntax   datatype.TryParse(string, out convertedreceivngfield)
//if the conversion works the TryParse will
//  a) fill the convertedreceivingfield with the converted value
//  b) true a boolean true value

//if the conversion does not work the TryParse will
//  a) will NOT fill the convertedreceivingfield 
//  b) false a boolean true value

//this test is a datatype test
if (int.TryParse(inputValue, out userChoice))
{
    //works
    // this is an example of a nested if structure
    // a nested if is an if structure within the true or false path of another if

    //check that the enterd value is 0, 1 or 2
    //we can combine multiple conditions within a single if condition

    //How to handle multiple conditions on a if statement
    //
    //there is another set of operator which are your "Logical" operators
    // these operators are and (&&), or (||), not !(condition)
    // these operators are used to join multiple conditions on an "if" statement
    //
    //  Truth Tables
    //
    //   condition A   B   result  comment
    //    AND      T   T     T     both conditions MUST be true
    //             T   F     F     one of the conditions is NOT true
    //             F   T     F     one of the conditions is NOT true
    //             F   F     F     one of the conditions is NOT true
    //
    //     OR      T   T     T     both of the conditions is true
    //             T   F     T     one of the conditions is true
    //             F   T     T     one of the conditions is true
    //             F   F     F     both conditions MUST be false

    //validate that the number enterd is 0, 1 or 2
    //this test is a range test (domain test)
    //if (userChoice == 0 || userChoice == 1 || userChoice == 2)
    if (userChoice >= 0 && userChoice <= 2)

    {
        Console.WriteLine($"{userChoice} is valid");
        if (userChoice == 0)
        {
            //do this testing ONLY if your use is Scissor
            //test the user choice against the machine choice
            if (machineChoice == 0)
            {
                Console.WriteLine("\n\n\tYou and the computer are both scissor. It is a draw.");
            }
            if (machineChoice == 1)
            {
                Console.WriteLine("\n\n\tYou are scissors and the machine is rock. You lose.");
            }
            if (machineChoice == 2)
            {
                Console.WriteLine("\n\n\tYou are scissors and the machine is paper. You win.");
            }
        }
        if (userChoice == 1)
        {
            //do this testing ONLY if your use is Rock
            //test the user choice against the machine choice
            if (machineChoice == 0)
            {
                Console.WriteLine("\n\n\tYou are rock and the machine is scissor. You win.");
            }
            if (machineChoice == 1)
            {
                Console.WriteLine("\n\n\tYou are both rock. It is a draw.");
            }
            if (machineChoice == 2)
            {
                Console.WriteLine("\n\n\tYou are rock and the machine is paper. You lose.");
            }
        }
        //using a compound if condition
        if (userChoice == 2 && machineChoice == 0)
        {
            Console.WriteLine("\n\n\tYou are paper and the machine is scissor. You lose.");
        }
        if (userChoice == 2 && machineChoice == 1)
        {
            Console.WriteLine("\n\n\tYou are paper and the machine is rock. You win.");
        }
        if (userChoice == 2 && machineChoice == 2)
        {
            Console.WriteLine("\n\n\tYou are both paper. It is a draw.");
        }
    }
    else
    {
        Console.WriteLine($"Your choice of{userChoice} is invalid. Use 0, 1, or 2");
    }
}
else
{
    //not a number
    Console.WriteLine($"you entered a non-numeric value >{inputValue}<");
}