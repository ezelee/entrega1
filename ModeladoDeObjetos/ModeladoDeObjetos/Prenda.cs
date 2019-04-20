using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoDeObjetos
{
    public class Prenda
    {
        public Categoria categoria;


        /* public string descripcion;
         public string categoria;
         public List<string> tiposTelasPosibles { get; set; }

        */
        public TipoPrenda tipo;
        public string color;
        public string tela;
        public Prenda(TipoPrenda tip, string col, string te)
        {
            tipo = tip;
            color = col;
            tela = te;
            categoria = tip.Categoria;
         }
        public Categoria MostrarCategoria()
        {
            return categoria;
        }
        
    }

}
