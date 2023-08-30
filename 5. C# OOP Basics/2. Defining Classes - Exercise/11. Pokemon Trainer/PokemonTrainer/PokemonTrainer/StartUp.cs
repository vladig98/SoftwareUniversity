using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            const string end = "Tournament";

            string input = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();

            while (input != end)
            {
                string[] inputTokens = input.Split(' ');

                string trainerName = inputTokens[0];
                string pokemonName = inputTokens[1];
                string element = inputTokens[2];
                int health = int.Parse(inputTokens[3]);

                if (trainers.All(x => x.Name != trainerName))
                {
                    Pokemon pokemon = new Pokemon(pokemonName, element, health);
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    Pokemon pokemon = new Pokemon(pokemonName, element, health);
                    Trainer trainer = trainers.Where(x => x.Name == trainerName).FirstOrDefault();
                    trainer.Pokemons.Add(pokemon);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == input))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(x => x.Health -= 10);
                    }
                }

                trainers.ForEach(x => x.Pokemons = x.Pokemons.Where(y => y.Health > 0).ToList());

                input = Console.ReadLine();
            }

            trainers = trainers.OrderByDescending(x => x.NumberOfBadges).ToList();

            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
