using System.Collections.Generic;

namespace lesson_collections_hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set1 = new HashSet<string>() 
            {
                "Andy",
                "Florence",
                "Florence",
                "Viola",
                "Viola",
                "Viola",
                "Gagik",
            };
            HashSet<string> set2 = new HashSet<string>()
            {
                "Baltazar",
                "Fionit",
                "Gagik",
                "Masha"
            };

            set2.Remove("Masha");
            Console.WriteLine("Remove(\"Masha\"): ");
            PrintCollection(set2);

            set1.RemoveWhere(x => x.Length >= 5);
            Console.WriteLine("RemoveWhere(x => x.Length > 5): ");
            PrintCollection(set1);

            // unionwith
            set1.UnionWith(set2);
            Console.WriteLine("UnionWith: ");
            PrintCollection(set1);

            //exeptwith
            set1.ExceptWith(set2);
            Console.WriteLine("ExceptWith: ");
            PrintCollection(set1);

            Console.ReadLine();
        }

        static public void PrintCollection(HashSet<string> values)
        {
            // output Hashset
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}