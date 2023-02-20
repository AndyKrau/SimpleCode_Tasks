namespace lesson_collections_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>() { "One","Two","Three","Four"};
            var mySet = new List<string>(numbers) { "Red","green","Yellow", "black","Silver","Gray"};

            Print(mySet);

            Console.WriteLine("Capacity: "+mySet.Capacity);
            Console.WriteLine("Count: "+mySet.Count);

            string[] myArray = new string[] {"###","$$$","%%%" };

            mySet.InsertRange(2,myArray);
            mySet.Reverse(0, 4);
            
            Print(mySet);
            Console.WriteLine();
            Console.ReadKey();
        }

        static void Print(List<string> list)
        {
            Console.WriteLine($"List: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}