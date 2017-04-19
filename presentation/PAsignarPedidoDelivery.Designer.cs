namespace presentation
{
    partial class PAsignarPedidoDelivery
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_buscar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(281, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(384, 36);
            this.label8.TabIndex = 50;
            this.label8.Text = "Asignar Pedido a Delivery";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(229, 109);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(423, 22);
            this.txtbuscar.TabIndex = 73;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 378);
            this.dataGridView1.TabIndex = 75;
            // 
            // button1
            // 
            this.button1.Image = global::presentation.Properties.Resources.motorcyclist_icon;
            this.button1.Location = new System.Drawing.Point(439, 576);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 65);
            this.button1.TabIndex = 76;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_buscar2
            // 
            this.btn_buscar2.Image = global::presentation.Properties.Resources.search;
            this.btn_buscar2.Location = new System.Drawing.Point(697, 88);
            this.btn_buscar2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar2.Name = "btn_buscar2";
            this.btn_buscar2.Size = new System.Drawing.Size(114, 65);
            this.btn_buscar2.TabIndex = 74;
            this.btn_buscar2.UseVisualStyleBackColor = true;
            this.btn_buscar2.Click += new System.EventHandler(this.btn_buscar2_Click);
            // 
            // PAsignarPedidoDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar2);
            this.Controls.Add(this.label8);
            this.Name = "PAsignarPedidoDelivery";
            this.Text = "PAsignarPedidoDelivery";
            this.Load += new System.EventHandler(this.PAsignarPedidoDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtbuscar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_buscar2;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button1;
    }
}