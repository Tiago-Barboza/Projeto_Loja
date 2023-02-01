using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Projeto_Sistema.Forms;
using System.Drawing.Drawing2D;
using Projeto_Sistema.Classes;

namespace Projeto_Sistema
{
    public partial class Menu : Form
    {
        //Classes
        private Paises oPais;
        private Usuarios oUsuario;
        //Controllers
        private ControllerPaises aControllerPaises;

        //Menu
        private IconButton BtnAtual;
        private Panel BordaEsquerdaBtn;

        //Formulário atual
        private Form CurrentChildForm;
        private struct CoresRGB
        {
            public static Color Cor1 = Color.FromArgb(172, 126, 241);
            public static Color Cor2 = Color.FromArgb(249, 118, 176);
            public static Color Cor3 = Color.FromArgb(253, 138, 114);
            public static Color Cor4 = Color.FromArgb(95, 77, 221);
            public static Color Cor5 = Color.FromArgb(249, 88, 155);
            public static Color Cor6 = Color.FromArgb(24, 161, 251);
        }
        public Menu()
        {
            InitializeComponent();
            BordaEsquerdaBtn = new Panel();
            BordaEsquerdaBtn.Size = new Size(7, 45);
            MenuPanel.Controls.Add(BordaEsquerdaBtn);

            //Classes
            oPais = new Paises();

            //Controllers
            aControllerPaises = new ControllerPaises();
            
            //Posicionando do Aplicativo
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkinegArea;
        }

        public void SetUsuario(object pObj)
        {
            oUsuario = (Usuarios)pObj;
        }
        private void AtivaBtn(object pBtn, Color color)
        {
            if (pBtn != null)
            {
                DesativaBtn();
                BtnAtual = (IconButton)pBtn;
                BtnAtual.BackColor = Color.FromArgb(37,36,81);
                BtnAtual.ForeColor = color;
                BtnAtual.TextAlign = ContentAlignment.MiddleCenter;
                BtnAtual.IconColor = color;
                BtnAtual.TextImageRelation = TextImageRelation.TextBeforeImage;
                


                BordaEsquerdaBtn.BackColor = color;
                BordaEsquerdaBtn.Location = new Point(0, BtnAtual.Location.Y);
                BordaEsquerdaBtn.Visible = true;
                BordaEsquerdaBtn.BringToFront();

                //Icone do formulário filho
                IconTitleChildForm.IconChar = BtnAtual.IconChar;
                IconTitleChildForm.IconColor = color;
                IconTitleChildForm.Text = BtnAtual.Text;
                IconTitleChildForm.ForeColor = BtnAtual.ForeColor;

            }

        }

        private void DesativaBtn()
        {
            if (BtnAtual != null)
            {
                BtnAtual.BackColor = Color.FromArgb(31,30,68);
                BtnAtual.ForeColor = Color.White;
                BtnAtual.TextAlign = ContentAlignment.MiddleLeft;
                BtnAtual.IconColor = Color.White;
                BtnAtual.TextImageRelation = TextImageRelation.ImageBeforeText;
                BtnAtual.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            AtivaBtn(sender, CoresRGB.Cor1);
        }

        private void BtnPaises_Click(object sender, EventArgs e)
        {
            AtivaBtn(sender, CoresRGB.Cor2);
            FrmPaises oFrmPaises = new FrmPaises(oPais,aControllerPaises);
            oFrmPaises.SetUsuario(oUsuario);
            OpenChildForm(oFrmPaises);
        }

        private void BtnEstados_Click(object sender, EventArgs e)
        {
            AtivaBtn(sender, CoresRGB.Cor3);
        }

        private void BtnCidades_Click(object sender, EventArgs e)
        {
            AtivaBtn(sender, CoresRGB.Cor4);

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AtivaBtn(sender, CoresRGB.Cor5);
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            AtivaBtn(sender, CoresRGB.Cor6);
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            AtivaBtn(sender, CoresRGB.Cor1);
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            AtivaBtn(sender, CoresRGB.Cor2);
        }

        private void ResetarBtn()
        {
            DesativaBtn();
            BordaEsquerdaBtn.Visible = false;
            IconTitleChildForm.IconChar = IconChar.Home;
            IconTitleChildForm.IconColor = Color.White;
            IconTitleChildForm.Text = "Home";
            IconTitleChildForm.ForeColor = Color.White;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            CurrentChildForm.Close();
            ResetarBtn();
        }

        //Arrastar programa através do Painel de Título
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }
           
            CurrentChildForm = (Form)ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            ChildForm.Anchor = AnchorStyles.None;
            ChildForm.Location = new Point((PanelDesktop.Width - ChildForm.Width) / 2, (PanelDesktop.Height - ChildForm.Height) / 2);
            PanelDesktop.Controls.Add(ChildForm);
            PanelDesktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            //this.Size = new Size(1238, 936);
            //LblTitleChildForm.Text = ChildForm.Text;
        }

        private void PanelTitle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, PanelTitle.Width, PanelTitle.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Black, Color.FromArgb(34, 33, 74), LinearGradientMode.Vertical);
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(0, 0, 1137, 124);
                LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Black, Color.FromArgb(31, 30, 68), LinearGradientMode.Vertical);
                g.FillRectangle(brush, rect);
                brush.Dispose();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSair_MouseHover(object sender, EventArgs e)
        {
            BtnSair.Font = new Font(BtnSair.Font.FontFamily,13,FontStyle.Bold);
            

        }

        private void BtnSair_MouseLeave(object sender, EventArgs e)
        {
            BtnSair.Font = new Font(BtnSair.Font.FontFamily,12, FontStyle.Regular);
        }

        private void BtnMinimizar_MouseHover(object sender, EventArgs e)
        {
            BtnMinimizar.Font = new Font(BtnMinimizar.Font.FontFamily, 13, FontStyle.Bold);
        }

        private void BtnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            BtnMinimizar.Font = new Font(BtnMinimizar.Font.FontFamily, 12 ,FontStyle.Regular);
        }
    }
}
