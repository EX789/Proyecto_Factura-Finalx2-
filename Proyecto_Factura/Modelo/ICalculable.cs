using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    //Interfaz para Factura
    public interface ICalculable
    {
        void calcularNeto();//Los metodos los implementara para caulcular tanto lo valores neto e
        void calcularIVA(); //IVA
    }
}
