namespace Projeto_Sistema
{
    partial class Menu
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BtnVendas = new FontAwesome.Sharp.IconButton();
            this.BtnCompras = new FontAwesome.Sharp.IconButton();
            this.BtnProdutos = new FontAwesome.Sharp.IconButton();
            this.BtnFuncionarios = new FontAwesome.Sharp.IconButton();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.BtnCidades = new FontAwesome.Sharp.IconButton();
            this.BtnEstados = new FontAwesome.Sharp.IconButton();
            this.BtnPaises = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.IconTitleChildForm = new FontAwesome.Sharp.IconButton();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.MenuPanel.Controls.Add(this.BtnVendas);
            this.MenuPanel.Controls.Add(this.BtnCompras);
            this.MenuPanel.Controls.Add(this.BtnProdutos);
            this.MenuPanel.Controls.Add(this.BtnFuncionarios);
            this.MenuPanel.Controls.Add(this.BtnClientes);
            this.MenuPanel.Controls.Add(this.BtnCidades);
            this.MenuPanel.Controls.Add(this.BtnEstados);
            this.MenuPanel.Controls.Add(this.BtnPaises);
            this.MenuPanel.Controls.Add(this.panel2);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(172, 648);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // BtnVendas
            // 
            this.BtnVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVendas.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnVendas.FlatAppearance.BorderSize = 0;
            this.BtnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVendas.ForeColor = System.Drawing.Color.White;
            this.BtnVendas.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.BtnVendas.IconColor = System.Drawing.Color.White;
            this.BtnVendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVendas.IconSize = 32;
            this.BtnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVendas.Location = new System.Drawing.Point(0, 473);
            this.BtnVendas.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVendas.Name = "BtnVendas";
            this.BtnVendas.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnVendas.Size = new System.Drawing.Size(172, 49);
            this.BtnVendas.TabIndex = 8;
            this.BtnVendas.Text = "Vendas";
            this.BtnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVendas.UseVisualStyleBackColor = false;
            this.BtnVendas.Click += new System.EventHandler(this.BtnVendas_Click);
            // 
            // BtnCompras
            // 
            this.BtnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCompras.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCompras.FlatAppearance.BorderSize = 0;
            this.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompras.ForeColor = System.Drawing.Color.White;
            this.BtnCompras.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.BtnCompras.IconColor = System.Drawing.Color.White;
            this.BtnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCompras.IconSize = 32;
            this.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.Location = new System.Drawing.Point(0, 424);
            this.BtnCompras.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnCompras.Size = new System.Drawing.Size(172, 49);
            this.BtnCompras.TabIndex = 7;
            this.BtnCompras.Text = "Compras";
            this.BtnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCompras.UseVisualStyleBackColor = false;
            this.BtnCompras.Click += new System.EventHandler(this.BtnCompras_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProdutos.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnProdutos.FlatAppearance.BorderSize = 0;
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.ForeColor = System.Drawing.Color.White;
            this.BtnProdutos.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.BtnProdutos.IconColor = System.Drawing.Color.White;
            this.BtnProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProdutos.IconSize = 32;
            this.BtnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdutos.Location = new System.Drawing.Point(0, 375);
            this.BtnProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnProdutos.Size = new System.Drawing.Size(172, 49);
            this.BtnProdutos.TabIndex = 6;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProdutos.UseVisualStyleBackColor = false;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // BtnFuncionarios
            // 
            this.BtnFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFuncionarios.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnFuncionarios.FlatAppearance.BorderSize = 0;
            this.BtnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.BtnFuncionarios.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.BtnFuncionarios.IconColor = System.Drawing.Color.White;
            this.BtnFuncionarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFuncionarios.IconSize = 32;
            this.BtnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFuncionarios.Location = new System.Drawing.Point(0, 326);
            this.BtnFuncionarios.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFuncionarios.Name = "BtnFuncionarios";
            this.BtnFuncionarios.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnFuncionarios.Size = new System.Drawing.Size(172, 49);
            this.BtnFuncionarios.TabIndex = 5;
            this.BtnFuncionarios.Text = "Funcinoários";
            this.BtnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFuncionarios.UseVisualStyleBackColor = false;
            this.BtnFuncionarios.Click += new System.EventHandler(this.BtnFuncionarios_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.ForeColor = System.Drawing.Color.White;
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.BtnClientes.IconColor = System.Drawing.Color.White;
            this.BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClientes.IconSize = 32;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 277);
            this.BtnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnClientes.Size = new System.Drawing.Size(172, 49);
            this.BtnClientes.TabIndex = 4;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnCidades
            // 
            this.BtnCidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnCidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCidades.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCidades.FlatAppearance.BorderSize = 0;
            this.BtnCidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCidades.ForeColor = System.Drawing.Color.White;
            this.BtnCidades.IconChar = FontAwesome.Sharp.IconChar.City;
            this.BtnCidades.IconColor = System.Drawing.Color.White;
            this.BtnCidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCidades.IconSize = 32;
            this.BtnCidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCidades.Location = new System.Drawing.Point(0, 228);
            this.BtnCidades.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCidades.Name = "BtnCidades";
            this.BtnCidades.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnCidades.Size = new System.Drawing.Size(172, 49);
            this.BtnCidades.TabIndex = 3;
            this.BtnCidades.Text = "Cidades";
            this.BtnCidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCidades.UseVisualStyleBackColor = false;
            this.BtnCidades.Click += new System.EventHandler(this.BtnCidades_Click);
            // 
            // BtnEstados
            // 
            this.BtnEstados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnEstados.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEstados.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnEstados.FlatAppearance.BorderSize = 0;
            this.BtnEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstados.ForeColor = System.Drawing.Color.White;
            this.BtnEstados.IconChar = FontAwesome.Sharp.IconChar.Flag;
            this.BtnEstados.IconColor = System.Drawing.Color.White;
            this.BtnEstados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEstados.IconSize = 32;
            this.BtnEstados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstados.Location = new System.Drawing.Point(0, 179);
            this.BtnEstados.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEstados.Name = "BtnEstados";
            this.BtnEstados.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnEstados.Size = new System.Drawing.Size(172, 49);
            this.BtnEstados.TabIndex = 2;
            this.BtnEstados.Text = "Estados";
            this.BtnEstados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEstados.UseVisualStyleBackColor = false;
            this.BtnEstados.Click += new System.EventHandler(this.BtnEstados_Click);
            // 
            // BtnPaises
            // 
            this.BtnPaises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnPaises.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPaises.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnPaises.FlatAppearance.BorderSize = 0;
            this.BtnPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPaises.ForeColor = System.Drawing.Color.White;
            this.BtnPaises.IconChar = FontAwesome.Sharp.IconChar.EarthAmericas;
            this.BtnPaises.IconColor = System.Drawing.Color.White;
            this.BtnPaises.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPaises.IconSize = 32;
            this.BtnPaises.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPaises.Location = new System.Drawing.Point(0, 130);
            this.BtnPaises.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPaises.Name = "BtnPaises";
            this.BtnPaises.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnPaises.Size = new System.Drawing.Size(172, 49);
            this.BtnPaises.TabIndex = 1;
            this.BtnPaises.Text = "Países";
            this.BtnPaises.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPaises.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPaises.UseVisualStyleBackColor = false;
            this.BtnPaises.Click += new System.EventHandler(this.BtnPaises_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.BtnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 130);
            this.panel2.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.Image = global::Projeto_Sistema.Properties.Resources.sommaroy_high_resolution_logo_color_on_transparent_background__2_;
            this.BtnHome.Location = new System.Drawing.Point(2, 10);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(170, 114);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHome.TabIndex = 0;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelDesktop.Location = new System.Drawing.Point(172, 124);
            this.PanelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(1139, 524);
            this.PanelDesktop.TabIndex = 3;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelTitle.Controls.Add(this.BtnMinimizar);
            this.PanelTitle.Controls.Add(this.BtnSair);
            this.PanelTitle.Controls.Add(this.IconTitleChildForm);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(172, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(1139, 124);
            this.PanelTitle.TabIndex = 4;
            this.PanelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTitle_Paint);
            // 
            // IconTitleChildForm
            // 
            this.IconTitleChildForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IconTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.IconTitleChildForm.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.IconTitleChildForm.FlatAppearance.BorderSize = 0;
            this.IconTitleChildForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.IconTitleChildForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.IconTitleChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.IconTitleChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconTitleChildForm.IconColor = System.Drawing.Color.White;
            this.IconTitleChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconTitleChildForm.IconSize = 32;
            this.IconTitleChildForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconTitleChildForm.Location = new System.Drawing.Point(530, 57);
            this.IconTitleChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.IconTitleChildForm.Name = "IconTitleChildForm";
            this.IconTitleChildForm.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.IconTitleChildForm.Size = new System.Drawing.Size(152, 36);
            this.IconTitleChildForm.TabIndex = 0;
            this.IconTitleChildForm.Text = "Home";
            this.IconTitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconTitleChildForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconTitleChildForm.UseVisualStyleBackColor = false;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Transparent;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.Red;
            this.BtnSair.Location = new System.Drawing.Point(1100, 3);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(25, 32);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            this.BtnSair.MouseLeave += new System.EventHandler(this.BtnSair_MouseLeave);
            this.BtnSair.MouseHover += new System.EventHandler(this.BtnSair_MouseHover);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.ForeColor = System.Drawing.Color.Green;
            this.BtnMinimizar.Location = new System.Drawing.Point(1058, -4);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(26, 39);
            this.BtnMinimizar.TabIndex = 4;
            this.BtnMinimizar.Text = "__";
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            this.BtnMinimizar.MouseLeave += new System.EventHandler(this.BtnMinimizar_MouseLeave);
            this.BtnMinimizar.MouseHover += new System.EventHandler(this.BtnMinimizar_MouseHover);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1311, 648);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.MenuPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MenuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private FontAwesome.Sharp.IconButton BtnVendas;
        private FontAwesome.Sharp.IconButton BtnCompras;
        private FontAwesome.Sharp.IconButton BtnProdutos;
        private FontAwesome.Sharp.IconButton BtnFuncionarios;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private FontAwesome.Sharp.IconButton BtnCidades;
        private FontAwesome.Sharp.IconButton BtnEstados;
        private FontAwesome.Sharp.IconButton BtnPaises;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.Panel PanelTitle;
        private FontAwesome.Sharp.IconButton IconTitleChildForm;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button BtnSair;
    }
}