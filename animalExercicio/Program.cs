using System;
using System.Collections.Generic;

namespace animalExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaNomes = new List<string>();
            List<string> listaTipos = new List<string>();

            //Solicitando o dado
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe o nome do seu animal: ");
                var nome = Console.ReadLine();
                listaNomes.Add(nome.Trim().ToLower());

                Console.WriteLine("Informe a raça do animal: ");
                var tipo = Console.ReadLine();
                listaTipos.Add(tipo.Trim().ToLower());

                Console.Clear();

            }
            
            Animal animal = new Animal(listaNomes, listaTipos);

            //Retornando o dado
            Console.Clear();

            Console.WriteLine("\n=====================================================");

            animal.Handle();

            Console.WriteLine("\n======================= FIM =========================");

            Console.ReadLine();
        }
    }
}
