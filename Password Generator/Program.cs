using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            int lenght = 8;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < lenght--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            Console.WriteLine(res.ToString() + "\nEnter to regenerate password");
            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }
}
