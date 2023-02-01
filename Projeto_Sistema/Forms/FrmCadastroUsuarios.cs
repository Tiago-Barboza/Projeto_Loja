using Projeto_Sistema.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Sistema.Forms
{
    public partial class FrmCadastroUsuarios : Form
    {
        private Usuarios oUsuario;
        private CtrlUsuarios aCtrlUsuarios;
        public FrmCadastroUsuarios()
        {
            InitializeComponent();
            aCtrlUsuarios = new CtrlUsuarios();
            oUsuario = new Usuarios();
        }

        private void FrmCadastro_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.MediumSlateBlue, Color.FromArgb(31, 30, 68), LinearGradientMode.Vertical);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TBUser.Text.Length == 0)
            {
                LblErroUser.Text = "Usuário é obrigatório";
                LblErroUser.Visible = true;
                TBUser.Focus();
            }
            else if (TBSenha.Text.Length == 0)
            {
                LblErroUser.Visible = false;
                LblErroSenha.Text = "Senha é obrigatória";
                LblErroSenha.Visible = true;
                TBSenha.Focus();
            }
            else if (TBEmail.Text.Length == 0)
            {
                LblErroUser.Visible = false;
                LblErroSenha.Visible = false;
                LblErroEmail.Text = "Email é obrigatório";
                LblErroEmail.Visible = true;
                TBEmail.Focus();
            }
            else
            {
                oUsuario.usuario = TBUser.Text;
                oUsuario.senha = TBSenha.Text;
                oUsuario.email = TBEmail.Text;
                aCtrlUsuarios.Salvar(oUsuario.Clone());
                this.Close();
            }
        }

        private void TBUser_TextChanged(object sender, EventArgs e)
        {
            Usuarios oUsuario = new Usuarios();
            CtrlUsuarios aCtrlUsuarios = new CtrlUsuarios();
            oUsuario.usuario = TBUser.Text;
            string resultado = aCtrlUsuarios.Carregar(oUsuario);
            if (resultado != "Erro")
            {
                LblErroUser.Text = "Usuário já existente";
                LblErroUser.Visible = true;
            }
            else
            {
                LblErroUser.Visible = false;
            }
        }

        private void TBEmail_TextChanged(object sender, EventArgs e)
        {
            Usuarios oUsuario = new Usuarios();
            CtrlUsuarios aCtrlUsuarios = new CtrlUsuarios();
            oUsuario.email = TBEmail.Text;
            string resultado = aCtrlUsuarios.Carregar(oUsuario);
            if (resultado != "Erro")
            {
                LblErroEmail.Text = "Email já existente";
                LblErroEmail.Visible = true;
            }
            else
            {
                LblErroEmail.Visible = false;
            }
        }
    }
}