namespace Projeto_Sistema.Forms
{
    partial class FrmPai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBPesquisar = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new FontAwesome.Sharp.IconButton();
            this.BtnSelecionar = new FontAwesome.Sharp.IconButton();
            this.BtnRecarregar = new FontAwesome.Sharp.IconButton();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblDataCad = new System.Windows.Forms.Label();
            this.LblDataUltAlt = new System.Windows.Forms.Label();
            this.LblUserUltAlt = new System.Windows.Forms.Label();
            this.TBDataCad = new System.Windows.Forms.MaskedTextBox();
            this.TBDataUltAlt = new System.Windows.Forms.MaskedTextBox();
            this.TBUserUltAlt = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new Projeto_Sistema.Classes.DesignButton();
            this.BtnExcluir = new Projeto_Sistema.Classes.DesignButton();
            this.BtnAlterar = new Projeto_Sistema.Classes.DesignButton();
            this.BtnIncluir = new Projeto_Sistema.Classes.DesignButton();
            this.SuspendLayout();
            // 
            // TBPesquisar
            // 
            this.TBPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TBPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPesquisar.Location = new System.Drawing.Point(12, 12);
            this.TBPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPesquisar.Name = "TBPesquisar";
            this.TBPesquisar.Size = new System.Drawing.Size(561, 23);
            this.TBPesquisar.TabIndex = 4;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.FlatAppearance.BorderSize = 0;
            this.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnPesquisar.IconColor = System.Drawing.Color.White;
            this.BtnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPesquisar.IconSize = 35;
            this.BtnPesquisar.Location = new System.Drawing.Point(579, 7);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(41, 33);
            this.BtnPesquisar.TabIndex = 5;
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.FlatAppearance.BorderSize = 0;
            this.BtnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelecionar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnSelecionar.IconColor = System.Drawing.Color.White;
            this.BtnSelecionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSelecionar.IconSize = 35;
            this.BtnSelecionar.Location = new System.Drawing.Point(7, 529);
            this.BtnSelecionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(41, 33);
            this.BtnSelecionar.TabIndex = 6;
            this.BtnSelecionar.UseVisualStyleBackColor = true;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // BtnRecarregar
            // 
            this.BtnRecarregar.FlatAppearance.BorderSize = 0;
            this.BtnRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecarregar.IconChar = FontAwesome.Sharp.IconChar.RotateRight;
            this.BtnRecarregar.IconColor = System.Drawing.Color.White;
            this.BtnRecarregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRecarregar.IconSize = 35;
            this.BtnRecarregar.Location = new System.Drawing.Point(816, 529);
            this.BtnRecarregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRecarregar.Name = "BtnRecarregar";
            this.BtnRecarregar.Size = new System.Drawing.Size(41, 33);
            this.BtnRecarregar.TabIndex = 7;
            this.BtnRecarregar.UseVisualStyleBackColor = true;
            this.BtnRecarregar.Click += new System.EventHandler(this.BtnRecarregar_Click);
            // 
            // TBCodigo
            // 
            this.TBCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TBCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBCodigo.Enabled = false;
            this.TBCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigo.ForeColor = System.Drawing.Color.White;
            this.TBCodigo.Location = new System.Drawing.Point(926, 74);
            this.TBCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(56, 23);
            this.TBCodigo.TabIndex = 9;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.White;
            this.LblCodigo.Location = new System.Drawing.Point(923, 39);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(61, 20);
            this.LblCodigo.TabIndex = 10;
            this.LblCodigo.Text = "Código";
            // 
            // LblDataCad
            // 
            this.LblDataCad.AutoSize = true;
            this.LblDataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataCad.ForeColor = System.Drawing.Color.White;
            this.LblDataCad.Location = new System.Drawing.Point(923, 494);
            this.LblDataCad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDataCad.Name = "LblDataCad";
            this.LblDataCad.Size = new System.Drawing.Size(84, 20);
            this.LblDataCad.TabIndex = 12;
            this.LblDataCad.Text = "Data Cad.";
            // 
            // LblDataUltAlt
            // 
            this.LblDataUltAlt.AutoSize = true;
            this.LblDataUltAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataUltAlt.ForeColor = System.Drawing.Color.White;
            this.LblDataUltAlt.Location = new System.Drawing.Point(1077, 494);
            this.LblDataUltAlt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDataUltAlt.Name = "LblDataUltAlt";
            this.LblDataUltAlt.Size = new System.Drawing.Size(108, 20);
            this.LblDataUltAlt.TabIndex = 14;
            this.LblDataUltAlt.Text = "Data. Ult. Alt.";
            // 
            // LblUserUltAlt
            // 
            this.LblUserUltAlt.AutoSize = true;
            this.LblUserUltAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserUltAlt.ForeColor = System.Drawing.Color.White;
            this.LblUserUltAlt.Location = new System.Drawing.Point(1233, 494);
            this.LblUserUltAlt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserUltAlt.Name = "LblUserUltAlt";
            this.LblUserUltAlt.Size = new System.Drawing.Size(104, 20);
            this.LblUserUltAlt.TabIndex = 16;
            this.LblUserUltAlt.Text = "User Ult. Alt.";
            // 
            // TBDataCad
            // 
            this.TBDataCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TBDataCad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBDataCad.Enabled = false;
            this.TBDataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDataCad.Location = new System.Drawing.Point(923, 537);
            this.TBDataCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBDataCad.Mask = "00/00/0000";
            this.TBDataCad.Name = "TBDataCad";
            this.TBDataCad.Size = new System.Drawing.Size(137, 23);
            this.TBDataCad.TabIndex = 17;
            // 
            // TBDataUltAlt
            // 
            this.TBDataUltAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TBDataUltAlt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBDataUltAlt.Enabled = false;
            this.TBDataUltAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDataUltAlt.Location = new System.Drawing.Point(1077, 537);
            this.TBDataUltAlt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBDataUltAlt.Mask = "00/00/0000";
            this.TBDataUltAlt.Name = "TBDataUltAlt";
            this.TBDataUltAlt.Size = new System.Drawing.Size(137, 23);
            this.TBDataUltAlt.TabIndex = 18;
            // 
            // TBUserUltAlt
            // 
            this.TBUserUltAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.TBUserUltAlt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBUserUltAlt.Enabled = false;
            this.TBUserUltAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUserUltAlt.Location = new System.Drawing.Point(1238, 533);
            this.TBUserUltAlt.Margin = new System.Windows.Forms.Padding(4);
            this.TBUserUltAlt.Name = "TBUserUltAlt";
            this.TBUserUltAlt.Size = new System.Drawing.Size(133, 23);
            this.TBUserUltAlt.TabIndex = 20;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(1654, 335);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 33);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(1654, 277);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(115, 33);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnAlterar.FlatAppearance.BorderSize = 0;
            this.BtnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.BtnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.ForeColor = System.Drawing.Color.White;
            this.BtnAlterar.Location = new System.Drawing.Point(1654, 225);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(115, 33);
            this.BtnAlterar.TabIndex = 1;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnIncluir.FlatAppearance.BorderSize = 0;
            this.BtnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.BtnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncluir.ForeColor = System.Drawing.Color.White;
            this.BtnIncluir.Location = new System.Drawing.Point(1654, 172);
            this.BtnIncluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(115, 33);
            this.BtnIncluir.TabIndex = 0;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = false;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // FrmPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1794, 587);
            this.Controls.Add(this.TBUserUltAlt);
            this.Controls.Add(this.TBDataUltAlt);
            this.Controls.Add(this.TBDataCad);
            this.Controls.Add(this.LblUserUltAlt);
            this.Controls.Add(this.LblDataUltAlt);
            this.Controls.Add(this.LblDataCad);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.TBCodigo);
            this.Controls.Add(this.BtnRecarregar);
            this.Controls.Add(this.BtnSelecionar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.TBPesquisar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnIncluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPai";
            this.Text = "FrmPai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Classes.DesignButton BtnIncluir;
        protected Classes.DesignButton BtnAlterar;
        protected Classes.DesignButton BtnExcluir;
        protected Classes.DesignButton BtnCancelar;
        protected System.Windows.Forms.TextBox TBPesquisar;
        protected FontAwesome.Sharp.IconButton BtnPesquisar;
        protected FontAwesome.Sharp.IconButton BtnSelecionar;
        protected FontAwesome.Sharp.IconButton BtnRecarregar;
        protected System.Windows.Forms.TextBox TBCodigo;
        protected System.Windows.Forms.Label LblCodigo;
        protected System.Windows.Forms.Label LblDataCad;
        protected System.Windows.Forms.Label LblDataUltAlt;
        protected System.Windows.Forms.Label LblUserUltAlt;
        protected System.Windows.Forms.MaskedTextBox TBDataCad;
        protected System.Windows.Forms.MaskedTextBox TBDataUltAlt;
        protected System.Windows.Forms.TextBox TBUserUltAlt;
    }
}