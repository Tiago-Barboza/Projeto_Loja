namespace Projeto_Sistema.Forms
{
    partial class FrmEstados
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
            this.TBEstado = new System.Windows.Forms.TextBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblUF = new System.Windows.Forms.Label();
            this.TBUF = new System.Windows.Forms.TextBox();
            this.LblCodPais = new System.Windows.Forms.Label();
            this.TBCodPais = new System.Windows.Forms.TextBox();
            this.LblPais = new System.Windows.Forms.Label();
            this.TBPais = new System.Windows.Forms.TextBox();
            this.DGVEstados = new System.Windows.Forms.DataGridView();
            this.BtnPesquisarPais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEstados)).BeginInit();
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
            // TBEstado
            // 
            this.TBEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TBEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEstado.ForeColor = System.Drawing.Color.White;
            this.TBEstado.Location = new System.Drawing.Point(1014, 74);
            this.TBEstado.Name = "TBEstado";
            this.TBEstado.Size = new System.Drawing.Size(590, 23);
            this.TBEstado.TabIndex = 21;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.BackColor = System.Drawing.Color.Transparent;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.ForeColor = System.Drawing.Color.White;
            this.LblEstado.Location = new System.Drawing.Point(1010, 39);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(61, 20);
            this.LblEstado.TabIndex = 22;
            this.LblEstado.Text = "Estado";
            // 
            // LblUF
            // 
            this.LblUF.AutoSize = true;
            this.LblUF.BackColor = System.Drawing.Color.Transparent;
            this.LblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUF.ForeColor = System.Drawing.Color.White;
            this.LblUF.Location = new System.Drawing.Point(922, 118);
            this.LblUF.Name = "LblUF";
            this.LblUF.Size = new System.Drawing.Size(31, 20);
            this.LblUF.TabIndex = 24;
            this.LblUF.Text = "UF";
            // 
            // TBUF
            // 
            this.TBUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TBUF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUF.ForeColor = System.Drawing.Color.White;
            this.TBUF.Location = new System.Drawing.Point(926, 153);
            this.TBUF.Name = "TBUF";
            this.TBUF.Size = new System.Drawing.Size(58, 23);
            this.TBUF.TabIndex = 23;
            // 
            // LblCodPais
            // 
            this.LblCodPais.AutoSize = true;
            this.LblCodPais.BackColor = System.Drawing.Color.Transparent;
            this.LblCodPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodPais.ForeColor = System.Drawing.Color.White;
            this.LblCodPais.Location = new System.Drawing.Point(920, 190);
            this.LblCodPais.Name = "LblCodPais";
            this.LblCodPais.Size = new System.Drawing.Size(81, 20);
            this.LblCodPais.TabIndex = 26;
            this.LblCodPais.Text = "Cód. País";
            // 
            // TBCodPais
            // 
            this.TBCodPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TBCodPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCodPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodPais.ForeColor = System.Drawing.Color.White;
            this.TBCodPais.Location = new System.Drawing.Point(924, 225);
            this.TBCodPais.Name = "TBCodPais";
            this.TBCodPais.Size = new System.Drawing.Size(77, 23);
            this.TBCodPais.TabIndex = 25;
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.BackColor = System.Drawing.Color.Transparent;
            this.LblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPais.ForeColor = System.Drawing.Color.White;
            this.LblPais.Location = new System.Drawing.Point(1037, 190);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(42, 20);
            this.LblPais.TabIndex = 28;
            this.LblPais.Text = "País";
            // 
            // TBPais
            // 
            this.TBPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TBPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPais.ForeColor = System.Drawing.Color.White;
            this.TBPais.Location = new System.Drawing.Point(1041, 225);
            this.TBPais.Name = "TBPais";
            this.TBPais.Size = new System.Drawing.Size(365, 23);
            this.TBPais.TabIndex = 27;
            // 
            // DGVEstados
            // 
            this.DGVEstados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DGVEstados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEstados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DGVEstados.Location = new System.Drawing.Point(12, 47);
            this.DGVEstados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVEstados.Name = "DGVEstados";
            this.DGVEstados.RowHeadersWidth = 51;
            this.DGVEstados.RowTemplate.Height = 24;
            this.DGVEstados.Size = new System.Drawing.Size(850, 478);
            this.DGVEstados.TabIndex = 29;
            // 
            // BtnPesquisarPais
            // 
            this.BtnPesquisarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisarPais.Location = new System.Drawing.Point(1421, 219);
            this.BtnPesquisarPais.Name = "BtnPesquisarPais";
            this.BtnPesquisarPais.Size = new System.Drawing.Size(94, 29);
            this.BtnPesquisarPais.TabIndex = 30;
            this.BtnPesquisarPais.Text = "Pesquisar";
            this.BtnPesquisarPais.UseVisualStyleBackColor = true;
            this.BtnPesquisarPais.Click += new System.EventHandler(this.BtnPesquisarPais_Click);
            // 
            // FrmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1794, 587);
            this.Controls.Add(this.BtnPesquisarPais);
            this.Controls.Add(this.DGVEstados);
            this.Controls.Add(this.LblPais);
            this.Controls.Add(this.TBPais);
            this.Controls.Add(this.LblCodPais);
            this.Controls.Add(this.TBCodPais);
            this.Controls.Add(this.LblUF);
            this.Controls.Add(this.TBUF);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.TBEstado);
            this.Name = "FrmEstados";
            this.Controls.SetChildIndex(this.TBEstado, 0);
            this.Controls.SetChildIndex(this.LblEstado, 0);
            this.Controls.SetChildIndex(this.TBUF, 0);
            this.Controls.SetChildIndex(this.LblUF, 0);
            this.Controls.SetChildIndex(this.TBCodPais, 0);
            this.Controls.SetChildIndex(this.LblCodPais, 0);
            this.Controls.SetChildIndex(this.TBPais, 0);
            this.Controls.SetChildIndex(this.LblPais, 0);
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
            this.Controls.SetChildIndex(this.LblDataCad, 0);
            this.Controls.SetChildIndex(this.LblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.LblUserUltAlt, 0);
            this.Controls.SetChildIndex(this.TBDataCad, 0);
            this.Controls.SetChildIndex(this.TBDataUltAlt, 0);
            this.Controls.SetChildIndex(this.TBUserUltAlt, 0);
            this.Controls.SetChildIndex(this.DGVEstados, 0);
            this.Controls.SetChildIndex(this.BtnPesquisarPais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBEstado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblUF;
        private System.Windows.Forms.TextBox TBUF;
        private System.Windows.Forms.Label LblCodPais;
        private System.Windows.Forms.TextBox TBCodPais;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.TextBox TBPais;
        private System.Windows.Forms.DataGridView DGVEstados;
        private System.Windows.Forms.Button BtnPesquisarPais;
    }
}
