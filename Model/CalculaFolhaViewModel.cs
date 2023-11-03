using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesktopPim.Model.FuncionarioDTO;

namespace DesktopPim.Model
{
    public class CalculaFolhaViewModel
    {
        public List<FuncionariosCalculo> Funcionarios { get; set; }
        public List<FuncionarioDetalhes> DetalhesFuncionario { get; set; }
        public int SelecionadoFuncionarioId { get; set; }
    }
}
