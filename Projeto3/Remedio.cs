using System.Collections.Generic;

namespace Projeto3
{
    public class Remedio
    {
        public string NomeRemedio { get; set; }

        public Remedio(string nomeRemedio)
        {
            NomeRemedio = nomeRemedio;
        }

        public override string ToString()
        {
            return NomeRemedio;
        }
    }

    public class RemedioRepository
    {
        public static List<Remedio> InicializarRemedios()
        {
            List<Remedio> remedios = new List<Remedio>();
            remedios.Add(new Remedio("Axert"));
            remedios.Add(new Remedio("Lotronex"));
            remedios.Add(new Remedio("Arimidex"));
            remedios.Add(new Remedio("Imuran"));
            remedios.Add(new Remedio("Alferon"));

            return remedios;
        }
    }

}
