using ModeEthiqueEtafy.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ModeEthiqueEtafy.View
{
    /// <summary>
    /// Interaction logic for FormulaireVendeur.xaml
    /// </summary>
    public partial class FormulaireVendeur : Window
    {
        public FormulaireVendeur()
        {
            InitializeComponent();
            DataContext = new VendeurInscriptionWindowViewModel();
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            ConditionUtilisateur condition = new ConditionUtilisateur();
            condition.Show();
            formulaireVendeur.Close();
        }

        private void motDePasse_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Password = (motDePasse).Password; }
        }

        private void confirmationMotDePasse_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).PasswordConfirm = (confirmationMotDePasse).Password; }
        }

        private void SinscrireBouton_Click(object sender, RoutedEventArgs e)
        {
            AuthentificationWindow pageAuthentification = new AuthentificationWindow();
            pageAuthentification.Show();
            formulaireVendeur.Close();
        }
    }
}
