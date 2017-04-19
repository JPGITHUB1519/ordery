﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using data;

namespace presentation
{
    public partial class PAsignarPedidoDelivery : Form
    {
        public void searchDelivery()
        {
            Delivery delivery = new Delivery();
            this.dataGridView1.DataSource = delivery.searchDeliveryByName(this.txtbuscar.Text.Trim()).Tables[0];
        }

        public PAsignarPedidoDelivery()
        {
            InitializeComponent();
        }

        private void PAsignarPedidoDelivery_Load(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            this.dataGridView1.DataSource = delivery.getDeliverys().Tables[0];
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.searchDelivery();
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            this.searchDelivery();
        }
    }
}
