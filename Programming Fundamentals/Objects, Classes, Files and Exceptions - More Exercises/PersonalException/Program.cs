using System;

namespace PersonalException
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            MyException myException = new MyException("My first exception is awesome!!!");

            while (true)
            {
                if (number < 0)
                {
                    try
                    {
                        throw myException;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine(number);
                }

                number = int.Parse(Console.ReadLine());
            }
        }

        public class MyException : System.Exception
        {
            public MyException(string message) : base(message)
            {
            }
        }
    }
}
