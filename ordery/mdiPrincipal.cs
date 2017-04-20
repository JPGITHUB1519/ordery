using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using presentation;
using utils;
using data;
using presentation.Reports;

namespace ordery
{
    public partial class mdiPrincipal : Form
    {
        private int childFormNumber = 0;

        public mdiPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PMantCategoria doform = new PMantCategoria();
            doform.MdiParent = this;
            doform.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PMantArticulo doform = new PMantArticulo();
            doform.MdiParent = this;
            doform.Show();
        }

        private void combosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PMantCombo doform = new PMantCombo();
            doform.MdiParent = this;
            doform.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PPedido doform = new PPedido();
            doform.MdiParent = this;
            doform.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PMantCliente doform = new PMantCliente();
            doform.MdiParent = this;
            doform.Show();
        }

        private void mdiPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PMantUsuario doform = new PMantUsuario();
            doform.MdiParent = this;
            doform.Show();
        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PMantCaja doform = new PMantCaja();
            doform.MdiParent = this;
            doform.Show();
        }

        private void abrirTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCloseCaja doform = new PCloseCaja();
            doform.MdiParent = this;
            doform.Show();
        }

        private void abrirCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POpenCaja doform = new POpenCaja();
            doform.MdiParent = this;
            doform.Show();
        }

        private void cerrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check that you do not have more than one turno open in a session
            if (session.idControlTurno == 0)
            {
                POpenTurno doform = new POpenTurno();
                doform.MdiParent = this;
                doform.Show();
            }
            else
            {
                messages.errorMessage("Ya existe un turno abierto en esta caja. Por favor cierre el turno y cree uno nuevo");
            }
        }

        private void verTotalEnCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messages.successMessage(session.total_en_caja.ToString());
        }

        private void reportesCombosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = database.executeQuery("EXEC getCantidadCombosVendidos");
            PReport frmreport = new PReport("presentation.Reports.RReporteCombosVendidos.rdlc", ds);
            frmreport.Show();
        }

        private void cerrarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session.idControlTurno != 0)
            {
                PCloseTurno doform = new PCloseTurno();
                doform.MdiParent = this;
                doform.Show();
            }
            else
            {
                messages.errorMessage("No hay turnos abiertos");
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void misVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session.idControlTurno != 0)
            {
                PMisVentas doform = new PMisVentas();
                doform.MdiParent = this;
                doform.Show();
            }
            else
            {
                messages.errorMessage("No has abierto un turno todavia");
            }
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cheffBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCheffBoard doform = new PCheffBoard();
            doform.MdiParent = this;
            doform.Show();
        }

        private void listadoDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PPedidoDetails doform = new PPedidoDetails();
            doform.MdiParent = this;
            doform.Show();
        }

        private void reporteDeVentasPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = database.executeQuery("EXEC RTotalSalesByEmployee");
            PReport frmreport = new PReport("presentation.Reports.RSalesByUsers.rdlc", ds);
            frmreport.Show();
        }
    }
}
