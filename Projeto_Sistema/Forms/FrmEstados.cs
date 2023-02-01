using Projeto_Sistema.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Sistema.Forms
{
    public partial class FrmEstados : Projeto_Sistema.Forms.FrmPai
    {
        private Estados oEstado;
        private CtrlEstados aCtrlEstados;
        private int CurrentID = 0;
        public FrmEstados()
        {
            InitializeComponent();
            oEstado = new Estados();
            aCtrlEstados = new CtrlEstados();

            DGVEstados.DataSource = aCtrlEstados.GetDS();
        }

        protected override void Pesquisar()
        {
            base.Pesquisar();
        }

        protected override void Selecionar()
        {
            int id = Int32.Parse(DGVEstados.CurrentRow.Cells[0].Value.ToString());
            CurrentID = id;
            if (id > 0)
            {
                AddLinhaMaskedTB();
                DesativaBtn(BtnExcluir);
                oEstado.codigo = id;
                string resultado = aCtrlEstados.Carregar(oEstado);
                if (resultado == "")
                {
                    TBCodigo.Text = oEstado.codigo.ToString();
                    TBDataCad.Text = oEstado.datacad.ToString("dd/MM/yyyy");
                    TBDataUltAlt.Text = oEstado.dataUltAlt.ToString("dd/MM/yyyy");
                    TBUserUltAlt.Text = oEstado.userUltAlt.usuario;
                    TBEstado.Text = oEstado.estado;
                    TBUF.Text = oEstado.uf;
                    TBCodPais.Text = oEstado.opais.codigo.ToString();
                    TBPais.Text = oEstado.opais.pais;
                }
            }
            else
            {
                MessageBox.Show("Selecione um país");
            }
        }

        protected override void Recarregar()
        {
            DGVEstados.DataSource = aCtrlEstados.GetDS();
        }

        protected override void Incluir()
        {
            if (TBEstado.Text.Length == 0)
            {
                MessageBox.Show("O campo Estado é obrigatório.");
                TBEstado.Focus();
            }
            else if (TBUF.Text.Length == 0)
            {
                MessageBox.Show("O campo UF é obrigatório.");
                TBUF.Focus();
            }
            else if (TBCodPais.Text.Length == 0)
            {
                MessageBox.Show("O campo Cód. País é obrigatório.");
                TBCodPais.Focus();
            }
            else if (TBPais.Text.Length == 0)
            {
                MessageBox.Show("O campo País é obrigatório.");
                TBPais.Focus();
            }
            else
            {
                oEstado.codigo = Int32.Parse(TBCodigo.Text);
                oEstado.estado = TBEstado.Text;
                oEstado.uf = TBUF.Text;
                oEstado.datacad = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
                oEstado.dataUltAlt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                oEstado.userUltAlt = oUsuario;
                aCtrlEstados.Salvar(oEstado.Clone());
                DGVEstados.DataSource = aCtrlEstados.GetDS();
                CurrentID = 0;
                Limpar();
            }
        }

        protected override void Alterar()
        {
            Estados AuxOEstado = new Estados();
            oEstado.codigo = CurrentID;
            aCtrlEstados.Carregar(oEstado);
            if (TBEstado.Text.Trim() == oEstado.estado.Trim() || TBUF.Text.Trim() == oEstado.uf.Trim() || TBCodPais.Text.Trim() == oEstado.opais.codigo.ToString()) 
            {

            }
        }

        private void BtnPesquisarPais_Click(object sender, EventArgs e)
        {

        }
    }
}
