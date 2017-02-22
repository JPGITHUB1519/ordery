namespace presentation
{
    partial class PPedido
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
            this.btncombo1 = new System.Windows.Forms.Button();
            this.btncombo2 = new System.Windows.Forms.Button();
            this.btncombo3 = new System.Windows.Forms.Button();
            this.btncombo4 = new System.Windows.Forms.Button();
            this.btncombo8 = new System.Windows.Forms.Button();
            this.btncombo7 = new System.Windows.Forms.Button();
            this.btncombo6 = new System.Windows.Forms.Button();
            this.btncombo5 = new System.Windows.Forms.Button();
            this.btncombo12 = new System.Windows.Forms.Button();
            this.btncombo11 = new System.Windows.Forms.Button();
            this.btncombo10 = new System.Windows.Forms.Button();
            this.btncombo9 = new System.Windows.Forms.Button();
            this.dgvpedido = new System.Windows.Forms.DataGridView();
            this.idcombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltotalcant = new System.Windows.Forms.Label();
            this.dgvExtras = new System.Windows.Forms.DataGridView();
            this.idarticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre_cliente = new utils.ntextbox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtidcliente = new utils.ntextbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdireccion = new utils.ntextbox(this.components);
            this.btnFacturar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtras)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(331, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 29);
            this.label8.TabIndex = 48;
            this.label8.Text = "Pedidos";
            // 
            // btncombo1
            // 
            this.btncombo1.Location = new System.Drawing.Point(29, 177);
            this.btncombo1.Name = "btncombo1";
            this.btncombo1.Size = new System.Drawing.Size(123, 107);
            this.btncombo1.TabIndex = 49;
            this.btncombo1.UseVisualStyleBackColor = true;
            this.btncombo1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncombo2
            // 
            this.btncombo2.Location = new System.Drawing.Point(177, 177);
            this.btncombo2.Name = "btncombo2";
            this.btncombo2.Size = new System.Drawing.Size(123, 107);
            this.btncombo2.TabIndex = 50;
            this.btncombo2.UseVisualStyleBackColor = true;
            this.btncombo2.Click += new System.EventHandler(this.btncombo2_Click);
            // 
            // btncombo3
            // 
            this.btncombo3.Location = new System.Drawing.Point(318, 177);
            this.btncombo3.Name = "btncombo3";
            this.btncombo3.Size = new System.Drawing.Size(123, 107);
            this.btncombo3.TabIndex = 51;
            this.btncombo3.UseVisualStyleBackColor = true;
            this.btncombo3.Click += new System.EventHandler(this.btncombo3_Click);
            // 
            // btncombo4
            // 
            this.btncombo4.Location = new System.Drawing.Point(458, 177);
            this.btncombo4.Name = "btncombo4";
            this.btncombo4.Size = new System.Drawing.Size(123, 107);
            this.btncombo4.TabIndex = 52;
            this.btncombo4.UseVisualStyleBackColor = true;
            this.btncombo4.Click += new System.EventHandler(this.btncombo4_Click);
            // 
            // btncombo8
            // 
            this.btncombo8.Location = new System.Drawing.Point(458, 306);
            this.btncombo8.Name = "btncombo8";
            this.btncombo8.Size = new System.Drawing.Size(123, 107);
            this.btncombo8.TabIndex = 56;
            this.btncombo8.UseVisualStyleBackColor = true;
            this.btncombo8.Click += new System.EventHandler(this.btncombo8_Click);
            // 
            // btncombo7
            // 
            this.btncombo7.Location = new System.Drawing.Point(318, 306);
            this.btncombo7.Name = "btncombo7";
            this.btncombo7.Size = new System.Drawing.Size(123, 107);
            this.btncombo7.TabIndex = 55;
            this.btncombo7.UseVisualStyleBackColor = true;
            this.btncombo7.Click += new System.EventHandler(this.btncombo7_Click);
            // 
            // btncombo6
            // 
            this.btncombo6.Location = new System.Drawing.Point(177, 306);
            this.btncombo6.Name = "btncombo6";
            this.btncombo6.Size = new System.Drawing.Size(123, 107);
            this.btncombo6.TabIndex = 54;
            this.btncombo6.UseVisualStyleBackColor = true;
            this.btncombo6.Click += new System.EventHandler(this.btncombo6_Click);
            // 
            // btncombo5
            // 
            this.btncombo5.Location = new System.Drawing.Point(29, 306);
            this.btncombo5.Name = "btncombo5";
            this.btncombo5.Size = new System.Drawing.Size(123, 107);
            this.btncombo5.TabIndex = 53;
            this.btncombo5.UseVisualStyleBackColor = true;
            this.btncombo5.Click += new System.EventHandler(this.btncombo5_Click);
            // 
            // btncombo12
            // 
            this.btncombo12.Location = new System.Drawing.Point(458, 430);
            this.btncombo12.Name = "btncombo12";
            this.btncombo12.Size = new System.Drawing.Size(123, 107);
            this.btncombo12.TabIndex = 60;
            this.btncombo12.UseVisualStyleBackColor = true;
            this.btncombo12.Click += new System.EventHandler(this.btncombo12_Click);
            // 
            // btncombo11
            // 
            this.btncombo11.Location = new System.Drawing.Point(318, 430);
            this.btncombo11.Name = "btncombo11";
            this.btncombo11.Size = new System.Drawing.Size(123, 107);
            this.btncombo11.TabIndex = 59;
            this.btncombo11.UseVisualStyleBackColor = true;
            this.btncombo11.Click += new System.EventHandler(this.btncombo11_Click);
            // 
            // btncombo10
            // 
            this.btncombo10.Location = new System.Drawing.Point(177, 430);
            this.btncombo10.Name = "btncombo10";
            this.btncombo10.Size = new System.Drawing.Size(123, 107);
            this.btncombo10.TabIndex = 58;
            this.btncombo10.UseVisualStyleBackColor = true;
            this.btncombo10.Click += new System.EventHandler(this.btncombo10_Click);
            // 
            // btncombo9
            // 
            this.btncombo9.Location = new System.Drawing.Point(29, 430);
            this.btncombo9.Name = "btncombo9";
            this.btncombo9.Size = new System.Drawing.Size(123, 107);
            this.btncombo9.TabIndex = 57;
            this.btncombo9.UseVisualStyleBackColor = true;
            this.btncombo9.Click += new System.EventHandler(this.btncombo9_Click);
            // 
            // dgvpedido
            // 
            this.dgvpedido.AllowUserToAddRows = false;
            this.dgvpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcombo,
            this.name,
            this.cantidad,
            this.price});
            this.dgvpedido.Location = new System.Drawing.Point(612, 154);
            this.dgvpedido.Name = "dgvpedido";
            this.dgvpedido.Size = new System.Drawing.Size(398, 178);
            this.dgvpedido.TabIndex = 62;
            this.dgvpedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpedido_CellContentClick);
            // 
            // Idcombo
            // 
            this.idcombo.HeaderText = "Idcombo";
            this.idcombo.Name = "Idcombo";
            // 
            // name
            // 
            this.name.HeaderText = "nombre";
            this.name.Name = "name";
            // 
            // Cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "Cantidad";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(825, 491);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(68, 24);
            this.lbltotal.TabIndex = 63;
            this.lbltotal.Text = "Total :";
            // 
            // lbltotalcant
            // 
            this.lbltotalcant.AutoSize = true;
            this.lbltotalcant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalcant.ForeColor = System.Drawing.Color.Red;
            this.lbltotalcant.Location = new System.Drawing.Point(899, 491);
            this.lbltotalcant.Name = "lbltotalcant";
            this.lbltotalcant.Size = new System.Drawing.Size(59, 24);
            this.lbltotalcant.TabIndex = 64;
            this.lbltotalcant.Text = "Valor";
            // 
            // dgvExtras
            // 
            this.dgvExtras.AllowUserToAddRows = false;
            this.dgvExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idarticulo,
            this.nombre,
            this.descripcion,
            this.precio});
            this.dgvExtras.Location = new System.Drawing.Point(602, 429);
            this.dgvExtras.Name = "dgvExtras";
            this.dgvExtras.Size = new System.Drawing.Size(398, 139);
            this.dgvExtras.TabIndex = 65;
            // 
            // idarticulo
            // 
            this.idarticulo.HeaderText = "idarticulo";
            this.idarticulo.Name = "idarticulo";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // Precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Extras:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 101;
            this.label2.Text = "Cod.Cliente";
            // 
            // txtnombre_cliente
            // 
            this.txtnombre_cliente.Location = new System.Drawing.Point(186, 86);
            this.txtnombre_cliente.Name = "txtnombre_cliente";
            this.txtnombre_cliente.Size = new System.Drawing.Size(195, 20);
            this.txtnombre_cliente.TabIndex = 102;
            this.txtnombre_cliente.validate = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Tipo Pedido";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(350, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 104;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(68, 86);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(104, 20);
            this.txtidcliente.TabIndex = 105;
            this.txtidcliente.validate = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Nombre Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 108;
            this.label5.Text = "Direccion";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(395, 86);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(195, 20);
            this.txtdireccion.TabIndex = 107;
            this.txtdireccion.validate = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = global::presentation.Properties.Resources.cash_icon;
            this.btnFacturar.Location = new System.Drawing.Point(793, 65);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 61);
            this.btnFacturar.TabIndex = 109;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // button1
            // 
            this.button1.Image = global::presentation.Properties.Resources.customer;
            this.button1.Location = new System.Drawing.Point(612, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 70;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::presentation.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(816, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 61);
            this.btnDelete.TabIndex = 69;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::presentation.Properties.Resources.add_icon;
            this.btnNew.Location = new System.Drawing.Point(662, 362);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(128, 61);
            this.btnNew.TabIndex = 67;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // price
            // 
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            // 
            // PPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 600);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvExtras);
            this.Controls.Add(this.lbltotalcant);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dgvpedido);
            this.Controls.Add(this.btncombo12);
            this.Controls.Add(this.btncombo11);
            this.Controls.Add(this.btncombo10);
            this.Controls.Add(this.btncombo9);
            this.Controls.Add(this.btncombo8);
            this.Controls.Add(this.btncombo7);
            this.Controls.Add(this.btncombo6);
            this.Controls.Add(this.btncombo5);
            this.Controls.Add(this.btncombo4);
            this.Controls.Add(this.btncombo3);
            this.Controls.Add(this.btncombo2);
            this.Controls.Add(this.btncombo1);
            this.Controls.Add(this.label8);
            this.Name = "PPedido";
            this.Text = "PPedido";
            this.Load += new System.EventHandler(this.PPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncombo1;
        private System.Windows.Forms.Button btncombo2;
        private System.Windows.Forms.Button btncombo3;
        private System.Windows.Forms.Button btncombo4;
        private System.Windows.Forms.Button btncombo8;
        private System.Windows.Forms.Button btncombo7;
        private System.Windows.Forms.Button btncombo6;
        private System.Windows.Forms.Button btncombo5;
        private System.Windows.Forms.Button btncombo12;
        private System.Windows.Forms.Button btncombo11;
        private System.Windows.Forms.Button btncombo10;
        private System.Windows.Forms.Button btncombo9;
        private System.Windows.Forms.DataGridView dgvpedido;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltotalcant;
        private System.Windows.Forms.DataGridView dgvExtras;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label2;
        private utils.ntextbox txtnombre_cliente;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private utils.ntextbox txtidcliente;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private utils.ntextbox txtdireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}