using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Sistema.Classes
{
    public class Usuarios
    {
        private int CodUser;
        private string Usuario;
        private string Senha;
        private string Email;

        public Usuarios()
        {
            CodUser = 0;
            Usuario = "";
            Senha = "";
            Email = "";
        }

        public Usuarios(int pCodUser, string pUsuario, string pSenha, string pEmail)
        {
            CodUser = pCodUser;
            Usuario = pUsuario;
            Senha = pSenha;
            Email = pEmail;
        }

        public int coduser
        {
            get { return CodUser; }
            set { CodUser = value; }
        }

        public string usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }

        public string senha
        {
            get { return Senha; } 
            set { Senha = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public Usuarios Clone()
        {
            return new Usuarios(CodUser,Usuario,Senha,Email);
        }
        ~Usuarios()
        {

        }
    }
}
