using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantoã_Arquitetura.Screens.Manager.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entities.tb_employees emp = new Database.Entities.tb_employees();
                emp.ds_email = Model.LoginModel.Email = txtEmail.Text.Trim();
                emp.pw_password = Model.LoginModel.Senha = txtSenha.Text.Trim();

                Business.EmployeesBusiness busemp = new Business.EmployeesBusiness();
                bool verificacao = busemp.Login(emp);

                if (verificacao == true)
                {
                    frmMenu tela = new frmMenu();
                    tela.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuário Inexistente!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgFechar_MouseEnter(object sender, EventArgs e)
        {
            imgFechar.Image = Properties.Resources.Fechar01;
            imgFechar.Image = Properties.Resources.Fechar02;
        }

        private void imgFechar_MouseLeave(object sender, EventArgs e)
        {
            imgFechar.Image = Properties.Resources.Fechar02;
            imgFechar.Image = Properties.Resources.Fechar01;
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgMinimizar_MouseEnter(object sender, EventArgs e)
        {
            imgMinimizar.Image = Properties.Resources.Minimizar01;
            imgMinimizar.Image = Properties.Resources.Minimizar02;
        }

        private void imgMinimizar_MouseLeave(object sender, EventArgs e)
        {
            imgMinimizar.Image = Properties.Resources.Minimizar02;
            imgMinimizar.Image = Properties.Resources.Minimizar01;
        }

        private void lblRecuperarSenha_Click(object sender, EventArgs e)
        {
            frmRecovery recovery = new frmRecovery();
            recovery.Show();
            Hide();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email do usuário")
                txtEmail.Clear();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
                txtEmail.Text = "Email do usuário";
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha do usuário")
            {
                txtSenha.Clear();
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == string.Empty)
            {
                txtSenha.Text = "Senha do usuário";
                txtSenha.UseSystemPasswordChar = false;
            }

        }
    }
}
