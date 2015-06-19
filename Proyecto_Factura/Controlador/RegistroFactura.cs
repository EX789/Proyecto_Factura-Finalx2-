using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;

namespace Controlador
{
    public class RegistroFactura
    {
        private List<Factura> facturas;

        public RegistroFactura()
        {
            facturas = new List<Factura>();
        }

        public Boolean agregarFactura(Factura nvaFactura)
        {
            facturas.Add(nvaFactura);
            return true;
        }

        public Boolean eliminarFactura(int numeroFactura)
        {
            foreach (var item in facturas)
            {
                if (item.numFactura == numeroFactura)
                {
                    facturas.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public string mostrarInfoCliente(int numFactura)
        {
            string salida = "";
            foreach (var item in facturas)
            {
                if (item.numFactura == numFactura)
                {
                    if (item.Persona is Cliente)
                    {
                        Cliente cn = (Cliente)item.Persona;
                        salida = cn.imprimir();
                    } 
                }
            }
            return salida;
        }
    }
}
