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
    /// Interaction logic for AcheteurInscriptionWindow.xaml
    /// </summary>
    public partial class AcheteurInscriptionWindow : Window
    {
        public AcheteurInscriptionWindow()
        {
            InitializeComponent();
            DataContext = new AcheteurInscriptionWindow();
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            ConditionUtilisationAcheteur condition = new ConditionUtilisationAcheteur();
            condition.Show();
            formulaireInscriptionAcheteur.Close();           
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password; }
        }

        private void inscrireBouton(object sender, RoutedEventArgs e)
        {

            AuthentificationWindow pageAuthentification = new AuthentificationWindow();
            pageAuthentification.Show();
            formulaireInscriptionAcheteur.Close();
        }
    }
}
