using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoDeObjetos
{
    class TipoPrenda
    {
        public String Descripcion { get; set; }
        public Categoria Categoria { get; set; }
        public List<String> TiposTelasPosibles { get; set; }
        public List<String> ColoresPosibles { get; set; }

        public bool ValidarColorYTela(String color, String tela)
        {

            return true;
        }
    }
}
