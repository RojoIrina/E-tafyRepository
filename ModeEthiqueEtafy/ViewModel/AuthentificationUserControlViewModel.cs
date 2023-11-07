using ModeEthiqueEtafy.Command;
using ModeEthiqueEtafy.Model;
using ModeEthiqueEtafy.View;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ModeEthiqueEtafy.ViewModel
{
    public class AuthentificationUserControlViewModel : BaseViewModel
    {

        private Window _currentWindow;
        private string _loginConnex;
        private string _motDePasseConnex;
       

       


        public string LoginConnex
        {
            get { return _loginConnex; }
            set { _loginConnex = value; OnPropertyChanged(nameof(LoginConnex)); }
        }

        public string MotDePasseConnex
        {
            get { return _motDePasseConnex; }
            set { _motDePasseConnex = value; }

        }
        public string Password { private get; set; }
        private ICommand _seConnecter;
        public ICommand SeConnecter
        {

            get { return _seConnecter; }
            set { _seConnecter = value; }

        }

        public Window CurrentWindow { get => _currentWindow; set => _currentWindow = value; }

        public AuthentificationUserControlViewModel(Window currentWindow)
        {
            CurrentWindow = currentWindow;
            _seConnecter= new RelayCommand(ExecuteSeConnecter, CanExecuteSeConnecter);

        }

        private bool CanExecuteSeConnecter(object arg)
        {
            return true;
        }

        private void ExecuteSeConnecter(object obj)
        {
            _motDePasseConnex = PasswordHasher(Password);

            
            bool authentifieVendeur = DBConnection.RecupererLoginVendeur(LoginConnex) && DBConnection.RecupererPasswordVendeur(_motDePasseConnex);

            if (authentifieVendeur)
            {
                MessageBox.Show("Connexion réussie !");
                EspaceVendeurWindow espaceVendeur = new EspaceVendeurWindow();
                espaceVendeur.Show();
                CurrentWindow.Close();


            }
            else
            {
                MessageBox.Show("Échec de la connexion. Veuillez vérifier vos informations.");
            }

            bool authentifiAcheteur = DBConnection.RecupererLoginAcheteur(LoginConnex) && DBConnection.RecupererPasswordAcheteur(_motDePasseConnex);
            if (authentifiAcheteur)
            {
                MessageBox.Show("Connexion réussie !");
                EspaceVendeurWindow espaceVendeur = new EspaceVendeurWindow();
                espaceVendeur.Show();
                CurrentWindow.Close();


            }
            else
            {
                MessageBox.Show("Échec de la connexion. Veuillez vérifier vos informations.");
            }

        }










    
    }
}
