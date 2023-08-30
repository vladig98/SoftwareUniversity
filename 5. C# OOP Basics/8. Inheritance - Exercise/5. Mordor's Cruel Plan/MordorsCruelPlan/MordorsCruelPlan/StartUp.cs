using System;
using System.Linq;

namespace MordorsCruelPlan
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            GrayWizard Gandalf = new GrayWizard();
            FoodFactory foodFactory = new FoodFactory();
            MoodFactory moodFactory = new MoodFactory();

            string[] inputTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()).ToArray();

            foreach (string input in inputTokens)
            {
                Gandalf.UpdateMoodPoints(foodFactory.GetPointsOfHappiness(input));
            }

            Gandalf.UpdateMood(moodFactory.GetMood(Gandalf.GetMoodPoints()));

            Console.WriteLine(Gandalf);
        }
    }
}
