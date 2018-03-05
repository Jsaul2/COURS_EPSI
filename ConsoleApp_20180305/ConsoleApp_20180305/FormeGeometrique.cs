using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_20180305
{
    public class FormeGeometrique
    {
        #region Attributs et accesseurs
        private int largeur;
        private int longueur;

        public int Largeur { get => largeur; set => largeur = value; }
        public int Longueur { get => longueur; set => longueur = value; }
        #endregion

        #region Constructeurs
        public FormeGeometrique(int aLargeur, int aLongueur)
        {
            this.largeur = aLargeur;
            this.longueur = aLongueur;
        }
        #endregion

        #region Méthodes
        public void Afficher()
        {
        }
        #endregion
    }
}
