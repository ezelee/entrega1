using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ModeladoDeObjetos
{
    public class Sistema
    {
        public List<Usuario> Usuarios { get; set; }

        static void Main()
        {
            Console.WriteLine("Iniciando");

            /*
             * Genero Tipos de Prendas
             */
            TipoPrendaController tipoPrendaController = new TipoPrendaController();
            tipoPrendaController.LevantarJson();

            /*
             * Genero Guardarropa
             */
            Guardarropa unGuardarropa = new Guardarropa();

            /*
             * Genero Prenda
             */
            if (tipoPrendaController.ValidarColorYTela("remera de manga corta", "algodon", "rojo"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("remera de manga corta");
                Prenda unaPrenda = new Prenda(unTipoPrenda, "algodon", "rojo");
                unGuardarropa.AgregarPrenda(unaPrenda);
            }

            if (tipoPrendaController.ValidarColorYTela("short", "cuero", "negro"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("short");
                Prenda unaPrenda = new Prenda(unTipoPrenda, "cuero", "negro");
                unGuardarropa.AgregarPrenda(unaPrenda);
            }

            /*
             * Acá generar prendas, guardarropas, usuarios, etc.
             * 
             * Luego hay que llamar a un usuario específico el método GenerarTodasSugerencias() para imprimir los atuendos
             * 
             */
            Console.ReadKey();
        }

    }

}
