using System;
using System.Linq;

namespace Jarvis
{
    class Program
    {
        static void Main(string[] args)
        {
            long maximumEnergy = long.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            Head head = new Head();
            Arm leftArm = new Arm();
            Arm rightArm = new Arm();
            Leg leftLeg = new Leg();
            Leg rightLeg = new Leg();
            Torso torso = new Torso();

            while (command != "Assemble!")
            {
                string[] tokens = command.Split(" ").ToArray();

                switch (tokens[0])
                {
                    case "Arm":
                        if (leftArm.EnergyConsumption == 0)
                        {
                            leftArm.EnergyConsumption = int.Parse(tokens[1]);
                            leftArm.ReachDistance = int.Parse(tokens[2]);
                            leftArm.Fingers = int.Parse(tokens[3]);
                        }
                        else
                        {
                            if (rightArm.EnergyConsumption == 0)
                            {
                                rightArm.EnergyConsumption = int.Parse(tokens[1]);
                                rightArm.ReachDistance = int.Parse(tokens[2]);
                                rightArm.Fingers = int.Parse(tokens[3]);
                            }
                            else
                            {
                                if (leftArm.EnergyConsumption > int.Parse(tokens[1]))
                                {
                                    leftArm.EnergyConsumption = int.Parse(tokens[1]);
                                    leftArm.ReachDistance = int.Parse(tokens[2]);
                                    leftArm.Fingers = int.Parse(tokens[3]);
                                }
                                else
                                {
                                    if (rightArm.EnergyConsumption > int.Parse(tokens[1]))
                                    {
                                        rightArm.EnergyConsumption = int.Parse(tokens[1]);
                                        rightArm.ReachDistance = int.Parse(tokens[2]);
                                        rightArm.Fingers = int.Parse(tokens[3]);
                                    }
                                }
                            }
                        }
                        break;
                    case "Leg":
                        if (leftLeg.EnergyConsumption == 0)
                        {
                            leftLeg.EnergyConsumption = int.Parse(tokens[1]);
                            leftLeg.Strength = int.Parse(tokens[2]);
                            leftLeg.Speed = int.Parse(tokens[3]);
                        }
                        else
                        {
                            if (rightLeg.EnergyConsumption == 0)
                            {
                                rightLeg.EnergyConsumption = int.Parse(tokens[1]);
                                rightLeg.Strength = int.Parse(tokens[2]);
                                rightLeg.Speed = int.Parse(tokens[3]);
                            }
                            else
                            {
                                if (leftLeg.EnergyConsumption > int.Parse(tokens[1]))
                                {
                                    leftLeg.EnergyConsumption = int.Parse(tokens[1]);
                                    leftLeg.Strength = int.Parse(tokens[2]);
                                    leftLeg.Speed = int.Parse(tokens[3]);
                                }
                                else
                                {
                                    if (rightLeg.EnergyConsumption > int.Parse(tokens[1]))
                                    {
                                        rightLeg.EnergyConsumption = int.Parse(tokens[1]);
                                        rightLeg.Strength = int.Parse(tokens[2]);
                                        rightLeg.Speed = int.Parse(tokens[3]);
                                    }
                                }
                            }
                        }
                        break;
                    case "Torso":
                        if (torso.EnergyConsumption == 0)
                        {
                            torso.EnergyConsumption = int.Parse(tokens[1]);
                            torso.ProcessorSize = double.Parse(tokens[2]);
                            torso.HousingMaterial = tokens[3];
                        }
                        else
                        {
                            if (torso.EnergyConsumption > int.Parse(tokens[1]))
                            {
                                torso.EnergyConsumption = int.Parse(tokens[1]);
                                torso.ProcessorSize = double.Parse(tokens[2]);
                                torso.HousingMaterial = tokens[3];
                            }
                        }
                        break;
                    case "Head":
                        if (head.EnergyConsumption == 0)
                        {
                            head.EnergyConsumption = int.Parse(tokens[1]);
                            head.IQ = int.Parse(tokens[2]);
                            head.SkinMaterial = tokens[3];
                        }
                        else
                        {
                            if (head.EnergyConsumption > int.Parse(tokens[1]))
                            {
                                head.EnergyConsumption = int.Parse(tokens[1]);
                                head.IQ = int.Parse(tokens[2]);
                                head.SkinMaterial = tokens[3];
                            }
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            long totalPower = leftArm.EnergyConsumption + rightArm.EnergyConsumption + leftLeg.EnergyConsumption + rightLeg.EnergyConsumption + torso.EnergyConsumption + head.EnergyConsumption;

            if (totalPower > maximumEnergy)
            {
                Console.WriteLine("We need more power!");
                return;
            }

            if (leftArm.EnergyConsumption == 0 || rightArm.EnergyConsumption == 0 || leftLeg.EnergyConsumption == 0
                || rightLeg.EnergyConsumption == 0 || torso.EnergyConsumption == 0 || head.EnergyConsumption == 0)
            {
                Console.WriteLine("We need more parts!");
                return;
            }

            if (rightArm.EnergyConsumption < leftArm.EnergyConsumption)
            {
                Arm temp = new Arm();

                temp.EnergyConsumption = leftArm.EnergyConsumption;
                temp.Fingers = leftArm.Fingers;
                temp.ReachDistance = leftArm.ReachDistance;

                leftArm.EnergyConsumption = rightArm.EnergyConsumption;
                leftArm.Fingers = rightArm.Fingers;
                leftArm.ReachDistance = rightArm.ReachDistance;

                rightArm.EnergyConsumption = temp.EnergyConsumption;
                rightArm.Fingers = temp.Fingers;
                rightArm.ReachDistance = temp.ReachDistance;
            }

            if (rightLeg.EnergyConsumption < leftLeg.EnergyConsumption)
            {
                Leg temp = new Leg();

                temp.EnergyConsumption = leftLeg.EnergyConsumption;
                temp.Speed = leftLeg.Speed;
                temp.Strength = leftLeg.Strength;

                leftLeg.EnergyConsumption = rightLeg.EnergyConsumption;
                leftLeg.Speed = rightLeg.Speed;
                leftLeg.Strength = rightLeg.Strength;

                rightLeg.EnergyConsumption = temp.EnergyConsumption;
                rightLeg.Speed = temp.Speed;
                rightLeg.Strength = temp.Strength;
            }

            Console.WriteLine("Jarvis:");
            Console.WriteLine("#Head:");
            Console.WriteLine($"###Energy consumption: {head.EnergyConsumption}");
            Console.WriteLine($"###IQ: {head.IQ}");
            Console.WriteLine($"###Skin material: {head.SkinMaterial}");
            Console.WriteLine("#Torso:");
            Console.WriteLine($"###Energy consumption: {torso.EnergyConsumption}");
            Console.WriteLine($"###Processor size: {torso.ProcessorSize:F1}");
            Console.WriteLine($"###Corpus material: {torso.HousingMaterial}");
            Console.WriteLine("#Arm:");
            Console.WriteLine($"###Energy consumption: {leftArm.EnergyConsumption}");
            Console.WriteLine($"###Reach: {leftArm.ReachDistance}");
            Console.WriteLine($"###Fingers: {leftArm.Fingers}");
            Console.WriteLine("#Arm:");
            Console.WriteLine($"###Energy consumption: {rightArm.EnergyConsumption}");
            Console.WriteLine($"###Reach: {rightArm.ReachDistance}");
            Console.WriteLine($"###Fingers: {rightArm.Fingers}");
            Console.WriteLine("#Leg:");
            Console.WriteLine($"###Energy consumption: {leftLeg.EnergyConsumption}");
            Console.WriteLine($"###Strength: {leftLeg.Strength}");
            Console.WriteLine($"###Speed: {leftLeg.Speed}");
            Console.WriteLine("#Leg:");
            Console.WriteLine($"###Energy consumption: {rightLeg.EnergyConsumption}");
            Console.WriteLine($"###Strength: {rightLeg.Strength}");
            Console.WriteLine($"###Speed: {rightLeg.Speed}");
        }

        public class Arm
        {
            public int EnergyConsumption { get; set; }
            public int ReachDistance { get; set; }
            public int Fingers { get; set; }
        }

        public class Leg
        {
            public int EnergyConsumption { get; set; }
            public int Strength { get; set; }
            public int Speed { get; set; }
        }

        public class Torso
        {
            public int EnergyConsumption { get; set; }
            public double ProcessorSize { get; set; }
            public string HousingMaterial { get; set; }
        }

        public class Head
        {
            public int EnergyConsumption { get; set; }
            public int IQ { get; set; }
            public string SkinMaterial { get; set; }
        }
    }
}
