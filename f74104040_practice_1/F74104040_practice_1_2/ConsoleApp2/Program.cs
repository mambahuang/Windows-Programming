using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int func;
            int currentmoney = 0;
            string money;
            int num_money;
            int type;
            string[] item = new string[5];
            int[] flag = { 0, 0, 0, 0, 0 };
            int[] item_money = { 0, 0, 0, 0, 0 };
            int[] item_total = { 0, 0, 0, 0, 0 };
            double total = 0;

            //check  if the value is valid
            bool valid;

            string tmp1;
            string tmp2;

            int tmp3;
            int tmp4;
            int tmp5;

            for (int i=0; i<5; i++)
            {
                item[i] = "";
            }

            do
            {
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)新增項目 (4)刪除項目 (5)計算比例 (6) 查詢支出 (7)剩餘金額 (8)退出程式");
                Console.Write("輸入數字選擇功能: ");
                func = Convert.ToInt32(Console.ReadLine());
                if (func == 1)
                {
                    Console.Write("輸入金額: ");
                    money = Console.ReadLine();
                    valid = int.TryParse(money, out int value);
                    if (valid)
                    {
                        num_money = Convert.ToInt32(money);
                        if (num_money >= 0)
                        {
                            currentmoney += num_money;
                        }
                        else
                        {
                            Console.WriteLine("收入不可為負數");
                        }
                    }
                    else
                    {
                        Console.WriteLine("請輸入數字");
                    }
                    
                }
                else if (func == 2)
                {
                    if (string.IsNullOrEmpty(item[0]))
                    {
                        Console.WriteLine("請新增支出項目");
                    }
                    else
                    {
                        for(int i=0; i<item.Length; i++)
                        {
                            if(!item[i].Equals(""))
                                Console.WriteLine("(" + (i + 1) + ")" + item[i]);
                        }
                        Console.Write("輸入數字選擇支出項目: ");
                        type = Convert.ToInt32(Console.ReadLine());
                        if(type <= 0 || type > item.Length)
                        {
                            Console.WriteLine("此數字不再範圍中");
                        }
                        else
                        {
                            if (item[type-1] == "")
                            {
                                Console.WriteLine("此數字不再範圍中");
                            }
                            else
                            {
                                Console.Write("輸入支出金額: ");
                                item_money[type-1] = Convert.ToInt32(Console.ReadLine());
                                if (currentmoney - item_money[type-1] < 0)
                                {
                                    Console.WriteLine("存款不足");
                                }
                                else
                                {
                                    currentmoney -= item_money[type-1];
                                    item_total[type-1] += item_money[type-1];
                                }
                            }
                        }
                    }
                }else if(func == 3)
                {
                    if (!string.IsNullOrEmpty(item[item.Length - 1]))
                    {
                        Console.WriteLine("已無法再新增支出項目");
                    }
                    else
                    {
                        Console.Write("輸入項目名稱: ");
                        tmp1 = Console.ReadLine();
                        for (int i = 0; i < flag.Length; i++)
                        {
                            if (flag[i] == 1)
                            {
                                if (tmp1.Equals(item[i]))
                                {
                                    Console.WriteLine("支出項目已存在");
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                                
                            }
                            else
                            {
                                item[i] = tmp1;
                                flag[i] = 1;
                                break;
                            }
                        }
                    }

                }else if(func == 4)
                {
                    string del;
                    if (string.IsNullOrEmpty(item[0]))
                    {
                        Console.WriteLine("已無法再刪除支出項目");
                    }
                    else
                    {
                        Console.Write("輸入項目名稱: ");
                        del = Console.ReadLine();
                        int i;
                        for (i = 0; i < item.Length; i++)
                        {
                            if (item[i] == del)
                            {
                                item[i] = "";
                                item_money[i] = 0;
                                item_total[i] = 0;
                                flag[i] = 0;

                                if (i != item.Length - 1)
                                {
                                    // 1 space forward
                                    for (int j = i + 1; j < item.Length; j++)
                                    {
                                        tmp2 = item[j];
                                        item[j] = "";
                                        item[j - 1] = tmp2;

                                        tmp3 = item_money[j];
                                        item_money[j] = 0;
                                        item_money[j - 1] = tmp3;

                                        tmp4 = item_total[j];
                                        item_total[j] = 0;
                                        item_total[j - 1] = tmp4;

                                        tmp5 = flag[j];
                                        flag[j] = 0;
                                        flag[j - 1] = tmp5;
                                    }
                                    break;
                                }
                                else
                                {
                                    //last item
                                    item[i] = "";
                                    item_money[i] = 0;
                                    item_total[i] = 0;
                                    break;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        if(i == item.Length)
                            Console.WriteLine("此項目不存在");
                    }
                    
                }
                else if (func == 5)
                {
                    //total expenditure
                    total = 0;
                    for (int i = 0; i<item_total.Length; i++)
                    {
                        total += item_total[i];
                    }
                    for (int i = 0; i < item.Length; i++)
                    {
                        if(item[i] != "")
                            Console.WriteLine("(" + (i + 1) + ")" + item[i] + ": " + (item_total[i] / total)*100 + "%");
                    }
                }
                else if(func == 6)
                {
                    string search;
                    Console.WriteLine("目前總支出: " + total);
                    Console.Write("輸入要查詢的項目: ");
                    search = Console.ReadLine();
                    int i;
                    for(i=0; i<item.Length; i++)
                    {
                        if (search.Equals(item[i]))
                        {
                            Console.WriteLine(item[i] + ": " + item_total[i]);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if(i == item.Length)
                        Console.WriteLine("此項目不存在");
                }
                else if (func == 7)
                {
                    Console.WriteLine("剩餘金額為: " + currentmoney);
                }
                else if (func == 8)
                {
                    ;
                }
                Console.WriteLine();
            } while (func != 8);
        }
    }
}
