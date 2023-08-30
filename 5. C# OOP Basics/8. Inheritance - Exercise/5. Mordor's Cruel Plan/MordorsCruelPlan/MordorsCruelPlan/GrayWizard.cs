using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan
{
    public class GrayWizard
    {
        private int moodPoints;
        private string mood;

        public void UpdateMoodPoints(int points)
        {
            moodPoints += points;
        }

        public int GetMoodPoints()
        {
            return moodPoints;
        }

        public void UpdateMood(string mood)
        {
            this.mood = mood;
        }

        public string GetMood()
        {
            return mood;
        }

        public override string ToString()
        {
            return $"{moodPoints}{Environment.NewLine}{mood}";
        }
    }
}
