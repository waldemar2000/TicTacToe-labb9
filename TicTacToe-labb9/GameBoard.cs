using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_labb9
{
    public delegate void PrintGameOverMessage();
    class GameBoard : Interface
    {
        private event PrintGameOverMessage GameIsOver;
        public Node[,] Grid { get; set; }
        //Node node = new Node();
        int WhosPLaying = 0;
        int playTime = 0;
        
        public void DrawGameBoard()
        {
            Grid = new Node[3, 3];

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Grid[row, col] = new Node { PositionRow = row, PositionCol = col };
                }
            }
        }

        public void PlaceMarker()
        {
            Console.WriteLine("skriv två siffror");
            int inputRow = int.Parse(Console.ReadLine());
            int inputCol = int.Parse(Console.ReadLine());

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    var node = Grid[row, col];

                    if (inputRow == node.PositionRow)
                    {
                        if (inputCol == node.PositionCol)
                        {
                            while (node.Taken == false)
                            {
                                playTime++;
                                if (WhosPLaying == 1)
                                {
                                    WhosPLaying = 0;
                                }
                                else
                                {
                                    WhosPLaying = 1;
                                }
                                node.Player = WhosPLaying;
                                node.Taken = true;
                            }   
                        }
                    }
                }
            }
        }

       

        public void Render()
        {
             
        Console.Clear();
 
            if (playTime == 9)
            {
                GameIsOver += new PrintGameOverMessage(Message);
                GameIsOver.Invoke();
               
                Console.ReadLine();
                Environment.Exit(0);
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    var node = Grid[row, col];
                    if (node.Taken == true)
                    {
                        if (node.Player == 1)
                            Console.Write("[X]");
                        else
                            Console.Write("[O]");
                    }
                    else Console.Write("[" + node.PositionRow + node.PositionCol + "]");
                    if (col == 2)
                        Console.WriteLine();
                }
            }
        }
        public void Message()
        {
            Console.WriteLine("Game over");
        }
    }

}


