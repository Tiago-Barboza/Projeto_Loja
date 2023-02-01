using Projeto_Sistema.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Sistema.Forms
{
    public partial class FrmPaises : Projeto_Sistema.Forms.FrmPai
    {
        private Paises oPais;
        private ControllerPaises aControllerPaises;
        private int CurrentID = 0;

        public FrmPaises(object pObj, object pCtrl)
        {
            InitializeComponent();
            oPais = (Paises)pObj;
            aControllerPaises = (ControllerPaises)pCtrl;

            //Adiciona o valor "0" ao código
            TBCodigo.Text = "0";

            //Preencher DataGridView
            DGVPaises.DataSource = aControllerPaises.GetDS();
        }

        protected override void Pesquisar()
        {

        }

        protected override void Selecionar()
        {
            int id = Int32.Parse(DGVPaises.CurrentRow.Cells[0].Value.ToString());
            CurrentID = id;
            if (id >= 0)
            {
                AddLinhaMaskedTB();
                DesativaBtn(BtnIncluir);
                oPais.codigo = id;
                aControllerPaises.Carregar(oPais);
                TBCodigo.Text = oPais.codigo.ToString();
                TBPais.Text = oPais.pais;
                TBSigla.Text = oPais.sigla;
                TBDDI.Text = oPais.ddi;
                TBDataCad.Text = oPais.datacad.ToString();
                TBDataUltAlt.Text = oPais.dataUltAlt.ToString();
                TBUserUltAlt.Text = oPais.userUltAlt.usuario;
            }
        }

        protected override void Recarregar()
        {
            DGVPaises.DataSource = aControllerPaises.GetDS();
        }

        protected override void Incluir()
        {
            if (TBPais.Text.Length == 0)
            {
                MessageBox.Show("O campo país é obrigatório!");
                TBPais.Focus();
            }
            else if (TBSigla.Text.Length == 0)
            {
                MessageBox.Show("O campo sigla é obrigatório!");
                TBSigla.Focus();
            }
            else if (TBDDI.Text.Length == 0)
            {
                MessageBox.Show("O campo DDI é obrigatório!");
                TBDDI.Focus();
            }
            else
            {
                oPais.pais = TBPais.Text;
                oPais.sigla = TBSigla.Text;
                oPais.ddi = TBDDI.Text;
                oPais.datacad = new DateTime(DateTime.Now.Year,DateTime.Now.Month, DateTime.Now.Day);
                oPais.dataUltAlt = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
                oPais.userUltAlt = oUsuario;
                aControllerPaises.Salvar(oPais.Clone());
                DGVPaises.DataSource = aControllerPaises.GetDS();
                CurrentID = 0;
                Limpar();
            }
        }

        protected override void Alterar()
        {
            Paises AuxOPais = new Paises();
            AuxOPais.codigo = CurrentID;
            aControllerPaises.Carregar(AuxOPais);
            if (TBPais.Text != AuxOPais.pais || TBSigla.Text != AuxOPais.sigla || TBDDI.Text != AuxOPais.ddi)
            {
                oPais.codigo = Int32.Parse(TBCodigo.Text);
                oPais.pais = TBPais.Text;
                oPais.sigla = TBSigla.Text;
                oPais.ddi = TBDDI.Text;
                oPais.dataUltAlt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                oPais.userUltAlt = oUsuario;
                aControllerPaises.Salvar(oPais.Clone());
                DGVPaises.DataSource = aControllerPaises.GetDS();
                Limpar();
            }
            else
            {
                MessageBox.Show("Não é possível alterar o País, pois não há nenhum valor diferente.");

            }
        }

        protected override void Excluir()
        {
            Paises AuxOPais = new Paises();
            AuxOPais.codigo = CurrentID;
            aControllerPaises.Carregar(AuxOPais);
            Limpar();
            aControllerPaises.Excluir(AuxOPais);
            DGVPaises.DataSource = aControllerPaises.GetDS();
        }

        protected override void Limpar()
        {
            base.Limpar();
            TBPais.Clear();
            TBSigla.Clear();
            TBDDI.Clear();
            AtivaBtn(BtnIncluir);
            AtivaBtn(BtnExcluir);
            CurrentID = 0;
        }

        private void TBPais_TextChanged(object sender, EventArgs e)
        {
            VerificaAlteracao();
        }

        private void TBSigla_TextChanged(object sender, EventArgs e)
        {
            VerificaAlteracao();
        }

        private void TBDDI_TextChanged(object sender, EventArgs e)
        {
            VerificaAlteracao();
        }

        //Evento realizado ao carregar o formulário FrmPaises
        private void FrmPaises_Load(object sender, EventArgs e)
        {
            //Personalizando TextBox
            AddLinhaTB();
            TextBox[] AuxTextBox = { TBPais, TBSigla, TBDDI };
            List<TextBox> TextBoxList = new List<TextBox>();
            TextBoxList.AddRange(AuxTextBox);
            foreach (TextBox TB in TextBoxList)
            {
                TB.AutoSize = false;
                TB.Controls.Add(new Label() { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            }
        }

        //Função exclusiva para identificar se o campo de texto foi alterado ou não, para então ativar/desativar os botões necessários z
        private void VerificaAlteracao()
        {
            if (CurrentID != 0)
            {
                Paises AuxOPais = new Paises();
                AuxOPais.codigo = CurrentID;
                aControllerPaises.Carregar(AuxOPais);
                if (TBPais.Text.Trim() != AuxOPais.pais.Trim() || TBSigla.Text.Trim() != AuxOPais.sigla.Trim() || TBDDI.Text.Trim() != AuxOPais.ddi.Trim())
                {
                    DesativaBtn(BtnExcluir);
                }
                else
                {
                    AtivaBtn(BtnExcluir);
                }
            }
        }

        

        ~FrmPaises()
        {

        }
    }
}
