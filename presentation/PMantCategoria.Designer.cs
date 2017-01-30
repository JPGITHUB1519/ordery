namespace presentation
{
    partial class PMantCategoria
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
            this.txtnombre = new utils.ntextbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtidcategoria = new utils.ntextbox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rchdescripcion = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label8.Size = new System.Drawing.Size(355, 29);
            this.label8.Text = "Mantenimiento de Categorias";
            // 
            // btnDelete
            // 
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rchdescripcion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtidcategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Size = new System.Drawing.Size(737, 561);
            this.groupBox1.Text = "Categorias";
            // 
            // btn_buscar2
            // 
            this.btn_buscar2.Click += new System.EventHandler(this.btn_buscar2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(364, 95);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(193, 20);
            this.txtnombre.TabIndex = 103;
            this.txtnombre.validate = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 102;
            this.label4.Text = "Nombre";
            // 
            // txtidcategoria
            // 
            this.txtidcategoria.Location = new System.Drawing.Point(364, 50);
            this.txtidcategoria.Name = "txtidcategoria";
            this.txtidcategoria.Size = new System.Drawing.Size(193, 20);
            this.txtidcategoria.TabIndex = 101;
            this.txtidcategoria.validate = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "IDCategoria";
            // 
            // rchdescripcion
            // 
            this.rchdescripcion.Location = new System.Drawing.Point(364, 156);
            this.rchdescripcion.Name = "rchdescripcion";
            this.rchdescripcion.Size = new System.Drawing.Size(204, 122);
            this.rchdescripcion.TabIndex = 105;
            this.rchdescripcion.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 104;
            this.label5.Text = "Descripción";
            // 
            // PMantCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 674);
            this.Name = "PMantCategoria";
            this.Text = "PMantCategoria";
            this.Load += new System.EventHandler(this.PMantCategoria_Load);
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

        private utils.ntextbox txtnombre;
        public System.Windows.Forms.Label label4;
        private utils.ntextbox txtidcategoria;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchdescripcion;
        public System.Windows.Forms.Label label5;
    }
}