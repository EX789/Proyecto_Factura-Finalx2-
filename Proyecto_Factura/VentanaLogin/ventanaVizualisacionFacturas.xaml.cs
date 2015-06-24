using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Controlador;
namespace VentanaLogin
{
    /// <summary>
    /// Lógica de interacción para ventanaVizualisacionFacturas.xaml
    /// </summary>
    public partial class ventanaVizualisacionFacturas : Window
    {
        RegistroFactura rgf;
        string strNomVen;
        public ventanaVizualisacionFacturas(RegistroFactura rg, string nombreVen)
        {
            InitializeComponent();
            rgf = rg;
            strNomVen = nombreVen;
        }

        private void btnMInfo_Click(object sender, RoutedEventArgs e)
        {
            txtblDatoCLiente.Text = rgf.mostrarInfoCliente(int.Parse(txbNumeroFactura.Text))+"      \nVendedor: "+strNomVen;
            //dgMostrarProducto.ItemsSource;
        }
    }
}
