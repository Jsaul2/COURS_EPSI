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
                string NombreRomain;
                int iValeur;

                // Initialisation
                Console.WriteLine("Saisir un nombre romain : ");
                NombreRomain = Console.ReadLine();

                // Traitement de données
                iValeur = GetValeurRomToDec(NombreRomain);

                // Affichage
                Console.WriteLine(iValeur);


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
         *  Méthode retournant la valeur d'un nombre Romain en décimal
         *  
         *  @param p_NombreRomain
         */
        public static int GetValeurRomToDec(string p_NombreRomain)
        {
            // Variables Locales
            int iValeur, iValeurCourant, iValeurSuivant;

            // Initialisation
            iValeur = 0;
            iValeurCourant = 0;
            iValeurSuivant = 0;

            for (int i = 0; i < p_NombreRomain.Length; i++)
            {
                iValeurCourant = Program.Convertir(p_NombreRomain[i]);

                // Avant dernière lettre ?
                if (i < p_NombreRomain.Length - 1)
                {
                    // Oui
                    iValeurSuivant = Program.Convertir(p_NombreRomain[i + 1]);

                    /**
                     * if(iValeurCourant < iValeurSuivant)
                     * {
                     *      iValeur -= iValeurCourant;
                     * } 
                     * else
                     * {
                     *      iValeur += iValeurCourant;
                     * }
                     */

                    iValeur += iValeurCourant < iValeurSuivant ?
                        iValeur - iValeurCourant :
                        iValeur + iValeurCourant;
                }
            }

            // Prendre en compte la dernière valeur
            iValeur += iValeurCourant;
            return iValeur;
        }

        /**
         *  Méthode de convertion d'un nombre romaine en décimal
         *  
         *  @param p_NombreRomain
         */
        public static int Convertir(char p_NombreRomain)
        {
            // Variables Locales
            int iValeur;

            // Initialisation
            iValeur = 0;

            switch (p_NombreRomain)
            {
                case 'M': { iValeur = 1000; break; }
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
