using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeEthiqueEtafy.Model
{
    internal class Stock
    {
        private int _idStock;

        public int IdStock
        {
            get { return _idStock; }
            set { _idStock = value; }
        }

        private int _quantite;

        public int Quantite
        {
            get { return _quantite; }
            set { _quantite = value; }
        }

        
        public Stock(int idStock, int quantite)
        {
            IdStock = idStock;
            Quantite = quantite;
        }

        public override string ToString()
        {
           return $"{IdStock},{Quantite}";
        }
    }
}
