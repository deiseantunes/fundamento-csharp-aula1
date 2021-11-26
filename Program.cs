using System;

using System.Linq;

using System.Collections.Generic;




namespace dotnetcore

{

    public class Pessoa

    {

        public Pessoa (string pNome, int pIdade)

        {

            Nome = pNome;

            Idade = pIdade;

        }

        public string Nome { get; set; }

        public int Idade { get; set; }

    }

    class Program

    {

        // Exercício 2:

        // - Fazer um programa que cadastre pessoas, contendo nome e idade;

        // - Imprimir a media de idade das pessoas

        // - Imprimir o nome e idade da pessoa mais velha

        // - Imprimir o nome e idade da pessoa mais nova

        // - Imprimir a quantidade de pessoas com maior idade

        // Requisítos:

        // - Utilizar List (Avg, Max, Min, Where)

        // - Utilizar Classe Pessoa

        static void Main(string[] args)

        {

            var xListaPessoas = new List<Pessoa>{

                new Pessoa ("Deise", 20),

                new Pessoa("Gabi", 19)

            };



            var xMedia = xListaPessoas.Average(p => p.Idade);

            var xPessoaMaisVelha = xListaPessoas.OrderByDescending(p => p.Idade).FirstOrDefault();

            var xPessoaMaisNova = xListaPessoas.OrderBy(p => p.Idade).FirstOrDefault();

            var xQuantidadePessoasMaioresIdade = xListaPessoas.Where(p => p.Idade >= 18).Count();

           

            Console.WriteLine ("A media de idade das pessoas é: " + xMedia);



            Console.WriteLine ("O nome da pessoa mais velha é: " + xPessoaMaisVelha.Nome + " e a idade é: " + xPessoaMaisVelha.Idade);

            Console.WriteLine ("O nome da pessoa mais nova é: " + xPessoaMaisNova.Nome + " e a idade é: " + xPessoaMaisNova.Idade);

            Console.WriteLine ("A media de idade das pessoas é: " + xQuantidadePessoasMaioresIdade);

         



        }

    }

}