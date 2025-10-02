using System;
using System.Threading;

class Fruits
{
    static void Apple()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("apple");
            Thread.Sleep(1000);
        }
    }

    static void Banana()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("banana");
            Thread.Sleep(2000);
        }
    }

    static void Cherry()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("cherry");
            Thread.Sleep(3000);
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Apple);
        Thread t2 = new Thread(Banana);
        Thread t3 = new Thread(Cherry);

        t1.Start();
        t2.Start();
        t3.Start();
       
        t1.Join();
        t2.Join();
        t3.Join();


    }
}