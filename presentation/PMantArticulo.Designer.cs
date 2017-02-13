namespace presentation
{
    partial class PMantArticulo
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
            this.txtidarticulo = new utils.ntextbox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtidcategoria = new utils.ntextbox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new utils.ntextbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rchdescripcion = new System.Windows.Forms.RichTextBox();
            this.txtprecio = new utils.ntextbox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtunidad = new utils.ntextbox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label8.Size = new System.Drawing.Size(329, 29);
            this.label8.Text = "Mantenimiento de Articulos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtunidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rchdescripcion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtidcategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtidarticulo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Text = "Articulos";
            // 
            // btnimprimir
            // 
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(159, 33);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(59, 31);
            // 
            // txtidarticulo
            // 
            this.txtidarticulo.Location = new System.Drawing.Point(312, 30);
            this.txtidarticulo.Name = "txtidarticulo";
            this.txtidarticulo.Size = new System.Drawing.Size(193, 20);
            this.txtidarticulo.TabIndex = 93;
            this.txtidarticulo.validate = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "IDArticulo";
            // 
            // txtidcategoria
            // 
            this.txtidcategoria.Location = new System.Drawing.Point(312, 73);
            this.txtidcategoria.Name = "txtidcategoria";
            this.txtidcategoria.Size = new System.Drawing.Size(193, 20);
            this.txtidcategoria.TabIndex = 95;
            this.txtidcategoria.validate = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "IDCategoria";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(312, 118);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(193, 20);
            this.txtnombre.TabIndex = 97;
            this.txtnombre.validate = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 98;
            this.label5.Text = "Descripción";
            // 
            // rchdescripcion
            // 
            this.rchdescripcion.Location = new System.Drawing.Point(312, 244);
            this.rchdescripcion.Name = "rchdescripcion";
            this.rchdescripcion.Size = new System.Drawing.Size(204, 122);
            this.rchdescripcion.TabIndex = 99;
            this.rchdescripcion.Text = "";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(312, 164);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(193, 20);
            this.txtprecio.TabIndex = 101;
            this.txtprecio.validate = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 100;
            this.label6.Text = "Precio";
            // 
            // txtunidad
            // 
            this.txtunidad.Location = new System.Drawing.Point(312, 202);
            this.txtunidad.Name = "txtunidad";
            this.txtunidad.Size = new System.Drawing.Size(193, 20);
            this.txtunidad.TabIndex = 103;
            this.txtunidad.validate = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 102;
            this.label7.Text = "Unidad";
            // 
            // button1
            // 
            this.button1.Image = global::presentation.Properties.Resources.search;
            this.button1.Location = new System.Drawing.Point(523, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 45);
            this.button1.TabIndex = 104;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PMantArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 666);
            this.Name = "PMantArticulo";
            this.Text = "PMantArticulo";
            this.Load += new System.EventHandler(this.PMantArticulo_Load);
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

        private utils.ntextbox txtunidad;
        public System.Windows.Forms.Label label7;
        private utils.ntextbox txtprecio;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rchdescripcion;
        public System.Windows.Forms.Label label5;
        private utils.ntextbox txtnombre;
        public System.Windows.Forms.Label label4;
        private utils.ntextbox txtidcategoria;
        public System.Windows.Forms.Label label1;
        private utils.ntextbox txtidarticulo;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
    }
}