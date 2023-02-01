using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projeto_Sistema.Classes
{
    internal class DAOUsuarios : DAO
    {
        private Usuarios oUsuario;
        public DAOUsuarios() 
        {

        }

        public override string Salvar(object pObj)
        {
            oUsuario = (Usuarios)pObj;
            using (MySqlConnection conn = new MySqlConnection(ConnectDB))
            {
                conn.Open();
                try
                {
                    string query = "";
                    if (oUsuario.coduser == 0)
                    {
                        query = "insert into usuarios(usuario,senha,email) values(@usuario,@senha,@email);";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = oUsuario.usuario;
                    cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = oUsuario.senha;
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = oUsuario.email;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Usuário cadastro com sucesso");
                    return "";
                }
                catch (Exception e) 
                {
                    MessageBox.Show("Erro ao salvar usuário. Erro: ", e.Message);
                    return "Erro";
                }
            }
        }

        public override string Carregar(object pObj)
        {
            oUsuario= (Usuarios)pObj;
            using (MySqlConnection conn = new MySqlConnection(ConnectDB))
            {
                conn.Open();
                try
                {
                    string query = "";
                    if (oUsuario.usuario.Length > 0)
                    {
                        query = "select u.coduser, u.usuario, u.senha, u.email from usuarios u where usuario = @usuario";
                    }
                    else
                    {
                        query = "select u.coduser, u.usuario, u.senha, u.email from usuarios u where email = @email";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = oUsuario.usuario;
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = oUsuario.email;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    oUsuario.coduser = reader.GetInt32(0);
                    oUsuario.usuario= reader.GetString(1);
                    oUsuario.senha = reader.GetString(2);
                    oUsuario.email = reader.GetString(3);
                    conn.Close();
                    return "";

                }
                catch (MySqlException e)
                {
                    conn.Close();
                    return "Erro";
                }
            }
        }
    }
}
