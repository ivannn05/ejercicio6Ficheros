using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6Ficheros.Servicios
{
    internal class OperativaImplementacion:OperativaInterfaz
    {
        public void guardarFichero(string[] lineas)
        {
            string ruta = "C:\\Users\\csi23-iloposa\\Desktop\\Archivo.txt";

            File.WriteAllLines(ruta, lineas);

        }

        public void insertarTexto(string[] lineas)
        {
           


            Console.WriteLine("Indique el numero de linea ");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique la posicion ");
            int numeroPosicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique el texto a insertar");
            string texto = Console.ReadLine();
            //Guardar todo el fichero en un array 
           
            //Seleccionar una linea especifica
            string linea = lineas[numeroLinea - 1];
            //Insertar texto en una posicion especifica
            string nuevoTexto = linea.Insert(numeroPosicion, texto);
            //Insertar el nuevo texto al array 
            lineas[numeroLinea - 1] = nuevoTexto;
            //Sobreescribir el fichero y guardar los cambios
           
        }

        public void modificarLinea(string[] lineas)
        {
           

            Console.WriteLine("Indique el numero de linea ");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique el texto");
            string texto = Console.ReadLine();
          

            lineas[numeroLinea - 1] = texto;
            guardarFichero(lineas ) ;
          


        }
    }
}
