using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoDeObjetos
{
    public class Categoria
    {
        private String DescripcionCategoria { get; set; }

        public Categoria(String unaCategoria)
        {
            DescripcionCategoria = unaCategoria;
        }
        public String MostrarDescripcion()
        {
            return DescripcionCategoria;
        }
        public bool EsDeCategoria(String unaDescripcionCategoria)
        {
            return DescripcionCategoria == unaDescripcionCategoria;
        }
    }
}
