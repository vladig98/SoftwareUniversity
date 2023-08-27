using System;

namespace Mankind
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] studentInputTokens = Console.ReadLine().Split(" ");
            string[] workedInputTokens = Console.ReadLine().Split(" ");

            try
            {
                Student student = new Student(studentInputTokens[0], studentInputTokens[1], studentInputTokens[2]);

                Worker worker = new Worker(workedInputTokens[0], workedInputTokens[1], double.Parse(workedInputTokens[2]),
                    double.Parse(workedInputTokens[3]));

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
