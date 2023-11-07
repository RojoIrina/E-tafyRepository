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
    /// Interaction logic for conditionUtilisationVendeur.xaml
    /// </summary>
    public partial class ConditionUtilisateur : Window
    {
        public ConditionUtilisateur()
        {
            InitializeComponent();
        }

       

        private void Jaccepte_Clicked(object sender, RoutedEventArgs e)
        {
            FormulaireVendeur formulaire = new FormulaireVendeur();
            formulaire.Show();
            conditionUtilisateur.Close();


        }

        private void Annuler_Bouton(object sender, RoutedEventArgs e)
        {
            InscriptionWindow inscriptionWindow = new InscriptionWindow();
            inscriptionWindow.Show();
            conditionUtilisateur.Close();
        }
    }
}
