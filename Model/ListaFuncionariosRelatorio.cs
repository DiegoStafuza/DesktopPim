using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPim.Model
{
    public class ListaFuncionariosRelatorio
    {
        public int id_funcionario { get; set; }
        public string nome_funcionario { get; set; }
        public string cpf { get; set; }
        public string sexo { get; set; }
        public string email_usuario { get; set; }
        public int cargo_id { get; set; }
        public DateTime data_contratacao { get; set; }
        public string estado_civil { get; set; }
        public List<object> endereco { get; set; }
    }
}
