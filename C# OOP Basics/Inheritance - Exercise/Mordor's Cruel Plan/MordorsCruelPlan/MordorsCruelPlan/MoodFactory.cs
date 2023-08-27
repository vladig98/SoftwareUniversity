using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan
{
    public class MoodFactory
    {
        public string GetMood(int happinessPoints)
        {
            if (happinessPoints < -5)
            {
                return "Angry";
            }
            else if (happinessPoints >= -5 && happinessPoints <= 0)
            {
                return "Sad";
            }
            else if (happinessPoints >= 1 && happinessPoints < 15)
            {
                return "Happy";
            }
            else
            {
                return "JavaScript";
            }
        }
    }
}
