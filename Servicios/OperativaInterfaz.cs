using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6Ficheros.Servicios
{
    internal interface OperativaInterfaz
    {
        public void modificarLinea(string[] lineas, string ruta);

        public void insertarTexto(string[] lineas, string ruta);

        public void guardarFichero(string[] lineas, string ruta);
    }
}
