
Console.WriteLine("\n\tUsing Parallel Arrays\n");

// Create a program that will allow the user to enter up to 25 names and
// marks into a set of parallel arrays.
// Calculate and display the mean average of the marks.
// Find the Highest Mark
// Find the Lowest Mark

/*
 * Declare array marks as int (25)
 * Declare array names as string (25)
 * Declare inputValue as string
 * Declare logicalSize as int  -- the number of elements filled in the array
 * Declare exitLoop as bool
 * Declare runningSum as int
 * Loop (while logicalSize < array size or exitLoop
 *    Prompt/Read a name
 *    Store in array if not exit value (x)
 *    Prompt/Read mark
 *    Store in array if not exit condition
 *    Add to running sum


 * Display student name and mark
 * Calculate average
 * Display the average
 * Find and Display the Highest mark without sorting, display name and mark
 * Find and display the lowest mark without sorting, display name and mark

 */

const int ARRAYSIZE = 25;
int[] grades = new int[ARRAYSIZE];
string[] names = new string[ARRAYSIZE];
string inputValue = "";
int inputNum = 0;
int logicalSize = 0;
bool exitLoop = false;
bool validInput = false;
int runningSum = 0;
double markAverage = 0.0;

try
{
    // loop and enter my data
    do
    {
        Console.Write("Enter the student name (use x to terminate student list):\t");
        inputValue = Console.ReadLine();
        if (inputValue.ToUpper().Equals("X"))
        {
            exitLoop = true;  //i want to exit the loop
        }
        else
        {
            names[logicalSize] = inputValue;
            do
            {
                Console.Write("Enter a positive whole number (0-100):\t");
                inputValue = Console.ReadLine();
                if (int.TryParse(inputValue, out inputNum))
                {
                    if (inputNum >= 0 && inputNum <= 100)
                    {
                        grades[logicalSize] = inputNum;
                        runningSum += inputNum;
                        validInput = true;
                        logicalSize++; //increment to the next element array space.
                    }
                    else
                    {
                        Console.Write("Number entered is not a positive whole number (0-100):\t");
                        validInput = false;
                    }
                }
                else
                {
                    Console.Write("Number entered is not a positive whole number (0-100):\t");
                    validInput = false;
                }
            } while (!validInput);
        }
    } while (logicalSize < ARRAYSIZE && !exitLoop);
}
catch(IndexOutOfRangeException ex) //very specific in the error type
{
    Console.WriteLine($"Array index Error: {ex.Message}");
}
catch(Exception ex) //catch all of any other error
{
    Console.WriteLine($"System Error: {ex.Message}");
}

//display the parallel array data
if (logicalSize == 0)
{
    Console.WriteLine($"\n\tNo students were entered.");
}
else
{
    //Sort the arrays grade ascending
    //to keep the names array in sync with the grades array, you need to alter the sort parameters
    Array.Sort(grades, names, 0,logicalSize);

    Console.WriteLine("{0,-20} {1,8} {2,6}","Student", "Mark", "P/F");
    for(int i = 0; i < logicalSize; i++)
    {
        Console.WriteLine("{0,-20} {1,8} {2,6}", names[i], grades[i], grades[i] < 50 ? "Fail" : "Pass");
    }
   
}