namespace Projeto_Sistema.Forms
{
    partial class FrmCadastroUsuarios
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
            this.IconSenha = new FontAwesome.Sharp.IconButton();
            this.IconUser = new FontAwesome.Sharp.IconButton();
            this.TBSenha = new ZBobb.AlphaBlendTextBox();
            this.TBUser = new ZBobb.AlphaBlendTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.TBEmail = new ZBobb.AlphaBlendTextBox();
            this.BtnCadastrar = new Projeto_Sistema.Classes.DesignButton();
            this.LblErroUser = new System.Windows.Forms.Label();
            this.LblErroSenha = new System.Windows.Forms.Label();
            this.LblErroEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IconSenha
            // 
            this.IconSenha.BackColor = System.Drawing.Color.Transparent;
            this.IconSenha.FlatAppearance.BorderSize = 0;
            this.IconSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.IconSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.IconSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IconSenha.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.IconSenha.IconColor = System.Drawing.Color.White;
            this.IconSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconSenha.IconSize = 35;
            this.IconSenha.Location = new System.Drawing.Point(84, 243);
            this.IconSenha.Name = "IconSenha";
            this.IconSenha.Size = new System.Drawing.Size(157, 44);
            this.IconSenha.TabIndex = 16;
            this.IconSenha.Text = "Senha";
            this.IconSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconSenha.UseVisualStyleBackColor = false;
            // 
            // IconUser
            // 
            this.IconUser.BackColor = System.Drawing.Color.Transparent;
            this.IconUser.FlatAppearance.BorderSize = 0;
            this.IconUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.IconUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.IconUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.IconUser.IconColor = System.Drawing.Color.White;
            this.IconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconUser.IconSize = 35;
            this.IconUser.Location = new System.Drawing.Point(84, 161);
            this.IconUser.Name = "IconUser";
            this.IconUser.Size = new System.Drawing.Size(157, 44);
            this.IconUser.TabIndex = 15;
            this.IconUser.Text = "Usuário";
            this.IconUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconUser.UseVisualStyleBackColor = false;
            // 
            // TBSenha
            // 
            this.TBSenha.BackAlpha = 0;
            this.TBSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TBSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSenha.ForeColor = System.Drawing.Color.White;
            this.TBSenha.Location = new System.Drawing.Point(247, 259);
            this.TBSenha.Name = "TBSenha";
            this.TBSenha.Size = new System.Drawing.Size(187, 29);
            this.TBSenha.TabIndex = 14;
            this.TBSenha.UseSystemPasswordChar = true;
            // 
            // TBUser
            // 
            this.TBUser.BackAlpha = 0;
            this.TBUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TBUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUser.ForeColor = System.Drawing.Color.White;
            this.TBUser.Location = new System.Drawing.Point(247, 177);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(187, 29);
            this.TBUser.TabIndex = 13;
            this.TBUser.TextChanged += new System.EventHandler(this.TBUser_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(84, 325);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(157, 44);
            this.iconButton1.TabIndex = 18;
            this.iconButton1.Text = "Email";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // TBEmail
            // 
            this.TBEmail.BackAlpha = 0;
            this.TBEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TBEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmail.ForeColor = System.Drawing.Color.White;
            this.TBEmail.Location = new System.Drawing.Point(247, 341);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(187, 29);
            this.TBEmail.TabIndex = 17;
            this.TBEmail.UseSystemPasswordChar = true;
            this.TBEmail.TextChanged += new System.EventHandler(this.TBEmail_TextChanged);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnCadastrar.FlatAppearance.BorderSize = 0;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(181, 431);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(182, 55);
            this.BtnCadastrar.TabIndex = 19;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // LblErroUser
            // 
            this.LblErroUser.AutoSize = true;
            this.LblErroUser.BackColor = System.Drawing.Color.Transparent;
            this.LblErroUser.ForeColor = System.Drawing.Color.Red;
            this.LblErroUser.Location = new System.Drawing.Point(244, 224);
            this.LblErroUser.Name = "LblErroUser";
            this.LblErroUser.Size = new System.Drawing.Size(82, 16);
            this.LblErroUser.TabIndex = 20;
            this.LblErroUser.Text = "Erro Usuário";
            this.LblErroUser.Visible = false;
            // 
            // LblErroSenha
            // 
            this.LblErroSenha.AutoSize = true;
            this.LblErroSenha.BackColor = System.Drawing.Color.Transparent;
            this.LblErroSenha.ForeColor = System.Drawing.Color.Red;
            this.LblErroSenha.Location = new System.Drawing.Point(244, 309);
            this.LblErroSenha.Name = "LblErroSenha";
            this.LblErroSenha.Size = new System.Drawing.Size(74, 16);
            this.LblErroSenha.TabIndex = 21;
            this.LblErroSenha.Text = "Erro Senha";
            this.LblErroSenha.Visible = false;
            // 
            // LblErroEmail
            // 
            this.LblErroEmail.AutoSize = true;
            this.LblErroEmail.BackColor = System.Drawing.Color.Transparent;
            this.LblErroEmail.ForeColor = System.Drawing.Color.Red;
            this.LblErroEmail.Location = new System.Drawing.Point(244, 387);
            this.LblErroEmail.Name = "LblErroEmail";
            this.LblErroEmail.Size = new System.Drawing.Size(69, 16);
            this.LblErroEmail.TabIndex = 22;
            this.LblErroEmail.Text = "Erro Email";
            this.LblErroEmail.Visible = false;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(517, 537);
            this.Controls.Add(this.LblErroEmail);
            this.Controls.Add(this.LblErroSenha);
            this.Controls.Add(this.LblErroUser);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.IconSenha);
            this.Controls.Add(this.IconUser);
            this.Controls.Add(this.TBSenha);
            this.Controls.Add(this.TBUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(517, 537);
            this.MinimumSize = new System.Drawing.Size(517, 537);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCadastro";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmCadastro_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton IconSenha;
        private FontAwesome.Sharp.IconButton IconUser;
        private ZBobb.AlphaBlendTextBox TBSenha;
        private ZBobb.AlphaBlendTextBox TBUser;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ZBobb.AlphaBlendTextBox TBEmail;
        private Classes.DesignButton BtnCadastrar;
        private System.Windows.Forms.Label LblErroUser;
        private System.Windows.Forms.Label LblErroSenha;
        private System.Windows.Forms.Label LblErroEmail;
    }
}