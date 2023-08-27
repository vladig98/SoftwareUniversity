using System;

internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        HarvestingFieldsTest harvestingFieldsTest = new HarvestingFieldsTest();

        while (input != "HARVEST")
        {
            Console.Write(harvestingFieldsTest.PrintFields("HarvestingFields", input));

            input = Console.ReadLine();
        }
    }
}

