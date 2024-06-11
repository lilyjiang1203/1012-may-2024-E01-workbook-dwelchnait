// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\t Round and Round we go!!\n\n");

///<summary>
/// Find the sum of the squares of the integers from 1 to MySquare, where MySquare is input by the user.  
/// E.g. user enters 4 then return 1x1 + 2x2 + 3x3 + 4x4 = 30
/// 
/// Detail Steps
/// DECLARE inputValue as string
/// DECLARE mySquare as int
/// DECLARE sumOfSquares as int
/// DELCARE loopCounter as int intialize to 1
/// 
/// REPEAT WHILE input is invalid
///     Prompt "Enter the integer upper square number to sum"
///     READ inputValue
///     check inputvalue to be valid
///       if no display an appropriate message
///       if yes SET mySquare to inputValue
/// end loop
/// 
/// REPEAT WHILE loop counter <= MySquare
///     Calculate the square of the loop counter
///     Add to the sum of the squares (sumOfSquares)
///     increment the loop counter by +1
///     DISPLAY the calculate as (loopcounter X loopcounter)
/// END LOOP
/// DISPLAY the final sum of squares.
/// 
/// </summary>

int mySquare = 0;
int sumOfSquares = 0;
int loopCounter = 1;
string inputValue = "";

bool valid = false; //typical this variable is reffered to as a "flag"

while (!valid)
{
    //preventitive error handling
    Console.Write("Enter the integer upper square number to sum:\t");
    inputValue = Console.ReadLine();
    if (!int.TryParse(inputValue,out mySquare)) //not an integer
    {
        Console.WriteLine("\n\tYour input is not a number\n");
    }
    else
    {
        if (mySquare <= 0)
        {
            Console.WriteLine($"\n\tYour number {mySquare} is not a positive number\n");
        }
        else
        {
            valid = true;
        }
    }
}
//
// to do a while loop in C# use the following syntax:
//   
// while(condition(s))
// [{]
//      if there is only one line of code the { ..... } are optional
//      indentation is for readability ONLY
//      the logic steps to repeat
// [}]


//WARNING: you MUST NOT use a break; or continue; statement to exit a loop
//         this will be regarded as a MAJOR LOGIC ERROR
//         EACH occurance of this type of coding will be treated as a separate MAJOR LOGIC ERROR

Console.Write($"\n\t The sum of squares for {mySquare} is ");
while(loopCounter <= mySquare)
{
    sumOfSquares += loopCounter * loopCounter;  //Math.Pow(loopCounter,2)
    Console.Write($"{loopCounter} X {loopCounter} ");
    if (loopCounter < mySquare)
    {
        Console.Write("+ ");
    }
    loopCounter++; //the same as loopCounter = loopCounter + 1
}

Console.WriteLine($"= {sumOfSquares}\n");
