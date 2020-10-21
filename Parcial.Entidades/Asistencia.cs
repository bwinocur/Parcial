using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class Asistencia
    {
        private string _fechaReferencia;
        private DateTime _fechaHoraReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estaPresente;
        private string fecha;
        private DateTime now;
        private Preceptor p;
        private Alumno alumno;
        private Func<bool> pedirBool;

        public Asistencia(string fechaReferencia_entrada, DateTime fechaHoraReal_entrada, Preceptor preceptor_entrada, Alumno alumno_entrada, bool estaPresente_entrada)
        {
            this._fechaReferencia = fechaReferencia_entrada;
            this._fechaHoraReal = fechaHoraReal_entrada;
            this._preceptor = preceptor_entrada;
            this._alumno = alumno_entrada;
            this._estaPresente = estaPresente_entrada;
        }

        public Asistencia(string fecha, DateTime now, Preceptor p, Alumno alumno, Func<bool> pedirBool)
        {
            this.fecha = fecha;
            this.now = now;
            this.p = p;
            this.alumno = alumno;
            this.pedirBool = pedirBool;
        }

        public bool EstaPresente
        {
            get { return this._estaPresente; }
            set { this._estaPresente = value; }
        }


        public Alumno AsistenciaAlumno
        {
            get { return this._alumno; }
            set { this._alumno = value; }
        }


        public Preceptor AsistenciaPreceptor
        {
            get { return this._preceptor; }
            set { this._preceptor = value; }
        }


        public DateTime FechaHoraReal
        {
            get { return this._fechaHoraReal; }
            set { this._fechaHoraReal = value; }
        }


        public string FechaReferencia
        {
            get { return _fechaReferencia; }
            set { _fechaReferencia = value; }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} esta presente {2} por {3} registrado el {4}", this._fechaReferencia, this._alumno.Display(), this._estaPresente, this._preceptor.Display(), this._fechaHoraReal.ToString()); ;
        }
    }
}
