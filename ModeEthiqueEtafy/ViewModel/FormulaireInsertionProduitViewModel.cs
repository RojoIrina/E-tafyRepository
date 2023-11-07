using Microsoft.Win32;
using ModeEthiqueEtafy.Command;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ModeEthiqueEtafy.ViewModel
{
    internal class FormulaireInsertionProduitViewModel:BaseViewModel
    {
        private Window _currentWindow;
        private string _idProduit;
        

        public string IdProduit
        {
            get { return _idProduit; }
            set { 
                _idProduit = value;
                OnPropertyChanged(nameof(IdProduit));
            }
        }

        private double _prix;

        public double Prix
        {
            get { return _prix; }
            set { _prix = value;
                OnPropertyChanged(nameof(Prix));
            }
        }


        private int _quantite;

        public int Quantite
        {
            get { return _quantite; }
            set { _quantite = value;
                OnPropertyChanged(nameof(Quantite));
            }
        }

        private string _taille;

        public string Taille
        {
            get { return _taille; }
            set { _taille = value;
                OnPropertyChanged(nameof(Taille));
            }
        }

        private string _categorie;

        public string Categorie
        {
            get { return _categorie; }
            set { _categorie = value;
                OnPropertyChanged(nameof(Categorie));
            }
        }

        private string _adresseDepot;

        public string AdresseDepot
        {
            get { return _adresseDepot; }
            set { _adresseDepot = value;
                OnPropertyChanged(nameof(AdresseDepot));
            }
        }

        private string _photo;

        public string Photo
        {
            get { return _photo; }
            set { _photo = value;
                OnPropertyChanged(nameof(Photo));
            }
        }

        private ICommand _insererProduit;

        public ICommand InsererProduit
        {
            get { return _insererProduit; }
            set { _insererProduit = value; }
        }

        private ICommand _parcourirCommand;

        public ICommand ParcourirCommand
        {
            get { return _parcourirCommand; }
            set { _parcourirCommand = value; }
        }

        private ICommand _annulerCommand;

        public ICommand AnnulerCommand
        {
            get { return _annulerCommand; }
            set { _annulerCommand = value; }
        }

        public Window CurrentWindow { get => _currentWindow; set => _currentWindow = value; }

        public FormulaireInsertionProduitViewModel(Window currentWindow)
        {
            CurrentWindow = currentWindow;
            InsererProduit = new RelayCommand(ExecuteInsererProduit, CanExecuteInsererProduit);
            ParcourirCommand = new RelayCommand(ExecuteParcourirCommand, CanExecuteParcourirCommand);
            AnnulerCommand = new RelayCommand(ExecuteAnnulerCommand, CanExecuteAnnulerCommand);
        }

        private bool CanExecuteAnnulerCommand(object arg)
        {
            return true;
        }

        private void ExecuteAnnulerCommand(object obj)
        {
            CurrentWindow.Close();
        }

        private bool CanExecuteParcourirCommand(object arg)
        {
            return true;
        }

        private void ExecuteParcourirCommand(object obj)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".png";
            fileDialog.ShowDialog();
            File.Copy($@"{ fileDialog.FileName}", $@"C:/CDAN7-TP/Rojo/ModeEthiqueEtafy/ModeEthiqueEtafy/Image/{fileDialog.SafeFileName}.png");
            Photo = $"C:/CDAN7-TP/Rojo/ModeEthiqueEtafy/ModeEthiqueEtafy/Image//{fileDialog.SafeFileName} ";
        }
        private bool CanExecuteInsererProduit(object arg)
        {
            return true;
        }

        private void ExecuteInsererProduit(object obj)
        {
            MessageBox.Show("Bouton inserer produit marche");
        }
    }
}
