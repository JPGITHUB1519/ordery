namespace presentation
{
    partial class PMantCaja
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
            this.txtdescripcion = new utils.ntextbox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtidcaja = new utils.ntextbox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.chk_is_active = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabpmantenimiento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabplistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Size = new System.Drawing.Size(355, 36);
            this.label8.Text = "Mantenimiento de Cajas";
            // 
            // tabpmantenimiento
            // 
            this.tabpmantenimiento.Location = new System.Drawing.Point(4, 25);
            this.tabpmantenimiento.Size = new System.Drawing.Size(1021, 693);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_is_active);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtidcaja);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Text = "Cajas";
            // 
            // tabplistado
            // 
            this.tabplistado.Location = new System.Drawing.Point(4, 25);
            this.tabplistado.Size = new System.Drawing.Size(1021, 693);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(469, 192);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(256, 22);
            this.txtdescripcion.TabIndex = 99;
            this.txtdescripcion.validate = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 98;
            this.label1.Text = "Descripcion";
            // 
            // txtidcaja
            // 
            this.txtidcaja.Location = new System.Drawing.Point(469, 139);
            this.txtidcaja.Margin = new System.Windows.Forms.Padding(4);
            this.txtidcaja.Name = "txtidcaja";
            this.txtidcaja.Size = new System.Drawing.Size(256, 22);
            this.txtidcaja.TabIndex = 97;
            this.txtidcaja.validate = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 96;
            this.label3.Text = "IDCaja";
            // 
            // chk_is_active
            // 
            this.chk_is_active.AutoSize = true;
            this.chk_is_active.Location = new System.Drawing.Point(469, 267);
            this.chk_is_active.Margin = new System.Windows.Forms.Padding(4);
            this.chk_is_active.Name = "chk_is_active";
            this.chk_is_active.Size = new System.Drawing.Size(90, 21);
            this.chk_is_active.TabIndex = 105;
            this.chk_is_active.Text = "Is Active?";
            this.chk_is_active.UseVisualStyleBackColor = true;
            // 
            // PMantCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 809);
            this.Name = "PMantCaja";
            this.Text = "PMantCaja";
            this.Load += new System.EventHandler(this.PMantCaja_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpmantenimiento.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabplistado.ResumeLayout(false);
            this.tabplistado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private utils.ntextbox txtdescripcion;
        public System.Windows.Forms.Label label1;
        private utils.ntextbox txtidcaja;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_is_active;
    }
}