using System;
using System.Collections.Generic;
using System.Text;

namespace patron_strategy
{
    public interface IVolar
    {
        void Volar();
    }

    public interface IGraznar
    {
        void Graznar();
    }
    public class VolarConAlas : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("Volando con alas");
        }
    }

    public class NoVolar : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("No puedo volar");
        }
    }
    public class GraznarComoUnPato : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("¡Cuac, cuac!");
        }
    }

    public class GraznarComoUnaBocina : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("¡Meec, meec!");
        }
    }

    public class GraznarEnSilencio : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("");
        }
    }
    public class Pato
    {
        public readonly IGraznar _estrategiaGraznar;
        public readonly IVolar _estrategiaVolar;


        public Pato(IGraznar estrategiaGraznar, IVolar estrategiaVolar)
        {
            _estrategiaGraznar = estrategiaGraznar;
            _estrategiaVolar = estrategiaVolar;
        }



        public void Graznar()
        {
            _estrategiaGraznar.Graznar();
        }

        public void Volar()
        {
            _estrategiaVolar.Volar();
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando");
        }
    }
    public class PatoDomestico : Pato
    {
        public PatoDomestico() :
            base(new GraznarComoUnPato(), new VolarConAlas())
        {
        }


    }

    public class PatoDeJuguete : Pato
    {


        public PatoDeJuguete() :
                base(new GraznarComoUnaBocina(), new NoVolar())
        {
        }



    }

    public class PatoDecorativo : Pato
    {
        public PatoDecorativo() :
            base(new GraznarEnSilencio(), new NoVolar())
        {

        }




    }
}