using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoDeObjetos
{
    class Usuario
    {
        private List<Guardarropa> Guardarropas { get; set; }

        public List<List<Atuendo>> GenerarTodasSugerencias()
        {
            List<List<Atuendo>> todasSugerencias = new List<List<Atuendo>>();

            foreach (Guardarropa unGuardarropa in Guardarropas)
            {
                todasSugerencias.Add(unGuardarropa.GenerarSugerencia());
            }

            return todasSugerencias;
        }
        //La sig funcion es para ingresar una prenda, busca al guardarropas del usuario y agrega la prenda si cumple las condiciones de buscarentipodeprenda
        /*public void ingresarPrendaASuGuardarropas(string identificacionG, string descripcion, string tela, string color)
        {
             Guardarropas.Find(g =>identificacionG ==g.mostrarIdentificacion()).AddPrenda(Sistema.BuscarEnTipoPrenda( descripcion, tela, color);
        }*/
    }
}
