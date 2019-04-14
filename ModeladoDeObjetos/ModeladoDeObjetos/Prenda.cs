using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoDeObjetos
{
    class Prenda
    {
        public Categoria Categoria { get; set; }
    }

    enum Categoria
    { ParteSuperior, ParteInferior, Calzado, Accesorio }

}
