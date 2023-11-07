using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeEthiqueEtafy.Model
{
    internal class Depot
    {
        private int _idDepot;

        public int IdDepot
        {
            get { return _idDepot; }
            set { _idDepot = value; }
        }

        private string _adresse;

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public Depot(int idDepot, string adresse)
        {
            IdDepot = idDepot;
            Adresse = adresse;
        }

        public override string ToString()
        {
            return $"{IdDepot},'{Adresse}'";
        }
    }
}
