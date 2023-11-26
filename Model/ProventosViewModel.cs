using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPim.Model
{
    public class ProventosViewModel
    {
        public int? FuncionarioId { get; set; }
        public string? Ano { get; set; }
        public string? Mes { get; set; }
        public List<Provento>? Proventos { get; set; }

        public DateTime? dataContratacao { get; set; }
    }
}
