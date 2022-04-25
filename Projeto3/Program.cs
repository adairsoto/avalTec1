using System;
using System.Collections.Generic;

namespace Projeto3
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            List<Remedio> remedios = RemedioRepository.InicializarRemedios();

            foreach (Remedio remedio in remedios)
            {
                Console.WriteLine(remedio);
            }

            Console.WriteLine("------------------------");

            Console.WriteLine("Informe o remédio desejado");
            var remDes = Console.ReadLine();

            var rem = remedios.Find(x => x.NomeRemedio == remDes);
                      
            if (rem != null)
            {
                Console.WriteLine($"Remédio encontrado: {rem} -  Index: {remedios.IndexOf(rem)}");
            }
            else
            {
                Console.WriteLine("Remédio não encontrado");
            }
        }
    }
}
