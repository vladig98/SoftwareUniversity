using System;

namespace InstructionSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code to debug and fix

            //string opCode = Console.ReadLine();

            //while (opCode != "end")
            //{
            //    string[] codeArgs = opCode.Split(' ');

            //    long result = 0;
            //    switch (codeArgs[0])
            //    {
            //        case "INC":
            //            {
            //                int operandOne = int.Parse(codeArgs[1]);
            //                result = operandOne++;
            //                break;
            //            }
            //        case "DEC":
            //            {
            //                int operandOne = int.Parse(codeArgs[1]);
            //                result = operandOne--;
            //                break;
            //            }
            //        case "ADD":
            //            {
            //                int operandOne = int.Parse(codeArgs[1]);
            //                int operandTwo = int.Parse(codeArgs[2]);
            //                result = operandOne + operandTwo;
            //                break;
            //            }
            //        case "MLA":
            //            {
            //                int operandOne = int.Parse(codeArgs[1]);
            //                int operandTwo = int.Parse(codeArgs[2]);
            //                result = (long)(operandOne * operandTwo);
            //                break;
            //            }
            //    }

            //    Console.WriteLine(result);

            string opCode = Console.ReadLine();

            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne + 1;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne - 1;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = (long)(operandOne * operandTwo);
                            break;
                        }
                }

                Console.WriteLine(result);

                opCode = Console.ReadLine();
            }
        }
    }
}
