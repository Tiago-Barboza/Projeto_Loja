using MySql.Data.MySqlClient;
using System.Data;
using System.Data.OleDb;

namespace Projeto_Sistema.Classes
{
    internal class DAO
    {
        protected string ConnectDB = "SERVER=localhost;DATABASE=loja;UID=root;PASSWORD=02862408;";
        public virtual string Salvar(object pObj)
        {
            return "Erro";
        }
        public virtual string Carregar(object pObj)
        {
            return "Erro";
        }
        public virtual DataTable Pesquisar(object pObj)
        {
            return null;
        }
        public virtual string Excluir(object pObj)
        {
            return "Erro";
        }
        public DataTable GetDS(string pTable)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectDB))
            {
                conn.Open();
                try
                {
                    string query = "";
                    switch (pTable)
                    {
                        case "Paises":
                            query = "select * from paises;";
                            break;

                        case "Estados":
                            query = "select * from estados;";
                            break;

                        case "Cidades":
                            query = "select * from cidades";
                            break;
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable DT = new DataTable();
                    DT.Load(reader);
                    conn.Close();
                    return DT;
                }
                catch (MySqlException e)
                {
                    return null;
                }
            }
        }
    }
}
