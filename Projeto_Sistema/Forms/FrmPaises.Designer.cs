namespace Projeto_Sistema.Forms
{
    partial class FrmPaises
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBPais = new System.Windows.Forms.TextBox();
            this.LblPais = new System.Windows.Forms.Label();
            this.LblSigla = new System.Windows.Forms.Label();
            this.TBSigla = new System.Windows.Forms.TextBox();
            this.TBDDI = new System.Windows.Forms.TextBox();
            this.LblDDI = new System.Windows.Forms.Label();
            this.DGVPaises = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.FlatAppearance.BorderSize = 0;
            this.BtnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.BtnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.FlatAppearance.BorderSize = 0;
            this.BtnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.BtnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            // 
            // TBPesquisar
            // 
            this.TBPesquisar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.FlatAppearance.BorderSize = 0;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.FlatAppearance.BorderSize = 0;
            // 
            // BtnRecarregar
            // 
            this.BtnRecarregar.FlatAppearance.BorderSize = 0;
            // 
            // TBCodigo
            // 
            this.TBCodigo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // TBDataCad
            // 
            this.TBDataCad.Margin = new System.Windows.Forms.Padding(5);
            // 
            // TBDataUltAlt
            // 
            this.TBDataUltAlt.Margin = new System.Windows.Forms.Padding(5);
            // 
            // TBUserUltAlt
            // 
            this.TBUserUltAlt.Margin = new System.Windows.Forms.Padding(5);
            // 
            // TBPais
            // 
            this.TBPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TBPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPais.ForeColor = System.Drawing.Color.White;
            this.TBPais.Location = new System.Drawing.Point(1013, 74);
            this.TBPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPais.Name = "TBPais";
            this.TBPais.Size = new System.Drawing.Size(568, 23);
            this.TBPais.TabIndex = 11;
            this.TBPais.TextChanged += new System.EventHandler(this.TBPais_TextChanged);
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPais.ForeColor = System.Drawing.Color.White;
            this.LblPais.Location = new System.Drawing.Point(1009, 39);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(42, 20);
            this.LblPais.TabIndex = 12;
            this.LblPais.Text = "País";
            // 
            // LblSigla
            // 
            this.LblSigla.AutoSize = true;
            this.LblSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSigla.ForeColor = System.Drawing.Color.White;
            this.LblSigla.Location = new System.Drawing.Point(922, 127);
            this.LblSigla.Name = "LblSigla";
            this.LblSigla.Size = new System.Drawing.Size(46, 20);
            this.LblSigla.TabIndex = 13;
            this.LblSigla.Text = "Sigla";
            // 
            // TBSigla
            // 
            this.TBSigla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TBSigla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSigla.ForeColor = System.Drawing.Color.White;
            this.TBSigla.Location = new System.Drawing.Point(925, 159);
            this.TBSigla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBSigla.Name = "TBSigla";
            this.TBSigla.Size = new System.Drawing.Size(100, 23);
            this.TBSigla.TabIndex = 14;
            this.TBSigla.TextChanged += new System.EventHandler(this.TBSigla_TextChanged);
            // 
            // TBDDI
            // 
            this.TBDDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TBDDI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBDDI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBDDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDDI.ForeColor = System.Drawing.Color.White;
            this.TBDDI.Location = new System.Drawing.Point(1081, 159);
            this.TBDDI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBDDI.Name = "TBDDI";
            this.TBDDI.Size = new System.Drawing.Size(100, 23);
            this.TBDDI.TabIndex = 16;
            this.TBDDI.TextChanged += new System.EventHandler(this.TBDDI_TextChanged);
            // 
            // LblDDI
            // 
            this.LblDDI.AutoSize = true;
            this.LblDDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDDI.ForeColor = System.Drawing.Color.White;
            this.LblDDI.Location = new System.Drawing.Point(1078, 127);
            this.LblDDI.Name = "LblDDI";
            this.LblDDI.Size = new System.Drawing.Size(39, 20);
            this.LblDDI.TabIndex = 15;
            this.LblDDI.Text = "DDI";
            // 
            // DGVPaises
            // 
            this.DGVPaises.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DGVPaises.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPaises.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DGVPaises.Location = new System.Drawing.Point(12, 46);
            this.DGVPaises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVPaises.Name = "DGVPaises";
            this.DGVPaises.RowHeadersWidth = 51;
            this.DGVPaises.RowTemplate.Height = 24;
            this.DGVPaises.Size = new System.Drawing.Size(850, 478);
            this.DGVPaises.TabIndex = 17;
            // 
            // FrmPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1794, 587);
            this.Controls.Add(this.DGVPaises);
            this.Controls.Add(this.TBDDI);
            this.Controls.Add(this.LblDDI);
            this.Controls.Add(this.TBSigla);
            this.Controls.Add(this.LblSigla);
            this.Controls.Add(this.LblPais);
            this.Controls.Add(this.TBPais);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmPaises";
            this.Load += new System.EventHandler(this.FrmPaises_Load);
            this.Controls.SetChildIndex(this.TBDataCad, 0);
            this.Controls.SetChildIndex(this.LblDataCad, 0);
            this.Controls.SetChildIndex(this.TBDataUltAlt, 0);
            this.Controls.SetChildIndex(this.LblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.TBUserUltAlt, 0);
            this.Controls.SetChildIndex(this.LblUserUltAlt, 0);
            this.Controls.SetChildIndex(this.BtnIncluir, 0);
            this.Controls.SetChildIndex(this.BtnAlterar, 0);
            this.Controls.SetChildIndex(this.BtnExcluir, 0);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.TBPesquisar, 0);
            this.Controls.SetChildIndex(this.BtnPesquisar, 0);
            this.Controls.SetChildIndex(this.BtnSelecionar, 0);
            this.Controls.SetChildIndex(this.BtnRecarregar, 0);
            this.Controls.SetChildIndex(this.TBCodigo, 0);
            this.Controls.SetChildIndex(this.LblCodigo, 0);
            this.Controls.SetChildIndex(this.TBPais, 0);
            this.Controls.SetChildIndex(this.LblPais, 0);
            this.Controls.SetChildIndex(this.LblSigla, 0);
            this.Controls.SetChildIndex(this.TBSigla, 0);
            this.Controls.SetChildIndex(this.LblDDI, 0);
            this.Controls.SetChildIndex(this.TBDDI, 0);
            this.Controls.SetChildIndex(this.DGVPaises, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBPais;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.Label LblSigla;
        private System.Windows.Forms.TextBox TBSigla;
        private System.Windows.Forms.TextBox TBDDI;
        private System.Windows.Forms.Label LblDDI;
        private System.Windows.Forms.DataGridView DGVPaises;
    }
}
