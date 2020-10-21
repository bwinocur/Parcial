using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    class AlumnoRegular : Alumno
    {
        private string _email;

        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public AlumnoRegular(int registro, string email_entrada, string nombre_entrada, string apellido_entrada)
            : base(registro, nombre_entrada, apellido_entrada)
        {
            this._email = email_entrada;
        }
    }
}