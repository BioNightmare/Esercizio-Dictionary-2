using System;
using System.Collections.Generic;

namespace Esercizio_Dictionary_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<UNIVERSITA, Dictionary<string, Dictionary<ESAME, int>>> uni =
                new Dictionary<UNIVERSITA, Dictionary<string, Dictionary<ESAME, int>>>();

            uni.Add(UNIVERSITA.ECONOMIA, new());
            uni.Add(UNIVERSITA.INFORMATICA, new());
            uni.Add(UNIVERSITA.LINGUE, new());

            uni[UNIVERSITA.ECONOMIA].Add("FBUIAFBF9000", new());
            uni[UNIVERSITA.INFORMATICA].Add("FCUIACBF9230", new());
            uni[UNIVERSITA.LINGUE].Add("FBMNOFBF9999", new());

            uni[UNIVERSITA.ECONOMIA]["FBUIAFBF9000"].Add(ESAME.ECONOMIA, 20);
            uni[UNIVERSITA.INFORMATICA]["FCUIACBF9230"].Add(ESAME.PROGRAMMAZIONE, 28);
            uni[UNIVERSITA.LINGUE]["FBMNOFBF9999"].Add(ESAME.INGLESE, 25);

            foreach (var voto in uni[UNIVERSITA.ECONOMIA]["FBUIAFBF9000"])
            {
                Console.WriteLine(voto.Value);
            }
        }
    }
    public enum UNIVERSITA
    {
        ECONOMIA,
        LINGUE,
        INFORMATICA
    }
    public enum ESAME
    {
        INGLESE,
        PROGRAMMAZIONE,
        ECONOMIA
    }
}
