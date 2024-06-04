// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tDecisions Decision Decisions .. What to do?\n\n");

/*
 * comment block
 * 
 * Decisions control the flow of your critical paths through your program logic.
 * 
 * Most programing languages use the keyword > if < to specify
 *      your queston for program flow control
 *      
 *  syntax:
 *  
 *  if (condition(s))
 *  [{]
 *      true path coding block
 *  [}]
 *  [else
 *  [{]
 *      false path coding block
 *  [}]]
 *  
 *  if your coding block contains more than one statement, you MUST enclose
 *       the coding block with { ..... }
 *  You do not need to have an > else < on your if structure - one way decision
 *  if you have both a true set of logic AND a false set of logic
 *       you will need the > else < structure -- two way decision
 *  You may nest decision structures within decision structures -- nested ifs
 *  You may discover that your logic creates unique structures
 *        when there is only one "arm" of results -- Branch structures
 *  With a Branch structure you can modify your nested ifs into an if - else if structure
 *  The final decision structure is called a case structure and can be coded
 *       using the > switch syntax < OR as a Branch structure
 *     
 */

// One way if
// this has no false path logic

//do I pay taxes?
//if so what is my tax amount

bool taxable = false;
int quantity = 5;
double gst = 0.05;
double price = 2.75;
double tax = 0.0;

//is the item taxable
if (taxable == true) //the two == symbol is the relational equals question
{ //start of a coding block, in this example are optional, why, one statement
    //descision coding blocks are indented in your code
    //indentation has absolutely on bearing on whether the code is part of a coding
    //      block or not
    tax = (quantity * price) * gst; // the one = symbol is your assignment command
} //end of a coding block

Console.WriteLine($"The tax on my {quantity} items each priced at " +
    $" ${price.ToString("0.00")} with a tax reat of {gst * 100}% is " +
    $" ${tax.ToString("0.00")}");

/*
 * What is the condition?
 * 
 * in the example above: taxable == true
 * 
 * Structure: argument operation-condition value
 * argument: taxable (variable)
 * operation-condition: ==
 * value: true (literal value)
 * 
 * NOTE: the argument and value can BOTH be variables / expression
 * 
 * operation condition:
 *      Relational Operators
 *      == Equals
 *      <  less than
 *      >  greater than
 *      <= less than or equal to
 *      >= greater than or equal to
 *      != or <> not equal to
 *      
 *      Logical Operators
 *       && and
 *       || or
 *       
 *      Bitwise Operators
 *       & and bit wise
 *       | or bit wise
 *       
 * all conditions resolve down to a single result for the "if" that is either true or false
 * 
 * condition expressions
 *  example (a + b) >= C
 *       1) sum of a + b
 *       2) compares to c
 *       3) resolves to either true or false
 *       
 * What about boolean variables in a condition?
 * Do I need to use the relative operators?
 * Depends:
 *   if there test is similar to the example above:
 *       taxable == true resolves to true or false
 *       if taxable is true?  --> true == true --> true
 *       if taxable is false? --> false == true --> false
 *       
 *   Can we shorten the code; YES
 *    if (taxable)
 *      if taxable is true?  -->  true
 *       if taxable is false? -->  false 
 */

/*
 * Write a program lets the user guess whether the flip of a coin results in heads or tails. 
 * The program randomly generates an integer 0 to 1, which represents head or tail. 
 * The program prompts the user to enter a guess, and reports whether the guess is 
 * correct or incorrect. 
 */

string inputValue;
int guess = 0;
Random rnd = new Random();
int flip = rnd.Next(0, 2); //returns either 0 or 1
Console.Write("\n\nEnter 1 for Heads or 0 for Tails:\t");
inputValue = Console.ReadLine();
guess = int.Parse(inputValue);

//decided whether the user has guess correctly and output an appropriate message

//there is two possible outcomes: a) guessed correctly or b) guessed incorrectly
//there is two paths as a result of the question
//this is a two-path structure
//this will require an > else < in my decision structure

if (flip == guess)
{
    Console.WriteLine($" Your guess of {guess} matches the flip of {flip}");
}
else
{
    Console.WriteLine($" Your guess of {guess} does not matches the flip of {flip}");
}

Console.WriteLine("\nNext statement after the if structure");
