using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6Ficheros.Servicios
{
    internal interface OperativaInterfaz
    {
        public void modificarLinea(string[] lineas);

        public void insertarTexto(string[] lineas);

        public void guardarFichero(string[] lineas);
    }
}
