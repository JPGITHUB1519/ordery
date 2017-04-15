namespace presentation
{
    partial class PPedidoDetail
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
            this.txtidpedido = new utils.ntextbox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtcliente = new utils.ntextbox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new utils.ntextbox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(367, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 36);
            this.label8.TabIndex = 49;
            this.label8.Text = "Pedido Details";
            // 
            // txtidpedido
            // 
            this.txtidpedido.Location = new System.Drawing.Point(162, 99);
            this.txtidpedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtidpedido.Name = "txtidpedido";
            this.txtidpedido.ReadOnly = true;
            this.txtidpedido.Size = new System.Drawing.Size(256, 22);
            this.txtidpedido.TabIndex = 105;
            this.txtidpedido.validate = false;
            this.txtidpedido.TextChanged += new System.EventHandler(this.txtidpedido_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 104;
            this.label5.Text = "idpedido";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(574, 99);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(256, 22);
            this.txtcliente.TabIndex = 107;
            this.txtcliente.validate = false;
            this.txtcliente.TextChanged += new System.EventHandler(this.txtidcliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 106;
            this.label1.Text = "Cliente";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(427, 168);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = true;
            this.txtusername.Size = new System.Drawing.Size(256, 22);
            this.txtusername.TabIndex = 109;
            this.txtusername.validate = false;
            this.txtusername.TextChanged += new System.EventHandler(this.txtidusuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 108;
            this.label2.Text = "Cajero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(367, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 36);
            this.label3.TabIndex = 110;
            this.label3.Text = "Detalle Pedido";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(263, 295);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 260);
            this.listBox1.TabIndex = 111;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PPedidoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 595);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidpedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Name = "PPedidoDetail";
            this.Text = "PPedidoDetail";
            this.Load += new System.EventHandler(this.PPedidoDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        private utils.ntextbox txtidpedido;
        public System.Windows.Forms.Label label5;
        private utils.ntextbox txtcliente;
        public System.Windows.Forms.Label label1;
        private utils.ntextbox txtusername;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
    }
}