using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole
{
    internal class testclass
    {

        public void buzzz()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 ==0)

                    Console.WriteLine("fizz");
                 if (i % 5 == 0)
                    Console.WriteLine("buzz");
                 if (i % 3 == 0 && i % 5 == 0)

                    Console.WriteLine("fizzbuzz”");
            }

        }


        public void reversestring()
        {
            string str = "abcdef";
            var strarr= str.ToArray();
            string strReverse = string.Empty;
            for (int i = strarr.Length-1; i >=0;i--)
            {
                strReverse = strReverse + strarr[i];
               
            }
            Console.WriteLine(strReverse);
        }
    }
}
