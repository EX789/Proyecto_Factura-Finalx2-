using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Vendedor:Persona//extiende d ela clase persona
    {
        //Metodo sin parametros de entrada
        public Vendedor() { }

        //Metodo con parametros de entrada
        public Vendedor(string intParCodigo, string strBaseNombre): base(strBaseNombre)
        {
            Codigo = intParCodigo;
        }

        protected string intCodigo;//Contraseña del vendedor

        public string Codigo
        {
            get { return intCodigo; }
            set { intCodigo = value; }
        }
    }
}
