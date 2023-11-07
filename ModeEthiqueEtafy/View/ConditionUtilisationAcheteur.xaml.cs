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
    /// Interaction logic for ConditionUtilisationAcheteur.xaml
    /// </summary>
    public partial class ConditionUtilisationAcheteur : Window
    {
        public ConditionUtilisationAcheteur()
        {
            InitializeComponent();
        }

        private void AnnulerBoutonClick(object sender, RoutedEventArgs e)
        {
            InscriptionWindow inscription = new InscriptionWindow();
            inscription.Show();
            conditionAcheteur.Close();

        }

        private void AccepteBouton(object sender, RoutedEventArgs e)
        {
            AcheteurInscriptionWindow acheteur = new AcheteurInscriptionWindow();
            acheteur.Show();
            conditionAcheteur.Close();
        }
    }
}
