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
    /// Interaction logic for InscriptionWindow.xaml
    /// </summary>
    public partial class InscriptionWindow : Window
    {
        public InscriptionWindow()
        {
            InitializeComponent();
        }

        private void inscriptionVendeur_Click(object sender, RoutedEventArgs e)
        {
            ConditionUtilisateur conditionVendeur = new ConditionUtilisateur();
            conditionVendeur.Show();
            inscriptionWindow.Close();



        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            inscriptionWindow.Close();




        }

        private void InscrireBoutonAcheteur(object sender, RoutedEventArgs e)
        {
            ConditionUtilisationAcheteur conditionAcheteur = new ConditionUtilisationAcheteur();
            conditionAcheteur.Show();
            inscriptionWindow.Close();

        }
    }
}
