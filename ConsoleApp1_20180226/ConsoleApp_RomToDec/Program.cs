using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_RomToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Variables locales
               

                // Instantisation
                

                // Traitement de données
                

                // Affichage
            }
            catch (Exception aEx)
            {
                Console.WriteLine(aEx.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        /**
         *  Méthode retournant le nombre d'élement d'une liste
         *  
         *  @param p_oListe
         */
        public static int GetValeurRomToDec(string p_NombreRomain)
        {
            // Variables Locales
            int iValeur;

            // Instanciation
            iValeur = 0;

            for(int i = 0; i < p_NombreRomain.Length; i++)
            {
                iValeur += Program.Convertir(p_NombreRomain[i]);
            }
            return iValeur;
        }

        /**
         *  Méthode retournant le
         *  
         *  @param p_oListe
         */
        public static int Convertir(char p_NombreRomain)
        {
            // Variables Locales
            int iValeur;

            // Instanciation
            iValeur = 0;

            switch (p_NombreRomain)
            {
                case 'M' : { iValeur = 1000; break; }
                case 'D': { iValeur = 500; break; }
                case 'C': { iValeur = 100; break; }
                case 'L': { iValeur = 50; break; }
                case 'X': { iValeur = 10; break; }
                case 'V': { iValeur = 5; break; }
                case 'I': { iValeur = 1; break; }
                default: { iValeur = 0; break; }
            }
            return iValeur;
        }
    }
}
