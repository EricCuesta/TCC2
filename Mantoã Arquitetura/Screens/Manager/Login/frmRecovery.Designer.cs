﻿namespace Mantoã_Arquitetura.Screens.Manager.Login
{
    partial class frmRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecovery));
            this.panelAlterarSenha = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imgSenha = new System.Windows.Forms.PictureBox();
            this.panelSubMenuCelular = new System.Windows.Forms.Panel();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.panelSubMenuCPF = new System.Windows.Forms.Panel();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.panelSubMenuRG = new System.Windows.Forms.Panel();
            this.lblRG = new System.Windows.Forms.Label();
            this.mtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.panelOpção = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOpção = new System.Windows.Forms.ComboBox();
            this.panelTítulo = new System.Windows.Forms.Panel();
            this.imgVoltar = new System.Windows.Forms.PictureBox();
            this.imgFechar = new System.Windows.Forms.PictureBox();
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            this.lblAlterarSenha = new System.Windows.Forms.Label();
            this.panelAlterarSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSenha)).BeginInit();
            this.panelSubMenuCelular.SuspendLayout();
            this.panelSubMenuCPF.SuspendLayout();
            this.panelSubMenuRG.SuspendLayout();
            this.panelOpção.SuspendLayout();
            this.panelTítulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlterarSenha
            // 
            this.panelAlterarSenha.BackColor = System.Drawing.Color.Transparent;
            this.panelAlterarSenha.Controls.Add(this.txtSenha);
            this.panelAlterarSenha.Controls.Add(this.dataGridView1);
            this.panelAlterarSenha.Controls.Add(this.imgSenha);
            this.panelAlterarSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlterarSenha.Location = new System.Drawing.Point(0, 171);
            this.panelAlterarSenha.Name = "panelAlterarSenha";
            this.panelAlterarSenha.Size = new System.Drawing.Size(400, 57);
            this.panelAlterarSenha.TabIndex = 329;
            this.panelAlterarSenha.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(63, 24);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(331, 19);
            this.txtSenha.TabIndex = 250;
            this.txtSenha.Text = "Senha do usuário";
            this.txtSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSenha_MouseClick);
            this.txtSenha.MouseLeave += new System.EventHandler(this.txtSenha_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 2);
            this.dataGridView1.TabIndex = 249;
            // 
            // imgSenha
            // 
            this.imgSenha.Image = global::Mantoã_Arquitetura.Properties.Resources.Senha;
            this.imgSenha.Location = new System.Drawing.Point(12, 6);
            this.imgSenha.Name = "imgSenha";
            this.imgSenha.Size = new System.Drawing.Size(45, 45);
            this.imgSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSenha.TabIndex = 248;
            this.imgSenha.TabStop = false;
            // 
            // panelSubMenuCelular
            // 
            this.panelSubMenuCelular.BackColor = System.Drawing.Color.Transparent;
            this.panelSubMenuCelular.Controls.Add(this.mtxtCelular);
            this.panelSubMenuCelular.Controls.Add(this.lblCelular);
            this.panelSubMenuCelular.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCelular.Location = new System.Drawing.Point(0, 141);
            this.panelSubMenuCelular.Name = "panelSubMenuCelular";
            this.panelSubMenuCelular.Size = new System.Drawing.Size(400, 30);
            this.panelSubMenuCelular.TabIndex = 333;
            this.panelSubMenuCelular.Visible = false;
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.mtxtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtCelular.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCelular.ForeColor = System.Drawing.Color.White;
            this.mtxtCelular.Location = new System.Drawing.Point(75, 5);
            this.mtxtCelular.Mask = "(000) 00000-0000";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(319, 19);
            this.mtxtCelular.TabIndex = 509;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.White;
            this.lblCelular.Location = new System.Drawing.Point(8, 5);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(61, 19);
            this.lblCelular.TabIndex = 507;
            this.lblCelular.Text = "Celular:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.Black;
            this.btnVerificar.Location = new System.Drawing.Point(127, 452);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(131, 36);
            this.btnVerificar.TabIndex = 328;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(127, 452);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(131, 36);
            this.btnAlterar.TabIndex = 326;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // panelSubMenuCPF
            // 
            this.panelSubMenuCPF.BackColor = System.Drawing.Color.Transparent;
            this.panelSubMenuCPF.Controls.Add(this.mtxtCPF);
            this.panelSubMenuCPF.Controls.Add(this.lblCPF);
            this.panelSubMenuCPF.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCPF.Location = new System.Drawing.Point(0, 111);
            this.panelSubMenuCPF.Name = "panelSubMenuCPF";
            this.panelSubMenuCPF.Size = new System.Drawing.Size(400, 30);
            this.panelSubMenuCPF.TabIndex = 332;
            this.panelSubMenuCPF.Visible = false;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.mtxtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtCPF.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCPF.ForeColor = System.Drawing.Color.White;
            this.mtxtCPF.Location = new System.Drawing.Point(53, 5);
            this.mtxtCPF.Mask = "000000000/00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(341, 19);
            this.mtxtCPF.TabIndex = 508;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(8, 5);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(39, 19);
            this.lblCPF.TabIndex = 507;
            this.lblCPF.Text = "CPF:";
            // 
            // panelSubMenuRG
            // 
            this.panelSubMenuRG.BackColor = System.Drawing.Color.Transparent;
            this.panelSubMenuRG.Controls.Add(this.lblRG);
            this.panelSubMenuRG.Controls.Add(this.mtxtRG);
            this.panelSubMenuRG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuRG.Location = new System.Drawing.Point(0, 81);
            this.panelSubMenuRG.Name = "panelSubMenuRG";
            this.panelSubMenuRG.Size = new System.Drawing.Size(400, 30);
            this.panelSubMenuRG.TabIndex = 331;
            this.panelSubMenuRG.Visible = false;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.ForeColor = System.Drawing.Color.White;
            this.lblRG.Location = new System.Drawing.Point(8, 5);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(33, 19);
            this.lblRG.TabIndex = 507;
            this.lblRG.Text = "RG:";
            // 
            // mtxtRG
            // 
            this.mtxtRG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.mtxtRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtRG.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtRG.ForeColor = System.Drawing.Color.White;
            this.mtxtRG.Location = new System.Drawing.Point(47, 5);
            this.mtxtRG.Mask = "00.000.000-0";
            this.mtxtRG.Name = "mtxtRG";
            this.mtxtRG.Size = new System.Drawing.Size(347, 19);
            this.mtxtRG.TabIndex = 247;
            // 
            // panelOpção
            // 
            this.panelOpção.BackColor = System.Drawing.Color.Transparent;
            this.panelOpção.Controls.Add(this.label1);
            this.panelOpção.Controls.Add(this.cboOpção);
            this.panelOpção.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpção.Location = new System.Drawing.Point(0, 35);
            this.panelOpção.Name = "panelOpção";
            this.panelOpção.Size = new System.Drawing.Size(400, 46);
            this.panelOpção.TabIndex = 330;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 508;
            this.label1.Text = "Escolha uma opção:";
            // 
            // cboOpção
            // 
            this.cboOpção.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboOpção.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboOpção.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpção.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOpção.FormattingEnabled = true;
            this.cboOpção.Items.AddRange(new object[] {
            "RG",
            "CPF",
            "Número do Celular"});
            this.cboOpção.Location = new System.Drawing.Point(0, 21);
            this.cboOpção.Name = "cboOpção";
            this.cboOpção.Size = new System.Drawing.Size(400, 21);
            this.cboOpção.TabIndex = 321;
            this.cboOpção.SelectedIndexChanged += new System.EventHandler(this.cboOpção_SelectedIndexChanged);
            // 
            // panelTítulo
            // 
            this.panelTítulo.BackColor = System.Drawing.Color.Transparent;
            this.panelTítulo.Controls.Add(this.imgVoltar);
            this.panelTítulo.Controls.Add(this.imgFechar);
            this.panelTítulo.Controls.Add(this.imgMinimizar);
            this.panelTítulo.Controls.Add(this.lblAlterarSenha);
            this.panelTítulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTítulo.Location = new System.Drawing.Point(0, 0);
            this.panelTítulo.Name = "panelTítulo";
            this.panelTítulo.Size = new System.Drawing.Size(400, 35);
            this.panelTítulo.TabIndex = 327;
            // 
            // imgVoltar
            // 
            this.imgVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgVoltar.Image = global::Mantoã_Arquitetura.Properties.Resources.Voltar01;
            this.imgVoltar.Location = new System.Drawing.Point(4, 5);
            this.imgVoltar.Name = "imgVoltar";
            this.imgVoltar.Size = new System.Drawing.Size(25, 25);
            this.imgVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVoltar.TabIndex = 370;
            this.imgVoltar.TabStop = false;
            this.imgVoltar.Click += new System.EventHandler(this.imgVoltar_Click);
            this.imgVoltar.MouseEnter += new System.EventHandler(this.imgVoltar_MouseEnter);
            this.imgVoltar.MouseLeave += new System.EventHandler(this.imgVoltar_MouseLeave);
            // 
            // imgFechar
            // 
            this.imgFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgFechar.BackColor = System.Drawing.Color.Transparent;
            this.imgFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFechar.Image = global::Mantoã_Arquitetura.Properties.Resources.Fechar01;
            this.imgFechar.Location = new System.Drawing.Point(371, 5);
            this.imgFechar.Name = "imgFechar";
            this.imgFechar.Size = new System.Drawing.Size(25, 25);
            this.imgFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFechar.TabIndex = 369;
            this.imgFechar.TabStop = false;
            this.imgFechar.Click += new System.EventHandler(this.imgFechar_Click);
            this.imgFechar.MouseEnter += new System.EventHandler(this.imgFechar_MouseEnter);
            this.imgFechar.MouseLeave += new System.EventHandler(this.imgFechar_MouseLeave);
            // 
            // imgMinimizar
            // 
            this.imgMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.imgMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinimizar.Image = global::Mantoã_Arquitetura.Properties.Resources.Minimizar01;
            this.imgMinimizar.Location = new System.Drawing.Point(340, 5);
            this.imgMinimizar.Name = "imgMinimizar";
            this.imgMinimizar.Size = new System.Drawing.Size(25, 25);
            this.imgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMinimizar.TabIndex = 368;
            this.imgMinimizar.TabStop = false;
            this.imgMinimizar.Click += new System.EventHandler(this.imgMinimizar_Click);
            this.imgMinimizar.MouseEnter += new System.EventHandler(this.imgMinimizar_MouseEnter);
            this.imgMinimizar.MouseLeave += new System.EventHandler(this.imgMinimizar_MouseLeave);
            // 
            // lblAlterarSenha
            // 
            this.lblAlterarSenha.AutoSize = true;
            this.lblAlterarSenha.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarSenha.ForeColor = System.Drawing.Color.White;
            this.lblAlterarSenha.Location = new System.Drawing.Point(107, 3);
            this.lblAlterarSenha.Name = "lblAlterarSenha";
            this.lblAlterarSenha.Size = new System.Drawing.Size(183, 28);
            this.lblAlterarSenha.TabIndex = 0;
            this.lblAlterarSenha.Text = "Alterar Senha";
            // 
            // frmRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.panelAlterarSenha);
            this.Controls.Add(this.panelSubMenuCelular);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.panelSubMenuCPF);
            this.Controls.Add(this.panelSubMenuRG);
            this.Controls.Add(this.panelOpção);
            this.Controls.Add(this.panelTítulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recovery";
            this.panelAlterarSenha.ResumeLayout(false);
            this.panelAlterarSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSenha)).EndInit();
            this.panelSubMenuCelular.ResumeLayout(false);
            this.panelSubMenuCelular.PerformLayout();
            this.panelSubMenuCPF.ResumeLayout(false);
            this.panelSubMenuCPF.PerformLayout();
            this.panelSubMenuRG.ResumeLayout(false);
            this.panelSubMenuRG.PerformLayout();
            this.panelOpção.ResumeLayout(false);
            this.panelOpção.PerformLayout();
            this.panelTítulo.ResumeLayout(false);
            this.panelTítulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAlterarSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox imgSenha;
        private System.Windows.Forms.Panel panelSubMenuCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel panelSubMenuCPF;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Panel panelSubMenuRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mtxtRG;
        private System.Windows.Forms.Panel panelOpção;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOpção;
        private System.Windows.Forms.Panel panelTítulo;
        private System.Windows.Forms.PictureBox imgVoltar;
        private System.Windows.Forms.PictureBox imgFechar;
        private System.Windows.Forms.PictureBox imgMinimizar;
        private System.Windows.Forms.Label lblAlterarSenha;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
    }
}