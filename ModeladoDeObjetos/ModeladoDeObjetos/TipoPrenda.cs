using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoDeObjetos
{
    public class TipoPrenda
    {
        public String Descripcion { get; private set; }
        public Categoria Categoria { get; private set; }
        public List<String> TiposTelasPosibles { get; private set; }
        public List<String> ColoresPosibles { get; private set; }

        public TipoPrenda(String descripcion, Categoria categoria, List<String> tiposTelasPosibles, List<String> coloresPosibles)
        {
            Descripcion = descripcion;
            Categoria = categoria;
            TiposTelasPosibles = tiposTelasPosibles;
            ColoresPosibles = coloresPosibles;
        }
    }
}
