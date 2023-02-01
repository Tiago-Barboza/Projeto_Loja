namespace Projeto_Sistema
{
    partial class Login
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
            this.TBUser = new ZBobb.AlphaBlendTextBox();
            this.TBSenha = new ZBobb.AlphaBlendTextBox();
            this.IconUser = new FontAwesome.Sharp.IconButton();
            this.IconSenha = new FontAwesome.Sharp.IconButton();
            this.LblErroUser = new System.Windows.Forms.Label();
            this.LblErroSenha = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.BtnLogin = new Projeto_Sistema.Classes.DesignButton();
            this.SuspendLayout();
            // 
            // TBUser
            // 
            this.TBUser.BackAlpha = 0;
            this.TBUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TBUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUser.ForeColor = System.Drawing.Color.White;
            this.TBUser.Location = new System.Drawing.Point(228, 188);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(187, 29);
            this.TBUser.TabIndex = 6;
            // 
            // TBSenha
            // 
            this.TBSenha.BackAlpha = 0;
            this.TBSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TBSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSenha.ForeColor = System.Drawing.Color.White;
            this.TBSenha.Location = new System.Drawing.Point(228, 270);
            this.TBSenha.Name = "TBSenha";
            this.TBSenha.Size = new System.Drawing.Size(187, 29);
            this.TBSenha.TabIndex = 7;
            this.TBSenha.UseSystemPasswordChar = true;
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
            this.IconUser.Location = new System.Drawing.Point(65, 172);
            this.IconUser.Name = "IconUser";
            this.IconUser.Size = new System.Drawing.Size(157, 44);
            this.IconUser.TabIndex = 9;
            this.IconUser.Text = "Usuário";
            this.IconUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconUser.UseVisualStyleBackColor = false;
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
            this.IconSenha.Location = new System.Drawing.Point(65, 254);
            this.IconSenha.Name = "IconSenha";
            this.IconSenha.Size = new System.Drawing.Size(157, 44);
            this.IconSenha.TabIndex = 10;
            this.IconSenha.Text = "Senha";
            this.IconSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconSenha.UseVisualStyleBackColor = false;
            // 
            // LblErroUser
            // 
            this.LblErroUser.AutoSize = true;
            this.LblErroUser.BackColor = System.Drawing.Color.Transparent;
            this.LblErroUser.ForeColor = System.Drawing.Color.Red;
            this.LblErroUser.Location = new System.Drawing.Point(225, 235);
            this.LblErroUser.Name = "LblErroUser";
            this.LblErroUser.Size = new System.Drawing.Size(32, 16);
            this.LblErroUser.TabIndex = 11;
            this.LblErroUser.Text = "Erro";
            this.LblErroUser.Visible = false;
            // 
            // LblErroSenha
            // 
            this.LblErroSenha.AutoSize = true;
            this.LblErroSenha.BackColor = System.Drawing.Color.Transparent;
            this.LblErroSenha.ForeColor = System.Drawing.Color.Red;
            this.LblErroSenha.Location = new System.Drawing.Point(225, 312);
            this.LblErroSenha.Name = "LblErroSenha";
            this.LblErroSenha.Size = new System.Drawing.Size(32, 16);
            this.LblErroSenha.TabIndex = 12;
            this.LblErroSenha.Text = "Erro";
            this.LblErroSenha.Visible = false;
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.LblCadastro.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblCadastro.Location = new System.Drawing.Point(209, 466);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(84, 16);
            this.LblCadastro.TabIndex = 13;
            this.LblCadastro.Text = "Se cadastrar";
            this.LblCadastro.Click += new System.EventHandler(this.LblCadastro_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(179, 388);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(182, 55);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(517, 537);
            this.Controls.Add(this.LblCadastro);
            this.Controls.Add(this.LblErroSenha);
            this.Controls.Add(this.LblErroUser);
            this.Controls.Add(this.IconSenha);
            this.Controls.Add(this.IconUser);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TBSenha);
            this.Controls.Add(this.TBUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(517, 537);
            this.MinimumSize = new System.Drawing.Size(517, 537);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZBobb.AlphaBlendTextBox TBUser;
        private ZBobb.AlphaBlendTextBox TBSenha;
        private Classes.DesignButton BtnLogin;
        private FontAwesome.Sharp.IconButton IconUser;
        private FontAwesome.Sharp.IconButton IconSenha;
        private System.Windows.Forms.Label LblErroUser;
        private System.Windows.Forms.Label LblErroSenha;
        private System.Windows.Forms.Label LblCadastro;
    }
}

