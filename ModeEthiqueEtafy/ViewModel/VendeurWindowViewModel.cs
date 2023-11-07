using ModeEthiqueEtafy.Command;
using ModeEthiqueEtafy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ModeEthiqueEtafy.ViewModel
{
    internal class VendeurInscriptionWindowViewModel : BaseViewModel
    {
        private string _nomVendeur;

        public string NomVendeur
        {
            get { return _nomVendeur; }
            set
            {
                _nomVendeur = value;
                OnPropertyChanged(nameof(NomVendeur));
            }
        }

        private string _niffStat;

        public string NiffStat
        {
            get { return _niffStat; }
            set
            {
                _niffStat = value;
                OnPropertyChanged(nameof(NiffStat));
            }
        }

        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        private string _motDePasse;

        public string MotDePasse
        {
            private get { return _motDePasse; }
            set
            {
                _motDePasse = value;
            }
        }

        private string _adresse;

        public string Adresse
        {
            get { return _adresse; }
            set
            {
                _adresse = value;
                OnPropertyChanged(nameof(Adresse));
            }
        }

        private string _label;
        public string Label
        {
            get { return _label; }
            set
            {
                _label = value;
                OnPropertyChanged(nameof(Label));
            }
        }

        private string _contact;

        public string Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }

        public string Password { private get; set; }
        public string PasswordConfirm { private get; set; }

        private ICommand _inscriptionVendeurCommand;

        public ICommand InscriptionVendeurCommand
        {
            get { return _inscriptionVendeurCommand; }
            set { _inscriptionVendeurCommand = value; }
        }

        public VendeurInscriptionWindowViewModel()
        {
            InscriptionVendeurCommand = new RelayCommand(ExecuteInscriptionVendeur, CanExecuteInscriptionVendeur);
        }

        private bool CanExecuteInscriptionVendeur(object arg)
        {
            return true;
        }

        private void ExecuteInscriptionVendeur(object obj)
        {
            if (Password == PasswordConfirm)
            {
                string passwordHashed = PasswordHasher(Password);
                Vendeur vendeur = new Vendeur(DBConnection.VendeurNextIndex(), NomVendeur, NiffStat, Login,
                    passwordHashed, Adresse, Contact, Label);
                DBConnection.VendeurInsert(vendeur);
                
            }
            else
            {
                MessageBox.Show("Les mots de passe ne correspondent pas");
            }


            MessageBox.Show($"Félicitations! vous êtes inscrits");

        }
    }
}