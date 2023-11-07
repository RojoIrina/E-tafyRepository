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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModeEthiqueEtafy.View
{
    /// <summary>
    /// Interaction logic for MagasinView.xaml
    /// </summary>
    public partial class MagasinView : UserControl
    {
        public MagasinView()
        {
            InitializeComponent();
        }

        private void InsererProduit_Click(object sender, RoutedEventArgs e)
        {
            FormulaireInsertionProduitWindow formulaireInsertionProduit = new FormulaireInsertionProduitWindow();
            formulaireInsertionProduit.Show();

            
        }
    }
}
