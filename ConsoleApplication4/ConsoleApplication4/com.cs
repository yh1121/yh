using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class com
    {
        public int jia(int a,int b)
        {
            return a + b;
        }
        public int jian(int a, int b)
        {
            return a - b;
        }
        public int cheng(int a, int b)
        {
            return a * b;
        }
        public void chu(int a, int b)
        {
            double c,d;
            try
            {
                c = a / b;
                d = (double)a / b;
                Console.WriteLine(a+"/"+b+"="+d);
            }
            catch
            {
                Console.WriteLine("除数不可以为0");
            }
        }
    }
}
