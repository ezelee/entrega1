using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoDeObjetos
{
    class Guardarropa
    {
       public string identificacion;
        private List<Atuendo> Atuendos { get; set; }
        private List<Prenda> Prendas { get; set; }
        /*public Guardarropa(string ident)
        {
            identificacion = ident;
        }*/
        
       /* public string mostrarIdentificacion()
        {
            return identificacion;
        }
        public void AddPrenda(Prenda prenda)
        {
            Prendas.Add(prenda);
        }*/
        public List<Atuendo> GenerarSugerencia()
        {
            List<Prenda> partesSuperiores = new List<Prenda>();
            List<Prenda> partesInferiores = new List<Prenda>();
            List<Prenda> accesorios = new List<Prenda>();
            List<Prenda> calzados = new List<Prenda>();

            //partesSuperiores = Prendas.FindAll(EsParteSuperior);
            //partesInferiores = Prendas.FindAll(EsParteInferior);
            //accesorios = Prendas.FindAll(EsAccesorio);
            //calzados = Prendas.FindAll(EsCalzado);

            foreach (Prenda unaPrendaSuperior in partesSuperiores)
            {
                foreach (Prenda unaPrendaInferior in partesInferiores)
                {
                    foreach (Prenda unAccesorio in accesorios)
                    {
                        foreach (Prenda unCalzado in calzados)
                        {
                            Atuendo unAtuendo = new Atuendo();

                            unAtuendo.Prendas.Add(unaPrendaSuperior);
                            unAtuendo.Prendas.Add(unaPrendaInferior);
                            unAtuendo.Prendas.Add(unAccesorio);
                            unAtuendo.Prendas.Add(unCalzado);

                            Atuendos.Add(unAtuendo);
                        }
                    }
                }
            }

            return Atuendos;
        }

        //private bool EsCalzado(Prenda unaPrenda)
        //{
        //    if (unaPrenda.Categoria == Categoria.Calzado)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //private bool EsAccesorio(Prenda unaPrenda)
        //{
        //    if (unaPrenda.Categoria == Categoria.Accesorio)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //private bool EsParteInferior(Prenda unaPrenda)
        //{
        //    if (unaPrenda.Categoria == Categoria.ParteInferior)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //private bool EsParteSuperior(Prenda unaPrenda)
        //{
        //    if (unaPrenda.Categoria == Categoria.ParteSuperior)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
