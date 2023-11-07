using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeEthiqueEtafy.Model
{
    public class Acheteur
    {
        private string _idAcheteur;
        private string _nom;
        private string _prenom;
        private string _contact;
        private string _adresse;
        private string _loginAcheteur;
        private string _motDePasse;

        public Acheteur(string idAcheteur, string nom, string prenom, string contact, string adresse, string loginAcheteur, string motDePasse)
        {
            _idAcheteur = idAcheteur;
            _nom = nom;
            _prenom = prenom;
            _contact = contact;
            _adresse = adresse;
            _loginAcheteur = loginAcheteur;
            _motDePasse = motDePasse;
        }

        public string IdAcheteur { get => _idAcheteur; set => _idAcheteur = value; }
       
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }

        public string LoginAcheteur { get => _loginAcheteur; set => _loginAcheteur = value; }
        public string MotDePasse { get => _motDePasse; set => _motDePasse = value; }
       
    

        public override string ToString()
        {
            return base.ToString();         
        }
    }
}
