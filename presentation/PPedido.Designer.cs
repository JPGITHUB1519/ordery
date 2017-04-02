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
            this.Idcombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltotalcant = new System.Windows.Forms.Label();
            this.dgvExtras = new System.Windows.Forms.DataGridView();
            this.artidarticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artPUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoPedido = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtNombreCajero = new utils.ntextbox(this.components);
            this.txtdireccion = new utils.ntextbox(this.components);
            this.txtidcliente = new utils.ntextbox(this.components);
            this.txtnombre_cliente = new utils.ntextbox(this.components);
            this.btnFacturar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtcambio = new utils.ntextbox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtPagarCon = new utils.ntextbox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txttotal = new utils.ntextbox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.idarticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtturno = new utils.ntextbox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtras)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(559, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 36);
            this.label8.TabIndex = 48;
            this.label8.Text = "Pedidos";
            // 
            // btncombo1
            // 
            this.btncombo1.Location = new System.Drawing.Point(37, 268);
            this.btncombo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncombo1.Name = "btncombo1";
            this.btncombo1.Size = new System.Drawing.Size(164, 132);
            this.btncombo1.TabIndex = 49;
            this.btncombo1.UseVisualStyleBackColor = true;
            this.btncombo1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncombo2
            // 
            this.btncombo2.Location = new System.Drawing.Point(235, 268);
            this.btncombo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncombo2.Name = "btncombo2";
            this.btncombo2.Size = new System.Drawing.Size(164, 132);
            this.btncombo2.TabIndex = 50;
            this.btncombo2.UseVisualStyleBackColor = true;
            this.btncombo2.Click += new System.EventHandler(this.btncombo2_Click);
            // 
            // btncombo3
            // 
            this.btncombo3.Location = new System.Drawing.Point(423, 268);
            this.btncombo3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncombo3.Name = "btncombo3";
            this.btncombo3.Size = new System.Drawing.Size(164, 132);
            this.btncombo3.TabIndex = 51;
            this.btncombo3.UseVisualStyleBackColor = true;
            this.btncombo3.Click += new System.EventHandler(this.btncombo3_Click);
            // 
            // btncombo4
            // 
            this.btncombo4.Location = new System.Drawing.Point(609, 268);
            this.btncombo4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncombo4.Name = "btncombo4";
            this.btncombo4.Size = new System.Drawing.Size(164, 132);
            this.btncombo4.TabIndex = 52;
            this.btncombo4.UseVisualStyleBackColor = true;
            this.btncombo4.Click += new System.EventHandler(this.btncombo4_Click);
            // 
            // btncombo8
            // 
            this.btncombo8.Location = new System.Drawing.Point(609, 427);
            this.btncombo8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncombo8.Name = "btncombo8";
            this.btncombo8.Size = new System.Drawing.Size(164, 132);
            this.btncombo8.TabIndex = 56;
            this.btncombo8.UseVisualStyleBackColor = true;
            this.btncombo8.Click += new System.EventHandler(this.btncombo8_Click);
            // 
            // btncombo7
            // 
            this.btncombo7.Location = new System.Drawing.Point(423, 427);
            this.btncombo7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncombo7.Name = "btncombo7";
            this.btncombo7.Size = new System.Drawing.Size(164, 132);
            this.btncombo7.TabIndex = 55;
            this.btncombo7.UseVisualStyleBackColor = true;
            this.btncombo7.Click += new System.EventHandler(this.btncombo7_Click);
            // 
            // btncombo6
            // 
            this.btncombo6.Location = new System.Drawing.Point(235, 427);
            this.btncombo6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncombo6.Name = "btncombo6";
            this.btncombo6.Size = new System.Drawing.Size(164, 132);
            this.btncombo6.TabIndex = 54;
            this.btncombo6.UseVisualStyleBackColor = true;
            this.btncombo6.Click += new System.EventHandler(this.btncombo6_Click);
            // 
            // btncombo5
            // 
            this.btncombo5.Location = new System.Drawing.Point(37, 427);
            this.btncombo5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncombo5.Name = "btncombo5";
            this.btncombo5.Size = new System.Drawing.Size(164, 132);
            this.btncombo5.TabIndex = 53;
            this.btncombo5.UseVisualStyleBackColor = true;
            this.btncombo5.Click += new System.EventHandler(this.btncombo5_Click);
            // 
            // btncombo12
            // 
            this.btncombo12.Location = new System.Drawing.Point(609, 580);
            this.btncombo12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncombo12.Name = "btncombo12";
            this.btncombo12.Size = new System.Drawing.Size(164, 132);
            this.btncombo12.TabIndex = 60;
            this.btncombo12.UseVisualStyleBackColor = true;
            this.btncombo12.Click += new System.EventHandler(this.btncombo12_Click);
            // 
            // btncombo11
            // 
            this.btncombo11.Location = new System.Drawing.Point(423, 580);
            this.btncombo11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncombo11.Name = "btncombo11";
            this.btncombo11.Size = new System.Drawing.Size(164, 132);
            this.btncombo11.TabIndex = 59;
            this.btncombo11.UseVisualStyleBackColor = true;
            this.btncombo11.Click += new System.EventHandler(this.btncombo11_Click);
            // 
            // btncombo10
            // 
            this.btncombo10.Location = new System.Drawing.Point(235, 580);
            this.btncombo10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncombo10.Name = "btncombo10";
            this.btncombo10.Size = new System.Drawing.Size(164, 132);
            this.btncombo10.TabIndex = 58;
            this.btncombo10.UseVisualStyleBackColor = true;
            this.btncombo10.Click += new System.EventHandler(this.btncombo10_Click);
            // 
            // btncombo9
            // 
            this.btncombo9.Location = new System.Drawing.Point(37, 580);
            this.btncombo9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncombo9.Name = "btncombo9";
            this.btncombo9.Size = new System.Drawing.Size(164, 132);
            this.btncombo9.TabIndex = 57;
            this.btncombo9.UseVisualStyleBackColor = true;
            this.btncombo9.Click += new System.EventHandler(this.btncombo9_Click);
            // 
            // dgvpedido
            // 
            this.dgvpedido.AllowUserToAddRows = false;
            this.dgvpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idcombo,
            this.name,
            this.Cantidad,
            this.price,
            this.importe});
            this.dgvpedido.Location = new System.Drawing.Point(811, 240);
            this.dgvpedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvpedido.Name = "dgvpedido";
            this.dgvpedido.Size = new System.Drawing.Size(487, 219);
            this.dgvpedido.TabIndex = 62;
            this.dgvpedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpedido_CellContentClick);
            // 
            // Idcombo
            // 
            this.Idcombo.HeaderText = "Idcombo";
            this.Idcombo.Name = "Idcombo";
            // 
            // name
            // 
            this.name.HeaderText = "nombre";
            this.name.Name = "name";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // price
            // 
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            // 
            // importe
            // 
            this.importe.HeaderText = "importe";
            this.importe.Name = "importe";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(1095, 655);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(87, 29);
            this.lbltotal.TabIndex = 63;
            this.lbltotal.Text = "Total :";
            // 
            // lbltotalcant
            // 
            this.lbltotalcant.AutoSize = true;
            this.lbltotalcant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalcant.ForeColor = System.Drawing.Color.Red;
            this.lbltotalcant.Location = new System.Drawing.Point(1193, 655);
            this.lbltotalcant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalcant.Name = "lbltotalcant";
            this.lbltotalcant.Size = new System.Drawing.Size(74, 29);
            this.lbltotalcant.TabIndex = 64;
            this.lbltotalcant.Text = "Valor";
            // 
            // dgvExtras
            // 
            this.dgvExtras.AllowUserToAddRows = false;
            this.dgvExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artidarticulo,
            this.artnombre,
            this.artPUnitario,
            this.artCantidad,
            this.artImporte});
            this.dgvExtras.Location = new System.Drawing.Point(797, 578);
            this.dgvExtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvExtras.Name = "dgvExtras";
            this.dgvExtras.Size = new System.Drawing.Size(531, 171);
            this.dgvExtras.TabIndex = 65;
            this.dgvExtras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExtras_CellContentClick);
            // 
            // artidarticulo
            // 
            this.artidarticulo.HeaderText = "idarticulo";
            this.artidarticulo.Name = "artidarticulo";
            // 
            // artnombre
            // 
            this.artnombre.HeaderText = "Nombre";
            this.artnombre.Name = "artnombre";
            // 
            // artPUnitario
            // 
            this.artPUnitario.HeaderText = "PrecioUnitario";
            this.artPUnitario.Name = "artPUnitario";
            // 
            // artCantidad
            // 
            this.artCantidad.HeaderText = "Cantidad";
            this.artCantidad.Name = "artCantidad";
            // 
            // artImporte
            // 
            this.artImporte.HeaderText = "Importe";
            this.artImporte.Name = "artImporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1047, 463);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 66;
            this.label1.Text = "Extras:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 101;
            this.label2.Text = "Cod.Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 103;
            this.label3.Text = "Tipo Pedido";
            // 
            // cmbTipoPedido
            // 
            this.cmbTipoPedido.FormattingEnabled = true;
            this.cmbTipoPedido.Location = new System.Drawing.Point(462, 224);
            this.cmbTipoPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoPedido.Name = "cmbTipoPedido";
            this.cmbTipoPedido.Size = new System.Drawing.Size(225, 24);
            this.cmbTipoPedido.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 106;
            this.label4.Text = "Nombre Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 108;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 110;
            this.label6.Text = "Cajero";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Blue;
            this.lblfecha.Location = new System.Drawing.Point(37, 11);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(141, 25);
            this.lblfecha.TabIndex = 112;
            this.lblfecha.Text = "Fecha y Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtNombreCajero
            // 
            this.txtNombreCajero.Enabled = false;
            this.txtNombreCajero.Location = new System.Drawing.Point(126, 73);
            this.txtNombreCajero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCajero.Name = "txtNombreCajero";
            this.txtNombreCajero.Size = new System.Drawing.Size(259, 22);
            this.txtNombreCajero.TabIndex = 111;
            this.txtNombreCajero.validate = false;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(522, 168);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(259, 22);
            this.txtdireccion.TabIndex = 107;
            this.txtdireccion.validate = false;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(86, 168);
            this.txtidcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(137, 22);
            this.txtidcliente.TabIndex = 105;
            this.txtidcliente.validate = false;
            // 
            // txtnombre_cliente
            // 
            this.txtnombre_cliente.Location = new System.Drawing.Point(244, 168);
            this.txtnombre_cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnombre_cliente.Name = "txtnombre_cliente";
            this.txtnombre_cliente.Size = new System.Drawing.Size(259, 22);
            this.txtnombre_cliente.TabIndex = 102;
            this.txtnombre_cliente.validate = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = global::presentation.Properties.Resources.cash_icon;
            this.btnFacturar.Location = new System.Drawing.Point(1151, 151);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(100, 64);
            this.btnFacturar.TabIndex = 109;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // button1
            // 
            this.button1.Image = global::presentation.Properties.Resources.customer;
            this.button1.Location = new System.Drawing.Point(811, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 75);
            this.button1.TabIndex = 70;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::presentation.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(1083, 496);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 75);
            this.btnDelete.TabIndex = 69;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::presentation.Properties.Resources.add_icon;
            this.btnNew.Location = new System.Drawing.Point(877, 496);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(171, 75);
            this.btnNew.TabIndex = 67;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtcambio
            // 
            this.txtcambio.Enabled = false;
            this.txtcambio.Location = new System.Drawing.Point(1083, 119);
            this.txtcambio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(256, 22);
            this.txtcambio.TabIndex = 118;
            this.txtcambio.validate = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(956, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 117;
            this.label7.Text = "Cambio";
            // 
            // txtPagarCon
            // 
            this.txtPagarCon.Location = new System.Drawing.Point(1083, 71);
            this.txtPagarCon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPagarCon.Name = "txtPagarCon";
            this.txtPagarCon.Size = new System.Drawing.Size(256, 22);
            this.txtPagarCon.TabIndex = 116;
            this.txtPagarCon.validate = false;
            this.txtPagarCon.TextChanged += new System.EventHandler(this.txtPagarCon_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(928, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 115;
            this.label9.Text = "Pagar Con";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(1083, 22);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(256, 22);
            this.txttotal.TabIndex = 114;
            this.txttotal.validate = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(913, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 25);
            this.label10.TabIndex = 113;
            this.label10.Text = "Total a Pagar";
            // 
            // idarticulo
            // 
            this.idarticulo.HeaderText = "IdArticulo";
            this.idarticulo.Name = "idarticulo";
            // 
            // anombre
            // 
            this.anombre.HeaderText = "Nombre";
            this.anombre.Name = "anombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(408, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 25);
            this.label11.TabIndex = 119;
            this.label11.Text = "Turno";
            // 
            // txtturno
            // 
            this.txtturno.Enabled = false;
            this.txtturno.Location = new System.Drawing.Point(494, 74);
            this.txtturno.Margin = new System.Windows.Forms.Padding(4);
            this.txtturno.Name = "txtturno";
            this.txtturno.Size = new System.Drawing.Size(259, 22);
            this.txtturno.TabIndex = 120;
            this.txtturno.validate = false;
            // 
            // PPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 794);
            this.Controls.Add(this.txtturno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPagarCon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.txtNombreCajero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.cmbTipoPedido);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label2;
        private utils.ntextbox txtnombre_cliente;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoPedido;
        private utils.ntextbox txtidcliente;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private utils.ntextbox txtdireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idcombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        public System.Windows.Forms.Label label6;
        private utils.ntextbox txtNombreCajero;
        public System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private utils.ntextbox txtcambio;
        public System.Windows.Forms.Label label7;
        private utils.ntextbox txtPagarCon;
        public System.Windows.Forms.Label label9;
        private utils.ntextbox txttotal;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn anombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn artidarticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn artnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn artPUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn artCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn artImporte;
        public System.Windows.Forms.Label label11;
        private utils.ntextbox txtturno;
    }
}