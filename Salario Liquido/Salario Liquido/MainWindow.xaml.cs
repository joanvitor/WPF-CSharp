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

namespace Salario_Liquido
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double Salario = 0, QtdHora = 0, ValorHora = 0;
            QtdHora = Convert.ToDouble((txtQtde.Text != "") ? txtQtde.Text : "0"); // ou double.parse();
            ValorHora = Convert.ToDouble((txtValor.Text != "") ? txtValor.Text : "0");
            Salario = QtdHora * ValorHora;
            txtSalario.Text = (Salario != 0) ? Salario.ToString() : "";
        }
    }
}
