using System;
using System.Collections.Generic;

namespace animalExercicio
{
    public class Animal
    {
        public Animal(
            List<string> nome,
            List<string> tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }

        private List<string> Nome { get; set; }

        private List<string> Tipo { get; set; }

        private List<string> ValidandoTipoAnimal()
        {
            TiposAnimais tiposAnimais =  new TiposAnimais();

            List<string> tipoAtualizado = new List<string>();


            foreach (var tipo in Tipo)
            {
                if(!(tipo == tiposAnimais.Peixe || tipo == tiposAnimais.Gato || tipo == tiposAnimais.Cachorro))
                {
                    tipoAtualizado.Add(tiposAnimais.Peixe);
                }
                else
                {
                    tipoAtualizado.Add(tipo);
                }                
            }

            return tipoAtualizado;
        }

        public void NomesAnimais()
        {
            var ordemNomes = 1;
            foreach(var nomes in Nome)
            {
                Console.WriteLine($"O nome do seu {ordemNomes++}º animal é {nomes}");
            }
        }

        public void AnimalPorQuantidade()
        {
            var tiposDeAnimais = ValidandoTipoAnimal();

            TiposAnimais tiposAnimais = new TiposAnimais();

            var gato = 0;
            var peixe = 0;
            var cachorro = 0;

            foreach (var tipo in tiposDeAnimais)
            {
                if(tipo == tiposAnimais.Peixe)
                {
                    peixe++;
                }
                if(tipo == tiposAnimais.Gato)
                {
                    gato++;
                }
                if(tipo == tiposAnimais.Cachorro)
                {
                    cachorro++;
                }
            }

            Console.WriteLine($"Quantidade Peixes: {peixe}");

            Console.WriteLine($"Quantidade Gatos: {gato}");

            Console.WriteLine($"Quantidade Cachorros: {cachorro}");
        }
    }
}
