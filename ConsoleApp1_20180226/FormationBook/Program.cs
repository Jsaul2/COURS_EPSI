using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationBook
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Variables locales
                List<string> oListe;
                List<string> oListeCaractereReduit;
                List<string> oListeTriAlphabetique;
                List<string> oListeSansDoublons;
                List<string> oListeSans2element;

                // Initialisation
                oListe = new List<string>()
                {
                    "Language C#",
                    "Window Forms",
                    "ASP .NET MVC",
                    "WPF",
                    "WCF",
                    "Framework Entity",
                    "Language C#",
                    "Visual Basic .NET"
                };
                oListeCaractereReduit = new List<string>();
                oListeTriAlphabetique = new List<string>();
                oListeSansDoublons = new List<string>();
                oListeSans2element = new List<string>();

                // Traitement de données
                oListeCaractereReduit = Program.FormationCaractereReduit(oListe);
                oListeTriAlphabetique = Program.FormationTriAlphabetique(oListeCaractereReduit);
                oListeSansDoublons = Program.FormationSansDoublons(oListeTriAlphabetique);
                oListeSans2element = Program.FormationSans2elements(oListeSansDoublons);

                // Affichage
                Console.WriteLine("----------  Liste initiale  ----------");
                // Liste initiale
                foreach (string s in oListe)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("\n----------  Liste avec au moins 5 caractères  ----------");

                // Liste avec que les formations ayant au moins 5 caractères
                foreach (string s in oListeCaractereReduit)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("\n----------  Liste triée par ordre alphabétique  ----------");

                // Liste triée par ordre alphabétique
                foreach (string s in oListeTriAlphabetique)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("\n----------  Liste sans doublons  ----------");

                // Liste sans doublons
                foreach (string s in oListeSansDoublons)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("\n----------  Liste sans les 2 premier éléments  ----------");

                // Liste sans les 2 premier éléments
                foreach (string s in oListeSans2element)
                {
                    Console.WriteLine(s);
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
         * Méthode retournant une liste contentenant des itemes avec au moins 5 caractère
         * 
         * @Param p_oListe
         */
        public static List<string> FormationCaractereReduit(List<string> p_oListe)
        {
            // Variables locales
            List<string> oListe;

            // Initialisation
            oListe = new List<string>();

            // Traitement de données
            foreach (string s in p_oListe)
            {
                if (s.Length >= 5)
                {
                    oListe.Add(s);
                }
            }

            // Retour
            return oListe;
        }

        /**
         * Méthode retournant une liste triée dans l'ordre alphabétique
         * 
         * @Param p_oListe
         */
        public static List<string> FormationTriAlphabetique(List<string> p_oListe)
        {
            // Variables locales
            List<string> oListe;
            int i;

            // Initialisation
            oListe = new List<string>();

            // Traitement de données
            foreach (string s in p_oListe)
            {
                i = 0;
                while(i < oListe.Count)
                {
                    if(string.Compare(s, oListe[i], true) < 0)
                    {
                        oListe.Insert(i, s);
                        break;
                    }
                    i++;
                }

                if(i == oListe.Count)
                {
                    oListe.Add(s);
                }
            }

            // Retour
            return oListe;
        }

        /**
         * Méthode retournant une liste sans doublons
         * 
         * @Param p_oListe
         */
        public static List<string> FormationSansDoublons(List<string> p_oListe)
        {
            // Variables Locales
            List<string> oListe;

            // Initialisation
            oListe = new List<string>();

            // Traitement de données
            foreach (string s in p_oListe)
            {
                if (!oListe.Contains(s))
                {
                    oListe.Add(s);
                }
            }

            // Retour
            return oListe;
        }

        /**
         * Méthode retournant une liste sans les 2 premiers éléments
         * 
         * @Param p_oListe
         */
        public static List<string> FormationSans2elements(List<string> p_oListe)
        {
            // Variables locales
            List<string> oListe;
            int i;

            // Initialisation
            oListe = new List<string>();
            i = 0;

            // Traitement de données
            // Version pour une une nouvelle liste
            for(i = 2; i < p_oListe.Count; i++)
            {
                oListe.Add(p_oListe[i]);
            }
            

            // V1
            //if (oListe.Count > 0)
            //{
            //    oListe.RemoveAt(0);
            //}
            //if (oListe.Count > 0)
            //{
            //    oListe.RemoveAt(0);
            //}

            // V2
            //if (oListe.Count >= 2)
            //{
            //    oListe.RemoveAt(0);
            //    oListe.RemoveAt(0);
            //}
            //else if(oListe.Count == 1)
            //{
            //    oListe.RemoveAt(0);
            //}

            // V3
            //while (i < 2 && oListe.Count > 0)
            //{
            //    oListe.RemoveAt(0);
            //    i++;
            //}


            // Retour
            return oListe;
        }
    }
}
