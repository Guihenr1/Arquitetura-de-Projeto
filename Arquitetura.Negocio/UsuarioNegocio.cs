using Arquitetura.Dominio;
using Arquitetura.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.Negocio
{
    public class UsuarioNegocio
    {
        UsuarioRepository _URep = new UsuarioRepository();
        public void InserirNovoUsuario()
        {
            Usuario objUsuario = new Usuario();
            objUsuario.codigo = 1;
            objUsuario.login = "Guilherme";
            objUsuario.senha = "123";
            objUsuario.DataLog = DateTime.Now.Date;

            _URep.inserir(objUsuario);
        }
    }
}
