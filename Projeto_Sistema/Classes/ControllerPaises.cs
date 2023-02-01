using System.Data;

namespace Projeto_Sistema.Classes
{
    internal class ControllerPaises : Controller
    {
        private DAOPaises aDAOPaises;
        public ControllerPaises()
        {
            aDAOPaises = new DAOPaises();
        }

        public override string Salvar(object pObj)
        {
            return aDAOPaises.Salvar(pObj);
        }

        public override string Carregar(object pObj)
        {
            return aDAOPaises.Carregar(pObj);
        }

        public override DataTable Pesquisar(object pObj)
        {
            return aDAOPaises.Pesquisar(pObj);
        }

        public override string Excluir(object pObj)
        {
            return aDAOPaises.Excluir(pObj);
        }

        public override DataTable GetDS()
        {
            return aDAOPaises.GetDS("Paises");
        }

        ~ControllerPaises()
        {

        }
    }
}
