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
    }
}
