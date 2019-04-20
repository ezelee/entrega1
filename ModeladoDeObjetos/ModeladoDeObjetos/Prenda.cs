using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoDeObjetos
{
    public class Prenda
    {
        private String Descripcion { get; set; }
        private TipoPrenda Tipo { get; set; }
        private String Color { get; set; }
        private String Tela { get; set; }

        public Prenda(TipoPrenda tipoPrenda, String color, String tela)
        {
            Tipo = tipoPrenda;
            Color = color;
            Tela = tela;
        }
        public bool EsDeCategoria(String unaDescripcionCategoria)
        {
            return Tipo.EsDeCategoria(unaDescripcionCategoria);
        }
    }
}
