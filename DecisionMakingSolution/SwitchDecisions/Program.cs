// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tSwitch Decisions\n\n");

//there is a structure reffered to as a case structure
//conditions:
//  a) there is a single argument to be check : machineChoice
//  b) that argument is check against a series of values: 0,1,2
//  c) the comparsion is EQUALS
//
//the C# command to use for a case structure is the switch
//syntax:
//      switch (argument)
//      {
//          case value:
//          {
//              C# logic to execute
//              break;
//          }
//          .
//          .
//          .
//          case value:
//          {
//              C# logic to execute
//              break;
//          }
//          default:
//          {
//              C# logic to execute
//              break;
//          }
//      }

string inputValue;
string planId;
double planAmount = 0.0;
double hours = 0.0;

Console.Write("Enter your plan A, B or C:\t");
inputValue = Console.ReadLine();

if (inputValue.ToUpper() == "A" || inputValue.ToUpper() == "B" || inputValue.ToUpper() == "C")
{
    planId = inputValue;
    Console.Write("Enter your hours used:\t");
    inputValue = Console.ReadLine();
    if (!double.TryParse(inputValue, out hours))
    {
        // not a integer number
        Console.WriteLine($"\n\tYou input of >{inputValue}< is not a number\n");
    }
    else if (hours < 0)
    {
        // is a number but it is negative
        Console.WriteLine($"\n\tYour input of >{hours}< is not a positive value (greater of equal to 0)\n");
    }
    else
    {
        switch (planId.ToUpper())
        {
            //the test condition for a switch MUST be equals
            case "A":
            {
                //9.95 / month up to 10 hours, all other at 2.00
                if (hours <= 10)
                {
                    planAmount = 9.95;
                }
                else
                {
                    planAmount = 9.95 + ((hours - 10) * 2.00);
                }
                break;
            }
            case "B":
            {
                //13.95 / month up to 20 hours, all other at 1.00
                if (hours <= 20)
                {
                    planAmount = 13.95;
                }
                else
                {
                    planAmount = 13.95 + ((hours - 20) * 1.00);
                }
                break;
            }
            default: 
            {
                //actually plan c
                //unlimited hours
                planAmount = 19.95;
                break;
            }
        }

        Console.WriteLine($"Under plan {planId.ToUpper()} your bill for {hours} hours is " +
            $" ${planAmount.ToString("0.00")}");
    }
}
else
{
    Console.WriteLine($"\n\tYour entered plan value >{inputValue}< is incorrect.\n");
}