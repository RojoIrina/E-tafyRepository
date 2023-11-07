using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeEthiqueEtafy.Model
{
    public class Vendeur
    {
        private string _idVendeur;
        private string _nomVendeur;
        private string _niffStat;
        private string _contactVendeur;
        private string _adresseVendeur;
        private string _loginVendeur;
        private string _motDePasseVendeur;
        private string _label;

        public Vendeur(string idVendeur, string nomVendeur, string niffStat, string contactVendeur, string adresseVendeur, string loginVendeur, string motDePasseVendeur, string label)
        {
            IdVendeur = idVendeur;
            NomVendeur = nomVendeur;
            NiffStat = niffStat;
            ContactVendeur = contactVendeur;
            AdresseVendeur = adresseVendeur;
            LoginVendeur = loginVendeur;
            MotDePasseVendeur = motDePasseVendeur;
            Label = label;
        }

        public string IdVendeur { get => _idVendeur; set => _idVendeur = value; }
        public string NomVendeur { get => _nomVendeur; set => _nomVendeur = value; }
        public string NiffStat { get => _niffStat; set => _niffStat = value; }
        public string ContactVendeur { get => _contactVendeur; set => _contactVendeur = value; }
        public string AdresseVendeur { get => _adresseVendeur; set => _adresseVendeur = value; }
        public string LoginVendeur { get => _loginVendeur; set => _loginVendeur = value; }
        public string MotDePasseVendeur { get => _motDePasseVendeur; set => _motDePasseVendeur = value; }
        public string Label { get => _label; set => _label = value; }

        public override string ToString()
        {
            return $"'{IdVendeur}','{NomVendeur}','{NiffStat}','{ContactVendeur}','{AdresseVendeur}','{LoginVendeur}','{MotDePasseVendeur}','{Label}'";
        }
    }
}
