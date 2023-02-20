using System.Diagnostics.Contracts;
using static System.Net.Mime.MediaTypeNames;

namespace SC_lesson_interfaces
{
    interface IWeapon
    {
        void Fire();
        void GetInfo() //реализация метода интерфейса по-умолчанию(не знаю плохо или хорошо), говорят не очень, т.к. смешивается абстракция и реализация
        {
            Console.WriteLine($"Вы используете {GetType().Name}:");
        }
    }
    interface IThrowingWeapon
    {
        void Throw();
    }
   
    class Gun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"Вы выстрели из {GetType().Name}! Бах!");
        }

    }
    
    class LaserGun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"Вы выстрели из {GetType().Name}! Пшунь!");
        }
      
    }

    class Knife : IWeapon, IThrowingWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"Вы ударили {GetType().Name}! Хлоп!");
        }

        public void Throw()
        {
            Console.WriteLine($"Вы бросили {GetType().Name}! Вжух!");
        }
       
    }

    class Person
    {
        public void Fire(IWeapon weapon)
        {
            weapon.GetInfo();
            weapon.Fire();
        }
        public void Throw(IThrowingWeapon throwingWeapon)
        {
            throwingWeapon.Throw();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person man = new Person();
            IWeapon[] weapon = { new Gun(), new LaserGun(), new Knife()};

            foreach (var item in weapon)
            {
                man.Fire(item);
            }

            Console.ReadKey();  
        }
    }
}