using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPim.Model
{
    public class ListaFuncionarios
    {
        public int funcionario_id { get; set; }
        public string nome_completo { get; set; }
        public string deparamento { get; set; }

        public string? sexo { get; set; }

        public string? cargo { get; set; }
        public DateTime? data_contratacao { get; set; }
        public string? cpf { get; set; }
    }
}
