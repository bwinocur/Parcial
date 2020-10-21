using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;

        public Persona(string Nombre_entrada, string Apellido_entrada)
        {
            this._nombre = Nombre_entrada;
            this._apellido = Apellido_entrada;
        }

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public override string ToString()
        {
            return this.Display();
        }

        internal abstract string Display();



    }
}
