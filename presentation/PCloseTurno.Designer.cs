namespace presentation
{
    partial class PCloseTurno
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
            this.txtmonto_inicial = new utils.ntextbox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtopen_timestamp = new utils.ntextbox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtidusuario = new utils.ntextbox(this.components);
            this.txtusuario = new utils.ntextbox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtidcontrol_turno = new utils.ntextbox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtturno_descripcion = new utils.ntextbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtclose_timestamp = new utils.ntextbox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtmonto_cierre = new utils.ntextbox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenTurno = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcaja = new utils.ntextbox(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtmonto_inicial
            // 
            this.txtmonto_inicial.Enabled = false;
            this.txtmonto_inicial.Location = new System.Drawing.Point(315, 461);
            this.txtmonto_inicial.Name = "txtmonto_inicial";
            this.txtmonto_inicial.Size = new System.Drawing.Size(242, 22);
            this.txtmonto_inicial.TabIndex = 128;
            this.txtmonto_inicial.validate = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 457);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 127;
            this.label5.Text = "Monto Inicial";
            // 
            // txtopen_timestamp
            // 
            this.txtopen_timestamp.Enabled = false;
            this.txtopen_timestamp.Location = new System.Drawing.Point(315, 346);
            this.txtopen_timestamp.Name = "txtopen_timestamp";
            this.txtopen_timestamp.Size = new System.Drawing.Size(242, 22);
            this.txtopen_timestamp.TabIndex = 124;
            this.txtopen_timestamp.validate = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 123;
            this.label2.Text = "Fecha y Hora de Apertura";
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(574, 289);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(65, 22);
            this.txtidusuario.TabIndex = 122;
            this.txtidusuario.validate = false;
            this.txtidusuario.Visible = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Enabled = false;
            this.txtusuario.Location = new System.Drawing.Point(315, 288);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(242, 22);
            this.txtusuario.TabIndex = 121;
            this.txtusuario.validate = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 120;
            this.label1.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(294, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 36);
            this.label8.TabIndex = 117;
            this.label8.Text = "Cerrar Turno";
            // 
            // txtidcontrol_turno
            // 
            this.txtidcontrol_turno.Enabled = false;
            this.txtidcontrol_turno.Location = new System.Drawing.Point(315, 177);
            this.txtidcontrol_turno.Name = "txtidcontrol_turno";
            this.txtidcontrol_turno.Size = new System.Drawing.Size(242, 22);
            this.txtidcontrol_turno.TabIndex = 130;
            this.txtidcontrol_turno.validate = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 129;
            this.label3.Text = "Turno ID";
            // 
            // txtturno_descripcion
            // 
            this.txtturno_descripcion.Enabled = false;
            this.txtturno_descripcion.Location = new System.Drawing.Point(315, 225);
            this.txtturno_descripcion.Name = "txtturno_descripcion";
            this.txtturno_descripcion.Size = new System.Drawing.Size(242, 22);
            this.txtturno_descripcion.TabIndex = 132;
            this.txtturno_descripcion.validate = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 131;
            this.label4.Text = "Turno";
            // 
            // txtclose_timestamp
            // 
            this.txtclose_timestamp.Enabled = false;
            this.txtclose_timestamp.Location = new System.Drawing.Point(315, 406);
            this.txtclose_timestamp.Name = "txtclose_timestamp";
            this.txtclose_timestamp.Size = new System.Drawing.Size(242, 22);
            this.txtclose_timestamp.TabIndex = 134;
            this.txtclose_timestamp.validate = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 25);
            this.label6.TabIndex = 133;
            this.label6.Text = "Fecha y Hora de Cierre";
            // 
            // txtmonto_cierre
            // 
            this.txtmonto_cierre.Location = new System.Drawing.Point(315, 517);
            this.txtmonto_cierre.Name = "txtmonto_cierre";
            this.txtmonto_cierre.Size = new System.Drawing.Size(242, 22);
            this.txtmonto_cierre.TabIndex = 136;
            this.txtmonto_cierre.validate = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 514);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 135;
            this.label7.Text = "Monto de Cierre";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::presentation.Properties.Resources.User_Interface_Login_icon;
            this.btnClose.Location = new System.Drawing.Point(384, 586);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 89);
            this.btnClose.TabIndex = 138;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpenTurno
            // 
            this.btnOpenTurno.Image = global::presentation.Properties.Resources.close;
            this.btnOpenTurno.Location = new System.Drawing.Point(242, 586);
            this.btnOpenTurno.Name = "btnOpenTurno";
            this.btnOpenTurno.Size = new System.Drawing.Size(127, 89);
            this.btnOpenTurno.TabIndex = 137;
            this.btnOpenTurno.UseVisualStyleBackColor = true;
            this.btnOpenTurno.Click += new System.EventHandler(this.btnOpenTurno_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(204, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 139;
            this.label9.Text = "Caja";
            // 
            // txtcaja
            // 
            this.txtcaja.Enabled = false;
            this.txtcaja.Location = new System.Drawing.Point(315, 110);
            this.txtcaja.Name = "txtcaja";
            this.txtcaja.Size = new System.Drawing.Size(242, 22);
            this.txtcaja.TabIndex = 140;
            this.txtcaja.validate = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PCloseTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 740);
            this.Controls.Add(this.txtcaja);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpenTurno);
            this.Controls.Add(this.txtmonto_cierre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtclose_timestamp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtturno_descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidcontrol_turno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmonto_inicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtopen_timestamp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "PCloseTurno";
            this.Text = "PCloseTurno";
            this.Load += new System.EventHandler(this.PCloseTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private utils.ntextbox txtmonto_inicial;
        public System.Windows.Forms.Label label5;
        private utils.ntextbox txtopen_timestamp;
        public System.Windows.Forms.Label label2;
        private utils.ntextbox txtidusuario;
        private utils.ntextbox txtusuario;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label8;
        private utils.ntextbox txtidcontrol_turno;
        public System.Windows.Forms.Label label3;
        private utils.ntextbox txtturno_descripcion;
        public System.Windows.Forms.Label label4;
        private utils.ntextbox txtclose_timestamp;
        public System.Windows.Forms.Label label6;
        private utils.ntextbox txtmonto_cierre;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpenTurno;
        public System.Windows.Forms.Label label9;
        private utils.ntextbox txtcaja;
        private System.Windows.Forms.Timer timer1;
    }
}