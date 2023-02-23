// Цель: изучение языка запросов LINQ
namespace lesson_LINQ
{
    internal class Program
    {
        // создаём экземпляр класса ramdom для получения случайных чисел далее
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            //цикл заполнения нашей коллекции объектами класса Product
            for (int i = 0; i < 10; i++)
            {
                var product = new Product(("Product " + (i + 1)), (rnd.Next(10, 14)));
                //{
                //    Name = "Product " + (i + 1),
                //    Energy = rnd.Next(10, 11)
                //};
                products.Add(product);
            }
            Print(products);

            // выборка с помощью ключевых слов 
            // where возвращает всегда коллекцию
            var selection = from item in products
                            where item.Energy > 11 && item.Energy < 13
                            orderby item.Energy
                            select item;
            Print(selection);

            // выборка с помощью методов расширения  Where
            var selection2 = products.Where(item => item.Energy > 13);
            Print(selection2);

            // выборка с помощью методов расширения select
            var selectEnergy = products.Select(product => product.Energy);
            Print(selectEnergy);

            //упорядочивание коллекции с помощью методов OrderBy and ThenBy(доп условия)
            var orderByEnergy = products.OrderBy(product => product.Energy)
                                        .ThenBy(product => product.Name);
            Print(orderByEnergy);

            // группировка коллекции GroupBy. возвращает группированный список списков
            var groupByEnergy = products.GroupBy(product => product.Energy);
            foreach (var group in groupByEnergy)
            {
                Console.WriteLine($"Группа по ключу №{group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
                Console.WriteLine();
            };

            // reverse не возвращает ничего, просто разворачиает порядок елементов
            // products.Reverse(0, 5);
            // products.Reverse();
            Print(products);

            // all and any 
            Console.WriteLine($"ALL\t у всех продуктов Energy = 11: {products.All(item => item.Energy == 11)}");
            Console.WriteLine($"ALL\t у всех продуктов Energy >= 10: {products.All(item => item.Energy >= 10)}");

            Console.WriteLine($"ANY\t хоть у одного из продуктов Energy = 14: {products.Any(item => item.Energy == 14)}");

            // contains, возвращает bool, проверяет вхождение елемента в коллекцию, аргументом передаётся элемент коллекции
            Console.WriteLine($"Contains\t коллекция содержит products[5]: {products.Contains(products[5])}");

            // Union объединяет элементы коллекций в новой коллекции c удалением повторяющихся
            List<Product> productsSecond = new List<Product>()
            {
                new Product( "Product 1", 10),
                new Product( "Product 2", 10),
                new Product( "Product 3", 10),
                new Product( "Product 4", 10),
                new Product( "Product 11", 10),
                new Product( "Product 12", 10),
            };

            var unionList = products.Union(productsSecond);

            Print(unionList);

            // Concat объединяет элементы коллекций в новой коллекции без удалением повторяющихся
            var concatCollection = products.Concat(productsSecond);

            Print(concatCollection);

            // Distinct удаляет из коллекции повторяющиеся элементы
            var distinctCollection = concatCollection.Distinct();

            Print(distinctCollection);

            // Агрегатные операции: Summ, Max, Min, Aggregate
            var summ = products.Sum(product => product.Energy);
            Console.WriteLine("summ: " + summ);

            var max = products.Max(product => product.Energy);
            Console.WriteLine("Max: " + max);

            var min = products.Min(product => product.Energy);
            Console.WriteLine("Min: " + min);

            var aggregate = products.Select(item => item.Energy).Aggregate((x, y) => x + y);
            Console.WriteLine("aggregate: " + aggregate);

            // обработка части коллекции skip, take 
            var sumPart = products.Skip(2).Take(5).Sum(product => product.Energy);
            Console.WriteLine("sum with skip and take: " + sumPart);

            // first возвращает первый элемент коллекции,
            // если есть условие по первое значение соответсвующее ламда-выражению
            // FirstOrGefault позволяет вывести значение по умолчанию, если коллекция пустая
            var firstElement = products.First();
            Console.WriteLine("products.First(): " + firstElement);

            var firstElementIf = products.First(product => product.Energy == 13);
            Console.WriteLine("products.First(product => product.Energy == 13): " + firstElementIf);

            var firstOrDefault = products.FirstOrDefault(product => product.Energy == 14);
            Console.WriteLine("products.firstOrDefault(product => product.Energy == 14): " + firstOrDefault);

            // last все заметки равноценны first

            // single возвращает единственный элемент в коллекции соответствующий лямда-выражению
            // если элементов соотв условию более одного выпадет exeption
            // SingleOrGefault позволяет вывести значение по умолчанию, если коллекция пустая
            // var single = products.Single(product => product.Energy == 13);

            //ElementAt получение элемента по индексу
            var elementAt = products.ElementAt(4);
            Console.WriteLine("products.ElementAt(4): " + elementAt);

            Console.ReadKey();
        }

        //метод для вывода коллекции List<Product>
        static void Print(List<Product> list)
        {
            Console.WriteLine("Quantity of elements (List<Product>): ");
            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }

        //метод для вывода результата сортировки IEnumerable<Product>
        static void Print(IEnumerable<Product> list)
        {
            Console.WriteLine("Quantity of elements (IEnumerable<Product>): ");

            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }

        //метод для вывода результата сортировки IEnumerable<int>
        static void Print(IEnumerable<int> list)
        {
            Console.WriteLine("Energy of elements (IEnumerable<int>): ");

            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
    }
}