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
            TipoPrendaController tipoPrendaController = new TipoPrendaController();
            tipoPrendaController.LevantarJson();

            /*
             * Punto 1. Creación de prendas, las cuales deben ser válidas, según al menos las siguientes reglas
             */
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Punto 1. Creación de prendas.");
            Guardarropa unGuardarropa = new Guardarropa();

            if (tipoPrendaController.ValidarColorYTela("remera de manga corta", "algodon", "rojo"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("remera de manga corta");
                Prenda unaPrenda = new Prenda("Remera de manga corta Adidas", unTipoPrenda, "algodon", "rojo");
                unGuardarropa.AgregarPrenda(unaPrenda);
                Console.WriteLine("Prenda: " + unaPrenda.ObtenerDescripcion() + " - Tipo: " + unaPrenda.ObtenerTipo() + " - Tela: " + unaPrenda.ObtenerTela() + " - Color: " + unaPrenda.ObtenerColor());
            }

            if (tipoPrendaController.ValidarColorYTela("short", "cuero", "negro"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("short");
                Prenda unaPrenda = new Prenda("Short de nike", unTipoPrenda, "cuero", "negro");
                Console.WriteLine("Prenda: " + unaPrenda.ObtenerDescripcion() + " - Tipo: " + unaPrenda.ObtenerTipo() + " - Tela: " + unaPrenda.ObtenerTela() + " - Color: " + unaPrenda.ObtenerColor());
                unGuardarropa.AgregarPrenda(unaPrenda);
            }

            if (tipoPrendaController.ValidarColorYTela("zapatos de tacón", "cuero", "negro"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("zapatos de tacón");
                Prenda unaPrenda = new Prenda("Zapatos de Sarkany", unTipoPrenda, "cuero", "negro");
                Console.WriteLine("Prenda: " + unaPrenda.ObtenerDescripcion() + " - Tipo: " + unaPrenda.ObtenerTipo() + " - Tela: " + unaPrenda.ObtenerTela() + " - Color: " + unaPrenda.ObtenerColor());
                unGuardarropa.AgregarPrenda(unaPrenda);
            }

            if (tipoPrendaController.ValidarColorYTela("pañuelo", "jersey", "verde", "blanco"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("pañuelo");
                Prenda unaPrenda = new Prenda("Pañuelo verde generico", unTipoPrenda, "jersey", "verde", "blanco");
                Console.WriteLine("Prenda: " + unaPrenda.ObtenerDescripcion() + " - Tipo: " + unaPrenda.ObtenerTipo() + " - Tela: " + unaPrenda.ObtenerTela() + " - Color: " + unaPrenda.ObtenerColor());
                unGuardarropa.AgregarPrenda(unaPrenda);
            }

            /*
             * Punto 2. Generar sugerencias de atuendos válidas, implementando un algoritmo que genere todas las 
             * combinaciones posibles de ropa.
             */
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Punto 2. Generar sugerencias de atuendos válidas.");
            List<Atuendo> listaAtuendos = unGuardarropa.GenerarSugerencia();
            foreach (Atuendo unAtuendo in listaAtuendos)
            {
                Console.Write("Atuendo: ");
                foreach(Prenda p in unAtuendo.Prendas)
                {
                    Console.Write(p.ObtenerDescripcion() + ". ");
                }
                Console.WriteLine();
            }
            /*
             * Punto 3. Creación de múltiples usuarios, cada uno con distintas prendas y guardarropas.
             */
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Punto 3. Creación de múltiples usuarios, cada uno con distintas prendas y guardarropas.");
            Usuario usuario = new Usuario();
            usuario.AgregarGuardarropa(unGuardarropa);

            /*
             * Punto 4. Obtener sugerencias desde varios guardarropas, sin mezclar prendas entre un guardarropa y 
             * otro. Es decir, las prendas no se comparten entre los guardarropas.
             */
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Punto 4. Obtener sugerencias desde varios guardarropas.");
            List<List<Atuendo>> todasSugerencias;
            todasSugerencias = usuario.GenerarTodasSugerencias();
            foreach(List<Atuendo> atuendos in todasSugerencias)
            {
                foreach (Atuendo atuendo in atuendos)
                {
                Console.Write("Atuendo: ");
                    foreach(Prenda p in atuendo.Prendas)
                    {
                        Console.Write(p.ObtenerDescripcion() + ". ");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
