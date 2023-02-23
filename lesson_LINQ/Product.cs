using System;
using System.Linq;

namespace lesson_LINQ
{
    internal class Product
    {
        public string Name { get; set; }
        public int Energy { get; set; }

        public Product(string name, int energy)
        {
            Name = name;
            Energy = energy;
        }

        // перезаписываем метод вывода полей класса
        public override string ToString()
        {
            return $"{Name} ({Energy})"; 
        }

        //коррекция метода Equals and GetHashCode для операции Distinct
        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Name == product.Name &&
                   Energy == product.Energy;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Energy);
        }
    }
}
