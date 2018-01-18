using App.Common;
using App.Model.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    public class EstoqueBO
    {
        public int VerificarQuantidades()
        {
            var json = WebApi.ExecutarResquisicaoGET(Constants.API_FUNCTION_PRODUCTS);

            var products = JsonConvert.DeserializeObject<List<ProductBE>>(json);

            return products.Count();
        }
    }
}
