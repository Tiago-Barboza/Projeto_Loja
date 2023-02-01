using System.Data;

namespace Projeto_Sistema.Classes
{
    abstract class Controller
    {
        public abstract string Salvar(object pObj);
        public abstract string Carregar(object pObj);
        public abstract DataTable Pesquisar(object pObj);
        public abstract string Excluir(object pObj);
        public abstract DataTable GetDS();

    }
}
