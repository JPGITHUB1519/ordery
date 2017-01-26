namespace presentation
{
    partial class PMantBase
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpmantenimiento = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabplistado = new System.Windows.Forms.TabPage();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btn_buscar2 = new System.Windows.Forms.Button();
            this.errprov = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabpmantenimiento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabplistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprov)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(233, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 29);
            this.label8.TabIndex = 47;
            this.label8.Text = "Mantenimiento de CAMBIAR";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpmantenimiento);
            this.tabControl1.Controls.Add(this.tabplistado);
            this.tabControl1.Location = new System.Drawing.Point(36, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 587);
            this.tabControl1.TabIndex = 48;
            // 
            // tabpmantenimiento
            // 
            this.tabpmantenimiento.Controls.Add(this.groupBox2);
            this.tabpmantenimiento.Controls.Add(this.groupBox1);
            this.tabpmantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabpmantenimiento.Name = "tabpmantenimiento";
            this.tabpmantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabpmantenimiento.Size = new System.Drawing.Size(764, 561);
            this.tabpmantenimiento.TabIndex = 0;
            this.tabpmantenimiento.Text = "Mantenimiento";
            this.tabpmantenimiento.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnsalir);
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(120, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 122);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 387);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAMBIAR";
            // 
            // tabplistado
            // 
            this.tabplistado.Controls.Add(this.btnimprimir);
            this.tabplistado.Controls.Add(this.txtbuscar);
            this.tabplistado.Controls.Add(this.label2);
            this.tabplistado.Controls.Add(this.btn_buscar2);
            this.tabplistado.Location = new System.Drawing.Point(4, 22);
            this.tabplistado.Name = "tabplistado";
            this.tabplistado.Padding = new System.Windows.Forms.Padding(3);
            this.tabplistado.Size = new System.Drawing.Size(764, 561);
            this.tabplistado.TabIndex = 1;
            this.tabplistado.Text = "Listado";
            this.tabplistado.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(141, 30);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(318, 20);
            this.txtbuscar.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Buscar";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::presentation.Properties.Resources.search;
            this.btnbuscar.Location = new System.Drawing.Point(239, 19);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(106, 72);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::presentation.Properties.Resources.delete;
            this.btneliminar.Location = new System.Drawing.Point(127, 19);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(106, 72);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::presentation.Properties.Resources.User_Interface_Login_icon;
            this.btnsalir.Location = new System.Drawing.Point(463, 19);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(106, 72);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::presentation.Properties.Resources.Undo_icon;
            this.btncancelar.Location = new System.Drawing.Point(351, 19);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(106, 72);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::presentation.Properties.Resources.save;
            this.btnNuevo.Location = new System.Drawing.Point(15, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 72);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = global::presentation.Properties.Resources.print;
            this.btnimprimir.Location = new System.Drawing.Point(595, 6);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(106, 72);
            this.btnimprimir.TabIndex = 73;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btn_buscar2
            // 
            this.btn_buscar2.Image = global::presentation.Properties.Resources.search;
            this.btn_buscar2.Location = new System.Drawing.Point(483, 6);
            this.btn_buscar2.Name = "btn_buscar2";
            this.btn_buscar2.Size = new System.Drawing.Size(106, 72);
            this.btn_buscar2.TabIndex = 71;
            this.btn_buscar2.UseVisualStyleBackColor = true;
            // 
            // errprov
            // 
            this.errprov.ContainerControl = this;
            // 
            // PMantBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 670);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Name = "PMantBase";
            this.Text = "PMantBase";
            this.tabControl1.ResumeLayout(false);
            this.tabpmantenimiento.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabplistado.ResumeLayout(false);
            this.tabplistado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabpmantenimiento;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnbuscar;
        public System.Windows.Forms.Button btneliminar;
        public System.Windows.Forms.Button btnsalir;
        public System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TabPage tabplistado;
        public System.Windows.Forms.Button btnimprimir;
        public System.Windows.Forms.TextBox txtbuscar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_buscar2;
        public System.Windows.Forms.ErrorProvider errprov;
    }
}