using System;
using System.Collections.Generic;
using System.Linq;

namespace EficienciaDosAlunos
{
    class Program
    {
        static void Main(String[] args)
        {
            List<int> amostra = new List<int>();

            Console.WriteLine("Quantas notas irá digitar? ");
            int notas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < notas; i++)
            {
                Console.Write("Entre com a nota " + (i + 1) + ": ");
                int entrada = Convert.ToInt32(Console.ReadLine());
                amostra.Add(entrada);
            }

            double eficiencia = CalculateEfficiency(amostra);
            Console.WriteLine($"Notas: {string.Join(", ", amostra)} - Eficiência: {eficiencia:F3}%");

        }
        static double CalculateEfficiency(List<int> listaDeNotas)
        {
            double media;
            int soma = 0;
            int acimaMedia = 0;

            for (int i = 0; i < listaDeNotas.Count; i++)
            {
                soma += listaDeNotas[i];
            }

            media = soma / listaDeNotas.Count;
            Console.WriteLine(media);

            for (int i = 0; i < listaDeNotas.Count; i++)
            {
                if (listaDeNotas[i] > media)
                {
                    acimaMedia += 1;
                }
            }

            int notas = listaDeNotas.Count;
            double eficiencia = (double)(100 * acimaMedia) / notas;

            return eficiencia;
        }
    }
}