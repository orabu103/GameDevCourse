using System;
using System.Runtime.Intrinsics.X86;
using System.Threading;


namespace TIC_TAC_TOE

{

    class Program

    {

        //making array and   

        //by default I am providing 0-9 where no use of zero  

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int player = 1; //By default player 1 is set  

        static int choice; //This holds the choice at which position user want to mark   



        // The flag veriable checks who has won if it's value is 1 then some one has won the match if -1 then Match has Draw if 0 then match is still running  

        static int flag = 0;
        static int p1wins = 0, p2wins = 0; // counts the number of wins each palyer had (or computer).


        static void Main(string[] args)

        {
            while (true)
            {
                arr[0] = '0'; arr[1] = '1'; arr[2] = '2'; arr[3] = '3'; arr[4] = '4'; arr[5] = '5'; arr[6] = '6'; arr[7] = '7'; arr[8] = '8'; arr[9] = '9';
                flag = 0;
                Board();
                do

                {

                    Console.Clear();// whenever loop will be again start then screen will be clear  
                    Console.WriteLine("to exit the game write quit (at the end of a match)");
                    Console.WriteLine("the last to play will be second to play in the next game.");
                    Console.WriteLine("Player1:X and Player2:O");
                    Console.WriteLine("player1:" + p1wins + "  player2:" + p2wins);

                    Console.WriteLine("\n");

                    if (player % 2 == 0)//checking the chance of the player  

                    {

                        Console.WriteLine("Player 2 Chance");

                    }

                    else

                    {

                        Console.WriteLine("Player 1 Chance");

                    }

                    Console.WriteLine("\n");

                    Board();// calling the board Function  
                    if (player % 2 == 1)
                    {
                        do
                        {
                            choice = int.Parse(Console.ReadLine());//Taking users choice   
                        } while (choice <= 0 | choice >= 10);
                    }
                    else
                    {
                        choice = PCpickChoice();//Taking computers choice  
                    }


                    // checking that position where user want to run is marked (with X or O) or not  

                    if (arr[choice] != 'X' && arr[choice] != 'O')

                    {

                        if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  

                        {

                            arr[choice] = 'O';

                            player++;

                        }

                        else

                        {

                            arr[choice] = 'X';

                            player++;

                        }

                    }

                    else //If there is any possition where user want to run and that is already marked then show message and load board again  

                    {
                        if (player % 2 == 1)
                        {
                            Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);

                            Console.WriteLine("\n");

                            Console.WriteLine("Please wait 2 second board is loading again.....");

                            Thread.Sleep(2000);

                        }
                    }

                    flag = CheckWin();// calling of check win  

                } while (flag != 1 && flag != -1);// This loop will run until all cell of the grid is not marked with X and O or some player won  



                Console.Clear();// clearing the console  

                Board();// getting filled board again  



                if (flag == 1)// if flag value is 1 then some one has won or means who won the last time. 

                {

                    Console.WriteLine("Player {0} has won", (player % 2) + 1);
                    if (player % 2 + 1 == 1) p1wins++;
                    else p2wins++;

                }

                else// if flag value is -1 the match will be draw and no one is winner  

                {

                    Console.WriteLine("Draw");

                }

                String s = Console.ReadLine();
                if(s == "quit")
                {
                    break;
                }
            }

        }

        // Board method which creats board  

