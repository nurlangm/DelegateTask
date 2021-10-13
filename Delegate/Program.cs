using System;

namespace Delegate
{
    class Program
    {
        public delegate bool NumberInfo<T>(T number);
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Action<int> action1 = Tek;
            action1.Invoke(num);
            Action<int> action2 = Menfi;
            action2.Invoke(num);
            Action<int> action3 = Murekkeb;
            action3.Invoke(num);

        }

        public static void Tek(int num)
        {
            if (num % 2 != 0)
            {
                Console.WriteLine("Eded tekdir");
            }
            else
            {
                Console.WriteLine("Cutdur");
            }
        }
        public static void Menfi(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("Menfidir");
            }
            else
            {
                Console.WriteLine("Musbetdir");
            }
        }
        public static void Murekkeb(int num)
        {
            int count = 0;
            if (num < 0)
            {
                Console.WriteLine("Murekkeb veya sade ededler menfi ola bilmez");
            }
            else
            {
                if(num>1)
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Prime");
                }
                else
                if (count > 0)
                {
                    Console.WriteLine("Not Prime");
                }
            }
        }
    }
}



        