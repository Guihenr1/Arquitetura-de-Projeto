using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.Dominio
{
    public class Funcionario
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public DateTime nascimento { get; set; }
    }
}