        private static void Board()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");

        }



        //Checking that any player has won or not  

        private static int PCpickChoice()
        {
            int x;
            //protective moves so the user doesnt win.
            if (arr[1] == 'X' & arr[3] == 'X' & arr[2] == '2') x = 2;
            else if (arr[1] == 'X' & arr[2] == 'X' & arr[3] == '3') x = 3;
            else if (arr[3] == 'X' & arr[2] == 'X' & arr[1] == '1') x = 1;

            else if (arr[4] == 'X' & arr[5] == 'X' & arr[6] == '6') x = 6;
            else if (arr[4] == 'X' & arr[6] == 'X' & arr[5] == '5') x = 5;
            else if (arr[5] == 'X' & arr[6] == 'X' & arr[4] == '4') x = 4;

            else if (arr[7] == 'X' & arr[8] == 'X' & arr[9] == '9') x = 9;
            else if (arr[7] == 'X' & arr[9] == 'X' & arr[8] == '8') x = 8;
            else if (arr[8] == 'X' & arr[9] == 'X' & arr[7] == '8') x = 7;

            else if (arr[1] == 'X' & arr[4] == 'X' & arr[7] == '7') x = 7;
            else if (arr[1] == 'X' & arr[7] == 'X' & arr[4] == '4') x = 4;
            else if (arr[4] == 'X' & arr[7] == 'X' & arr[1] == '1') x = 1;

            else if (arr[2] == 'X' & arr[5] == 'X' & arr[8] == '8') x = 8;
            else if (arr[2] == 'X' & arr[8] == 'X' & arr[5] == '5') x = 5;
            else if (arr[5] == 'X' & arr[8] == 'X' & arr[2] == '2') x = 2;

            else if (arr[3] == 'X' & arr[6] == 'X' & arr[9] == '9') x = 9;
            else if (arr[3] == 'X' & arr[9] == 'X' & arr[6] == '6') x = 6;
            else if (arr[9] == 'X' & arr[6] == 'X' & arr[3] == '3') x = 3;

            else if (arr[1] == 'X' & arr[5] == 'X' & arr[9] == '9') x = 9;
            else if (arr[1] == 'X' & arr[9] == 'X' & arr[5] == '5') x = 5;
            else if (arr[5] == 'X' & arr[9] == 'X' & arr[1] == '1') x = 1;

            else if (arr[3] == 'X' & arr[5] == 'X' & arr[7] == '7') x = 7;
            else if (arr[3] == 'X' & arr[7] == 'X' & arr[5] == '5') x = 5;
            else if (arr[7] == 'X' & arr[5] == 'X' & arr[3] == '3') x = 3;

            //offensive moves to defeat the user.
            else if (arr[1] == 'O' & arr[3] == 'O' & arr[2] == '2') x = 2;
            else if (arr[1] == 'O' & arr[7] == 'O' & arr[4] == '4') x = 4;
            else if (arr[3] == 'O' & arr[7] == 'O' & arr[6] == '6') x = 6;
            else if (arr[7] == 'O' & arr[9] == 'O' & arr[8] == '8') x = 8;
            else if (arr[1] == 'O' & arr[9] == 'O' & arr[5] == '5') x = 5;
            else if (arr[3] == 'O' & arr[7] == 'O' & arr[5] == '5') x = 5;
            else if (arr[2] == 'O' & arr[8] == 'O' & arr[5] == '5') x = 5;
            else if (arr[4] == 'O' & arr[6] == 'O' & arr[5] == '5') x = 5;
            else if (arr[1] == 'O' & arr[3] == 'O' & arr[9] == '9') x = 9;
            else if (arr[1] == 'O' & arr[3] == 'O' & arr[7] == '7') x = 7;
            else if (arr[1] == 'O' & arr[7] == 'O' & arr[3] == '3') x = 3;
            else if (arr[1] == 'O' & arr[7] == 'O' & arr[9] == '9') x = 9;
            else if (arr[3] == 'O' & arr[9] == 'O' & arr[1] == '1') x = 1;
            else if (arr[3] == 'O' & arr[9] == 'O' & arr[7] == '7') x = 7;
            else if (arr[9] == 'O' & arr[7] == 'O' & arr[1] == '1') x = 1;
            else if (arr[9] == 'O' & arr[7] == 'O' & arr[3] == '3') x = 3;

            //third moves
            else if (arr[1] == 'O' & arr[3] == 'O' & arr[9] == '9') x = 9;
            else if (arr[1] == 'O' & arr[3] == 'O' & arr[7] == '7') x = 7;
            else if (arr[7] == 'O' & arr[9] == 'O' & arr[3] == '3') x = 3;
            else if (arr[7] == 'O' & arr[9] == 'O' & arr[1] == '1') x = 1;
            else if (arr[9] == 'O' & arr[3] == 'O' & arr[1] == '1') x = 1;
            else if (arr[9] == 'O' & arr[3] == 'O' & arr[7] == '7') x = 7;
            else if (arr[1] == 'O' & arr[7] == 'O' & arr[9] == '9') x = 9;
            else if (arr[1] == 'O' & arr[7] == 'O' & arr[3] == '3') x = 3;
            else if (arr[1] == 'O' & arr[9] == 'O' & arr[3] == '3') x = 3;
            else if (arr[1] == 'O' & arr[9] == 'O' & arr[7] == '7') x = 7;
            else if (arr[3] == 'O' & arr[7] == 'O' & arr[1] == '1') x = 1;
            else if (arr[3] == 'O' & arr[7] == 'O' & arr[9] == '9') x = 9;

            //second moves
            else if (arr[1] == 'O' & arr[3] == '3') x = 3;
            else if (arr[1] == 'O' & arr[7] == '7') x = 7;
            else if (arr[7] == 'O' & arr[9] == '9') x = 9;
            else if (arr[7] == 'O' & arr[1] == '1') x = 1;
            else if (arr[3] == 'O' & arr[1] == '1') x = 1;
            else if (arr[3] == 'O' & arr[9] == '9') x = 9;
            else if (arr[9] == 'O' & arr[3] == '3') x = 3;
            else if (arr[9] == 'O' & arr[7] == '7') x = 7;

            //first moves
            else if (arr[1] == '1') x = 1;
            else if (arr[3] == '3') x = 3;
            else if (arr[7] == '7') x = 7;
            else if (arr[9] == '9') x = 9;
            else if (arr[5] == '5') x = 5;

            //if all moves cannot be done, pick a random move.
            else
            {
                Random rand = new Random();
                x = rand.Next(1, 10);
            }
            Console.WriteLine(x);
            Thread.Sleep(2000);
            return x;
        }
        private static int CheckWin()

        {

            #region Horzontal Winning Condtion

            //Winning Condition For First Row   

            if (arr[1] == arr[2] && arr[2] == arr[3])

            {

                return 1;

            }

            //Winning Condition For Second Row   

            else if (arr[4] == arr[5] && arr[5] == arr[6])

            {

                return 1;

            }

            //Winning Condition For Third Row   

            else if (arr[6] == arr[7] && arr[7] == arr[8])

            {

                return 1;

            }

            #endregion



            #region vertical Winning Condtion

            //Winning Condition For First Column       

            else if (arr[1] == arr[4] && arr[4] == arr[7])

            {

                return 1;

            }

            //Winning Condition For Second Column  

            else if (arr[2] == arr[5] && arr[5] == arr[8])

            {

                return 1;

            }

            //Winning Condition For Third Column  

            else if (arr[3] == arr[6] && arr[6] == arr[9])

            {

                return 1;

            }

            #endregion



            #region Diagonal Winning Condition

            else if (arr[1] == arr[5] && arr[5] == arr[9])

            {

                return 1;

            }

            else if (arr[3] == arr[5] && arr[5] == arr[7])

            {

                return 1;

            }

            #endregion



            #region Checking For Draw

            // If all the cells or values filled with X or O then any player has won the match  

            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')

            {

                return -1;

            }

            #endregion



            else

            {

                return 0;

            }

        }

    }

}