using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class SuperString
    {
        public int length;
        public SuperString(string s)
        {
            this.length = s.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int m = 7;
            Console.WriteLine("Последовательность месяцев с длиной строки m={0}: \n",m);
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            IEnumerable<string> sort1 = months
                .Where(n => n.Length == m)
                .Select(n => n);
            foreach (string s in sort1)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Зимние и летние месяцы: \n");

            IEnumerable<string> sort2 = months
                .Where(n => String.Equals(n, "January") || String.Equals(n, "February") || String.Equals(n, "December") || String.Equals(n, "June") || String.Equals(n, "July") || String.Equals(n, "August"))
                .Select(n => n);
            foreach (string s1 in sort2)
            {
                Console.WriteLine(s1);
            }

            Console.WriteLine("В алфавитном порядке: \n");

            IEnumerable<string> sort3 = months
                .OrderBy(n => n);
            foreach (string s3 in sort3)
            {
                Console.WriteLine(s3);
            }

            Console.WriteLine(" Количество, содержащих 'u' и длина не менее 4: \n");
            List<string> list1 = new List<string> { "aaaaa", "bbbb", "cccccc" };
            IEnumerable<string> sort4 = months
                .Where(n => String.Equals(n, "January") || String.Equals(n, "February") || String.Equals(n, "June") || String.Equals(n, "July") || String.Equals(n, "August"))
                .OrderBy(n => n.Length).ThenBy(n => n.Length >= 4);
            int i = 0;
            foreach (string s4 in sort4)
            {
                i++;
            }
            Console.WriteLine(i);

            List<SuperString> list = new List<SuperString> { new SuperString("aaaaa"), new SuperString("bbbb"), new SuperString("cccccc")};

            Console.WriteLine("С длиной строки 3 и 4: \n");
            IEnumerable<string> l1 = list1
                .Where(n => n.Length == 3 || n.Length == 4)
                .Select(n => n);
            foreach (string k1 in l1)
            {
                Console.WriteLine(k1);
            }

            Console.WriteLine("Самое длинное: \n");

            IEnumerable<string> l2 = list1
                .OrderBy(n => n.Length)
                .Skip(2)
                .Select(n => n);
            foreach (string k1 in l2)
            {
                Console.WriteLine(k1);
            }
        }
    }
}
