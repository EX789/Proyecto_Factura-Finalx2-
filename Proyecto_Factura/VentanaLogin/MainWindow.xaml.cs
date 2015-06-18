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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Modelo;

namespace VentanaLogin
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Vendedor> vnt = new List<Vendedor>();
        public MainWindow()
        {
            InitializeComponent();
            vnt.Add(new Vendedor("2002", "Pedro"));
            vnt.Add(new Vendedor("3003", "Juan"));
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in vnt)
            {
                if (txbNombre.Text == item.Nombre && pwbClave.Password == item.Codigo)
                {
                    ventanGuardarProducto nuevaVentana = new ventanGuardarProducto(item);
                    nuevaVentana.Show();
                    this.Close();
                    break;
                }
                else if (txbNombre.Text != item.Nombre && pwbClave.Password != item.Codigo)
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña mal escrita");
                }
            }
        }
    }
}
