using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace ModeladoDeObjetos
{
    class Parser
    {
        /*public static List<Prenda> parsearJson(string path)
        {

            // LEE ARCHIVO .JSON
            string json = System.IO.File.ReadAllText(path);



            // PARSER MAGICO
            List<Prenda> listaPrendas = JsonConvert.DeserializeObject<JObject>(json).Value<JArray>("tipoPrenda").ToObject<List<Prenda>>();

            /* - Value<JArray>("tipoPrenda"): Indica al converter que para convertir los objetos se 
             *                            pare sobre la key "prenda" que corresponde a un Array de Json
             * - ToObject<List<Prenda>: Indica que ese JArray debe ser convertido a una lista de prendas
             * */

           /* return listaPrendas;

        } */
    }
}
