using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPim.Model
{
    public class FuncionarioDetalhes
    {
        public string nomeFuncionario { get; set; }
        public string departamento { get; set; }
        public string cargo { get; set; }
        public decimal salario { get; set; }
        public DateTime dataContratacao { get; set; }
        public decimal descontoINSS { get; set; }
        public decimal descontoIRRF { get; set; }

        public decimal descontoFGTS { get; set; }

    }
}
