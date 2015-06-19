using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Cliente:Persona //extiende de la clase persona
    {
        public Cliente()
        {
            Movil = 0;
        }
        //Rut del cliente
        private string strRut;

        public string Rut
        {
            get { return strRut; }
            set { strRut = value; }
        }
        //Telefono fijo del cliente
        private int intTelefono;

        public int Telefono
        {
            get { return intTelefono; }
            set { intTelefono = value; }
        }
        
        //Telefono movil del cliente
        public int Movil { get; set;}
        //Direccion de cliente
        public string Direccion { get; set; }
        
        //La comuna del cliente, que depende de enumeradores
        private Comuna itComuna;

        public Comuna comuna
        {
            get { return itComuna; }
            set { itComuna = value; }
        }

        public override string imprimir() //metodo que sobrescribe el metodo anterior de la clase persona, y agrega nuea informacion
        {
            return base.imprimir()+
                "\nRut: "+Rut+
                "\nTelefono de contacto: "+
                "\nFijo: "+Telefono+
                "\nMovil: "+Movil+
                "\nDireccion: "+Direccion+", "+comuna;
        }
    }
}
