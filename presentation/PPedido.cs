using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using presentation.Reports;
using data;
using utils;

namespace presentation
{
    public partial class PPedido : Form
    {
        // dataStructure to save buttons vs combos relations
        // keys <button_name> = Idcombo
        Dictionary<string, int> combosDic = new Dictionary<string, int>();

        // put an image from database to a button
        public void setImageToButtonFromDatabase(Button button, DataRow dr)
        {
            byte[] imagenBuffer = (byte[])dr["image"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            button.BackgroundImage = Image.FromStream(ms);
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // factory function to put all button the images
        public void setImagesButtons()
        {
            Combo combo = new Combo();
            DataTable dt = new DataTable();
            dt = combo.getCombosTodays().Tables[0];
            int cont = 1;
            foreach (DataRow dr in dt.Rows)
            {
                Button btn = this.Controls.Find("btncombo" + cont.ToString(), true).FirstOrDefault() as Button;
                this.setImageToButtonFromDatabase(btn, dr);
                // save in the DataStructure the combo with the button
                combosDic[btn.Name] = Convert.ToInt32(dr["Idcombo"]);
                cont++;     
            }
            // disable buttons that do not have combos
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Name.Contains("btncombo"))
                {
                    if(!combosDic.ContainsKey(control.Name))
                    {
                        control.Enabled = false;
                    }   
                }

            }

            /*
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    messages.successMessage(control.Name);
                }

            }
             * */
        }

        // add items from buttons to pedidos
        public void addComboDetailToPedido(object sender)
        {
            // getting the trigger button name
            string trigger_button_name;
            var trigger = (Button)sender;
            trigger_button_name = trigger.Name;
            Combo combo = new Combo();
            //this.dgvpedido.DataSource = combo.getComboDetails(this.combosDic[trigger_button_name]).Tables[0];
            //this.dgvpedido.DataSource = combo.getComboById(this.combosDic[trigger_button_name]).Tables[0];
            //this.lbltotalcant.Text = DGV.sumColumnFromDatagridView(this.dgvpedido, "Precio").ToString() + " $";
            
            DataTable dt = combo.getComboById(this.combosDic[trigger_button_name]).Tables[0];
            bool founded = false;
            if(dt != null && dt.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvpedido.Rows)
                {
                    // si encontro el combo, sumale uno al existente
                    if (Convert.ToInt32(row.Cells["Idcombo"].Value) == this.combosDic[trigger_button_name])
                    {
                       row.Cells["Cantidad"].Value = Convert.ToInt32(row.Cells["Cantidad"].Value) + 1;
                       founded = true;
                    }  
                }
                // si no encontro el combo en la lista añadelo
                if (!founded)
                {
                    double precio_combo = combo.getPrice(Convert.ToInt32(dt.Rows[0]["Idcombo"]));
                    dgvpedido.Rows.Add(dt.Rows[0]["Idcombo"], dt.Rows[0]["nombre"], 1, precio_combo);
                }
            }
        }

        // add a row to Extras DatagridView
        public void addRowToExtraDagridView(int idarticulo, string nombre, string descripcion, double precio)
        {
            this.dgvExtras.Rows.Add(idarticulo, nombre, descripcion, precio);

        }

        public PPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.addComboDetailToPedido(sender);
        }

        private void PPedido_Load(object sender, EventArgs e)
        {
            this.setImagesButtons();
            // añadir tipos de pedidos a combo

            cmbTipoPedido.Items.AddRange(configuration.tipos_pedidos.ToArray());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            print.printDictionary(this.combosDic);
        }

        private void btncombo2_Click(object sender, EventArgs e)
        {
            this.addComboDetailToPedido(sender);
        }

        private void btncombo3_Click(object sender, EventArgs e)
        {
            this.addComboDetailToPedido(sender);
        }

        private void btncombo4_Click(object sender, EventArgs e)
        {
            this.addComboDetailToPedido(sender);
        }

        private void btncombo5_Click(object sender, EventArgs e)
        {
            this.addComboDetailToPedido(sender);
        }

        private void btncombo6_Click(object sender, EventArgs e)
        {
            this.addComboDetailToPedido(sender);
        }

        private void btncombo7_Click(object sender, EventArgs e)
        {
            this.addComboDetailToPedido(sender);
        }

        private void btncombo8_Click(object sender, EventArgs e)
        {
            this.addComboDetailToPedido(sender);
        }

        private void btncombo9_Click(object sender, EventArgs e)
        {
            this.addComboDetailToPedido(sender);
        }

        private void btncombo10_Click(object sender, EventArgs e)
        {
            this.addComboDetailToPedido(sender);
        }

        private void btncombo11_Click(object sender, EventArgs e)
        {
            this.addComboDetailToPedido(sender);
        }

        private void btncombo12_Click(object sender, EventArgs e)
        {
            this.addComboDetailToPedido(sender);
        }

        private void dgvpedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            PVistaArticulos doform = new PVistaArticulos();
            if (doform.ShowDialog() == DialogResult.OK)
            {
                int pos = doform.dgvData.CurrentCell.RowIndex;
                // add row to extra datagridview with the articulo selected
                int idarticulo = Convert.ToInt32(doform.dgvData.Rows[pos].Cells["idarticulo"].Value);
                string nombre = doform.dgvData.Rows[pos].Cells["nombre"].Value.ToString();
                string descripcion = doform.dgvData.Rows[pos].Cells["descripcion"].Value.ToString();
                double precio = Convert.ToDouble(doform.dgvData.Rows[pos].Cells["Precio"].Value);
                this.addRowToExtraDagridView(idarticulo, nombre, descripcion, precio);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // deleted selected from datagridView
            DGV.deleteSelectedRowFromDatagridView(this.dgvExtras);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            PVistaCliente doform = new PVistaCliente();
            if (doform.ShowDialog() == DialogResult.OK)
            {
                int pos = doform.dgvData.CurrentCell.RowIndex;
                // add row to extra datagridview with the articulo selected
                this.txtidcliente.Text = doform.dgvData.Rows[pos].Cells["Idcliente"].Value.ToString();
                this.txtnombre_cliente.Text = doform.dgvData.Rows[pos].Cells["nombre"].Value.ToString();
                this.txtdireccion.Text = doform.dgvData.Rows[pos].Cells["direccion"].Value.ToString();


            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            int idpedido;
            // creando pedido
            pedido.Idcliente = Convert.ToInt32(this.txtidcliente.Text.Trim());
            pedido.Tipo_pedido = cmbTipoPedido.Text.Trim();
            pedido.Idusuario = session.userId;
            // getting the idpedido and create pedido
            idpedido = pedido.createPedido(pedido);
            // creando detalle de pedido
            foreach(DataGridViewRow row in dgvpedido.Rows)
            {
                pedido.Idpedido = idpedido;
                pedido.Idcombo = Convert.ToInt32(row.Cells["idcombo"].Value);
                pedido.Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                pedido.Precio = Convert.ToDouble(row.Cells["price"].Value);
                pedido.insertDetailToPedido(pedido);
            }

            // generar reporte
            DataSet ds = pedido.getPedidoDetailsById(idpedido);
            PReport frmreport = new PReport("presentation.Reports.RPedido.rdlc", ds);
            frmreport.Show();
           
        }
    }
}
