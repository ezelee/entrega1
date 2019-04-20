using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoDeObjetos
{
    public class Guardarropa
    {
       //public string identificacion;
        private List<Atuendo> Atuendos { get; set; }
        private List<Prenda> Prendas { get; set; }
        public void AgregarPrenda(Prenda prenda)
        {
            Prendas.Add(prenda);
        }
        public List<Atuendo> GenerarSugerencia()
        {
            List<Atuendo> atuendos = new List<Atuendo>();

            List<Prenda> partesSuperiores = Prendas.FindAll(p => p.EsDeCategoria("parte superior"));
            List<Prenda> partesInferiores = Prendas.FindAll(p => p.EsDeCategoria("parte inferior"));
            List<Prenda> accesorios = Prendas.FindAll(p => p.EsDeCategoria("accesorio"));
            List<Prenda> calzados = Prendas.FindAll(p => p.EsDeCategoria("calzado"));

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

                            atuendos.Add(unAtuendo);
                        }
                    }
                }
            }
            Atuendos = atuendos.ToList();

            return atuendos;
        }
    }
}
