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
    public partial class PMantUsuario : PMantBase
    {
        public PMantUsuario()
        {
            InitializeComponent();
            this.ttpNotification.SetToolTip(this.txtusername, "Ingrese Nombre de Usuario");
            this.ttpNotification.SetToolTip(this.txtpassword, "Ingrese Password");
            this.ttpNotification.SetToolTip(this.txtconfirm, "Confirme Password");
        }

        // fill datagrid
        public override void fillDatagrid()
        {
            Usuario usuario = new Usuario();
            this.dgvData.DataSource = usuario.getUsuarios().Tables[0];
        }

        // enable / disable methods
        public override void enable(bool cond)
        {
            this.txtidusuario.ReadOnly = !cond;
            this.txtusername.ReadOnly = !cond;
            this.txtpassword.ReadOnly = !cond;
            this.txtconfirm.ReadOnly = !cond;
            this.chk_is_active.Enabled = cond;
        }

        // clearTextBoxes
        public override void clearTextBoxes()
        {
            this.txtidusuario.Text = string.Empty;
            this.txtusername.Text = string.Empty;
            this.txtpassword.Text = string.Empty;
            this.txtconfirm.Text = string.Empty;
            this.chk_is_active.Checked = false;
        }

        // searchByName Override
        public override void searchByName()
        {
            Usuario usuario = new Usuario();
            this.dgvData.DataSource = usuario.searchUsuarioByName(this.txtbuscar.Text.Trim()).Tables[0];
        }

        public override void guardar()
        {
            string rpta = "";
            Usuario usuario = new Usuario();
            try
            {
                // if the confirm password and password are equals
                if(txtpassword.Text == txtconfirm.Text)
                {
                    if (this.isNew)
                    {
                        // create new user
                        usuario.Username = this.txtusername.Text.Trim();
                        usuario.Password = this.txtpassword.Text.Trim();
                        usuario.Is_active = this.chk_is_active.Checked;
                        rpta = usuario.insertUsuario(usuario);
                    }
                    else
                    {
                        usuario.Idusuario = Convert.ToInt32(this.txtidusuario.Text.Trim());
                        usuario.Username = this.txtusername.Text.Trim();
                        usuario.Password = this.txtpassword.Text.Trim();
                        usuario.Is_active = this.chk_is_active.Checked;
                        rpta = usuario.updateUsuario(usuario);
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
                    this.validated = true;
                }
                else
                {
                    messages.errorMessage("Los Passwords no Coinciden");
                    // failed on validation
                    this.validated = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // fill textboxes on doubleClickDatgrid
        public override void fillTextBoxesFromDatagrid()
        {
            this.txtidusuario.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["idusuario"].Value);
            this.txtusername.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["username"].Value);
            this.txtpassword.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["password"].Value);
            this.tabControl1.SelectedIndex = 0;
        }

        public override void setIdRecordToParent()
        {
            this.idrecord = this.txtidusuario.Text.Trim();
        }

        // delete record individually override
        public override string deleteMultipleFromDatagridView(int codigo)
        {
            Usuario articulo = new Usuario();
            return articulo.deleteUsuario(codigo);
        }

        public override void deleteRecord()
        {
            Usuario usuario = new Usuario();
            string rpta = usuario.deleteUsuario(Convert.ToInt32(this.txtidusuario.Text.Trim()));
            if (rpta.Equals(configuration.db_ok))
            {
                messages.successMessage(configuration.delete_success);
            }
            else
            {
                messages.errorMessage(rpta);
            }
        }
        private void PMantUsuario_Load(object sender, EventArgs e)
        {
            
        }
    }
}
