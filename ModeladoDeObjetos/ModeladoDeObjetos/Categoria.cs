using System;

namespace ModeladoDeObjetos
{
    public class Categoria
    {
        private String DescripcionCategoria { get; set; }

        public Categoria(String unaCategoria)
        {
            DescripcionCategoria = unaCategoria;
        }
        public String ObtenerDescripcion()
        {
            return DescripcionCategoria;
        }
        public bool EsDeCategoria(String unaDescripcionCategoria)
        {
            return DescripcionCategoria == unaDescripcionCategoria;
        }
    }
}
