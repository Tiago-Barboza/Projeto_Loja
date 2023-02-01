using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Sistema.Classes
{
    internal class CtrlUsuarios : Controller
    {
        DAOUsuarios aDAOUsuarios;
        public CtrlUsuarios() 
        {
            aDAOUsuarios = new DAOUsuarios();
        }

        public override string Salvar(object pObj)
        {
            return aDAOUsuarios.Salvar(pObj);
        }

        public override string Carregar(object pObj)
        {
            return aDAOUsuarios.Carregar(pObj);
        }

        public override DataTable Pesquisar(object pObj)
        {
            return aDAOUsuarios.Pesquisar(pObj);
        }

        public override string Excluir(object pObj)
        {
            return aDAOUsuarios.Excluir(pObj);
        }

        public override DataTable GetDS()
        {
            return aDAOUsuarios.GetDS("Paises");
        }
    }
}
