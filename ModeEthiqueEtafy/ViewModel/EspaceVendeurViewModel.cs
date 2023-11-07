using ModeEthiqueEtafy.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModeEthiqueEtafy.ViewModel
{
    public class EspaceVendeurViewModel : BaseViewModel
    {

        private BaseViewModel _selectedView;
        private ICommand _pageMagasin;
        private ICommand _pageCommande;
        private ICommand _pagePaiement;
        
        public EspaceVendeurViewModel()
        {

            PageMagasin = new RelayCommand(ExecutePageMagasin, CanExecutePageMagasin);
            PageCommande = new RelayCommand(ExecutePageCommande, CanExecutePageCommande);
            PagePaiement = new RelayCommand(ExecutePagePaiment, CanExecutePagePaiment);
        }
   



   

        private bool CanExecutePagePaiment(object arg)
        {
            return true;
        }

        private void ExecutePagePaiment(object obj)
        {
            SelectedView = new PaiementViewMode();
        }

        private bool CanExecutePageCommande(object arg)
        {
            return true;
        }

        private void ExecutePageCommande(object obj)
        {
            SelectedView = new CommandeViewModel();
        }

        private bool CanExecutePageMagasin(object arg)
        {
            return true;
        }

        private void ExecutePageMagasin(object obj)
        {
            SelectedView = new MagasinViewModel();
        }

        public BaseViewModel SelectedView
        {
            get => _selectedView;
            set
            {
                _selectedView = value;
                OnPropertyChanged(nameof(SelectedView));

            }
        }

        public ICommand PageMagasin { get => _pageMagasin; set => _pageMagasin = value; }
        public ICommand PageCommande { get => _pageCommande; set => _pageCommande = value; }
        public ICommand PagePaiement { get => _pagePaiement; set => _pagePaiement = value; }



    }    
 }