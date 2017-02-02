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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabplistado = new System.Windows.Forms.TabPage();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.chkeliminar = new System.Windows.Forms.CheckBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar2 = new System.Windows.Forms.Button();
            this.errProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttpNotification = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabpmantenimiento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabplistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
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
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Location = new System.Drawing.Point(3, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 122);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::presentation.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(263, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 72);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::presentation.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(151, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 72);
            this.btnSave.TabIndex = 12;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::presentation.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(375, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 72);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::presentation.Properties.Resources.User_Interface_Login_icon;
            this.btnExit.Location = new System.Drawing.Point(599, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 72);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::presentation.Properties.Resources.Undo_icon;
            this.btnCancel.Location = new System.Drawing.Point(487, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 72);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::presentation.Properties.Resources.add_icon;
            this.btnNew.Location = new System.Drawing.Point(39, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 72);
            this.btnNew.TabIndex = 7;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.tabplistado.Controls.Add(this.btnDelete2);
            this.tabplistado.Controls.Add(this.chkeliminar);
            this.tabplistado.Controls.Add(this.dgvData);
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
            this.tabplistado.Click += new System.EventHandler(this.tabplistado_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Image = global::presentation.Properties.Resources.delete;
            this.btnDelete2.Location = new System.Drawing.Point(168, 61);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(106, 72);
            this.btnDelete2.TabIndex = 77;
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkeliminar
            // 
            this.chkeliminar.AutoSize = true;
            this.chkeliminar.Location = new System.Drawing.Point(60, 90);
            this.chkeliminar.Name = "chkeliminar";
            this.chkeliminar.Size = new System.Drawing.Size(62, 17);
            this.chkeliminar.TabIndex = 76;
            this.chkeliminar.Text = "Eliminar";
            this.chkeliminar.UseVisualStyleBackColor = true;
            this.chkeliminar.CheckedChanged += new System.EventHandler(this.chkeliminar_CheckedChanged);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar});
            this.dgvData.Location = new System.Drawing.Point(45, 150);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(656, 361);
            this.dgvData.TabIndex = 75;
            this.dgvData.AllowUserToAddRowsChanged += new System.EventHandler(this.dgvData_AllowUserToAddRowsChanged);
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.DoubleClick += new System.EventHandler(this.dgvData_DoubleClick);
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // btn_buscar2
            // 
            this.btn_buscar2.Image = global::presentation.Properties.Resources.search;
            this.btn_buscar2.Location = new System.Drawing.Point(483, 6);
            this.btn_buscar2.Name = "btn_buscar2";
            this.btn_buscar2.Size = new System.Drawing.Size(106, 72);
            this.btn_buscar2.TabIndex = 71;
            this.btn_buscar2.UseVisualStyleBackColor = true;
            this.btn_buscar2.Click += new System.EventHandler(this.btn_buscar2_Click);
            // 
            // errProv
            // 
            this.errProv.ContainerControl = this;
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
            this.Load += new System.EventHandler(this.PMantBase_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpmantenimiento.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabplistado.ResumeLayout(false);
            this.tabplistado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabpmantenimiento;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TabPage tabplistado;
        public System.Windows.Forms.Button btnimprimir;
        public System.Windows.Forms.TextBox txtbuscar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_buscar2;
        public System.Windows.Forms.ErrorProvider errProv;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.ToolTip ttpNotification;
        public System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.CheckBox chkeliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eliminar;
        public System.Windows.Forms.Button btnDelete2;
    }
}