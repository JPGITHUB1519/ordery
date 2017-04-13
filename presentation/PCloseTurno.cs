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
    public partial class PCloseTurno : Form
    {
        public PCloseTurno()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PCloseTurno_Load(object sender, EventArgs e)
        {
            Turno turno = new Turno();
            DataTable dt = turno.getAllInfoControlTurnoById(session.idControlTurno).Tables[0];
            this.txtidcontrol_turno.Text = dt.Rows[0]["idcontrol_turno"].ToString();
            this.txtturno_descripcion.Text = dt.Rows[0]["turno_descripcion"].ToString();
            this.txtcaja.Text = dt.Rows[0]["caja_descripcion"].ToString();
            this.txtusuario.Text = dt.Rows[0]["username"].ToString();
            this.txtidusuario.Text = dt.Rows[0]["idusuario"].ToString();
            this.txtmonto_inicial.Text = dt.Rows[0]["monto_inicial"].ToString();
            this.txtopen_timestamp.Text = dt.Rows[0]["fecha_apertura"].ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txtclose_timestamp.Text = DateTime.Now.ToString();
        }

        private void btnOpenTurno_Click(object sender, EventArgs e)
        {
            /*
                CERRAR TURNO
	            Implica asignar el total de la caja al final del turno y asignarle una fecha de cierre 
                En variable Session asignar a 0 la variable idcontrol_turno
             
             */
            Turno turno = new Turno();
            messages.successMessage(turno.closeTurno(session.idControlTurno, Convert.ToDouble(this.txtmonto_cierre.Text), DateTime.Parse(this.txtclose_timestamp.Text)));
            session.idControlTurno = 0;
            //session.total_en_caja = 0;
        }
    }
}
