using ModeEthiqueEtafy.Command;
using ModeEthiqueEtafy.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ModeEthiqueEtafy.ViewModel
{
    public class AcheteurInscriptionWindowViewModel:BaseViewModel
    {
       
        private string _nom;
        private string _prenom;
        private string _contact;
        private string _adresse;
        private string _loginAcheteur;
        private string _motDePasse;
        private ICommand _sinscrire;


        public string Nom
        {
            get { return _nom; }
            set { _nom = value; OnPropertyChanged(nameof(Nom)); }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; OnPropertyChanged(nameof(Prenom)); }
        }
        public string Contact
        {
            get { return _contact; }
            set { _contact = value; OnPropertyChanged(nameof(Contact)); }
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; OnPropertyChanged(nameof(Adresse)); }
        }
        public string LoginAcheteur
        {
            get { return _loginAcheteur; }
            set { _loginAcheteur = value; OnPropertyChanged(nameof(LoginAcheteur)); }
        }
        public string MotDePasse
        {
            get { return _motDePasse; }
            set { _motDePasse = value; }
        }
        public string Password { private get; set; }


        public ICommand Sinscrire { 

            get {return _sinscrire; } 
            set { _sinscrire = value; }
            
        }


        public AcheteurInscriptionWindowViewModel()
        {
            Sinscrire=new RelayCommand(ExecuteSinscrire, CanExecuteSinscrire);

        }

        private bool CanExecuteSinscrire(object arg)
        {
            return true
                ;
        }

        private void ExecuteSinscrire(object obj)
        {



            
             _motDePasse=PasswordHasher(Password);
            Acheteur acheteur = new Acheteur(DBConnection.AcheteurNextIndex(), Nom, Prenom, Contact, Adresse, LoginAcheteur, _motDePasse);
            MessageBox.Show($"{acheteur.Nom} a été ajouté!!!");





        }
    }
}
