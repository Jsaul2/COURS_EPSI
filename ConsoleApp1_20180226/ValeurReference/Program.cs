using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValeurReference
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Variables locales
                int[,] oTab;

                // Initialisation
                oTab = new int[3, 2]
                {
                { 2, 3 },
                { 7, 2 },
                { 9, 6 }
                };


                // Traitement de données


                // Affichage
                Program.AfficherInformation(oTab);
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

        public static void AfficherInformation(int[,] p_oTab)
        {
            // Variables locales
            int nbElement;
            int nbDimension;
            int dim1, dim2;
            int[] oTab;

            // Initialisation
            nbElement = p_oTab.Length;
            nbDimension = p_oTab.Rank;
            dim1 = p_oTab.GetUpperBound(0);
            dim2 = p_oTab.GetUpperBound(1);
            oTab = new int[dim1 + 1];

            // Traitement de données
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    oTab[i] += p_oTab[i, j];
                }
            }

            Console.WriteLine("----------  INFORMATION  ----------");
            Console.WriteLine("Nombre d'élement : " + nbElement);
            Console.WriteLine("Dimmension : " + nbDimension);
            Console.WriteLine("Indice dimension 1 : " + dim1);
            Console.WriteLine("Indice dimension 2 : " + dim2);
            for (int i = 0; i < oTab.Length; i++)
            {
                Console.WriteLine(oTab[i]);
            }
            
        }
    }
}
