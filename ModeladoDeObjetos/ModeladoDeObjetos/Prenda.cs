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
      
        
           /* public string descripcion;
            public string categoria;
            public List<string> tiposTelasPosibles { get; set; }

           */
        
    }

    enum Categoria
    { ParteSuperior, ParteInferior, Calzado, Accesorio }

}
