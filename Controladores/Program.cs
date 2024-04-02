using ejercicio6Ficheros.Servicios;

namespace ejercicio6Ficheros.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz op = new OperativaImplementacion();

            string ruta = "C:\\Users\\csi23-iloposa\\Desktop\\Archivo.txt";
            string[] lineas = File.ReadAllLines(ruta);


            bool cerrarMenu = false;
            int opcion;

            while (!cerrarMenu)
            {
                opcion = mi.mostrarMenu();
                switch (opcion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        op.modificarLinea(lineas,ruta);
                        break;
                    case 2:
                        op.insertarTexto(lineas, ruta);
                        break;
                    case 3:
                        op.guardarFichero(lineas, ruta);
                        break;
                }
            }







          



        }
    }
}