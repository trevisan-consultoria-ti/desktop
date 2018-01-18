using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Api
{
    public class ProductBE
    {
        public int id { get; set; }
        public string keyid { get; set; }
        public string descricao { get; set; }
        public decimal estoque { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
    }
}
