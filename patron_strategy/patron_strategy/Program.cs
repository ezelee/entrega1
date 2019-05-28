using System;

namespace patron_strategy
{

    class Program
    {
        static void Main()
        {
            //Hay distintos tipos de patos que vuelan diferente y graznan diferente
            //para no repetir codigo y poder intercambiar methods o comportamientos
            //se utilizan clases "volar" y "graznar" y cada pato diferente
            //usara una clase volar diferente
            Console.WriteLine("Hello World!");
            PatoDecorativo patito = new PatoDecorativo();
            PatoDomestico patitodom = new PatoDomestico();

            Console.Write("El patito decorativo vuela asi\n");
            patito.Volar();

            Console.Write("El patito domestico vuela asi\n");
            patitodom.Volar();
        }
    }
}
