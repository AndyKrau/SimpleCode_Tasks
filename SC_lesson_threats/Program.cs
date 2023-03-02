using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Пример создания потоков разных типов, 
// с аргументами и без.
namespace SC_lesson_threats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region create 2 threads examples

            //Thread threadWithoutArg = new Thread(new ThreadStart(DoWork));
            //threadWithoutArg.Start();


            //Thread threadWithArg = new Thread(new ParameterizedThreadStart(DoWork1));
            //threadWithArg.Start(1000);

            //MainThread();
            #endregion

            #region async/await
            // Пример выполенения асинхронного метода без блокировки ввода.
            // Пока работает метод DoWorkAsync метод DoWork продолжает работать

            //DoWorkAsync("D://testAsync.txt");
            //DoWork();

            #endregion

            #region async/await
            // Запись в файл текста введенного из консоли

            //Console.Write("Введите текст для записи в файл: ");

            //string str = Console.ReadLine();

            //WriteTextInFileAsync("D://testAsync.txt", str);

            //DoWork2();

            #endregion

            Console.ReadLine();
        }

        /// <summary>
        /// Асинхронный метод-обертка для метода FileWrite показывает старт и конец метода
        /// тем самым можно увидеть вывод результатов после
        /// конкурентного захвата разными методами вывода консоли
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <returns></returns>
        static async Task<bool> DoWorkAsync(string path)
        {
            Console.WriteLine("Start Async method");

            var result = await Task.Run(() => FileWrite(path));

            Console.WriteLine("End Async method");

            Console.WriteLine("Recording succesfull: " + result);

            return result;
        }

        /// <summary>
        /// Асинхронный метод-обертка для метода FileWriteFromConsole показывает старт и конец метода,
        /// Стартует после принятия строки и констоли.
        /// вызывает метод FileWriteFromConsole записи текста в нужный файл
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <param name="text">тескт для записи</param>
        /// <returns></returns>
        static async Task<bool> WriteTextInFileAsync(string path, string text)
        {
            Console.WriteLine("Start Async method WriteTextInFileAsync");

            var result = await Task.Run(() => FileWriteFromConsole(path, text));

            Console.WriteLine($"Recording in {path} succesfull: " + result);

            return result;
        }

        static bool FileWrite(string path)
        {
            var random = new Random();
            var text = "";

            for (int i = 0; i < 50000; i++)
            {
                text += random.Next();
            }

            using (var streamWriter = new StreamWriter(path, true, Encoding.UTF8))
            {
                streamWriter.WriteLine(text);
            }

            return true;

        }

        static bool FileWriteFromConsole(string path, string text)
        {
            using ( var sw = new StreamWriter(path , false, Encoding.UTF8))
            {
                sw.WriteLine(text);
            }

            return true;
        }

        // обычные счетчики, помогаю в реализации асинхронных методов
        // создын для наглядности
        static void MainThread()
        {
            int j = 0;
            Console.WriteLine("Start: Main");
            for (int i = 0; i < 1000; i++)
            {
                j++;

                if (j % 10 == 0)
                {
                    Console.WriteLine("1 ------> Do Main!");
                }
                Thread.Sleep(100);
                
            }
            Console.WriteLine("End: Main");
        }

        static void DoWork ()
        {
            int j = 0;
            Console.WriteLine("Start: DoWork");
            for (int i = 0; i < 1000; i++)
            {
                j++;

                if (j % 10 == 0)
                {
                    Console.WriteLine("2 ------> Do Work!");
                }
                Thread.Sleep(100);
            }
            Console.WriteLine("End: DoWork");
        }

        static void DoWork1 (object value)
        {
            int j = 0;
            Console.WriteLine("Start: DoWork 1");
            for (int i = 0; i < (int)value; i++)
            {
                j++;

                if (j % 10 == 0)
                {
                    Console.WriteLine("3 ------> Do Work 1!");
                }
                Thread.Sleep(100);
            }
            Console.WriteLine("End: DoWork 1");
        }

        static void DoWork2()
        {
            int j = 0;
            Console.WriteLine("Start: DoWork 2");
            for (int i = 0; i < 400; i++)
            {
                j++;
                Thread.Sleep(10);
            }
            Console.WriteLine("result " + j);
            Console.WriteLine("End: DoWork 2");
        }
        static void DoWork3( object arg)
        {
            int j = 0;
            Console.WriteLine("Start: DoWork 2");
            for (int i = 0; i < (int)arg; i++)
            {
                j++;
                Thread.Sleep(10);
            }
            Console.WriteLine("result " + j);
            Console.WriteLine("End: DoWork 2");
        }


        
    }


    
}
