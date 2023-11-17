using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPim.Model
{
    public class ProventosListModel
    {
        public int? id_funcionario { get; set; }
        public string? nome_valor { get; set; }
        public string? tipo_valor { get; set; }
        public decimal? valor { get; set; }
        public string? mes { get; set; }
        public string? ano { get; set; }
        public DateTime? data { get; set; }
    }
}
