namespace ordery
{
    partial class PLogin
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new utils.ntextbox(this.components);
            this.txtusername = new utils.ntextbox(this.components);
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 117;
            this.label9.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 119;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 121;
            this.label2.Text = "Login";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::ordery.Properties.Resources.Undo_icon;
            this.btncancelar.Location = new System.Drawing.Point(174, 182);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(106, 72);
            this.btncancelar.TabIndex = 124;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::ordery.Properties.Resources.User_Interface_Login_icon;
            this.btnsalir.Location = new System.Drawing.Point(296, 182);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(106, 72);
            this.btnsalir.TabIndex = 123;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Image = global::ordery.Properties.Resources.Login_icon;
            this.btnlogin.Location = new System.Drawing.Point(48, 182);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(106, 72);
            this.btnlogin.TabIndex = 122;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(178, 133);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '•';
            this.txtpassword.Size = new System.Drawing.Size(193, 20);
            this.txtpassword.TabIndex = 120;
            this.txtpassword.validate = false;
            this.txtpassword.TextChanged += new System.EventHandler(this.ntextbox1_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(178, 85);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(193, 20);
            this.txtusername.TabIndex = 118;
            this.txtusername.validate = false;
            // 
            // PLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 266);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label9);
            this.Name = "PLogin";
            this.Text = "PLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private utils.ntextbox txtusername;
        public System.Windows.Forms.Label label9;
        private utils.ntextbox txtpassword;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnlogin;
        public System.Windows.Forms.Button btnsalir;
        public System.Windows.Forms.Button btncancelar;
    }
}