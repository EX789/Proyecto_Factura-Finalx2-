using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Factura: ICalculable
    {
        /// <summary>
        /// primeraCantidad,segundaCantidad,terceraCantidad: cantdad que querra el usurio de un 
        /// mismo producto
        /// </summary>
        public int primeraCantidad { get; set; }
        public int segundaCantidad { get; set; }
        public int terceraCantidad { get; set; }
        
        //Donde se encuentran los prudctos en forma de ennumerador
        #region Productos
        private Producto prmProducto;

        public Producto primerProducto
        {
            get { return prmProducto; }
            set { prmProducto = value; }
        }

        private Producto sgnProducto;

        public Producto segundoProducto
        {
            get { return sgnProducto; }
            set { sgnProducto = value; }
        }

        private Producto tProducto;

        public Producto tercerProducto
        {
            get { return tProducto; }
            set { tProducto = value; }
        } 
        #endregion
        

        public DateTime Fecha { get; set; }//Fecha de la factura

        public Persona Persona { get; set; }//Asociacion con la clase Persona

        private int intNumFactura; //Num. de la factura 

        public int numFactura
        {
            get { return intNumFactura; }
            set { intNumFactura = value; }
        }
        
        public int calcularTotal(int intCantidad, Producto producto) //Metodo para calcular el valor monetario de un producto,
        {                                                            //ingresanto un parametro int de la cantidad de un objeto especifico
            int calculo;                                             //y el valor del producto.
            int valor = (int)producto;
            calculo = valor * intCantidad;
            return calculo;
        }

        public void calcularNeto()
        {

            throw new NotImplementedException();
        }

        public void calcularIVA()
        {
            throw new NotImplementedException();
        }
    }
}
