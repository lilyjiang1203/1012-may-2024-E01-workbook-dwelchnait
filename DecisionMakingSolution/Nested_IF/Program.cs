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

if (int.TryParse(inputValue, out userChoice))
{
    //works
   // this is an example of a nested if structure
   // a nested if is an if structure within the true or false path of another if

    //check that the enterd value is 0, 1 or 2
    //we can combine multiple conditions within a single if condition

}
else
{
    //not a number
    Console.WriteLine($"you entered a non-numeric value >{inputValue}<");
}