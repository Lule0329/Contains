using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] testNames = { "Anna", "Bertil", "Cesar", "Johan", "Karl", "Bernt" };
            
            Console.WriteLine("Enter names");
            string name = Console.ReadLine();
            string name2 = Console.ReadLine();
            
            Console.Clear();

            Console.WriteLine("Contains " + name + ": " + Contains(testNames, name)); // true
            Console.WriteLine("Contains " + name2 + ": " + Contains(testNames, name2)); // false
        }

        public static bool Contains(string[] names, string name)
        {
            bool contains = false;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    contains = true;
                }
            }
            return contains;
        }
    }
}
