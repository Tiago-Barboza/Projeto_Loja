using Projeto_Sistema.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Sistema.Forms
{
    public partial class FrmPai : Form
    {
        protected Usuarios oUsuario;
        public FrmPai()
        {
            InitializeComponent();
        }

        protected void AddLinhaTB()
        {
            TextBox[] AuxTextBox = { TBCodigo, TBPesquisar, TBUserUltAlt };
            List<TextBox> TextBoxList = new List<TextBox>();
            TextBoxList.AddRange(AuxTextBox);
            foreach (TextBox TB in TextBoxList)
            {
                TB.AutoSize = false;
                TB.Controls.Add(new Label() { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            }
        }

        protected void AddLinhaMaskedTB()
        {
            MaskedTextBox[] AuxMaskedTextBox = {TBDataCad,TBDataUltAlt};
            List<MaskedTextBox> MaskedTextBoxList = new List<MaskedTextBox>();
            MaskedTextBoxList.AddRange(AuxMaskedTextBox);
            foreach (MaskedTextBox MTB in MaskedTextBoxList)
            {
                MTB.AutoSize = false;
                MTB.Controls.Add(new Label() { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            }
        }

        public void SetUsuario(object pObj)
        {
            oUsuario= (Usuarios)pObj;
        }

        protected virtual void Pesquisar()
        {

        }

        protected virtual void Selecionar()
        {

        }

        protected virtual void Recarregar()
        {

        }
        protected virtual void Incluir()
        {

        }

        protected virtual void Alterar()
        {

        }

        protected virtual void Excluir()
        {

        }

        protected virtual void Limpar()
        {
            TBCodigo.Text = "0";
            TBDataCad.Text = "";
            TBDataUltAlt.Text = "";
            TBUserUltAlt.Text = "";

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void BtnRecarregar_Click(object sender, EventArgs e)
        {
            Recarregar();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        protected void AtivaBtn(Button pButton)
        {
            pButton.Enabled = true;
            pButton.BackColor = Color.MediumSlateBlue;
        }

        protected void DesativaBtn(Button pButton)
        {
            pButton.Enabled = false;
            pButton.BackColor = Color.Gray;
        }
    }
}
