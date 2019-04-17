using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ModeladoDeObjetos
{
    class Sistema
    {
        public List<Usuario> Usuarios { get; set; }

        static void Main()
        {
            Console.WriteLine("Iniciando");

            /*
             * Acá generar prendas, guardarropas, usuarios, etc.
             * 
             * Luego hay que llamar a un usuario específico el método GenerarTodasSugerencias() para imprimir los atuendos
             * 
             */
            Console.ReadKey();
        }

        public List<TipoPrenda> LevantarJson()
        {
            Console.WriteLine("Iniciando");
            var path = "tipoPrenda.json";
            List<TipoPrenda> tipoPrenda = new List<TipoPrenda>();

            var json = System.IO.File.ReadAllText(path);

            // PARSER MAGICO
            tipoPrenda = JsonConvert.DeserializeObject<List<TipoPrenda>>(json);

            foreach (TipoPrenda unTipo in tipoPrenda)
            {
                Console.WriteLine("descripcion: " + unTipo.Descripcion);
                Console.WriteLine("categoria: " + unTipo.Categoria);

                Console.WriteLine("--------------------------------");

            };

            return tipoPrenda;
        }
    }
}
