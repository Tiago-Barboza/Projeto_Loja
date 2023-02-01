using Projeto_Sistema.Classes;
using Projeto_Sistema.Forms;
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

namespace Projeto_Sistema
{
    public partial class Login : Form
    {
        private Menu oMenu;
        public Login()
        {
            InitializeComponent();
            oMenu = new Menu();
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Usuarios oUsuario = new Usuarios();
            CtrlUsuarios aCtrlUsuarios = new CtrlUsuarios();
            oUsuario.usuario = TBUser.Text;
            string resultado = aCtrlUsuarios.Carregar(oUsuario);
            if (resultado == "Erro")
            {
                LblErroSenha.Visible = false;
                LblErroUser.Text = "Usuário não encontrado";
                LblErroUser.Visible = true;
            }
            else if (oUsuario.senha != TBSenha.Text)
            {
                LblErroUser.Visible = false;
                LblErroSenha.Text = "Senha incorreta";
                LblErroSenha.Visible = true;
            }
            else
            {
                this.Hide();
                LblErroUser.Visible = false;
                LblErroSenha.Visible = false;
                oMenu.SetUsuario(oUsuario);
                oMenu.Closed += (s, args) => this.Close();
                if (oMenu.ShowDialog() == DialogResult.OK) ;
                
            }
        }
        private void Login_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.MediumSlateBlue, Color.FromArgb(31, 30, 68), LinearGradientMode.Vertical);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TextBox[] AuxTextBox = { TBUser,TBSenha };
            List<TextBox> TextBoxList = new List<TextBox>();
            TextBoxList.AddRange(AuxTextBox);
            foreach (TextBox TB in TextBoxList)
            {
                TB.AutoSize = false;
                TB.Controls.Add(new Label() { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            }
        }

        private void LblCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuarios Cadastro = new FrmCadastroUsuarios();
            if (Cadastro.ShowDialog() == DialogResult.OK) ;
        }
    }
}
