﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nTic Tac Toe Game\n");

/************************************ driver *****************************/

//multi-dimensional array
//2 or more values within a row on your array

//game board

//              *          *
//        1     *    2     *      3                 this area would be a row
//              *          *
//    **************************************
//              *          *
//        4     *     5    *       6                this area would be a row
//              *          *
//    **************************************
//              *          *
//         7    *     8    *       9               this area would be a row
//              *          *
//     column     column        column



//the array STILL must be of a single datatype
//the rows vs columns do not need to match
//syntax string[ , ] indicates a 2 dimensional array (2D-array)
//                   the comma indicates each additional dimension (3D [,,])
//in a 2D array, the first value is your rows, the second value is the columns
string[,] gameBoard = new string [5 , 5];

InitializeBoard(gameBoard);

PlayGame(gameBoard);

/************************************ methods ****************************/

static void InitializeBoard(string[,] gameBoard)
{
    //for each row
    for(int r = 0; r < 5; r++)
    {
        //for each column on the row
        for(int c = 0; c < 5; c++)
        {
            if (c == 1 || c == 3)
            {
                gameBoard[r, c] = "|";
            }
            else if (r == 1 || r == 3)
            {
                gameBoard[r, c] = "-".PadLeft(3,'-');
            }
            else
            {
                gameBoard[r, c] = "   ";
            }
        }
    }
    gameBoard[0, 0] = " 1 ";
    gameBoard[0, 2] = " 2 ";
    gameBoard[0, 4] = " 3 ";
    gameBoard[2, 0] = " 4 ";
    gameBoard[2, 2] = " 5 ";
    gameBoard[2, 4] = " 6 ";
    gameBoard[4, 0] = " 7 ";
    gameBoard[4, 2] = " 8 ";
    gameBoard[4, 4] = " 9 ";
}

static void DisplayGameBoard(string[,] gameBoard)
{
    for (int r = 0; r < 5; r++)
    {
        //for each column on the row
        for (int c = 0; c < 5; c++)
        {
            Console.Write(gameBoard[r, c]);
        }
        Console.WriteLine(); //moves the display to the next row
    }
}

static void PlayGame(string[,] gameBoard)
{
    DisplayGameBoard(gameBoard);
    int turns = 0;
    int elementId = 1;
    bool valid = false;

    while (turns < 9)
    {
        if (turns % 2 == 0)
        {
            //first person is X
            elementId = PromptForPlace("Player X: select an usused cell number");
            valid = PlaceSymbol(" X ", elementId, gameBoard);
        }
        else
        {
            //second person is O
            elementId = PromptForPlace("Player O: select an usused cell number");
            valid = PlaceSymbol(" O ", elementId, gameBoard);
        }
        Console.WriteLine();
        DisplayGameBoard(gameBoard);
        if (valid)
        {
            // TODO:
            // create a method that would check to see if there is a 
            //  winner to the game
            // turns = CheckForWin(gameboard,turns);
            turns++;
        }
    }
}

static int PromptForPlace(string prompt)
{
    string inputValue = "";
    Console.Write($"\n{prompt}:\t");
    inputValue = Console.ReadLine();

    //put in validation code to ensure value entered is an integer

    return int.Parse(inputValue);
}

static bool PlaceSymbol(string symbol, int elementId, string[,] gameBoard)
{
    bool valid = true;

    //check that the game cell is not already used
    switch(elementId)
    {
        case 1:
            {
                if (gameBoard[0, 0].Equals(" X ") || gameBoard[0, 0].Equals(" O "))
                {
                    //is the cell on the game board already in use
                    Console.WriteLine($"\nThe game cell is already selected. Select a different cell.");
                    valid = false;
                }
                else
                {
                    gameBoard[0, 0] = symbol;
                }
                break;
            }
        case 2:
            {
                if (gameBoard[0, 2].Equals(" X ") || gameBoard[0, 0].Equals(" O "))
                {
                    //is the cell on the game board already in use
                    Console.WriteLine($"\nThe game cell is already selected. Select a different cell.");
                    valid = false;
                }
                else
                {
                    gameBoard[0, 2] = symbol;
                }
                break;
            }
        case 3:
            {
                if (gameBoard[0, 4].Equals(" X ") || gameBoard[0, 0].Equals(" O "))
                {
                    //is the cell on the game board already in use
                    Console.WriteLine($"\nThe game cell is already selected. Select a different cell.");
                    valid = false;
                }
                else
                {
                    gameBoard[0, 4] = symbol;
                }
                break;
            }
        case 4:
            {
                if (gameBoard[2, 0].Equals(" X ") || gameBoard[0, 0].Equals(" O "))
                {
                    //is the cell on the game board already in use
                    Console.WriteLine($"\nThe game cell is already selected. Select a different cell.");
                    valid = false;
                }
                else
                {
                    gameBoard[2, 0] = symbol;
                }
                break;
            }
        case 5:
            {
                if (gameBoard[2, 2].Equals(" X ") || gameBoard[0, 0].Equals(" O "))
                {
                    //is the cell on the game board already in use
                    Console.WriteLine($"\nThe game cell is already selected. Select a different cell.");
                    valid = false;
                }
                else
                {
                    gameBoard[2, 2] = symbol;
                }
                break;
            }
        case 6:
            {
                if (gameBoard[2, 4].Equals(" X ") || gameBoard[0, 0].Equals(" O "))
                {
                    //is the cell on the game board already in use
                    Console.WriteLine($"\nThe game cell is already selected. Select a different cell.");
                    valid = false;
                }
                else
                {
                    gameBoard[2, 4] = symbol;
                }
                break;
            }
        case 7:
            {
                if (gameBoard[4, 0].Equals(" X ") || gameBoard[0, 0].Equals(" O "))
                {
                    //is the cell on the game board already in use
                    Console.WriteLine($"\nThe game cell is already selected. Select a different cell.");
                    valid = false;
                }
                else
                {
                    gameBoard[4, 0] = symbol;
                }
                break;
            }
        case 8:
            {
                if (gameBoard[4, 2].Equals(" X ") || gameBoard[0, 0].Equals(" O "))
                {
                    //is the cell on the game board already in use
                    Console.WriteLine($"\nThe game cell is already selected. Select a different cell.");
                    valid = false;
                }
                else
                {
                    gameBoard[4, 2] = symbol;
                }
                break;
            }
        case 9:
            {
                if (gameBoard[4, 4].Equals(" X ") || gameBoard[0, 0].Equals(" O "))
                {
                    //is the cell on the game board already in use
                    Console.WriteLine($"\nThe game cell is already selected. Select a different cell.");
                    valid = false;
                }
                else
                {
                    gameBoard[4, 4] = symbol;
                }
                break;
            }
        default:
            {
                Console.WriteLine($"\nYour cell number choice of {elementId} is invalid.");
                valid = false;
                break;
            }
    }
    return valid;
}