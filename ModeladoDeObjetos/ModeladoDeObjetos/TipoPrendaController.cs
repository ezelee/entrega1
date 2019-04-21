using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ModeladoDeObjetos
{
    public class TipoPrendaController
    {
        private List<TipoPrenda> TipoPrendas { get; set; } = new List<TipoPrenda>();

        public bool ValidarColorYTela(String descripcion, String tela, String colorPrimario, String colorSecundario = null)
        {
            TipoPrenda unTipo;

            unTipo = TipoPrendas.Find(unTipoPrenda => unTipoPrenda.EsDeDescripcion(descripcion));

            if (!unTipo.ValidarColorYTela(tela, colorPrimario))
            {
                return false;
            }

            if (!String.IsNullOrEmpty(colorSecundario))
            {
                if (!unTipo.ValidarColorYTela(tela, colorSecundario))
                {
                    return false;
                }
            }
            return true;
        }
        public TipoPrenda BuscarTipoPrenda(String descripcion)
        {
            TipoPrenda tipoPrenda = TipoPrendas.Find(unTipoPrenda => unTipoPrenda.EsDeDescripcion(descripcion));
            return tipoPrenda;
        }
        public void LevantarJson()
        {
            var path = @"C:\Users\eze\Desktop\tipoPrenda2.json";
            List<TipoPrenda> tipoPrendas = new List<TipoPrenda>();

            var json = System.IO.File.ReadAllText(path);
            RootObject objetoJson = JsonConvert.DeserializeObject<RootObject>(json);

            foreach (TipoPrendaJson unTipo in objetoJson.TipoPrenda)
            {
                Categoria categoria = new Categoria(unTipo.Categoria);
                TipoPrenda tipoPrenda = new TipoPrenda(unTipo.Descripcion, categoria, unTipo.TiposTelasPosibles.ToList(), unTipo.ColoresPosibles.ToList());
                tipoPrendas.Add(tipoPrenda);
            };

            TipoPrendas = tipoPrendas;
        }
        private class TipoPrendaJson
        {
            public String Descripcion { get; set; }
            public String Categoria { get; set; }
            public List<String> TiposTelasPosibles { get; set; }
            public List<String> ColoresPosibles { get; set; }
        }
        private class RootObject
        {
            public List<TipoPrendaJson> TipoPrenda { get; set; }
        }
    }
}
