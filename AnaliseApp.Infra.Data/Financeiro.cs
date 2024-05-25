using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseApp.Infra.Data
{
    public class Financeiro
    {
        public int Id { get; set; }
        public Guid EmpresaId { get; set; }
        public int PessoaId { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataEmissao { get; set; }
        public decimal Valor { get; set; }
    }
}
