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
            //dt = combo.getCombosTodays().Tables[0];
            dt = combo.getCombos().Tables[0];
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
                       row.Cells["importe"].Value = Convert.ToInt32(row.Cells["Cantidad"].Value) * Convert.ToDouble(row.Cells["price"].Value); 
                       founded = true;
                    }  
                }
                // si no encontro el combo en la lista añadelo
                if (!founded)
                {
                    double precio_combo = combo.getPrice(Convert.ToInt32(dt.Rows[0]["Idcombo"]));
                    dgvpedido.Rows.Add(dt.Rows[0]["Idcombo"], dt.Rows[0]["nombre"], 1, precio_combo, precio_combo);
                                    
                }
            }
            // sum total
            this.txttotal.Text = DGV.sumColumnFromDatagridView(this.dgvpedido, "importe").ToString();
        }

        // Fill Cajero Username to the gridview
        public void fillUsernameToTextbox()
        {
            Usuario usuario = new Usuario();
            this.txtNombreCajero.Text = usuario.getUsuarioById(session.userId).Tables[0].Rows[0]["username"].ToString();
        
        }

        // fill turnoTextBox

        public void fillTurnoTextBox()
        {
            Turno turno = new Turno();
            this.txtturno.Text = turno.getTurnoDescripcionByControlTurno(session.idControlTurno);
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
            // fill username
            this.fillUsernameToTextbox();

            // fill turno textBox
            this.fillTurnoTextBox();
            // set total a pagar to 0
            this.txttotal.Text = Convert.ToString(0);
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
                bool found = false; // flag to see ifthe article selected exits 
                int pos = doform.dgvData.CurrentCell.RowIndex;
                // add row to extra datagridview with the articulo selected
                int idarticulo = Convert.ToInt32(doform.dgvData.Rows[pos].Cells["idarticulo"].Value);
                string nombre = doform.dgvData.Rows[pos].Cells["nombre"].Value.ToString();
                //string descripcion = doform.dgvData.Rows[pos].Cells["descripcion"].Value.ToString();
                double precio = Convert.ToDouble(doform.dgvData.Rows[pos].Cells["Precio"].Value);
                // look if exits in dgv the article selected
                foreach (DataGridViewRow row in this.dgvExtras.Rows)
                {
                    if (Convert.ToInt32(row.Cells["artidarticulo"].Value) == idarticulo)
                    {
                        row.Cells["artCantidad"].Value = Convert.ToInt32(row.Cells["artCantidad"].Value) + 1;
                        row.Cells["artImporte"].Value = Convert.ToDouble( Convert.ToInt32(row.Cells["artCantidad"].Value) * Convert.ToDouble(row.Cells["artPUnitario"].Value));
                        found = true;
                    }
                }
                // si no encontro el articulo, añadelo como nuevo
                if(!found)
                {
                    this.dgvExtras.Rows.Add(idarticulo, nombre, precio, 1, precio);
                }
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
            pedido.Pago_con = Convert.ToDouble(this.txtPagarCon.Text.Trim());
            // agregar turno
            pedido.Control_turno = session.idControlTurno;
            //pedido.Control_turno = 1;
            // getting the idpedido and create pedido
            idpedido = pedido.createPedido(pedido);
            // creando detalle de pedido para combos
            foreach(DataGridViewRow row in dgvpedido.Rows)
            {
                pedido.Idpedido = idpedido;
                pedido.Idcombo = Convert.ToInt32(row.Cells["idcombo"].Value);
                pedido.Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                pedido.Precio = Convert.ToDouble(row.Cells["price"].Value);
                pedido.insertDetailToPedidoCombo(pedido);
            }

            // crear detalle de pedido para articulos
            foreach (DataGridViewRow row in dgvExtras.Rows)
            {
                pedido.Idpedido = idpedido;
                pedido.Idcombo = Convert.ToInt32(row.Cells["idcombo"].Value);
                pedido.Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                pedido.Precio = Convert.ToDouble(row.Cells["price"].Value);
                pedido.insertDetailToPedidoCombo(pedido);
            }
            // agregar a caja el total del pedido
            //session.total_en_caja += Convert.ToDouble(this.txttotal.Text.Trim());
            // generar reporte
            DataSet ds = pedido.getPedidoDetailsById(idpedido);
            PReport frmreport = new PReport("presentation.Reports.RPedido.rdlc", ds);
            frmreport.Show();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblfecha.Text = DateTime.Now.ToString();
        }

        private void txtPagarCon_TextChanged(object sender, EventArgs e)
        {
            // total, pagar con, cambio
            double pagar_con = 0;
            if(this.txttotal.Text == string.Empty) this.txttotal.Text = Convert.ToString(0);
            if(txtPagarCon.Text.Trim() != string.Empty)
            {
                pagar_con = Convert.ToDouble(this.txtPagarCon.Text.Trim());
            }

            this.txtcambio.Text = (pagar_con - Convert.ToDouble(this.txttotal.Text.Trim())).ToString();
            if(Convert.ToDouble(txtcambio.Text.Trim()) < 0)
            {
                this.txtcambio.Text = Convert.ToString(0);
            }
        }

        private void dgvExtras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
