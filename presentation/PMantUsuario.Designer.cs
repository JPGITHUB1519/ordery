namespace presentation
{
    partial class PMantUsuario
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
            this.txtpassword = new utils.ntextbox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new utils.ntextbox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtconfirm = new utils.ntextbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtidusuario = new utils.ntextbox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.chk_is_active = new System.Windows.Forms.CheckBox();
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
            this.label8.Size = new System.Drawing.Size(331, 29);
            this.label8.Text = "Mantenimiento de Usuarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_is_active);
            this.groupBox1.Controls.Add(this.txtidusuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtconfirm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Text = "Usuarios";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(347, 134);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '•';
            this.txtpassword.Size = new System.Drawing.Size(193, 20);
            this.txtpassword.TabIndex = 99;
            this.txtpassword.validate = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(347, 91);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(193, 20);
            this.txtusername.TabIndex = 97;
            this.txtusername.validate = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "Nombre";
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(347, 184);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '•';
            this.txtconfirm.Size = new System.Drawing.Size(193, 20);
            this.txtconfirm.TabIndex = 101;
            this.txtconfirm.validate = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "Confirme Password";
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(347, 47);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(193, 20);
            this.txtidusuario.TabIndex = 103;
            this.txtidusuario.validate = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 102;
            this.label5.Text = "IdUsuario";
            // 
            // chk_is_active
            // 
            this.chk_is_active.AutoSize = true;
            this.chk_is_active.Location = new System.Drawing.Point(347, 236);
            this.chk_is_active.Name = "chk_is_active";
            this.chk_is_active.Size = new System.Drawing.Size(73, 17);
            this.chk_is_active.TabIndex = 104;
            this.chk_is_active.Text = "Is Active?";
            this.chk_is_active.UseVisualStyleBackColor = true;
            // 
            // PMantUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 659);
            this.Name = "PMantUsuario";
            this.Text = "PMantUsuario";
            this.Load += new System.EventHandler(this.PMantUsuario_Load);
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

        private utils.ntextbox txtidusuario;
        public System.Windows.Forms.Label label5;
        private utils.ntextbox txtconfirm;
        public System.Windows.Forms.Label label4;
        private utils.ntextbox txtpassword;
        public System.Windows.Forms.Label label1;
        private utils.ntextbox txtusername;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_is_active;
    }
}