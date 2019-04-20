using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoDeObjetos
{
    public class TipoPrenda
    {
        public String Descripcion { get; set; }
        public Categoria Categoria { get; set; }
        public List<String> TiposTelasPosibles { get; set; }
        public List<String> ColoresPosibles { get; set; }

        public TipoPrenda(String descripcion, Categoria categoria, List<String> tiposTelasPosibles, List<String> coloresPosibles)
        {
            Descripcion = descripcion;
            Categoria = categoria;
            TiposTelasPosibles = tiposTelasPosibles;
            ColoresPosibles = coloresPosibles;
        }
        
        public bool ValidarColorYTela(String tela, String color)
        {
           return TiposTelasPosibles.Contains(tela) && ColoresPosibles.Contains(color);
        }
    }
}
