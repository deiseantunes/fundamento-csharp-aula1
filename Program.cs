using System;
using System.Collections.Generic;


namespace dotnetcore
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
    class Program
    {
        // ExercÃ­cio 2:
        // - Fazer um programa que cadastre pessoas, contendo nome e idade;
        // - Imprimir a media de idade das pessoas
        // - Imprimir o nome e idade da pessoa mais velha
        // - Imprimir o nome e idade da pessoa mais nova
        // - Imprimir a quantidade de pessoas com maior idade
        // RequisÃ­tos:
        // - Utilizar List (Avg, Max, Min, Where)
        // - Utilizar Classe Pessoa
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Programa");

            var xNotasZuqui = new List<int> { 7, 6, 5, 3 };
            var xNotasBronza = new List<int> { 8, 9, 10, 8 };
            var xMediaZuqui = CalcularMedia(xNotasZuqui);
            Console.WriteLine("MÃ©dia do Zuqui: " + xMediaZuqui);
            ImprimirResultado(xMediaZuqui);


            var xMediaBronza = CalcularMedia(xNotasBronza);
            //Console.WriteLine("MÃ©dia do Bronza: " + CalcularMedia(xNotasBronza));
            Console.WriteLine("MÃ©dia do Bronza: " + xMediaBronza);
            ImprimirResultado(xMediaBronza);


            //MÃ©todo Caclular mÃ©dia
            float CalcularMedia(List<int> pNotas)
            {
                var xMedia = 0;
                var xSomaNotas = 0;
                var xQuantidadeItens = 0;

               foreach (var xNota in pNotas)
               {
                   xSomaNotas = xSomaNotas + xNota;
                   xQuantidadeItens = xQuantidadeItens + 1;
                   xMedia = xSomaNotas / xQuantidadeItens;
               }

               return xMedia;

            }

            static void ImprimirResultado(float pMedia)
            {
                if (pMedia >= 7)
                {
                    Console.WriteLine ("Passou no ano letivo");
                }
                else
                {
                    Console.WriteLine ("NÃ£o passou no ano letivo");
                }
            }
        }
    }
}