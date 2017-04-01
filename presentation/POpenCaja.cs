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
    public partial class POpenCaja : Form
    {
        public POpenCaja()
        {
            InitializeComponent();
        }

        private void frmOpenCaja_Load(object sender, EventArgs e)
        {
            // check that one caja is not open
            this.fillCajasCombo();
            this.fillUsuarioTextBox();
        }

        public void fillCajasCombo()
        {
            Caja caja = new Caja();
            this.cmbcaja.DataSource = caja.getCajas().Tables[0];
            this.cmbcaja.DisplayMember = "descripcion";
            this.cmbcaja.ValueMember = "idcaja";

        }

        public void fillUsuarioTextBox()
        {
            Usuario usuario = new Usuario();
            this.txtidusuario.Text = session.userId.ToString();
            this.txtusuario.Text = usuario.getUsuarioById(session.userId).Tables[0].Rows[0]["username"].ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txttimestamp.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Caja caja = new Caja();
            int idcaja = Convert.ToInt32(this.cmbcaja.SelectedValue);
            // valdiar si la caja ya esta abierta
            if(caja.checkIfOpen(idcaja))
            {
                messages.errorMessage("Esta caja ya sido Abierta");
            }
            else
            {
                int idcontrol_caja = caja.openCaja(idcaja, session.userId);
                //session.idControlCaja = idcontrol_caja;
                messages.successMessage("La caja fue abierta Exitosamente");
                this.Close();
            }   
        }
    }
}
