using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class AsistenciaIconsistenteException : Exception
    {
        public AsistenciaIconsistenteException() : base("No hay asistencias registradas para esa fecha")
        { }
    }
}
