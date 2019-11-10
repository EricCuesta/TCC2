﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantoã_Arquitetura.Screens.Manager.Stock
{
    public partial class frmDeleteSupplies : Form
    {
        public frmDeleteSupplies()
        {
            InitializeComponent();
        }

        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudID.Value);

            Business.SupplyBusiness bussupply = new Business.SupplyBusiness();
            Database.Entities.tb_supply supply = bussupply.ConsultarPorID(id);

            if (supply == null)
            {
                txtNome.Text = string.Empty;
                nudQuantidade.Value = 0;
                nudValor.Value = Convert.ToDecimal("0,00");
                rtxtDescrição.Text = string.Empty;
            }
            else
            {
                txtNome.Text = supply.nm_supply;
                nudQuantidade.Value = supply.vl_amount;
                nudValor.Value = supply.vl_value;
                rtxtDescrição.Text = supply.ds_note;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudID.Value);

            Business.SupplyBusiness bussupplies = new Business.SupplyBusiness();
            bussupplies.Remover(id);

            MessageBox.Show("Suprimento deletado com sucesso");
        }
    }
}
