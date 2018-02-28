using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroisMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Variables Locales
                List<int> oListe1, oListe2, oListeRes;

                // Initialisation
                oListe1 = new List<int>() { 1, 2, 3, 4, 5 };
                oListe2 = new List<int>() { 1, 2, 3, 6, 7 };



                // Traitement de données et Affichage
                /** 
                 *   LISTE ET 
                 */
                oListeRes = Program.Traiter_ET(oListe1, oListe2);
                Console.WriteLine("--------- LISTE ET ---------");
                Console.WriteLine(oListeRes.Select(i => i.ToString()).Aggregate((i, j) => i + " " + j));
                //for (int i = 0; i < oListeRes.Count; i++)
                //{
                //    Console.WriteLine(oListeRes.ElementAt(i));
                //}



            
                // Traitement de données et Affichage
                /** 
                 *   LISTE OU 
                 */
                oListeRes = Program.Traiter_OU(oListe1, oListe2);
                Console.WriteLine("--------- LISTE OU ---------");
                Console.WriteLine(oListeRes.Select(i => i.ToString()).Aggregate((i, j) => i + " " + j));
                //for (int i = 0; i < oListeRes.Count; i++)
                //{
                //    Console.WriteLine(oListeRes.ElementAt(i));
                //}




                // Traitement de données et Affichage
                /** 
                 *   LISTE EXCEPT 
                 */
                oListeRes = Program.Traiter_EXCEPT(oListe1, oListe2);
                Console.WriteLine("--------- LISTE EXCEPT ---------");
                Console.WriteLine(oListeRes.Select(i => i.ToString()).Aggregate((i, j) => i + " " + j));
                //for (int i = 0; i < oListeRes.Count; i++)
                //{
                //    Console.WriteLine(oListeRes.ElementAt(i));
                //}
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

        public static List<int> Traiter_ET(List<int> p_oListe1, List<int> p_oListe2)
        {
            // Variables Locales
            List<int> oListe;

            // Initialisation
            oListe = new List<int>();

            // Traitement de données
            // V1
            //foreach (int i in p_oListe1)
            //{
            //    foreach (int j in p_oListe2)
            //    {
            //        if (i == j && !oListe.Contains(i))
            //        {
            //            oListe.Add(i);
            //        }
            //    }
            //}

            // V2
            //foreach (int i in p_oListe1)
            //{
            //    if (p_oListe2.Contains(i) && !oListe.Contains(i))
            //    {
            //        oListe.Add(i);
            //    }
            //}

            // V3
            oListe = p_oListe1.Intersect(p_oListe2).ToList();

            // Retour
            return oListe;
        }

        public static List<int> Traiter_OU(List<int> p_oListe1, List<int> p_oListe2)
        {
            // Variables Locales
            List<int> oListe;

            // Initialisation
            oListe = new List<int>();

            // Traitement de données
            // V1
            foreach (int i in p_oListe1)
            {
                if (!oListe.Contains(i))
                {
                    oListe.Add(i);
                }

            }
            //oListe.AddRange(p_oListe1.Distinct());

            foreach (int i in p_oListe2)
            {
                if (!oListe.Contains(i))
                {
                    oListe.Add(i);
                }
            }
            //oListe.AddRange(p_oListe2.Distinct());

            // V2
            //oListe = p_oListe1.Union(p_oListe2).ToList();


            // Retour
            return oListe;
        }

        public static List<int> Traiter_EXCEPT(List<int> p_oListe1, List<int> p_oListe2)
        {
            // Variables Locales
            List<int> oListe;
            bool bTrouve;

            // Initialisation
            oListe = new List<int>();

            // Traitement de données
            // V1
            //foreach (int i in p_oListe1)
            //{
            //    if (!p_oListe2.Contains(i) && !oListe.Contains(i))
            //    {
            //        oListe.Add(i);
            //    }
            //}

            // V2
            foreach (int i in p_oListe1)
            {
                bTrouve = false;
                foreach (int j in p_oListe2)
                {
                    if (i == j)
                    {
                        bTrouve = true;
                        break;
                    }
                }

                if(!bTrouve && !oListe.Contains(i))
                {
                    oListe.Add(i);
                }
            }

            // V3
            //oListe = p_oListe1.Except(p_oListe2).ToList();

            // Retour
            return oListe;
        }
    }
}
