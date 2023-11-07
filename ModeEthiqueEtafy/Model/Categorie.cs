using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeEthiqueEtafy.Model
{
    public class Categorie
    {
        private int _idCategorie;

        public int IdCategorie
        {
            get { return _idCategorie; }
            set { _idCategorie = value; }
        }

        private string _nomCategorie;

        public string NomCategorie
        {
            get { return _nomCategorie; }
            set { _nomCategorie = value; }
        }

        public Categorie(int idCategorie, string nomCategorie)
        {
            IdCategorie = idCategorie;
            NomCategorie = nomCategorie;
        }

        public override string ToString()
        {
            return $"'{IdCategorie}','{NomCategorie}'";
        }
    }
}
