///Реализация примера с абстрактным классом. 
///За основу взят пример с оружием и игроком.
///Создайм абстрактный класс weapon, с абстрактным свойством и методом,
///так же есть обычный метод для получения информации об оружии и уроне. 
///Далее реализуется 3 класса наследника от базового абстрактного класса weapon.
///В классе player создаём метод, который помогает стрелять игроку из любого оружия.
namespace SC_lesson_abstract_class
{
    abstract class Weapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();
        public void GetInfo()
        {
            Console.WriteLine($"Вы стреляете из: {GetType().Name}\nурон составляет: {Damage}");
        }
    }

    class Bow : Weapon
    {
        public override int Damage { get => 2; }

        public override void Fire()
        {
            Console.WriteLine("Пиу-пиу!");
            Console.WriteLine();
        }
    }

    class Gun:Weapon
    {
        public override int Damage { get => 45; }
        public override void Fire()
        {
            Console.WriteLine("Ба-бах!");
            Console.WriteLine();
        }
    }

    class MashineGun : Weapon
    {
        public override int Damage { get => 165; }
        public override void Fire()
        {
            Console.WriteLine("Тра-та-та-та-та!");
            Console.WriteLine();
        }
    }


    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Gun gun = new Gun();
            Bow bow = new Bow();
            MashineGun mashineGun = new MashineGun();

            Weapon[] weapons= {bow, gun, mashineGun};
            Weapon[] weapons1 = {new Bow(),new Gun(), new MashineGun() };


            foreach (Weapon item in weapons1)
            {
                item.GetInfo();
                //player.Fire(item);
            }

            Console.ReadKey();
        }
    }
}