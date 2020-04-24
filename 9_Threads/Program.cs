﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using ITEA_Collections.Common;
using IteaAsync;

namespace IteaThreads
{
    class Program
    {
        static int counter = 0;
        static readonly object locker = new object();

        public struct MyStruct
        {
            public int From;
            public int To;
        }

        static void Main(string[] args)
        {
            /*Process current = Process.GetCurrentProcess();
            Console.WriteLine($"Id: {current.Id}");
            Console.WriteLine($"Process name: {current.ProcessName}");
            Console.WriteLine($"MachineName: {current.MachineName}");
            Console.WriteLine($"PrivateMemorySize64: {current.PrivateMemorySize64}");*/
            //Console.WriteLine("Kill Chrome? (Y - yes, else - no)", ConsoleColor.Red);
            //if (Console.ReadKey().Key == ConsoleKey.Y)
            //    Process
            //        .GetProcessesByName("chrome")
            //        .Once(() => Console.Write(""))
            //        .ToList()
            //        .ForEach(x =>
            //        {
            //            Console.WriteLine($"{x.ProcessName}/{x.Id}");
            //            x.Kill();
            //        });
            //else Console.WriteLine("\nOkay");

            //List<object> list = new List<object>();

            //list = Enumerable.Range(0, 100_000_000).Select(x => (object)x).ToList();

            //Console.WriteLine($"PrivateMemorySize64: {current.PrivateMemorySize64}");

            //Console.ReadKey();

            //Thread.CurrentThread.Name = "Main";
            //Thread.CurrentThread.Priority = ThreadPriority.Highest;
            /*
            ThreadStart threadStart1 = Write;

            Thread thread1 = new Thread(threadStart1)
            {
                Name = "Write1"
            };

            Thread thread2 = new Thread(new ThreadStart(Write))
            {
                Name = "Write2"
            };

            thread1.Start();
            thread2.Start();
            */
            //new Thread(new ParameterizedThreadStart(WriteFromTo)) // new Thread(WriteFromTo)
            //{
            //    Priority = ThreadPriority.AboveNormal,
            //    Name = "WriteFromTo"
            //}.Start(new MyStruct { From = 0, To = 2 });

            //Write();

            // deadlock

            //Thread thread01 = new Thread((ThreadStart)ObliviousFunction);
            //Thread thread02 = new Thread((ThreadStart)BlindFunction);

            //thread01.Start();
            //thread02.Start();

            //while (true) ;

            //мьютексы

            //MutexExample.IncThread mt1 = new MutexExample.IncThread("Inc thread", 5);

            //// разрешить инкременирующему потоку начаться
            //Thread.Sleep(1);

            //MutexExample.DecThread mt2 = new MutexExample.DecThread("Dec thread", 5);

            //mt1.thread.Join();
            //mt2.thread.Join();

            Console.WriteLine("Select an action. Tab the action number:");

            Console.WriteLine("1. Simple method");
            Console.WriteLine("2. Semaphore using");
            Console.WriteLine("3. Locker using\r\n");
            Console.WriteLine("0. All types\r\n");

            string key = Console.ReadLine();

            MyClass myClass = new MyClass(100);
            if (int.TryParse(key, out int index))
            {
                Console.Clear();
                switch (index)
                {
                    case 1:
                        //Test1
                        Console.WriteLine("\r\nTest Simple#1\r\n");
                        myClass.RunTest(MethodType.Simple);
                        Console.ReadKey();

                        //Test 2
                        Console.WriteLine("\r\nTest Simple#2\r\n");
                        myClass.RunTest(MethodType.Simple);
                        break;
                    case 2:
                        //Test 1
                        Console.WriteLine("\r\nTest Semaphore(5,5)#1\r\n");
                        myClass.RunTest(MethodType.Semaphore, 5, 5);
                        Console.ReadKey();

                        //Test 2
                        Console.WriteLine("\r\nTest Semaphore(1,5)#2\r\n");
                        myClass.RunTest(MethodType.Semaphore, 1, 5);
                        break;
                    case 3:
                        //Test 1
                        Console.WriteLine("\r\nTest Locker#1\r\n");
                        myClass.RunTest(MethodType.Locker);
                        Console.ReadKey();

                        //Test 2
                        Console.WriteLine("\r\nTest Locker#2\r\n");
                        myClass.RunTest(MethodType.Locker);
                        break;
                    case 0:
                        //Test1
                        Console.WriteLine("\r\nTest Simple#1\r\n");
                        myClass.RunTest(MethodType.Simple);
                        Console.ReadKey();

                        //Test 2
                        Console.WriteLine("\r\nTest Simple#2\r\n");
                        myClass.RunTest(MethodType.Simple);

                        //Test 1
                        Console.WriteLine("\r\nTest Semaphore(5,5)#1\r\n");
                        myClass.RunTest(MethodType.Semaphore, 5, 5);
                        Console.ReadKey();

                        //Test 2
                        Console.WriteLine("\r\nTest Semaphore(1,5)#2\r\n");
                        myClass.RunTest(MethodType.Semaphore, 1, 5);

                        //Test 1
                        Console.WriteLine("\r\nTest Locker#1\r\n");
                        myClass.RunTest(MethodType.Locker);
                        Console.ReadKey();

                        //Test 2
                        Console.WriteLine("\r\nTest Locker#2\r\n");
                        myClass.RunTest(MethodType.Locker);
                        break;
                }

            }
            Console.ReadLine();
        }

        /*public static void Write()
        {
            lock (locker)
            {
                Thread thread = Thread.CurrentThread;
                for (int i = 0; i < 100; i++)
                {
                    counter++;
                    Console.WriteLine($"{thread.Name}: {i}, counter: {counter}");
                }
            }
        }

        public static void WriteFromTo(object param)
        {
            Thread thread = Thread.CurrentThread;
            MyStruct @struct = (MyStruct)param;
            for (int i = @struct.From; i < @struct.To; i++)
            {
                counter++;
                Console.WriteLine($"{thread.Name}: {i}, counter: {counter}");
                //Thread.Sleep(500);
            }
        }

        static object object1 = new object();
        static object object2 = new object();

        public static void ObliviousFunction()
        {
            lock (object1)
            {
                Thread.Sleep(1000);
                lock (object2)
                {
                }
            }
        }

        public static void BlindFunction()
        {
            lock (object2)
            {
                Thread.Sleep(1000);
                lock (object1)
                {
                }
            }
        }*/
    }
}
