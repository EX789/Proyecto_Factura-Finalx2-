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
    /// Lógica de interacción para ventanGuardarProducto.xaml
    /// </summary>
    public partial class ventanGuardarProducto : Window
    {
        RegistroFactura reg = new RegistroFactura();
        
        public ventanGuardarProducto(object nuevoobjeto) 
        {
            InitializeComponent();
            if (nuevoobjeto is Vendedor)
            {
                Vendedor vnt = (Vendedor)nuevoobjeto;
                txbNombreVendedor.Text = vnt.Nombre;
            }
            cbComuna.ItemsSource = Enum.GetValues(typeof(Comuna));
            cbProductoUno.ItemsSource = Enum.GetValues(typeof(Producto));
            cbProductoDos.ItemsSource = Enum.GetValues(typeof(Producto));
            cbProductoTres.ItemsSource = Enum.GetValues(typeof(Producto));
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Factura fc = new Factura();
                //fc.Persona.Nombre = null;
                //if (fc is Factura)
                //{
                //    Persona per = (Persona)fc.Persona;
                //    per.Nombre = txbNombreCliente.Text;
                //}
                if (fc.Persona is Cliente)
                {
                    Cliente cl = (Cliente)fc.Persona;
                    cl.Nombre = txbNombreCliente.Text;
                    cl.Rut = txbRut.Text;
                    cl.Telefono = int.Parse(txbNumFijo.Text);
                    cl.Movil = int.Parse(txbNumMovil.Text);
                    cl.Direccion = txbDireccion.Text;
                    cl.comuna = (Comuna)cbComuna.SelectedItem;
                }
                fc.primerProducto = (Producto)cbProductoUno.SelectedItem;
                fc.segundoProducto = (Producto)cbProductoDos.SelectedItem;
                fc.tercerProducto = (Producto)cbProductoTres.SelectedItem;
                if (fc.Persona is Vendedor)
                {
                    Vendedor vd = (Vendedor)fc.Persona;
                    vd.Nombre = txbNombreVendedor.Text;
                }
                DateTime fecha = DateTime.UtcNow;
                string soloFecha = fecha.ToString("d");
                fc.Fecha = Convert.ToDateTime(soloFecha);
                reg.agregarFactura(fc);
                MessageBox.Show("Guardado correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("");
            }
        }
    }
}
