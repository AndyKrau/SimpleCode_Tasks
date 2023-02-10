namespace SC_lesson_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Security security = new Security("Jay", "Tompson", 1000, "ABC-Med");
            Student student = new Student( "Valуryi", "Duglas", "QWERTY-765" );
            Teacher teacher = new Teacher("Elena", "Derbi", 1300, "school№145");

            Person[] people = {security, student, teacher,}; /// создаём массив с вышесозданными людьми для вывода их на консоль 

            PrintPeople(people);

            // Практика для тестов AS / IS

            object obj = new Student("Ivan", "Panin", "WERT-234");
            object obj2 = new Student("Oleg", "Bodrov", "12333-234");

            TestOperatorAs(obj);
            TestOperatorIs(obj2);


            Console.ReadKey();
        }

        /// <summary>
        /// Выводит на консоль полное имя всех кто находится в массиве 
        /// </summary>
        /// <param name="people">массив людей</param>
        static void PrintPeople(Person[] people)
        {
            foreach (Person item in people)
            {
                item.GetFullName();
            }
        }

        /// <summary>
        /// Оператора is
        /// </summary>
        /// <param name="obj"></param>
        static void TestOperatorIs(object obj)
        {
            if (obj is Student student2)
            {
                student2.GetFullName();
            }
        }

        /// <summary>
        /// Оператора as
        /// </summary>
        /// <param name="obj"></param>
        static void TestOperatorAs(object obj)
        {
            Student student3 = obj as Student;
            if (student3 != null)
            {
                student3.GetFullName();
            }
        }
    }
}