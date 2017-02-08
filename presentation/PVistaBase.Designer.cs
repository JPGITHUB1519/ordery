namespace presentation
{
    partial class PVistaBase
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
            this.tabplistado = new System.Windows.Forms.TabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label8 = new System.Windows.Forms.Label();
            this.tabplistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabplistado
            // 
            this.tabplistado.Controls.Add(this.dgvData);
            this.tabplistado.Controls.Add(this.txtbuscar);
            this.tabplistado.Controls.Add(this.label2);
            this.tabplistado.Controls.Add(this.btn_buscar2);
            this.tabplistado.Location = new System.Drawing.Point(4, 22);
            this.tabplistado.Name = "tabplistado";
            this.tabplistado.Padding = new System.Windows.Forms.Padding(3);
            this.tabplistado.Size = new System.Drawing.Size(748, 488);
            this.tabplistado.TabIndex = 1;
            this.tabplistado.Text = "Listado";
            this.tabplistado.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(45, 104);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(656, 361);
            this.dgvData.TabIndex = 75;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(141, 30);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(318, 20);
            this.txtbuscar.TabIndex = 12;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabplistado);
            this.tabControl1.Location = new System.Drawing.Point(33, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(756, 514);
            this.tabControl1.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(270, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 29);
            this.label8.TabIndex = 50;
            this.label8.Text = "Vista de <cambiar>";
            // 
            // PVistaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 629);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Name = "PVistaBase";
            this.Text = "Vista de <cambiar>";
            this.Load += new System.EventHandler(this.PConsBase_Load);
            this.tabplistado.ResumeLayout(false);
            this.tabplistado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabPage tabplistado;
        public System.Windows.Forms.DataGridView dgvData;
        public System.Windows.Forms.TextBox txtbuscar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_buscar2;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.Label label8;
    }
}