using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Sistema.Classes
{
    internal class CtrlEstados : Controller
    {
        DAOEstados aDAOEstados;
        public CtrlEstados() 
        {
            aDAOEstados = new DAOEstados();
        }
        public override string Salvar(object pObj)
        {
            return aDAOEstados.Salvar(pObj);
        }

        public override string Carregar(object pObj)
        {
            return aDAOEstados.Carregar(pObj);
        }

        public override DataTable Pesquisar(object pObj)
        {
            return aDAOEstados.Pesquisar(pObj);
        }

        public override string Excluir(object pObj)
        {
            return aDAOEstados.Excluir(pObj);
        }

        public override DataTable GetDS()
        {
            return aDAOEstados.GetDS("Estados");
        }

        ~CtrlEstados()
        {

        }
    }
}
