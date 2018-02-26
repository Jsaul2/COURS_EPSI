using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_20180226
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            * StringBuilder oStringBuilder;
            * oStringBuilder = new StringBuilder("Init");
            * oStringBuilder.Append("10");
            */


            // Varaibles locale
            String s;
            long taille;
            long NbreVoyelle;

            // Initialisation
            Console.WriteLine("Saisir une phrase : ");
            s = Console.ReadLine();
            taille = Program.Taille(s);
            NbreVoyelle = Program.GetCountVoyelle(s);

            // Traitement de données
            Console.WriteLine("___________________________");
            Console.WriteLine("Phrase : " + s);
            Console.WriteLine("Taille : " + taille);
            Console.WriteLine("Nombre de voyelle : " + NbreVoyelle);
        }

        /**
         *  Méthode retournant l'addition entre 2 entiers
         *  
         *  @Param p_valeurA
         *  @Param p_valeurB
         */
        public static long Additionner(int p_valeurA, int p_valeurB)
        {
            return p_valeurA + p_valeurB;
        }

        /**
         *  Méthode retournant la taille d'une chaine
         *  
         *  @param p_chaine
         */
        public static long Taille(String p_chaine)
        {
            return p_chaine.LongCount();
        }

        /**
         *  Méthode retournant le nombre de voyelle d'une chaine
         *  
         *  @param p_chaine
         */
        public static long GetCountVoyelle(String p_chaine)
        {
            // Variables locales
            long compteur;

            // Initialisation
            compteur = 0;
            char[] voyelle = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' }; // Tableau
            //List<char> voyelle1 = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y' }; // Collection génerique

            // Traintement de données
            foreach (char c in p_chaine) // Pour chaque caractère de la chaine,
            {
                if (voyelle.Contains(c)) // Si le caractère est dans le tableau / la collection
                {
                    // Incrémenter le compteur
                    compteur++;
                }
            }

            // Retour
            return compteur;
        }
    }
}
