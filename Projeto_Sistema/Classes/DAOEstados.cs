using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projeto_Sistema.Classes
{
    internal class DAOEstados : DAO
    {
        private Estados oEstado;

        public DAOEstados()
        {

        }

        public override string Salvar(object pObj)
        {
            oEstado = (Estados)pObj;
            string resultado = "";
            using (MySqlConnection conn = new MySqlConnection(ConnectDB))
            {
                conn.Open();
                try
                {
                    string query = "";
                    if (oEstado.codigo == 0)
                    {
                        query = "insert into estados(estado,uf,codpais,datacad,dataultalt,coduserultalt) values(@estado,@uf,@codpais,@datacad,@dataultalt,@coduserultalt);";
                        resultado = "inserido";
                    }
                    else
                    {
                        query = "update estados set estado = @estado, uf = @uf, codpais = @codpais, datacad = @datacad, dataultalt = @dataultalt, coduserultalt = @coduserultalt where codestado = @codestado;";
                            resultado = "alterado";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@codestado", MySqlDbType.Int32).Value = oEstado.codigo;
                    cmd.Parameters.Add("@estado", MySqlDbType.VarChar).Value = oEstado.estado;
                    cmd.Parameters.Add("@uf", MySqlDbType.VarChar).Value = oEstado.uf;
                    cmd.Parameters.Add("@codpais", MySqlDbType.Int32).Value = oEstado.opais.codigo;
                    cmd.Parameters.Add("@datacad", MySqlDbType.Date).Value = oEstado.datacad.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@dataultalt", MySqlDbType.Date).Value = oEstado.dataUltAlt.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@coduserultalt", MySqlDbType.Date).Value = oEstado.userUltAlt.coduser;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(string.Format("O estado {0} foi {1} com sucesso.",oEstado.estado,resultado));
                    return "";
                }
                catch (Exception e)
                {
                    conn.Close();
                    if (oEstado.codigo == 0)
                    {
                        resultado = "inserir";
                    }
                    else
                    {
                        resultado = "alterar";
                    }
                    MessageBox.Show(string.Format("Erro ao {0} o estado {1}. Erro: {2}", resultado, oEstado.estado, e.Message));
                    return "Erro";
                }
            }
        }

        public override string Carregar(object pObj)
        {
            oEstado = (Estados)pObj;
            using (MySqlConnection conn = new MySqlConnection(ConnectDB))
            {
                conn.Open();
                try
                {
                    string query = "select e.estado, e.uf, e.codpais, p.pais, e.datacad, e.dataultalt, e.coduserultalt, u.usuario from estados e, paises p, usuarios u where e.codestado = @codestado and e.coduserultalt = u.coduser and e.codpais = p.codpais;";
                    MySqlCommand cmd = new MySqlCommand(query, conn); 
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    oEstado.estado = reader.GetString(0);
                    oEstado.uf = reader.GetString(1);
                    oEstado.opais.codigo = reader.GetInt32(2);
                    oEstado.opais.pais = reader.GetString(3);
                    oEstado.datacad = reader.GetDateTime(4);
                    oEstado.dataUltAlt = reader.GetDateTime(5);
                    oEstado.userUltAlt.coduser = reader.GetInt32(6);
                    oEstado.userUltAlt.usuario = reader.GetString(7);

                    conn.Close();
                    return "";

                }
                catch (MySqlException e)
                {
                    MessageBox.Show(string.Format("Não foi possível carregar o estado. Erro: {0}", e.Message));
                    return "Erro";
                }
            }
        }

        public override DataTable Pesquisar(object pObj)
        {
            oEstado = (Estados)pObj;
            using (MySqlConnection conn = new MySqlConnection(ConnectDB))
            {
                conn.Open();
                try
                {
                    string query = "";
                    if (oEstado.estado.Length > 0)
                    {
                        query = "select e.codestado, e.estado, e.uf, p.pais, e.datacad, e.dataultalt, u.usuario from estados e, usuarios u, paises p where e.estado LIKE '@estado%' and e.coduserultalt = u.coduser and e.codpais = p.codpais;";
                    }
                    else
                    {
                        query = "select e.codestado, e.estado, e.uf, p.pais, e.datacad, e.dataultalt, u.usuario from estados e, usuarios u, paises p where e.codestado = @codestado and e.codpais = p.codpais and e.coduserultalt = u.coduser;";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@estado", MySqlDbType.VarChar).Value = oEstado.estado;
                    cmd.Parameters.Add("@codestado", MySqlDbType.Int32).Value = oEstado.codigo;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    return dt;
                }
                catch (MySqlException e) 
                {
                    Console.WriteLine("Erro ao pesquisar pais. Erro: ", e.Message);
                    return null;
                }
            }
        }

        public override string Excluir(object pObj)
        {
            oEstado = (Estados)pObj;
            using (MySqlConnection conn = new MySqlConnection(ConnectDB))
            {
                conn.Open();
                try
                {
                    string query = "delete from estados where codestado = @codestado";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@codestado", MySqlDbType.Int32).Value = oEstado.codigo;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(string.Format("{0} foi excluído com sucesso.", oEstado.estado));
                    return "";
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(string.Format("Erro ao excluir {0}. Erro: {1}",oEstado.estado,e.Message));
                    return "Erro";
                }
            }
        }

        ~DAOEstados()
        {

        }
    }
}
