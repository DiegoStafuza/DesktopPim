using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPim.Model
{
    public class DadosPgto
    {
        public string mes { get; set; }
        public string ano { get; set; }
        public decimal valor_liquido { get; set; }
        public decimal total_descontos { get; set; }
        public decimal total_proventos { get; set; }
    }
}
