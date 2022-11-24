using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int func;
            int currentmoney = 0;
            int money;
            int type;
            double allex = 0;
            //five types of money
            double alleat = 0;
            double allcloth = 0;
            double alllive = 0;
            double allwalk = 0;
            double allplay = 0;

            do
            {
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)計算比例 (4)剩餘金額 (5)退出程式");
                Console.Write("輸入數字選擇功能: ");
                func = Convert.ToInt32(Console.ReadLine());
                if (func == 1)
                {
                    currentmoney = Income(currentmoney);
                }
                else if (func == 2)
                {
                    Console.WriteLine("(1)食 (2)衣 (3)住 (4)行 (5)育樂");
                    Console.Write("輸入數字選擇支出項目: ");
                    type = Convert.ToInt32(Console.ReadLine());
                    Console.Write("輸入支出金額: ");
                    money = Convert.ToInt32(Console.ReadLine());
                    switch (type)
                    {
                        case 1:
                            currentmoney -= money;
                            alleat += money;
                            break;
                        case 2:
                            currentmoney -= money;
                            allcloth += money;
                            break;
                        case 3:
                            currentmoney -= money;
                            alllive += money;
                            break;
                        case 4:
                            currentmoney -= money;
                            allwalk += money;
                            break;
                        case 5:
                            currentmoney -= money;
                            allplay += money;
                            break;
                    }
                }
                else if (func == 3)
                {
                    if(alleat != 0 || allcloth != 0 || alllive !=0 || allwalk != 0 || allplay != 0)
                    {
                        allex = alleat + allcloth + alllive + allwalk + allplay;
                        Console.WriteLine(allex);
                        Console.WriteLine(alleat);
                        Console.WriteLine("食: " + (alleat / allex) * 100 + "%");
                        Console.WriteLine("衣: " + (allcloth / allex) * 100 + "%");
                        Console.WriteLine("住: " + (alllive / allex) * 100 + "%");
                        Console.WriteLine("行: " + (allwalk / allex) * 100 + "%");
                        Console.WriteLine("育樂: " + (allplay / allex) * 100 + "%");
                    }
                    else
                    {
                        Console.WriteLine("食: 0%");
                        Console.WriteLine("衣: 0%");
                        Console.WriteLine("住: 0%");
                        Console.WriteLine("行: 0%");
                        Console.WriteLine("育樂: 0%");
                    }
                    
                }
                else if (func == 4)
                {
                    Console.WriteLine("剩餘金額為: " + currentmoney);
                }
                else if (func == 5)
                {
                    ;
                }
                Console.WriteLine();
            } while (func != 5);
            
        }
        static int Income(int currentmoney)
        {
            int money;
            Console.Write("輸入金額: ");
            money = Convert.ToInt32(Console.ReadLine());
            currentmoney += money;
            return currentmoney;
        }

    }
}
