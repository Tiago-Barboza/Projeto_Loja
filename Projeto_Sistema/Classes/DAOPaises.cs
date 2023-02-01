using MySql.Data.MySqlClient;
using Projeto_Sistema.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projeto_Sistema.Classes
{
    internal class DAOPaises : DAO
    {
        private Paises oPais;

        public DAOPaises()
        {

        }

        public override string Salvar(object pObj)
        {
            oPais = (Paises)pObj;
            string resultado = "";
            using (MySqlConnection conn = new MySqlConnection(ConnectDB))
            {
                conn.Open();
                try
                {
                    string query;
                    if (oPais.codigo == 0)
                    {
                        query = "insert into paises(pais,sigla,ddi,datacad,dataultalt,coduserultalt) values(@pais,@sigla,@ddi,@datacad,@dataultalt,@coduserultalt);";
                        resultado = "inserido";
                    }
                    else
                    {
                        query = "update paises set pais = @pais, sigla = @sigla, ddi = @ddi, dataultalt = @dataultalt, coduserultalt = @coduserultalt where codpais = @codpais";
                        resultado = "alterado";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@codpais", MySqlDbType.Int32).Value = oPais.codigo;
                    cmd.Parameters.Add("@pais", MySqlDbType.VarChar).Value = oPais.pais;
                    cmd.Parameters.Add("@sigla", MySqlDbType.VarChar).Value = oPais.sigla;
                    cmd.Parameters.Add("@ddi", MySqlDbType.VarChar).Value = oPais.ddi;
                    cmd.Parameters.Add("@datacad", MySqlDbType.Date).Value = oPais.datacad.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@dataultalt", MySqlDbType.Date).Value = oPais.dataUltAlt.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@coduserultalt", MySqlDbType.Int32).Value = oPais.userUltAlt.coduser;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(string.Format("O país {0} foi {1} com sucesso.",oPais.pais,resultado));
                    return "";
                }
                catch (MySqlException e)
                {
                    if (oPais.codigo == 0)
                    {
                        resultado = "inserir";
                    }
                    else
                    {
                        resultado = "alterar";
                    }
                    MessageBox.Show(string.Format("Erro ao {0} o país {1}. Erro: ",resultado,oPais.pais,e.Message));
                    return "Erro";
                }   
            }
        }

        public override string Carregar(object pObj)
        {
            oPais = (Paises)pObj;
            using (MySqlConnection conn = new MySqlConnection(ConnectDB))
            {
                conn.Open();
                try
                {
                    string query = "";
                    if (oPais.pais.Length > 0)
                    {
                        query = "select p.codpais, p.pais, p.sigla, p.ddi, p.datacad, p.dataultalt, u.usuario from paises p, usuarios u where p.pais = @pais and p.coduserultalt = u.coduser;";
                    }
                    else
                    {
                        query = "select p.codpais, p.pais, p.sigla, p.ddi, p.datacad, p.dataultalt, u.usuario from paises p, usuarios u where p.codpais = @codpais and p.coduserultalt = u.coduser;";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@codpais", MySqlDbType.Int32).Value = oPais.codigo;
                    cmd.Parameters.Add("@pais", MySqlDbType.VarChar).Value = oPais.pais;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    oPais.codigo = reader.GetInt32(0);
                    oPais.pais = reader.GetString(1);
                    oPais.sigla = reader.GetString(2);
                    oPais.ddi = reader.GetString(3);
                    oPais.datacad = reader.GetDateTime(4);
                    oPais.dataUltAlt = reader.GetDateTime(5);
                    oPais.userUltAlt.usuario = reader.GetString(6);
                    conn.Close();
                    return "";
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erro ao carregar o país. Erro: ",e.Message);
                    return "Erro";
                }
            }
        }

        public override DataTable Pesquisar(object pObj)
        {
            oPais = (Paises)pObj;
            using (MySqlConnection conn = new MySqlConnection(ConnectDB))
            {
                conn.Open();
                try
                {
                    string query;
                    if (oPais.pais.Length > 0)
                    {
                        query = "select p.codpais, p.pais, p.sigla, p.ddi from paises p where p.pais = @pais;";
                    }
                    else
                    {
                        query = "select p.codpais, p.pais, p.sigla, p.ddi from paises p where p.codipais = @codpais;";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@codpais", MySqlDbType.Int32).Value = oPais.codigo;
                    cmd.Parameters.Add("@pais", MySqlDbType.VarChar).Value = oPais.pais;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    return dt;
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erro ao pesquisar país. Erro: ", e.Message);
                    return null;
                }
            }
        }

        public override string Excluir(object pObj)
        {
            oPais = (Paises)pObj;
            using (MySqlConnection conn = new MySqlConnection(ConnectDB))
            {
                conn.Open();
                try
                {
                    string query = "delete from paises where codpais = @codpais";
                    MySqlCommand cmd = new MySqlCommand(query, conn); 
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@codpais", MySqlDbType.Int32).Value = oPais.codigo;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(string.Format("O país {0} foi excluído com sucesso", oPais.pais));
                    return "";
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(string.Format("Erro ao excluir {0}. Erro: {1}", e.Message));
                    return "Erro";
                }
            }
        }
    }
}
