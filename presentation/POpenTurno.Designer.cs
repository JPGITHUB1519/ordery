namespace presentation
{
    partial class POpenTurno
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
            this.txttimestamp = new utils.ntextbox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtidusuario = new utils.ntextbox(this.components);
            this.txtusuario = new utils.ntextbox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbcaja = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmonto_inicial = new utils.ntextbox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenTurno = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txttimestamp
            // 
            this.txttimestamp.Enabled = false;
            this.txttimestamp.Location = new System.Drawing.Point(372, 307);
            this.txttimestamp.Name = "txttimestamp";
            this.txttimestamp.Size = new System.Drawing.Size(242, 22);
            this.txttimestamp.TabIndex = 110;
            this.txttimestamp.validate = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 109;
            this.label2.Text = "Fecha y Hora de Apertura";
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(631, 243);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(65, 22);
            this.txtidusuario.TabIndex = 108;
            this.txtidusuario.validate = false;
            this.txtidusuario.Visible = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Enabled = false;
            this.txtusuario.Location = new System.Drawing.Point(372, 242);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(242, 22);
            this.txtusuario.TabIndex = 107;
            this.txtusuario.validate = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 106;
            this.label1.Text = "Usuario";
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(372, 181);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(242, 24);
            this.cmbTurno.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 104;
            this.label3.Text = "Seleccione Turno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(336, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 36);
            this.label8.TabIndex = 103;
            this.label8.Text = "Abrir Turno";
            // 
            // cmbcaja
            // 
            this.cmbcaja.FormattingEnabled = true;
            this.cmbcaja.Location = new System.Drawing.Point(372, 120);
            this.cmbcaja.Name = "cmbcaja";
            this.cmbcaja.Size = new System.Drawing.Size(242, 24);
            this.cmbcaja.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 113;
            this.label4.Text = "Seleccione Caja";
            // 
            // txtmonto_inicial
            // 
            this.txtmonto_inicial.Location = new System.Drawing.Point(372, 366);
            this.txtmonto_inicial.Name = "txtmonto_inicial";
            this.txtmonto_inicial.Size = new System.Drawing.Size(242, 22);
            this.txtmonto_inicial.TabIndex = 116;
            this.txtmonto_inicial.validate = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 115;
            this.label5.Text = "Monto Inicial";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::presentation.Properties.Resources.User_Interface_Login_icon;
            this.btnClose.Location = new System.Drawing.Point(411, 429);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 89);
            this.btnClose.TabIndex = 112;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpenTurno
            // 
            this.btnOpenTurno.Image = global::presentation.Properties.Resources.open;
            this.btnOpenTurno.Location = new System.Drawing.Point(269, 429);
            this.btnOpenTurno.Name = "btnOpenTurno";
            this.btnOpenTurno.Size = new System.Drawing.Size(127, 89);
            this.btnOpenTurno.TabIndex = 111;
            this.btnOpenTurno.UseVisualStyleBackColor = true;
            this.btnOpenTurno.Click += new System.EventHandler(this.btnOpenTurno_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // POpenTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 555);
            this.Controls.Add(this.txtmonto_inicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbcaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpenTurno);
            this.Controls.Add(this.txttimestamp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Name = "POpenTurno";
            this.Text = "POpenTurno";
            this.Load += new System.EventHandler(this.POpenTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpenTurno;
        private utils.ntextbox txttimestamp;
        public System.Windows.Forms.Label label2;
        private utils.ntextbox txtidusuario;
        private utils.ntextbox txtusuario;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTurno;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbcaja;
        public System.Windows.Forms.Label label4;
        private utils.ntextbox txtmonto_inicial;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}