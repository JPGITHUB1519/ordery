namespace presentation
{
    partial class PMantCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidcliente = new utils.ntextbox(this.components);
            this.txtnombre = new utils.ntextbox(this.components);
            this.txtapellido = new utils.ntextbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelefono = new utils.ntextbox(this.components);
            this.txtdireccion = new utils.ntextbox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new utils.ntextbox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.chkis_active = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabpmantenimiento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabplistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Size = new System.Drawing.Size(324, 29);
            this.label8.Text = "Mantenimiento de Clientes";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkis_active);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtidcliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Text = "Clientes";
            // 
            // tabplistado
            // 
            this.tabplistado.Controls.Add(this.dataGridView1);
            this.tabplistado.Controls.SetChildIndex(this.btn_buscar2, 0);
            this.tabplistado.Controls.SetChildIndex(this.label2, 0);
            this.tabplistado.Controls.SetChildIndex(this.txtbuscar, 0);
            this.tabplistado.Controls.SetChildIndex(this.btnimprimir, 0);
            this.tabplistado.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // btn_buscar2
            // 
            this.btn_buscar2.Click += new System.EventHandler(this.btn_buscar2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "IdCliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "Nombre";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(353, 37);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(193, 20);
            this.txtidcliente.TabIndex = 91;
            this.txtidcliente.validate = false;
            this.txtidcliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtidcliente_Validating);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(353, 78);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(193, 20);
            this.txtnombre.TabIndex = 92;
            this.txtnombre.validate = false;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(353, 123);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(193, 20);
            this.txtapellido.TabIndex = 93;
            this.txtapellido.validate = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 95;
            this.label5.Text = "Telefono";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(353, 164);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(193, 20);
            this.txttelefono.TabIndex = 96;
            this.txttelefono.validate = false;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(353, 202);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(193, 20);
            this.txtdireccion.TabIndex = 98;
            this.txtdireccion.validate = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "Direccion";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(353, 244);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(193, 20);
            this.txtemail.TabIndex = 100;
            this.txtemail.validate = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 99;
            this.label7.Text = "Email";
            // 
            // chkis_active
            // 
            this.chkis_active.AutoSize = true;
            this.chkis_active.Location = new System.Drawing.Point(353, 309);
            this.chkis_active.Name = "chkis_active";
            this.chkis_active.Size = new System.Drawing.Size(76, 17);
            this.chkis_active.TabIndex = 101;
            this.chkis_active.Text = "Is_Active?";
            this.chkis_active.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 446);
            this.dataGridView1.TabIndex = 74;
            // 
            // PMantCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 665);
            this.Name = "PMantCliente";
            this.Text = "PMantCliente";
            this.Load += new System.EventHandler(this.PMantCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpmantenimiento.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabplistado.ResumeLayout(false);
            this.tabplistado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkis_active;
        private utils.ntextbox txtemail;
        public System.Windows.Forms.Label label7;
        private utils.ntextbox txtdireccion;
        public System.Windows.Forms.Label label6;
        private utils.ntextbox txttelefono;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        private utils.ntextbox txtapellido;
        private utils.ntextbox txtnombre;
        private utils.ntextbox txtidcliente;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}