using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.Dominio
{
    public class Usuario
    {
        public int codigo { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public DateTime DataLog { get; set; }
    }
}
