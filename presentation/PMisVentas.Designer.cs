namespace presentation
{
    partial class PMisVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvMisVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPedLocal = new utils.ntextbox(this.components);
            this.txtTotalPedDom = new utils.ntextbox(this.components);
            this.txtTotalPedidos = new utils.ntextbox(this.components);
            this.txtTotalVentas = new utils.ntextbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(417, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 36);
            this.label8.TabIndex = 48;
            this.label8.Text = "Mis Ventas";
            // 
            // dgvMisVentas
            // 
            this.dgvMisVentas.AllowUserToAddRows = false;
            this.dgvMisVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisVentas.Location = new System.Drawing.Point(99, 83);
            this.dgvMisVentas.Name = "dgvMisVentas";
            this.dgvMisVentas.RowTemplate.Height = 24;
            this.dgvMisVentas.Size = new System.Drawing.Size(861, 479);
            this.dgvMisVentas.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Cantidad de Pedidos Locales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 648);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Cantidad de Pedidos a domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 699);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Cantidad Total de Pedidos";
            // 
            // txtTotalPedLocal
            // 
            this.txtTotalPedLocal.Enabled = false;
            this.txtTotalPedLocal.Location = new System.Drawing.Point(601, 600);
            this.txtTotalPedLocal.Name = "txtTotalPedLocal";
            this.txtTotalPedLocal.Size = new System.Drawing.Size(167, 22);
            this.txtTotalPedLocal.TabIndex = 53;
            this.txtTotalPedLocal.validate = false;
            // 
            // txtTotalPedDom
            // 
            this.txtTotalPedDom.Enabled = false;
            this.txtTotalPedDom.Location = new System.Drawing.Point(601, 651);
            this.txtTotalPedDom.Name = "txtTotalPedDom";
            this.txtTotalPedDom.Size = new System.Drawing.Size(167, 22);
            this.txtTotalPedDom.TabIndex = 54;
            this.txtTotalPedDom.validate = false;
            // 
            // txtTotalPedidos
            // 
            this.txtTotalPedidos.Enabled = false;
            this.txtTotalPedidos.Location = new System.Drawing.Point(601, 703);
            this.txtTotalPedidos.Name = "txtTotalPedidos";
            this.txtTotalPedidos.Size = new System.Drawing.Size(167, 22);
            this.txtTotalPedidos.TabIndex = 55;
            this.txtTotalPedidos.validate = false;
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Enabled = false;
            this.txtTotalVentas.Location = new System.Drawing.Point(601, 774);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(167, 22);
            this.txtTotalVentas.TabIndex = 57;
            this.txtTotalVentas.validate = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 774);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Total Acumulado de Ventas";
            // 
            // PMisVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 837);
            this.Controls.Add(this.txtTotalVentas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalPedidos);
            this.Controls.Add(this.txtTotalPedDom);
            this.Controls.Add(this.txtTotalPedLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMisVentas);
            this.Controls.Add(this.label8);
            this.Name = "PMisVentas";
            this.Text = "PMisVentas";
            this.Load += new System.EventHandler(this.PMisVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvMisVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private utils.ntextbox txtTotalPedLocal;
        private utils.ntextbox txtTotalPedDom;
        private utils.ntextbox txtTotalPedidos;
        private utils.ntextbox txtTotalVentas;
        private System.Windows.Forms.Label label4;
    }
}