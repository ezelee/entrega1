using System;

namespace ModeladoDeObjetos
{
    public class Prenda
    {
        private String Descripcion { get; set; }
        private TipoPrenda Tipo { get; set; }
        private String ColorPrimario { get; set; }
        private String ColorSecundario { get; set; }
        private String Tela { get; set; }

        public Prenda(String descripcion, TipoPrenda tipoPrenda, String tela, String colorPrimario, String colorSecundario = null)
        {
            Descripcion = descripcion;
            Tipo = tipoPrenda;
            Tela = tela;
            ColorPrimario = colorPrimario;
            ColorSecundario = colorSecundario;
        }
        public bool EsDeCategoria(String unaDescripcionCategoria)
        {
            return Tipo.EsDeCategoria(unaDescripcionCategoria);
        }
        public String ObtenerDescripcion() { return Descripcion; }
        public String ObtenerColor() { return ColorPrimario + (String.IsNullOrEmpty(ColorSecundario) ? "" : "/" + ColorSecundario); }
        public String ObtenerTela() { return Tela; }
        public String ObtenerTipo() { return Tipo.ObtenerDescripcion(); }
        public String ObtenerCategoria() { return Tipo.ObtenerCategoria(); }
    }
}
