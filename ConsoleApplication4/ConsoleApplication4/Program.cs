using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a, b;
                com c = new com();
                Console.WriteLine("请输入要进行运算的两个数：");
                string y = Console.ReadLine();
                a = int.Parse(y);
                string z = Console.ReadLine();
                b = int.Parse(z);
                Console.WriteLine("请输入运算规则：加法（1），减法（2），乘法（3），除法（4），字符串相加（5），字符串相减（6），退出（7）");
                int i;
                string x = Console.ReadLine();
                i = int.Parse(x);
                switch (i)
                {
                    case 1: Console.WriteLine(a + "+" + b + "=" + c.jia(a, b)); break;
                    case 2: Console.WriteLine(a + "-" + b + "=" + c.jian(a, b)); break;
                    case 3: Console.WriteLine(a + "*" + b + "=" + c.cheng(a, b)); break;
                    case 4: c.chu(a, b); break;
                    case 5: Console.WriteLine("请依次输入两个字符串：");
                            string d = Console.ReadLine(); string f = Console.ReadLine();
                            Console.WriteLine(d+"+"+f+"="+d+f);break;
                    case 6: Console.WriteLine("请依次输入两个字符串：");
                            string j = Console.ReadLine(); string k = Console.ReadLine();
                            Regex r=new Regex(k);j=r.Replace(j,"");
                            Console.WriteLine(j+"-"+k+"="+j); break;
                    case 7: break;
                    default: Console.WriteLine("输入有误，请重新输入"); break;
                }
                if (i == 7)
                {
                    break;
                }
            }
        }
    }
}
