using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using data;
using utils;

namespace presentation
{
    public partial class PPedido : Form
    {
        // dataStructure to save buttons vs combos relations
        // keys <button_name> = idcombo
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
            int cont = 0;
            foreach (DataRow dr in dt.Rows)
            {
                cont++;
                switch (cont)
                {
                    case 1:
                        {
                            this.setImageToButtonFromDatabase(this.btncombo1, dr);
                            // save in the DataStructure the combo with the button
                            combosDic[this.btncombo1.Name] = Convert.ToInt32(dr["idcombo"]); 
                            break;
                        }
                    case 2:
                        {
                            this.setImageToButtonFromDatabase(this.btncombo2, dr);
                            combosDic[this.btncombo2.Name] = Convert.ToInt32(dr["idcombo"]); 
                            break;
                        }
                    case 3:
                        {
                            this.setImageToButtonFromDatabase(this.btncombo3, dr);
                            combosDic[this.btncombo3.Name] = Convert.ToInt32(dr["idcombo"]); 
                            break;
                        }
                    case 4:
                        {
                            this.setImageToButtonFromDatabase(this.btncombo4, dr);
                            combosDic[this.btncombo4.Name] = Convert.ToInt32(dr["idcombo"]); 
                            break;
                        }
                    case 5:
                        {
                            this.setImageToButtonFromDatabase(this.btncombo5, dr);
                            combosDic[this.btncombo5.Name] = Convert.ToInt32(dr["idcombo"]); 
                            break;
                        }
                    case 6:
                        {
                            this.setImageToButtonFromDatabase(this.btncombo6, dr);
                            combosDic[this.btncombo6.Name] = Convert.ToInt32(dr["idcombo"]); 
                            break;
                        }
                    case 7:
                        {
                            this.setImageToButtonFromDatabase(this.btncombo7, dr);
                            combosDic[this.btncombo7.Name] = Convert.ToInt32(dr["idcombo"]); 
                            break;
                        }
                    case 8:
                        {
                            this.setImageToButtonFromDatabase(this.btncombo8, dr);
                            combosDic[this.btncombo8.Name] = Convert.ToInt32(dr["idcombo"]); 
                            break;
                        }
                    case 9:
                        {
                            this.setImageToButtonFromDatabase(this.btncombo9, dr);
                            combosDic[this.btncombo9.Name] = Convert.ToInt32(dr["idcombo"]); 
                            break;
                        }
                    case 10:
                        {
                            this.setImageToButtonFromDatabase(this.btncombo10, dr);
                            combosDic[this.btncombo10.Name] = Convert.ToInt32(dr["idcombo"]); 
                            break;
                        }
                    case 11:
                        {
                            this.setImageToButtonFromDatabase(this.btncombo11, dr);
                            combosDic[this.btncombo11.Name] = Convert.ToInt32(dr["idcombo"]); 
                            break;
                        }
                    case 12:
                        {
                            this.setImageToButtonFromDatabase(this.btncombo12, dr);
                            combosDic[this.btncombo12.Name] = Convert.ToInt32(dr["idcombo"]); 
                            break;
                        }

                }

            }
        }

        // add items from buttons to pedidos
        public void addComboDetailToPedido(object sender)
        {
             // getting the trigger button name
            string trigger_button_name;
            var trigger =  (Button) sender;
            trigger_button_name = trigger.Name;
            Combo combo = new Combo();
            this.dgvpedido.DataSource = combo.getComboDetails(this.combosDic[trigger_button_name]).Tables[0];
            this.lbltotalcant.Text = DGV.sumColumnFromDatagridView(this.dgvpedido, "precio").ToString() + " $";
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
    }
}
