using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

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
            /* public levantarJson()
            {
                Console.WriteLine("Iniciando");
                var path = "tipoPrenda.json";
                List<Prenda> listaPrenda = Parser.parsearJson(path);

                foreach (Prenda p in listaPrenda)
                {

                    Console.WriteLine("descripcion: " + p.descripcion);
                    Console.WriteLine("categoria: " + p.categoria);
                    Console.WriteLine("tiposTelasPosibles : " + p.tiposTelasPosibles);


                    Console.WriteLine("--------------------------------");

                }*/
            Console.ReadKey();
        }

            

        }
    }

