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
using Modelo;
using Controlador;
namespace VentanaLogin
{
    /// <summary>
    /// Lógica de interacción para ventanaEliminarFactura.xaml
    /// </summary>
    public partial class ventanaEliminarFactura : Window
    {
        //List<Factura> fac = new List<Factura>();
        RegistroFactura rg;
        public ventanaEliminarFactura(RegistroFactura reg)               //List<Factura> registroFactura
        {
            InitializeComponent();
            rg = reg;
            //fac = registroFactura;
            //if (registroFactura is Factura)
            //{
            //    Factura ft = (Factura)registroFactura;
            //    fac.Add(ft);
            //}
        }

        private void btnEliminaFac_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar esta factura?","¿Esta seguro?",MessageBoxButton.YesNo,MessageBoxImage.Question)== MessageBoxResult.Yes)
            {
                if (rg.eliminarFactura(int.Parse(txbNumFacEliminar.Text)))
                {
                    MessageBox.Show("Eliminado exitosamente","Factura Eliminada",MessageBoxButton.OK,MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("No se encuentra la factura","Error",MessageBoxButton.OK,MessageBoxImage.Exclamation);
                }
            }
        }
    }
}
