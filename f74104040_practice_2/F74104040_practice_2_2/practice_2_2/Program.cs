using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[9, 9];
            char[] op = new char[2];
            bool player = true;
            int O_num = 0;
            int X_num = 0;

            //initialize the board
            board[0, 0] = ' ';
            char a = '1';
            for (int i=1; i<board.GetLength(0); i++)
            {
                board[i, 0] = a;
                a++;
            }
            char tmp = 'A';
            for (int j=1; j<board.GetLength(1); j++)
            {
                board[0, j] = tmp;
                tmp++;
            }
            for(int i=1; i<board.GetLength(0); i++)
            {
                for(int j=1; j<board.GetLength(1); j++)
                {
                    board[i, j] = '-';
                }
            }

            print(ref board);
            do
            {
                if (player)
                {
                    Console.WriteLine("It is player O's turn, please enter the position: ");
                    op = Console.ReadLine().ToCharArray();
                    if(board[op[1] - '1' + 1, op[0] - 'A' + 1] == '-')
                    {
                        board[op[1] - '1' + 1, op[0] - 'A' + 1] = 'O';
                        O_num++;

                        check(op[1] - '1' + 1, op[0] - 'A' + 1, ref X_num, ref O_num, ref board, player);
                        Console.Clear();
                        print(ref board);
                        player = false;
                    }
                    else
                    {
                        Console.WriteLine("There is a chess piece in this position, please press a key to continue");
                        Console.ReadKey(); // let user to press any key
                        Console.Clear();
                        print(ref board);
                    }
                    
                }
                else
                {
                    Console.WriteLine("It is player X's turn, please enter the position: ");
                    op = Console.ReadLine().ToCharArray();
                    if (board[op[1] - '1' + 1, op[0] - 'A' + 1] == '-')
                    {
                        board[op[1] - '1' + 1, op[0] - 'A' + 1] = 'X';
                        X_num++;

                        check(op[1] - '1' + 1, op[0] - 'A' + 1, ref X_num, ref O_num, ref board, player);
                        Console.Clear();
                        print(ref board);
                        player = true;
                    }
                    else
                    {
                        Console.WriteLine("There is a chess piece in this position, please press a key to continue");
                        Console.ReadKey(); // let user to press any key
                        Console.Clear();
                        print(ref board);
                    } 
                    
                }
                
            } while ((O_num + X_num) != 64);

            if(O_num > X_num)
            {
                Console.WriteLine("Game Over, Winner is player O !");
            }
            else
            {
                Console.WriteLine("Game Over, Winner is player X !");
            }
            Console.ReadLine();
        }

        static void print(ref char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void check(int row, int col, ref int X_num, ref int O_num, ref char[,] board, bool player)
        {
            int next = row;
            if (player)//O
            {
                // check the column down
                for(int i=row; i<8; i++)
                {
                    if (board[i + 1, col] == '-') continue;
                    else if(board[i + 1, col] == 'O')
                    {
                        for(int j=i; j>next; j--)
                        {
                            if(board[j,col] == 'X')
                            {
                                board[j, col] = 'O';
                                X_num--;
                                O_num++;
                            }
                        }
                        next = i + 1;
                        Console.WriteLine(next);  // This is a annotation
                    }
                }

                next = row;

                // check the column up
                for (int i=row; i>0; i--)
                {
                    if (board[i - 1, col] == '-') continue;
                    else if(board[i - 1,col] == 'O')
                    {
                        for (int j=i; j<next; j++)
                        {
                            if (board[j, col] == 'X')
                            {
                                board[j, col] = 'O';
                                X_num--;
                                O_num++;
                            }
                        }
                        next = i - 1;
                    }
                }

                next = col;

                //check the row right
                for(int i=col; i<8; i++)
                {
                    if (board[row, i + 1] == '-') continue;
                    else if(board[row, i + 1] == 'O')
                    {
                        for(int j=i; j>next; j--)
                        {
                            if(board[row, j] == 'X')
                            {
                                board[row, j] = 'O';
                                X_num--;
                                O_num++;
                            }
                        }
                        next = i + 1;
                    }
                }

                next = col;

                //check the row left
                for (int i = col; i > 0; i--)
                {
                    if (board[row, i - 1] == '-') continue;
                    else if (board[row, i - 1] == 'O')
                    {
                        for (int j = i; j < next; j++)
                        {
                            if (board[row, j] == 'X')
                            {
                                board[row, j] = 'O';
                                X_num--;
                                O_num++;
                            }
                        }
                        next = i - 1;
                    }
                }
            }
            else //X
            {
                // check the column down
                for (int i = row; i < 8; i++)
                {
                    if (board[i + 1, col] == '-') continue;
                    else if (board[i + 1, col] == 'X')
                    {
                        for (int j = i; j > next; j--)
                        {
                            if (board[j, col] == 'O')
                            {
                                board[j, col] = 'X';
                                X_num++;
                                O_num--;
                            }
                        }
                        next = i + 1;
                        Console.WriteLine(next);  // This is a annotation
                    }
                }

                next = row;

                // check the column up
                for (int i = row; i > 0; i--)
                {
                    if (board[i - 1, col] == '-') continue;
                    else if (board[i - 1, col] == 'X')
                    {
                        for (int j = i; j < next; j++)
                        {
                            if (board[j, col] == 'O')
                            {
                                board[j, col] = 'X';
                                X_num++;
                                O_num--;
                            }
                        }
                        next = i - 1;
                    }
                }

                next = col;

                //check the row right
                for (int i = col; i < 8; i++)
                {
                    if (board[row, i + 1] == '-') continue;
                    else if (board[row, i + 1] == 'X')
                    {
                        for (int j = i; j > next; j--)
                        {
                            if (board[row, j] == 'O')
                            {
                                board[row, j] = 'X';
                                X_num++;
                                O_num--;
                            }
                        }
                        next = i + 1;
                    }
                }

                next = col;

                //check the row left
                for (int i = col; i > 0; i--)
                {
                    if (board[row, i - 1] == '-') continue;
                    else if (board[row, i - 1] == 'X')
                    {
                        for (int j = i; j < next; j++)
                        {
                            if (board[row, j] == 'O')
                            {
                                board[row, j] = 'X';
                                X_num++;
                                O_num--;
                            }
                        }
                        next = i - 1;
                    }
                }
            }
            
        }
    }
}
