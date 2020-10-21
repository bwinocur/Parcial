using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class Presentismo
    {
        private List<Preceptor> _preceptores;
        private List<Alumno> _alumnos;
        private List<Asistencia> _asistencias;
        private List<string> _fechas;

        // iniciar Presentismo con los siguientes datos
        public Presentismo()
        {
            _alumnos = new List<Alumno>();
            _asistencias = new List<Asistencia>();
            _preceptores = new List<Preceptor>();
            _fechas = new List<string>();

            _alumnos.Add(new AlumnoRegular(123, "Carlos", "Juarez", "cjua@gmail.com"));
            _alumnos.Add(new AlumnoRegular(124, "Carla", "Jaime", "cjai@gmail.com"));
            _alumnos.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumnos.Add(new AlumnoOyente(321, "Alejandro", "Medina"));

            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos"));

        }

        public List<string> PresentismoFechas
        {
            get { return _fechas; }
        }


        public List<Asistencia> PresentismoAsistencias
        {
            get { return this._asistencias; }
        }


        public List<Alumno> PresentismoAlumnos
        {
            get { return this._alumnos; }
        }


        public List<Preceptor> Preceptores
        {
            get { return this._preceptores; }
        }

        private bool AsistenciaRegistrada(string fecha)
        {
            return this._fechas.Contains(fecha);
        }

        private int GetCantidadAlumnosRegulares()
        {
            int count=0;
            foreach (Alumno alumno in _alumnos)
            {
                if (alumno is AlumnoRegular)
                    count++;
            }
            return count;
        }
        public Preceptor GetPreceptorActivo()
        {
            return _preceptores.FirstOrDefault();
        }

        public List<Alumno> GetListaAlumnos(string fecha)
        {
            if (_alumnos.Count == 0)
                throw new SinAlumnosRegistradosException();
            return this._alumnos;
        }
        public List<Alumno> GetListaAlumnosRegulares()
        {
            List<Alumno> regulares = new List<Alumno>();
            foreach (Alumno alumno in this._alumnos)
            {
                if (alumno is AlumnoRegular)
                    regulares.Add(alumno);
            }
            if (regulares.Count == 0)
            {
                throw new SinAlumnosRegistradosException();
            }
            return regulares;
        }

        public void AgregarAsistencia(List<Asistencia> lista, string fecha)
        {
            if (AsistenciaRegistrada(fecha))
            {
                throw new AsistenciaExistenteEseDiaException();
            }
            else
            {
                foreach (Asistencia nueva in lista)
                {
                    this._asistencias.Add(nueva);
                }
                this._fechas.Add(fecha);
            }
        }

        public List<Asistencia> GetAsistenciasPorFecha(string fecha)
        {
            List<Asistencia> asistenciasFecha = new List<Asistencia>();
            if (this._fechas.Contains(fecha))
            {
                foreach (Asistencia asistencia in this._asistencias)
                {
                    if (asistencia.FechaReferencia == fecha)
                    {
                        asistenciasFecha.Add(asistencia);
                    }
                }
                if (asistenciasFecha.Count == 0)
                    throw new SinAlumnosRegistradosException();
            }
            else
            {
                throw new AsistenciaIconsistenteException();
            }
            return asistenciasFecha;
        }
    }
}