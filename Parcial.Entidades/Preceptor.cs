using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class Preceptor : Persona
    {
        private int _legajo;

        public Preceptor(int legajo_entrada, string nombre_entrada, string apellido_entrada)
            : base(nombre_entrada, apellido_entrada)
        {
            this._legajo = legajo_entrada;
        }

        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

        internal override string Display()
        {
            return string.Format("{0} - {1}", this._apellido, this._legajo);
        }
    }
}
