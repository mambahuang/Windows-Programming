using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int func;
            int credits = 0;
            bool flag2 = true;
            string info;
            string delete;
            string[] subs = new string[4];
            int checkpos = 0;

            //initialize
            string[] check = new string[72];
            for (int i = 0; i < check.Length; i++)
                check[i] = "";

            //initialize
            string[,] curri = new string[9,8];
            for(int i = 0; i<9; i++)
            {
                for(int j=0; j<8; j++)
                {
                    curri[i, j] = "";
                }
            }

            curri[0, 0] = "";
            curri[1, 0] = "1";
            curri[2, 0] = "2";
            curri[3, 0] = "3";
            curri[4, 0] = "4";
            curri[5, 0] = "5";
            curri[6, 0] = "6";
            curri[7, 0] = "7";
            curri[8, 0] = "8";

            //Everyday
            curri[0, 0] = "";
            curri[0, 1] = "Sun";
            curri[0, 2] = "Mon";
            curri[0, 3] = "Tue";
            curri[0, 4] = "Wed";
            curri[0, 5] = "Thu";
            curri[0, 6] = "Fri";
            curri[0, 7] = "Sat";

            do
            {
                Console.WriteLine("(1)Add a course (2)Delete a course (3)Print timetable (4)Computing credits  (5)Exit");
                Console.Write("Input number selection function: ");
                func = Convert.ToInt32(Console.ReadLine());
                if(func == 1)
                {
                    Console.WriteLine("Please Input the course you want to add, format is <Course code, Mon~Sun, Start, End>");
                    info = Console.ReadLine();
                    subs = info.Split(' ');

                    for(int j=0; j<check.Length; j++){
                        if (subs[0] == check[j])
                        {
                            flag2 = true;
                            Console.WriteLine("Course repetition");
                            break;
                        }
                        if(j == check.Length - 1)
                        {
                            flag2 = false;
                        }
                    }

                    //Console.WriteLine(flag2);
                    if (!flag2)
                    {
                        for (int i = Convert.ToInt32(subs[2]); i <= Convert.ToInt32(subs[3]); i++)
                        {
                            if (curri[i, Convert.ToInt32(subs[1]) + 1] != "")
                            {
                                Console.WriteLine("Course redemption");
                                break;
                            }
                            else if (i == Convert.ToInt32(subs[3]))
                            {
                                check[checkpos] = subs[0];
                                checkpos++;
                                for (int j = Convert.ToInt32(subs[2]); j <= Convert.ToInt32(subs[3]); j++)
                                {
                                    curri[j, Convert.ToInt32(subs[1]) + 1] = subs[0];
                                }
                                Console.WriteLine("Success to add the course");
                                credits += Convert.ToInt32(subs[3]) - Convert.ToInt32(subs[2]) + 1;
                            }
                        }
                    }

                }
                else if(func == 2)
                {
                    Console.Write("Please enter the course code you want to delete: ");
                    delete = Console.ReadLine();
                    bool flag = false;
                    for(int k= 0; k<check.Length; k++)
                    {
                        //remove the record
                        if (check[k] == delete)
                        {
                            flag = true;
                            for(int i=0; i<check.Length; i++)
                            {
                                string tmp = "";
                                if(check[i] == delete)
                                {
                                    check[i] = "";
                                    for(int j=i+1; j<check.Length; j++)
                                    {
                                        tmp = check[j];
                                        check[j] = check[j - 1];
                                        check[j - 1] = tmp;
                                    }
                                }
                                
                            }
                            //delete curriculum
                            for(int i=1; i<9; i++)
                            {
                                for(int j=1; j<8; j++)
                                {
                                    if(curri[i,j] == delete)
                                    {
                                        curri[i,j] = "";
                                        credits--;
                                    }
                                }
                            }
                            Console.WriteLine("Successfully delete the course: " + delete);
                            break;
                        }
                        
                    }
                    if(!flag)
                        Console.WriteLine("Course " + delete + " is not in the curriculum");
                }
                else if(func == 3)
                {
                    for(int i=0; i<9; i++)
                    {
                        for(int j=0; j<8; j++)
                        {
                            Console.Write(String.Format("{0,-6}", curri[i, j]));
                        }
                        Console.WriteLine();
                    }
                }else if(func == 4)
                {
                    Console.WriteLine(credits);
                }else if(func == 5)
                {
                    ;
                }
            } while (func != 5);
        }
    }
}
