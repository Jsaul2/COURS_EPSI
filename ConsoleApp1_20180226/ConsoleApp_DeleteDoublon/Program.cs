using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DeleteDoublon
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Variables locales
                List<int> oListeEntier, oListeEntierSansDoublons;

                // Initialisation
                oListeEntier = new List<int> { 1, 2, 2, 3, 3, 4, 5, 6, 6, 7, 8, 1, 9 };

                // Traitement de données
                oListeEntierSansDoublons = Program.SuppDoublons(oListeEntier);

                // Affichage
                Console.WriteLine("Taille avant traitement: " + Program.Taille(oListeEntier));
                Console.WriteLine("Taille après traitement: " + Program.Taille(oListeEntierSansDoublons));

                foreach (int i in oListeEntierSansDoublons)
                {
                    Console.WriteLine(i);
                }
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
        public static long Taille(List<int> p_oListe)
        {
            return p_oListe.Count();
        }

        /**
         *  Méthode retournant une liste d'entier sans doublon
         *  
         *  @param p_oListe
         */
         public static List<int> SuppDoublons(List<int> p_oListe)
        {
            // Variables Locales
            List<int> oListe;

            // Initialisation
            oListe = new List<int>();
            
            // Traitement de données
            foreach(int i in p_oListe)
            {
                if (!oListe.Contains(i))
                {
                    oListe.Add(i);
                }
            }

            // Retour
            return oListe;
        }
    }
}
