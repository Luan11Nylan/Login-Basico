using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemalogin
{
    static class CadastroUsuario
    { 

        private static Usuario[] usuarios =
        {
           new Usuario() { Nome = "Luan", Senha = "abc123" },
           new Usuario() { Nome = "João", Senha = "123abc" },
           new Usuario() { Nome = "Zé", Senha = "1234" }
        };

        private static Usuario _userLogado = null;
     
        public static Usuario UsuarioLogado
        {
           get { return _userLogado; }
           private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }

    } 
}
