using System;

namespace test_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("A = ");
                int a = 0;bool _error = true;
                while (_error)
                {
                    try
                    {
                        a = Int32.Parse(Console.ReadLine());
                        _error = false;
                    }
                    catch
                    {
                        Console.Write("Please try again! A = ");
                    }
                }

                Console.Write("B = ");
                int b = 0;bool _error_2 = true;
                do
                {
                    try
                    {
                        b = Int32.Parse(Console.ReadLine());
                        _error_2 = false;
                    }
                    catch
                    {                        
                        Console.Write("Please try again! B = ");
                    }
                } while (_error_2);

                Console.WriteLine("Please select operation 1:+ 2:- 3:* 4:/ 5(default):exit (enter only numbers) : ");
                int operation = 0;
                try
                {
                    operation = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    operation = 5;
                }
                if (operation < 1 || operation > 5)
                {
                    operation = 5;
                }

                if (operation == 1)
                {
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                }
                if (operation == 2)
                {
                    Console.WriteLine("A - B = {0}", a - b);
                }
                if (operation == 3)
                {
                    Console.WriteLine("A * B = {0}", a * b);
                }
                if (operation == 4)
                {
                    try
                    {
                        Console.WriteLine("A / B = {0}", a / b);
                    }
                    catch
                    {
                        Console.WriteLine("Error: divide by zero!!!");
                    }
                }
                if (operation == 5)
                {
                    break;
                }
            }
            
            //Console.WriteLine(operation);
            //Console.WriteLine("A = {0}, B = {1}", a, b);
            /*Console.WriteLine("Hello World!");*/
            Console.ReadLine();
        }
    }
}
