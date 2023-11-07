using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeEthiqueEtafy.Model
{
    public class Produit
    {
        private int _idProduit;

        public int IdProduit
        {
            get { return _idProduit; }
            set { _idProduit = value; }
        }

        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private double _prix;

        public double Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        private string _matiere;

        public string Matiere
        {
            get { return _matiere; }
            set { _matiere = value; }
        }

        private string _taille;

        public string Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }

        private string _photo;

        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

        public Produit(int idProduit, string nom, double prix, string matiere, string taille, string photo)
        {
            IdProduit = idProduit;
            Nom = nom;
            Prix = prix;
            Matiere = matiere;
            Taille = taille;
            Photo = photo;
        }

        public override string ToString()
        {
            return $"{IdProduit}, '{Nom}', {Prix}, '{Matiere}', '{Taille}', '{Photo}'";
        }
    }
}
