using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Persona
    {
        //Metodo sin parametros de entrada
        public Persona() { }

        //Metodo con parametros de entrada
        public Persona(string strParNombre)
        {
            Nombre = strParNombre;
        }

        private string strNombre;//Nombre de la persona, tanto para el cliente como para el Vendedor

        public string Nombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }

        //Metodo imprimir que mostrara la informacion de la persona, se extendera hacia el cliente.
        public virtual string imprimir()
        {
            return "Nombre: "+Nombre;
        }
    }
}
