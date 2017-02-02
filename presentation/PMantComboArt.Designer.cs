namespace presentation
{
    partial class PMantComboArt
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.dgvArticulosCombo = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbuscar = new utils.ntextbox(this.components);
            this.txtBuscarComboArt = new utils.ntextbox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(390, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 29);
            this.label8.TabIndex = 48;
            this.label8.Text = "Agregar Articulos a Combo";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 148);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(435, 383);
            this.dgvArticulos.TabIndex = 49;
            // 
            // dgvArticulosCombo
            // 
            this.dgvArticulosCombo.AllowUserToAddRows = false;
            this.dgvArticulosCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosCombo.Location = new System.Drawing.Point(581, 148);
            this.dgvArticulosCombo.Name = "dgvArticulosCombo";
            this.dgvArticulosCombo.Size = new System.Drawing.Size(435, 383);
            this.dgvArticulosCombo.TabIndex = 50;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::presentation.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(465, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 72);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::presentation.Properties.Resources.add_icon;
            this.btnNew.Location = new System.Drawing.Point(465, 229);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 72);
            this.btnNew.TabIndex = 51;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(93, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Lista General de Articulos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(705, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Articulos del Combo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(97, 109);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(245, 20);
            this.txtbuscar.TabIndex = 59;
            this.txtbuscar.validate = false;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged_1);
            // 
            // txtBuscarComboArt
            // 
            this.txtBuscarComboArt.Location = new System.Drawing.Point(672, 107);
            this.txtBuscarComboArt.Name = "txtBuscarComboArt";
            this.txtBuscarComboArt.Size = new System.Drawing.Size(245, 20);
            this.txtBuscarComboArt.TabIndex = 60;
            this.txtBuscarComboArt.validate = false;
            this.txtBuscarComboArt.TextChanged += new System.EventHandler(this.txtBuscarComboArt_TextChanged);
            // 
            // PMantComboArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 561);
            this.Controls.Add(this.txtBuscarComboArt);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvArticulosCombo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.label8);
            this.Name = "PMantComboArt";
            this.Text = "PMantComboArt";
            this.Load += new System.EventHandler(this.PMantComboArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosCombo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridView dgvArticulosCombo;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private utils.ntextbox txtbuscar;
        private utils.ntextbox txtBuscarComboArt;
    }
}