using parcialcubo.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialcubo.Datos
{
    public static class manejadorDeArchivo
    {
        private static string archivo = "cubo.text";
        public static void GuardarenArchivo(List<cubo> lista)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                foreach (var cubo in lista)
                {
                    string linea = ContruirLinea(cubo);
                    escritor.WriteLine(linea);


                }
            }
        }

        private static string ContruirLinea(cubo cubo)
        {
            return $"{cubo.Arista} | {(int)cubo.relleno} | {(int)cubo.trazo}";
        }
    }
}
