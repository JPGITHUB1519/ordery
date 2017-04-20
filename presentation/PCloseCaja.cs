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
    public partial class PCloseCaja : Form
    {
        public PCloseCaja()
        {
            InitializeComponent();
        }

        public void fillCajasCombo()
        {
            Caja caja = new Caja();
            this.cmbcaja.DataSource = caja.getOpenCajasToday().Tables[0];
            this.cmbcaja.DisplayMember = "descripcion";
            this.cmbcaja.ValueMember = "idcaja";

        }

        public void fillUsuarioTextBox()
        {
            Usuario usuario = new Usuario();
            this.txtidusuario.Text = session.userId.ToString();
            this.txtusuario.Text = usuario.getUsuarioById(session.userId).Tables[0].Rows[0]["username"].ToString();
        }

        private void PCloseCaja_Load(object sender, EventArgs e)
        {
            this.fillCajasCombo();
            this.fillUsuarioTextBox();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txttimestamp.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Caja caja = new Caja();
            caja.closeCaja(Convert.ToInt32(this.cmbcaja.SelectedValue.ToString()), DateTime.Parse(this.txttimestamp.Text.Trim()));
        }
    }
}
