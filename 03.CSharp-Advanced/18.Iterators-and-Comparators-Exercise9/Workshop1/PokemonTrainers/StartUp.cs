﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                

                AddTrainerWithPokemon(trainers, tokens);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                CheckElement(input, trainers);
                input = Console.ReadLine();
            }

            Print(trainers);
        }

        private static void Print(List<Trainer> trainers)
        {
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static void CheckElement(string element, List<Trainer> trainers)
        {
            foreach (var trainer in trainers.OrderByDescending(x => x.Badges))
            {
                if (trainer.Pokemons.Any(x => x.Element == element))
                {
                    trainer.Badges += 1;
                }
                else
                {
                    foreach (var trainerPokemon in trainer.Pokemons)
                    {
                        trainerPokemon.Health -= 10;
                    }
                }
            }

            foreach (var trainer in trainers)
            {
                trainer.Pokemons.RemoveAll(x => x.Health <= 0);
            }
        }

        private static void AddTrainerWithPokemon(List<Trainer> trainers, string[] tokens)
        {
            string trainerName = tokens[0];
            string pokemonName = tokens[1];
            string pokemonElement = tokens[2];
            int pokemonHealth = int.Parse(tokens[3]);

            Trainer trainer = trainers.FirstOrDefault(x => x.Name == trainerName);

            if (trainer == null)
            {
                trainer = new Trainer(trainerName);
                trainers.Add(trainer);
            }

            Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            trainer.Pokemons.Add(pokemon);
        }
    }
}
