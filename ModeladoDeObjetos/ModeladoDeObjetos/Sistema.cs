using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ModeladoDeObjetos
{
    public class Sistema
    {
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

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
                //Categoria parteSuperior = new Categoria("parte superior");
                unGuardarropa.AgregarPrenda(unaPrenda);
            }

            if (tipoPrendaController.ValidarColorYTela("short", "cuero", "negro"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("short");
                Prenda unaPrenda = new Prenda(unTipoPrenda, "cuero", "negro");
                unGuardarropa.AgregarPrenda(unaPrenda);
            }

            if (tipoPrendaController.ValidarColorYTela("zapatos de tacón", "cuero", "negro"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("zapatos de tacón");
                Prenda unaPrenda = new Prenda(unTipoPrenda, "cuero", "negro");
                unGuardarropa.AgregarPrenda(unaPrenda);
            }

            if (tipoPrendaController.ValidarColorYTela("pañuelo", "jersey", "verde"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("pañuelo");
                Prenda unaPrenda = new Prenda(unTipoPrenda, "jersey", "verde");
                unGuardarropa.AgregarPrenda(unaPrenda);
            }

            /*
             * Acá generar prendas, guardarropas, usuarios, etc.
             * 
             * Luego hay que llamar a un usuario específico el método GenerarTodasSugerencias() para imprimir los atuendos
             * 
             */
            List<Atuendo> listaAtuendos = unGuardarropa.GenerarSugerencia();

            Console.ReadKey();
        }
    }
}
