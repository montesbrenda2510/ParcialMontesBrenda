using parcialcubo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialcubo.Datos
{
  
    public class Repositorio
    {
        private List<cubo> listaCubos;
        private bool haycambios = false;
        public Repositorio()
        {
            listaCubos = new List<cubo>();
        }
        
        public void Agragar (cubo cubo)
        {
            listaCubos.Add(cubo);
            haycambios = true;
        }
        public void Borrar(cubo cubo)
        {
            listaCubos.Remove(cubo);
            haycambios = true;
        }
        public void Editar (cubo cubo)
        {
            haycambios = true;
        }
        
        public List<cubo> GetLista()
        {
            return listaCubos;
        }
         public int Getcanntidad()
        {
            return listaCubos.Count;
        }

        public void GuardarenArchivo()
        {
            if (haycambios)
            {
                manejadorDeArchivo.GuardarenArchivo(listaCubos);
            }
        }
    }
    
}
