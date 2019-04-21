using System;
using System.Collections.Generic;

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
            }

            if (tipoPrendaController.ValidarColorYTela("short", "cuero", "negro"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("short");
                Prenda unaPrenda = new Prenda("Short de nike", unTipoPrenda, "cuero", "negro");
                unGuardarropa.AgregarPrenda(unaPrenda);
            }

            if (tipoPrendaController.ValidarColorYTela("zapatos de tacón", "cuero", "negro"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("zapatos de tacón");
                Prenda unaPrenda = new Prenda("Zapatos de Sarkany", unTipoPrenda, "cuero", "negro");
                unGuardarropa.AgregarPrenda(unaPrenda);
            }

            if (tipoPrendaController.ValidarColorYTela("pañuelo", "jersey", "verde", "blanco"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("pañuelo");
                Prenda unaPrenda = new Prenda("Pañuelo verde generico", unTipoPrenda, "jersey", "verde", "blanco");
                unGuardarropa.AgregarPrenda(unaPrenda);
            }

            foreach (Prenda unaPrenda in unGuardarropa.ObtenerPrendas())
            {
                Console.WriteLine(" + Prenda: " + unaPrenda.ObtenerDescripcion() + " - Tipo: " + unaPrenda.ObtenerTipo() + " - Tela: " + unaPrenda.ObtenerTela() + " - Color: " + unaPrenda.ObtenerColor());
            }

            /*
             * 1.c debe tener un tipo tipo de tela, que debe ser consistente con el tipo de prenda: por
             * ejemplo, no tiene sentido tener una campera de seda o una remera de cuero.
             */
            if (tipoPrendaController.ValidarColorYTela("remera de manga corta", "cuero", "gris"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("remera de manga corta");
                Prenda unaPrenda = new Prenda("Remera de manga corta nike", unTipoPrenda, "cuero", "gris");
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
                Console.Write(" + Atuendo: ");
                foreach (Prenda p in unAtuendo.Prendas)
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
            Usuario usuario1 = new Usuario();
            Usuario usuario2 = new Usuario();
            usuario1.AgregarGuardarropa(unGuardarropa);

            Guardarropa unGuardarropa2 = new Guardarropa();

            if (tipoPrendaController.ValidarColorYTela("musculosa", "algodon", "gris"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("musculosa");
                Prenda unaPrenda = new Prenda("Musculosa Nike", unTipoPrenda, "algodon", "gris");
                unGuardarropa2.AgregarPrenda(unaPrenda);
            }

            if (tipoPrendaController.ValidarColorYTela("remera manga larga", "poliester", "azul"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("remera manga larga");
                Prenda unaPrenda = new Prenda("Remera manga larga zara", unTipoPrenda, "poliester", "azul");
                unGuardarropa2.AgregarPrenda(unaPrenda);
            }

            if (tipoPrendaController.ValidarColorYTela("pantalon largo", "algodon", "negro"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("pantalon largo");
                Prenda unaPrenda = new Prenda("Pantalon Adidas", unTipoPrenda, "algodon", "negro");
                unGuardarropa2.AgregarPrenda(unaPrenda);
            }

            if (tipoPrendaController.ValidarColorYTela("ojotas", "goma", "negro"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("ojotas");
                Prenda unaPrenda = new Prenda("Ojotas havaianas", unTipoPrenda, "goma", "negro");
                unGuardarropa2.AgregarPrenda(unaPrenda);
            }

            if (tipoPrendaController.ValidarColorYTela("collar calabera", "aluminio", "plata"))
            {
                TipoPrenda unTipoPrenda = tipoPrendaController.BuscarTipoPrenda("collar calabera");
                Prenda unaPrenda = new Prenda("Collar calabera Joyeria II", unTipoPrenda, "aluminio", "plata");
                unGuardarropa2.AgregarPrenda(unaPrenda);
            }
            usuario1.AgregarGuardarropa(unGuardarropa2);

            /*
             * Punto 4. Obtener sugerencias desde varios guardarropas, sin mezclar prendas entre un guardarropa y 
             * otro. Es decir, las prendas no se comparten entre los guardarropas.
             */
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Punto 4. Obtener sugerencias desde varios guardarropas.");
            List<List<Atuendo>> todasSugerencias;
            todasSugerencias = usuario1.GenerarTodasSugerencias();
            int count = 1;

            Console.WriteLine(" + Usuario: usuario 1");
            foreach (List<Atuendo> atuendos in todasSugerencias)
            {
                Console.WriteLine(" + Guardarropa " + count.ToString());
                foreach (Atuendo atuendo in atuendos)
                {
                    Console.Write(" + Atuendo: ");
                    foreach (Prenda p in atuendo.Prendas)
                    {
                        Console.Write(p.ObtenerDescripcion() + ". ");
                    }
                    Console.WriteLine();
                }
                count++;
            }
            Console.ReadKey();
        }
    }
}
