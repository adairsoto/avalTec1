using System;

namespace Projeto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = new Random().Next(1, 10);
            int tent = 0;
            const int maxTent = 4;

            for (var i = 0; i < maxTent; i++)
            {
                Console.Write("Chute um número entre 1 e 10: ");
                var guess = Convert.ToInt32(Console.ReadLine());
               

                if (guess == number)
                {
                    Console.WriteLine($"Parabens! Você acertou em {i + 1} tentativa(s)");
                    return;
                }else if(tent < (maxTent - 1))
                {
                    tent++;
                    Console.WriteLine($"Voce ainda possui {maxTent - tent} tentativa(s)");
                }                
                
            }
            Console.WriteLine("Tentativas Esgotadas");
        }
    }
}
