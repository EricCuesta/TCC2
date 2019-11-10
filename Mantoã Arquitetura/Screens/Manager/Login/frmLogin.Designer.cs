namespace Mantoã_Arquitetura.Screens.Manager.Login
{
    partial class frmLogin
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.imgFechar = new System.Windows.Forms.PictureBox();
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            this.lblRecuperarSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imgSenha = new System.Windows.Forms.PictureBox();
            this.imgEmail = new System.Windows.Forms.PictureBox();
            this.imgLogotipo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.LimeGreen;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(70, 378);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(313, 19);
            this.txtSenha.TabIndex = 263;
            this.txtSenha.Text = "Senha do usuário";
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // imgFechar
            // 
            this.imgFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgFechar.BackColor = System.Drawing.Color.Transparent;
            this.imgFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFechar.Image = global::Mantoã_Arquitetura.Properties.Resources.Fechar;
            this.imgFechar.Location = new System.Drawing.Point(368, 6);
            this.imgFechar.Name = "imgFechar";
            this.imgFechar.Size = new System.Drawing.Size(25, 25);
            this.imgFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFechar.TabIndex = 262;
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
            this.imgMinimizar.Image = global::Mantoã_Arquitetura.Properties.Resources.Minimizar;
            this.imgMinimizar.Location = new System.Drawing.Point(337, 6);
            this.imgMinimizar.Name = "imgMinimizar";
            this.imgMinimizar.Size = new System.Drawing.Size(25, 25);
            this.imgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMinimizar.TabIndex = 261;
            this.imgMinimizar.TabStop = false;
            this.imgMinimizar.Click += new System.EventHandler(this.imgMinimizar_Click);
            this.imgMinimizar.MouseEnter += new System.EventHandler(this.imgMinimizar_MouseEnter);
            this.imgMinimizar.MouseLeave += new System.EventHandler(this.imgMinimizar_MouseLeave);
            // 
            // lblRecuperarSenha
            // 
            this.lblRecuperarSenha.AutoSize = true;
            this.lblRecuperarSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblRecuperarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecuperarSenha.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarSenha.ForeColor = System.Drawing.Color.Blue;
            this.lblRecuperarSenha.Location = new System.Drawing.Point(132, 475);
            this.lblRecuperarSenha.Name = "lblRecuperarSenha";
            this.lblRecuperarSenha.Size = new System.Drawing.Size(120, 16);
            this.lblRecuperarSenha.TabIndex = 260;
            this.lblRecuperarSenha.Text = "Esqueceu a senha?";
            this.lblRecuperarSenha.Click += new System.EventHandler(this.lblRecuperarSenha_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LimeGreen;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(70, 304);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(313, 19);
            this.txtEmail.TabIndex = 259;
            this.txtEmail.Text = "Email do usuário";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(128, 426);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(131, 36);
            this.btnEntrar.TabIndex = 258;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(70, 401);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(313, 2);
            this.dataGridView2.TabIndex = 257;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 2);
            this.dataGridView1.TabIndex = 256;
            // 
            // imgSenha
            // 
            this.imgSenha.BackColor = System.Drawing.Color.Transparent;
            this.imgSenha.Image = global::Mantoã_Arquitetura.Properties.Resources.Senha;
            this.imgSenha.Location = new System.Drawing.Point(20, 358);
            this.imgSenha.Name = "imgSenha";
            this.imgSenha.Size = new System.Drawing.Size(45, 45);
            this.imgSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSenha.TabIndex = 255;
            this.imgSenha.TabStop = false;
            // 
            // imgEmail
            // 
            this.imgEmail.BackColor = System.Drawing.Color.Transparent;
            this.imgEmail.Image = global::Mantoã_Arquitetura.Properties.Resources.E_mail;
            this.imgEmail.Location = new System.Drawing.Point(20, 284);
            this.imgEmail.Name = "imgEmail";
            this.imgEmail.Size = new System.Drawing.Size(45, 45);
            this.imgEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEmail.TabIndex = 254;
            this.imgEmail.TabStop = false;
            // 
            // imgLogotipo
            // 
            this.imgLogotipo.Image = global::Mantoã_Arquitetura.Properties.Resources.Logo_DSD_Novo;
            this.imgLogotipo.Location = new System.Drawing.Point(12, 37);
            this.imgLogotipo.Name = "imgLogotipo";
            this.imgLogotipo.Size = new System.Drawing.Size(376, 239);
            this.imgLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogotipo.TabIndex = 253;
            this.imgLogotipo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mantoã_Arquitetura.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.imgFechar);
            this.Controls.Add(this.imgMinimizar);
            this.Controls.Add(this.lblRecuperarSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.imgSenha);
            this.Controls.Add(this.imgEmail);
            this.Controls.Add(this.imgLogotipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogotipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox imgFechar;
        private System.Windows.Forms.PictureBox imgMinimizar;
        private System.Windows.Forms.Label lblRecuperarSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox imgSenha;
        private System.Windows.Forms.PictureBox imgEmail;
        private System.Windows.Forms.PictureBox imgLogotipo;
    }
}