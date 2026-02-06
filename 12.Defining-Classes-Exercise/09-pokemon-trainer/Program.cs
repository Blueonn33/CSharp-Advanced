using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_pokemon_trainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                string[] input = command.Split();

                string trainerName = input[0];

                Trainer trainer = trainers.FirstOrDefault(t => t.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }

                Pokemon pokemon = new Pokemon(input[1], input[2], int.Parse(input[3]));

                trainer.Pokemons.Add(pokemon);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                List<Trainer> winningTrainers = trainers
                    .Where(t => t
                    .HasElement(command))
                    .ToList();

                List<Trainer> losingTrainers = trainers
                    .Where(t => !t
                    .HasElement(command))
                    .ToList();

                foreach (Trainer trainer in winningTrainers)
                {
                    trainer.NumberOfBadges++;
                }

                foreach (Trainer trainer in losingTrainers)
                {
                    trainer.Lose();
                }

                command = Console.ReadLine();
            }

            trainers = trainers.OrderByDescending(t => t.NumberOfBadges).ToList();

            foreach (var trainer in trainers)
            {
                Console.WriteLine(trainer);
            }
        }
    }
}