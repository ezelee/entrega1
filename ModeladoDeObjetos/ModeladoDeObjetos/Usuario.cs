using System.Collections.Generic;

namespace ModeladoDeObjetos
{
    public class Usuario
    {
        private List<Guardarropa> Guardarropas { get; set; } = new List<Guardarropa>();

        public List<List<Atuendo>> GenerarTodasSugerencias()
        {
            List<List<Atuendo>> todasSugerencias = new List<List<Atuendo>>();

            foreach (Guardarropa unGuardarropa in Guardarropas)
            {
                todasSugerencias.Add(unGuardarropa.GenerarSugerencia());
            }

            return todasSugerencias;
        }
        public void AgregarGuardarropa(Guardarropa unGuardarropa)
        {
            Guardarropas.Add(unGuardarropa);
        }
    }
}
