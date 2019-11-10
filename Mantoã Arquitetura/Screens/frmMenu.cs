using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantoã_Arquitetura.Screens
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            Current = this;
            CustomizeDesign();
        }

        public static frmMenu Current;

        Database.Entities.tb_employees emp;

        private void Horas_Tick(object sender, EventArgs e)
        {
            lblhrs.Text = "Hrs: " + DateTime.Now.ToString("HH:mm:ss");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTítulo_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CustomizeDesign()
        {
            panelSubMenuRecursosHumanos.Visible = false;
            panelSubMenuFinanceiro.Visible = false;
            panelSubMenuFornecedor.Visible = false;
            panelSubMenuEstoque.Visible = false;
            panelSubMenuCRM.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelSubMenuRecursosHumanos.Visible == true)
            {
                panelSubMenuRecursosHumanos.Visible = false;
            }
            if (panelSubMenuFinanceiro.Visible == true)
            {
                panelSubMenuFinanceiro.Visible = false;
            }
            if (panelSubMenuFornecedor.Visible == true)
            {
                panelSubMenuFornecedor.Visible = false;
            }
            if (panelSubMenuEstoque.Visible == true)
            {
                panelSubMenuEstoque.Visible = false;
            }
            if (panelSubMenuCRM.Visible == true)
            {
                panelSubMenuCRM.Visible = false;
            }
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == true)
            {
                HideSubMenu();
                SubMenu.Visible = false;
            }
            else
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
        }

        private void btnRecursosHumanos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuRecursosHumanos);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuFinanceiro);
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuFornecedor);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuEstoque);
        }

        private void btnCRM_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuCRM);
        }

        public Form activeForm = null;
        public void openContedor(Form Contedor)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = Contedor;
            Contedor.TopLevel = false;
            Contedor.FormBorderStyle = FormBorderStyle.None;
            Contedor.Dock = DockStyle.Fill;
            panelContedor.Controls.Add(Contedor);
            panelContedor.Tag = Contedor;
            Contedor.BringToFront();
            panelContedor.Visible = true;
            Contedor.Show();
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnCadastrarFuncionário_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.HumanResources.frmRegisterEmployee());
            HideSubMenu();
        }

        private void btnConsultarFuncionário_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.HumanResources.frmConsultEmployee());
            HideSubMenu();
        }

        private void btnAlterarFuncionário_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.HumanResources.frmChangeEmployee());
            HideSubMenu();
        }

        private void btnDemitirFuncionário_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.HumanResources.frmDismissEmployee());
            HideSubMenu();
        }

        private void btnFolhaDePagamento_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.HumanResources.frmPayroll());
            HideSubMenu();
        }

        private void btnConsultarCartãoDePonto_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.HumanResources.frmConsultTimeCard());
            HideSubMenu();
        }

        private void btnCartãoDePonto_Click(object sender, EventArgs e)
        {
            openContedor(new Employee.frmEmployeeTimeCard());
            HideSubMenu();
        }

        private void btnFluxoDeCaixa_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Financial.frmCashflow());
            HideSubMenu();
        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Financial.frmRegisterAccount());
            HideSubMenu();
        }

        private void btnConsultarConta_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Financial.frmQueryAccount());
            HideSubMenu();
        }

        private void btnAlterarConta_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Financial.frmChangeAccount());
            HideSubMenu();
        }

        private void btnDeletarConta_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Financial.frmDeleteAccount());
            HideSubMenu();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Provider.frmRegisterSupplier());
            HideSubMenu();
        }

        private void btnConsultarFornecedor_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Provider.frmConsultSupplier());
            HideSubMenu();
        }

        private void btnAlterarFornecedor_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Provider.frmChangeProvider());
            HideSubMenu();
        }

        private void btnDeletarFornecedor_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Provider.frmDeleteSupplier());
            HideSubMenu();
        }

        private void btnCadastrarSuprimentos_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Stock.frmRegisterSupplies());
            HideSubMenu();
        }

        private void btnConsultarSuprimentos_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Stock.frmConsultSupplies());
            HideSubMenu();
        }

        private void btnAlterarSuprimentos_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Stock.frmChangeSupplies());
            HideSubMenu();
        }

        private void btnDeletarSuprimentos_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.Stock.frmDeleteSupplies());
            HideSubMenu();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.CRM.frmRegisterCustomer());
            HideSubMenu();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.CRM.frmConsultCustomer());
            HideSubMenu();
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.CRM.frmChangeCustomer());
            HideSubMenu();
        }

        private void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.CRM.frmDeleteClient());
            HideSubMenu();
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            openContedor(new Manager.CRM.frmEmailSending());
            HideSubMenu();
        }
    }
}
