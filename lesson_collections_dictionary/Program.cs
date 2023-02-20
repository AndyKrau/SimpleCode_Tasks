using System.ComponentModel.DataAnnotations;

namespace lesson_collections_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();

            // Создание отдельных KeyValuePair для словаря
            var Mercedes = new KeyValuePair<int, string>(4, "Mercedes");
            var BMW = new KeyValuePair<int, string>(5, "BMW"); 
            var Volkswagen = new KeyValuePair<int, string>(6, "Volkswagen");

            //добавление KeyValuePair в список
            var germanCars = new List<KeyValuePair<int, string>>() { Mercedes };
            germanCars.Add(BMW);
            germanCars.Add(Volkswagen);

            // create dictionary and add List 
            var cars = new Dictionary<int, string>(germanCars)
            {
                {1, "toyota" },
                {2, "volvo" },
                {3, "Chevrolet" }
            };

            // add & remove
            cars.Add(23, "Alabama");
            cars.Remove(23);
            Console.WriteLine();

            //containsKey & containsValue
            var toyotaContains = cars.ContainsValue("toyota");
            Console.WriteLine("ContainsValue \"toyota\" in cars: " + toyotaContains);

            var keyContains = cars.ContainsKey(26);
            Console.WriteLine("ContainsKey 26 in cars: " + keyContains);
            Console.WriteLine();

            //remove получение удаленного элемента
            cars.Remove(4, out string value);
            Console.WriteLine("remove and get element: " + value);
            Console.WriteLine(value.GetType());
            Console.WriteLine();

            //Получение элемента по значению key;
            Console.WriteLine(cars[3]);
            Console.WriteLine();

            //TryGetValue 
            int keyCars = 33;
            bool tryGetValueInCars = cars.TryGetValue(keyCars, out string modelCar);
            if (tryGetValueInCars != false) 
                Console.WriteLine($"Марка авто в словаре cars под номером {keyCars}: {modelCar}");
            else
                Console.WriteLine($"Марка авто в словаре cars под номером {keyCars}: не существует");
            Console.WriteLine();

            // TryAdd 
            int carNumber = 45;
            string newCar = "Лада";
            bool addNewCar1 = cars.TryAdd(carNumber, newCar);
            if (addNewCar1 != false)
                Console.WriteLine($"Марка {newCar} успешно добавлена в словарь cars под номером {carNumber}!");
            else
                Console.WriteLine($"Марка {newCar} уже есть в словаре в словаре cars!");
            Console.WriteLine();

            //вывод словаря на консоль
            foreach (var item in cars) Console.WriteLine($"Номер машины: {item.Key}, \t марка: {item.Value}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}