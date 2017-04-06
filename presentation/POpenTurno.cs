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
    public partial class POpenTurno : Form
    {
        public POpenTurno()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txttimestamp.Text = DateTime.Now.ToString();
        }

        private void POpenTurno_Load(object sender, EventArgs e)
        {
            this.fillCajasCombo();
            this.fillUsuarioTextBox();
            this.fillTurnosCombo();

        }

        public void fillCajasCombo()
        {
            Caja caja = new Caja();
            this.cmbcaja.DataSource = caja.getCajas().Tables[0];
            this.cmbcaja.DisplayMember = "descripcion";
            this.cmbcaja.ValueMember = "idcaja";

        }

        public void fillTurnosCombo()
        {
            Turno turno = new Turno();
            this.cmbTurno.DataSource = turno.getTurnos().Tables[0];
            this.cmbTurno.DisplayMember = "descripcion";
            this.cmbTurno.ValueMember = "idturno";
        }

        public void fillUsuarioTextBox()
        {
            Usuario usuario = new Usuario();
            this.txtidusuario.Text = session.userId.ToString();
            this.txtusuario.Text = usuario.getUsuarioById(session.userId).Tables[0].Rows[0]["username"].ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenTurno_Click(object sender, EventArgs e)
        {
            // check if the selectedCaja is open
            Caja caja = new Caja();
            Turno turno = new Turno();
            int idcaja = Convert.ToInt32(this.cmbcaja.SelectedValue);
            int idturno = Convert.ToInt32(this.cmbTurno.SelectedValue);
            if(caja.checkIfOpen(idcaja))
            {
                if(!turno.checkIfOpen(idturno))
                {
                    session.idControlTurno = turno.openTurno(idturno, idcaja, session.userId, Convert.ToDouble(this.txtmonto_inicial.Text.Trim()));
                    messages.successMessage("Turno Abierto Exitosamente");
                    // asignar el total en caja de sesion el valor del monto inicial
                    session.total_en_caja = Convert.ToDouble(this.txtmonto_inicial.Text.Trim());
                    this.Close();
                }
                else
                {
                    messages.errorMessage("Este Turno ya ha Sido Abierto");
                }
            }
            else
            {
                messages.errorMessage("La caja Seleccionada esta Cerrada");
            }
        }
    }
}
