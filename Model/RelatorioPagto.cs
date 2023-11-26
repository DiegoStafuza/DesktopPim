using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPim.Model
{
    public class RelatorioPagto
    {
        public string Mes { get; set; }
        public string Ano { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal TotalDescontos { get; set; }
        public decimal TotalProventos { get; set; }
    }
}
