using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("A name should not be empty.");
                    throw new Exception();
                }
                name = value; 
            }
        }

        private int endurance;

        private int Endurance
        {
            get { return endurance; }
            set 
            {
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Endurance should be between 0 and 100.");
                    throw new Exception();
                }
                endurance = value; 
            }
        }

        private int sprint;

        private int Sprint
        {
            get { return sprint; }
            set 
            {
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Sprint should be between 0 and 100.");
                    throw new Exception();
                }
                sprint = value;
            }
        }

        private int dribble;

        private int Dribble
        {
            get { return dribble; }
            set 
            {
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Dribble should be between 0 and 100.");
                    throw new Exception();
                }
                dribble = value; 
            }
        }

        private int passing;

        private int Passing
        {
            get { return passing; }
            set 
            {
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Passing should be between 0 and 100.");
                    throw new Exception();
                }
                passing = value; 
            }
        }

        private int shooting;

        private int Shooting
        {
            get { return shooting; }
            set 
            {
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Shooting should be between 0 and 100.");
                    throw new Exception();
                }
                shooting = value; 
            }
        }

        private double overallSkill;

        public double OverallSkill { get { return overallSkill; } private set { overallSkill = value; } }

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
            OverallSkill = (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
        }
    }
}
