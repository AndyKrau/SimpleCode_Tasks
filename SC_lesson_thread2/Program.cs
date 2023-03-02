using System;
using System.Threading;

namespace SC_lesson_thread2
{
    // Имитация двух потоков с приостановкой одного из них при наступлении условия
    // и возобновлении вторичного из основного потока после наступления определенного условия
    // используются методы suspend and resume
    internal class Program
    {
        static void WriteSecond()
        {
            Thread thread = Thread.CurrentThread;

            thread.Name = "Second thread";

            Console.WriteLine( $"name: {thread.Name} \tID потока: {thread.GetHashCode()} \tPriority: {thread.Priority}" );

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\t{thread.Name}: {i}");
                
                if ( i == 5 )
                {
                    Console.WriteLine("\tSuspend Second thread!");
                    thread.Suspend();
                }
                
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread primaryThread = Thread.CurrentThread;

            primaryThread.Name = "Primary thread";
            //primaryThread.Priority = ThreadPriority.Highest;

            Console.WriteLine($"name: {primaryThread.Name} \tID потока: {primaryThread.GetHashCode()} \tPriority: {primaryThread.Priority}");

            Thread secondThread = new Thread(WriteSecond);

            secondThread.Start();
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{primaryThread.Name}: {i}");
                if ( i == 9 ) 
                {
                    Console.WriteLine("\tResume Second thread!");
                    secondThread.Resume();
                }
                Thread.Sleep(1300);
            }

            Console.ReadLine();
        }
    }
}
