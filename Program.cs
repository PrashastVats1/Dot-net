using System;

namespace _2DArraynStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter 2 nos.");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //calc(ref a, ref b);
            //int i=0;
            //int[] cnumbers = {1,2,3,4,5,6,7,8,9,10};
            //Console.WriteLine("array");
            //while (i < 10)
            //{
            //  Console.WriteLine(cnumbers[i]);
            //    i++;
            //  }
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            palindrome(ref str);
        }

        static void palindrome(ref string str)
        {
            int i = 0, l = str.Length, n = 0;
            for (i = 0; i < str.Length/2; i++)
            {
                if (str[i] == str[l-1-i])
                {
                    n++;
                    continue;
                }
            }
            if (n == l / 2)
            {
                Console.WriteLine("Is palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
        //static void calc(ref int a, ref int b)
        //{
            //int sum, mul, sub;
            //sum = a + b;
            //mul = a * b;
            //sub = a - b;
            //Console.WriteLine("Sum" +sum);
            //Console.WriteLine("Sub" + sub);
          //  Console.WriteLine("Mul" + mul);
        //}
    }
}
