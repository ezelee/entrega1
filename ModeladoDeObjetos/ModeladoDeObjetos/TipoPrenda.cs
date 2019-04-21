using System;
using System.Collections.Generic;

namespace ModeladoDeObjetos
{
    public class TipoPrenda
    {
        private String Descripcion { get; set; }
        private Categoria Categoria { get; set; }
        private List<String> TiposTelasPosibles { get; set; } = new List<String>();
        private List<String> ColoresPosibles { get; set; } = new List<String>();

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
        public bool EsDeDescripcion(String unaDescripcion)
        {
            return unaDescripcion == Descripcion;
        }
        public bool EsDeCategoria(String unaDescripcionCategoria)
        {
            return Categoria.EsDeCategoria(unaDescripcionCategoria);
        }
        public String ObtenerDescripcion() { return Descripcion; }
        public String ObtenerCategoria() { return Categoria.ObtenerDescripcion(); }
    }
}
