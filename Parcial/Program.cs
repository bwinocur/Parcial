using Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Corregido y completado el parcial con capa de presentecación en consola

namespace Parcial
{
    class Program
    {
       private static Presentismo _presentismo;

        static Program()
        {
            _presentismo = new Presentismo();
        }
        static void Main(string[] args)
        {
            bool funcionando = true;
            do
            {
                Console.Clear();
                Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();

                if (preceptorActivo == null)
                    throw new Exception("No hay preceptor valido para tomar lista. Fin de programa.");

                DesplegarOpcionesMenu();
                string opcionMenu = Helper.PedirPalabra("Ingrese una opción");
                switch (opcionMenu)
                {
                    case "1":
                        TomarAsistencia(preceptorActivo);
                        break;
                    case "2":
                        MostrarAsistencia();
                        break;
                    case "X":
                        funcionando = false;
                        break;
                    default:
                        Console.WriteLine("No se ha ingresado una opción válida. \nPresione una tecla para intentar nuevamente.");
                        Console.ReadKey();
                        break;
                }
            } while (funcionando);

        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Tomar Asistencia");
            Console.WriteLine("2) Mostrar Asistencia");
            Console.WriteLine("X: Terminar");
        }
        static void TomarAsistencia(Preceptor p)
        {
            string fecha = Helper.PedirFechaString("Ingrese una fecha.");
            try
            {
                List<Asistencia> listaAsistencias = new List<Asistencia>();
                foreach (Alumno alumno in _presentismo.PresentismoAlumnos)
                {
                    Console.WriteLine("Se tomará lista al alumno:" + alumno.ToString()); 
                    if (!_presentismo.GetListaAlumnosRegulares().Contains(alumno))
                        Console.WriteLine("El alumno {0} es oyente", alumno.ToString());
                    else
                    {
                        listaAsistencias.Add(new Asistencia(fecha, DateTime.Now, p, alumno, Helper.PedirPresente()));
                    }
                }
                _presentismo.AgregarAsistencia(listaAsistencias, fecha);
                Helper.Continuar();
            }
            catch (AsistenciaExistenteEseDiaException e)
            {
                Console.WriteLine("Error " + e.Message);
                if (Helper.QuiereReintentar() == "S")
                {
                    TomarAsistencia(p);
                }
                else
                {
                    DesplegarOpcionesMenu();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }
        static void MostrarAsistencia()
        {
            try
            {
                string fecha = Helper.PedirFechaString("Ingrese una fecha");
                List<Asistencia> presentes = _presentismo.GetAsistenciasPorFecha(fecha);
                foreach (Asistencia asistencia in presentes)
                {
                    Console.WriteLine(asistencia.ToString());
                }
                Helper.Continuar();
            }
            catch (AsistenciaIconsistenteException e)
            {
                Console.WriteLine(e.Message);
                if (Helper.QuiereReintentar() == "S")
                {
                    MostrarAsistencia();
                }
                else
                {
                    DesplegarOpcionesMenu();
                }

            }
            catch (SinAlumnosRegistradosException e)
            {
                Console.WriteLine(e.Message);
                if (Helper.QuiereReintentar() == "S")
                {
                    MostrarAsistencia();
                }
                else
                {
                    DesplegarOpcionesMenu();
                }
            }


            // ingreso fecha
            // muestro el toString de cada asistencia
        }
    }

}

