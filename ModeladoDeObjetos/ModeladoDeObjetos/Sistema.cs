using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ModeladoDeObjetos
{
    class Sistema
    {
        public List<Usuario> Usuarios { get; set; }

        static void Main()
        {
            Console.WriteLine("Iniciando");

            /*
             * Genero Tipos de Prendas
             */
            List<TipoPrenda> tipoPrenda = new List<TipoPrenda>();
            tipoPrenda = LevantarJson();

            /*
             * Genero 
             */
            Guardarropa unGuardarropa = new Guardarropa();
            


            /*
             * Acá generar prendas, guardarropas, usuarios, etc.
             * 
             * Luego hay que llamar a un usuario específico el método GenerarTodasSugerencias() para imprimir los atuendos
             * 
             */
            Console.ReadKey();
        }
       /* public Prenda BuscarEnTipoPrenda(string descripcion, string tela, string color)
        {
            try
            {
                if (tipoPrenda.Find(tip => tip.Descripcion == descripcion).validarColorYTela(color, tela))
                {
                    Prenda unaPrenda = new Prenda(tipoPrenda.Find(tip => tip.Descripcion == descripcion), color, tela);
                    return unaPrenda;
                }
            }


            catch
            {
                throw new Exception("No se pudo crear Prenda");
            }
        }*/

        public static List<TipoPrenda> LevantarJson()
        {
            Console.WriteLine("Iniciando");
            var path = "tipoPrenda.json";
            List<TipoPrenda> tipoPrendas = new List<TipoPrenda>();

            var json = System.IO.File.ReadAllText(path);
            RootObject objetoJson = JsonConvert.DeserializeObject<RootObject>(json);

            foreach (TipoPrendaJson unTipo in objetoJson.TipoPrenda)
            {
                Categoria categoria = new Categoria();
                categoria.DescripcionCategoria = unTipo.Categoria;
                TipoPrenda tipoPrenda = new TipoPrenda(unTipo.Descripcion, categoria, unTipo.TiposTelasPosibles.ToList(), unTipo.ColoresPosibles.ToList());
            };

            return tipoPrendas;
        }
        
        
    }

    public class TipoPrendaJson
    {
        public String Descripcion { get; set; }
        public String Categoria { get; set; }
        public List<String> TiposTelasPosibles { get; set; }
        public List<String> ColoresPosibles { get; set; }
    }

    public class RootObject
    {
        public List<TipoPrendaJson> TipoPrenda { get; set; }
    }
}
