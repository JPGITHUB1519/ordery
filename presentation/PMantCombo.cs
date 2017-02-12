using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utils;
using data;

namespace presentation
{
    public partial class PMantCombo : PMantBase
    {
        public PMantCombo()
        {
            InitializeComponent();
            this.ttpNotification.SetToolTip(this.txtidcombo, "Ingrese Combo");
            this.ttpNotification.SetToolTip(this.txtnombre, "Ingrese Nombre");
            //this.ttpNotification.SetToolTip(this.txtprecio, "Ingrese Precio");
            this.ttpNotification.SetToolTip(this.rchdescripcion, "Ingrese Descripcion");
        }

        // fill datagrid
        public override void fillDatagrid()
        {
            Combo combo = new Combo();
            this.dgvData.DataSource = combo.getCombos().Tables[0];
        }

        // enable / disable
        public override void enable(bool cond)
        {
            this.txtidcombo.ReadOnly = !cond;
            this.txtnombre.ReadOnly = !cond;
            //this.txtprecio.ReadOnly = !cond;
            this.rchdescripcion.ReadOnly = !cond;
        }

        // clearTextBoxes
        public override void clearTextBoxes()
        {
            this.txtidcombo.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            //this.txtprecio.Text = string.Empty;
            this.rchdescripcion.Text = string.Empty;
            this.picPicture.Image = presentation.Properties.Resources.transparent;
        }

        // searchByName Override
        public override void searchByName()
        {
            Combo combo = new Combo();
            this.dgvData.DataSource = combo.searchComboByName(this.txtbuscar.Text.Trim()).Tables[0];
        }

        // save
        public override void guardar()
        {
            string rpta = "";
            Combo combo = new Combo();
            try
            {
                // getting Image buffer from pictureBox
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.picPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] image = ms.GetBuffer();

                if(this.isNew)
                {
                    // creating combo
                    combo.Nombre = this.txtnombre.Text.Trim();
                    //combo.Precio = Convert.ToDouble(this.txtprecio.Text.Trim());
                    combo.Descripcion = this.rchdescripcion.Text.Trim();
                    combo.Image = image;
                    rpta = combo.insertCombo(combo);
                }
                else
                {
                    //editing combo
                    combo.Idcombo = Convert.ToInt32(this.txtidcombo.Text.Trim());
                    combo.Nombre = this.txtnombre.Text.Trim();
                    //combo.Precio = Convert.ToDouble(this.txtidcombo.Text.Trim());
                    combo.Descripcion = this.rchdescripcion.Text.Trim();
                    combo.Image = image;
                    rpta = combo.updateCombo(combo);
                }

                if (rpta.Equals(configuration.db_ok))
                {
                    if (this.isNew)
                    {
                        messages.successMessage(configuration.insert_sucess);
                    }
                    else
                    {
                        messages.successMessage(configuration.update_success);
                    }
                }
                else
                {
                    messages.errorMessage(rpta);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // fill textBoxes from datagrid
        public override void fillTextBoxesFromDatagrid()
        {
            this.txtidcombo.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["idcombo"].Value);
            this.txtnombre.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["nombre"].Value);
            //this.txtprecio.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["precio"].Value);
            this.rchdescripcion.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["descripcion"].Value);
            
            // load image from datagridview to picture box
            byte[] imagenBuffer = (byte[])this.dgvData.CurrentRow.Cells["image"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            this.picPicture.Image = Image.FromStream(ms);
            this.picPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.tabControl1.SelectedIndex = 0;
        }

        // set idRecort To ParentBase
        public override void setIdRecordToParent()
        {
            this.idrecord = this.txtidcombo.Text.Trim();
        }

        // delete categoria individually override
        public override string deleteMultipleFromDatagridView(int codigo)
        {
            Combo combo = new Combo();
            return combo.deleteCombo(codigo);
        }

        public override void deleteRecord()
        {
            string rpta;
            Combo combo = new Combo();
            rpta = combo.deleteCombo(Convert.ToInt32(this.txtidcombo.Text.Trim()));
            if (rpta.Equals(configuration.db_ok))
            {
                messages.successMessage(configuration.delete_success);
            }
            else
            {
                messages.errorMessage(rpta);
            }
        }

        // enable / disable images buttons
        public override void setImageButtons()
        {
            if(this.isNew || this.isEdit)
            {
                this.btnLoadimage.Enabled = true;
                this.btnQuitImage.Enabled = true;
            }
            else
            {
                this.btnLoadimage.Enabled = false;
                this.btnQuitImage.Enabled = false;
            }
        }

        private void PMantCombo_Load(object sender, EventArgs e)
        {

        }

        private void btnArticuloInsert_Click(object sender, EventArgs e)
        {
            if(this.txtidcombo.Text.Trim() != string.Empty)
            {
                PMantComboArt doform = new PMantComboArt(Convert.ToInt32(this.txtidcombo.Text.Trim()));
                doform.Show();
            }
            else
            {
                messages.errorMessage("Debe Seleccionar un combo");
            }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.picPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                this.picPicture.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnQuitImage_Click(object sender, EventArgs e)
        {
            this.picPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picPicture.Image = presentation.Properties.Resources.transparent;
        }
    }
}
