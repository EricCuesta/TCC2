﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantoã_Arquitetura.Screens.Manager.HumanResources
{
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string rg0 = mtxtRG.Text.Trim();
            string mesAno = mtxtAno.Text.Trim();

            Model.PayrollModel.data = mesAno;
            Model.PayrollModel.RG = rg0;

            Business.FinancialBusiness FB = new Business.FinancialBusiness();
            string r = FB.Verificar(mesAno, rg0);

            if (r != "")
            {
                MessageBox.Show(r);
            }
            else
            {
                int mes = Convert.ToInt32(mesAno.Substring(0, 2));
                int ano = Convert.ToInt32(mesAno.Substring(3, 4));

                string rg1 = rg0.Substring(0, 2);
                string rg2 = rg0.Substring(3, 3);
                string rg3 = rg0.Substring(7, 5);
                string rg = rg1 + "." + rg2 + "." + rg3;

                FB.Consultar(rg);

                lblBruto.Text = FB.Bruto();
                lblSalário.Text = FB.Bruto();
                lblDependentes.Text = FB.Dependents();
                lblHorasÁPagar.Text = FB.HorasÁPagar();
                lblValeTransporte.Text = FB.ValeTransporte(ano, mes);
                txtNomeDoFuncionário.Text = FB.NomeCompleto();
                lblValeAlimentação.Text = FB.ValeAlimentação(ano, mes);
                lblLíquido.Text = FB.Liquido();
            }
        }
    }
}
