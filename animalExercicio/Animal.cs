using System;
using System.Collections.Generic;

namespace animalExercicio
{
    public class Animal
    {
        private readonly TiposAnimais _tiposAnimais;
        public Animal(
            List<string> nome,
            List<string> tipo)
        {
            Nome = nome;
            Tipo = tipo;
            _tiposAnimais = new TiposAnimais();
        }

        private List<string> Nome { get; set; }

        private List<string> Tipo { get; set; }

        private List<string> TipoAtualizado = new List<string>();      

        private int gato = 0;

        private int peixe = 0;

        private int cachorro = 0;

        private int ordemNomes = 1;

        public void Handle()
        {   
            foreach (var tipo in Tipo)
            {
                if(!(tipo == _tiposAnimais.Peixe || tipo == _tiposAnimais.Gato || tipo == _tiposAnimais.Cachorro))
                {
                    TipoAtualizado.Add(_tiposAnimais.Peixe);
                }
                else
                {
                    TipoAtualizado.Add(tipo);
                }                
            }

            foreach (var nomes in Nome)
            {
                Console.WriteLine($"O nome do seu {ordemNomes++}º animal é {nomes}");
            }

            foreach (var tipo in TipoAtualizado)
            {
                if (tipo == _tiposAnimais.Peixe)
                {
                    peixe++;
                }
                if (tipo == _tiposAnimais.Gato)
                {
                    gato++;
                }
                if (tipo == _tiposAnimais.Cachorro)
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
