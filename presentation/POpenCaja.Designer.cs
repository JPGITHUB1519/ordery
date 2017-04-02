namespace presentation
{
    partial class POpenCaja
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbcaja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txttimestamp = new utils.ntextbox(this.components);
            this.txtidusuario = new utils.ntextbox(this.components);
            this.txtusuario = new utils.ntextbox(this.components);
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(283, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 36);
            this.label8.TabIndex = 48;
            this.label8.Text = "Abrir Caja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 94;
            this.label3.Text = "Seleccione Caja";
            // 
            // cmbcaja
            // 
            this.cmbcaja.FormattingEnabled = true;
            this.cmbcaja.Location = new System.Drawing.Point(322, 111);
            this.cmbcaja.Name = "cmbcaja";
            this.cmbcaja.Size = new System.Drawing.Size(242, 24);
            this.cmbcaja.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 96;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 99;
            this.label2.Text = "Fecha y Hora de Apertura";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Image = global::presentation.Properties.Resources.caja;
            this.button1.Location = new System.Drawing.Point(216, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 89);
            this.button1.TabIndex = 101;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::presentation.Properties.Resources.User_Interface_Login_icon;
            this.button2.Location = new System.Drawing.Point(358, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 89);
            this.button2.TabIndex = 102;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txttimestamp
            // 
            this.txttimestamp.Enabled = false;
            this.txttimestamp.Location = new System.Drawing.Point(322, 237);
            this.txttimestamp.Name = "txttimestamp";
            this.txttimestamp.Size = new System.Drawing.Size(242, 22);
            this.txttimestamp.TabIndex = 100;
            this.txttimestamp.validate = false;
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(582, 173);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(65, 22);
            this.txtidusuario.TabIndex = 98;
            this.txtidusuario.validate = false;
            this.txtidusuario.Visible = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Enabled = false;
            this.txtusuario.Location = new System.Drawing.Point(322, 172);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(242, 22);
            this.txtusuario.TabIndex = 97;
            this.txtusuario.validate = false;
            // 
            // POpenCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 407);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttimestamp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbcaja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Name = "POpenCaja";
            this.Text = "frmOpenCaja";
            this.Load += new System.EventHandler(this.frmOpenCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbcaja;
        public System.Windows.Forms.Label label1;
        private utils.ntextbox txtusuario;
        private utils.ntextbox txtidusuario;
        public System.Windows.Forms.Label label2;
        private utils.ntextbox txttimestamp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}