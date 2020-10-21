using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public abstract class Alumno : Persona
    {
        protected int _registro;
        public Alumno(int registro_entrada, string nombre_entrada, string apellido_entrada) : base(nombre_entrada, apellido_entrada)
        {
            this._registro = registro_entrada;
        }
        public int Registro
        {
            get { return this._registro; }
            set { this._registro = value; }
        }

        internal override string Display()
        {
            return string.Format("{0} ({1})", this._nombre, this._registro);
        }

    }
}