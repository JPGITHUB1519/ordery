namespace presentation
{
    partial class PMantCombo
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
            this.txtnombre = new utils.ntextbox(this.components);
            this.txtidcombo = new utils.ntextbox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprecio = new utils.ntextbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.rchdescripcion = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnArticuloInsert = new System.Windows.Forms.Button();
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.btnLoadimage = new System.Windows.Forms.Button();
            this.btnQuitImage = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabpmantenimiento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabplistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Size = new System.Drawing.Size(325, 29);
            this.label8.Text = "Mantenimiento de Combos";
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Size = new System.Drawing.Size(912, 618);
            // 
            // tabpmantenimiento
            // 
            this.tabpmantenimiento.Size = new System.Drawing.Size(904, 592);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnArticuloInsert);
            this.groupBox2.Location = new System.Drawing.Point(6, 454);
            this.groupBox2.Size = new System.Drawing.Size(868, 122);
            this.groupBox2.Controls.SetChildIndex(this.btnNew, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnCancel, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnExit, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnDelete, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnSave, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnEdit, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnArticuloInsert, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(510, 19);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(744, 19);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(632, 19);
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitImage);
            this.groupBox1.Controls.Add(this.btnLoadimage);
            this.groupBox1.Controls.Add(this.picPicture);
            this.groupBox1.Controls.Add(this.rchdescripcion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtidcombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Size = new System.Drawing.Size(713, 387);
            this.groupBox1.Text = "Combos";
            // 
            // tabplistado
            // 
            this.tabplistado.Size = new System.Drawing.Size(904, 592);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(151, 90);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(193, 20);
            this.txtnombre.TabIndex = 98;
            this.txtnombre.validate = false;
            // 
            // txtidcombo
            // 
            this.txtidcombo.Location = new System.Drawing.Point(151, 49);
            this.txtidcombo.Name = "txtidcombo";
            this.txtidcombo.Size = new System.Drawing.Size(193, 20);
            this.txtidcombo.TabIndex = 97;
            this.txtidcombo.validate = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "IdCombo";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(151, 135);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(193, 20);
            this.txtprecio.TabIndex = 100;
            this.txtprecio.validate = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 99;
            this.label4.Text = "Precio";
            // 
            // rchdescripcion
            // 
            this.rchdescripcion.Location = new System.Drawing.Point(151, 190);
            this.rchdescripcion.Name = "rchdescripcion";
            this.rchdescripcion.Size = new System.Drawing.Size(204, 122);
            this.rchdescripcion.TabIndex = 107;
            this.rchdescripcion.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 106;
            this.label5.Text = "Descripción";
            // 
            // btnArticuloInsert
            // 
            this.btnArticuloInsert.Image = global::presentation.Properties.Resources.food_icon;
            this.btnArticuloInsert.Location = new System.Drawing.Point(389, 19);
            this.btnArticuloInsert.Name = "btnArticuloInsert";
            this.btnArticuloInsert.Size = new System.Drawing.Size(106, 72);
            this.btnArticuloInsert.TabIndex = 14;
            this.btnArticuloInsert.UseVisualStyleBackColor = true;
            this.btnArticuloInsert.Click += new System.EventHandler(this.btnArticuloInsert_Click);
            // 
            // picPicture
            // 
            this.picPicture.BackgroundImage = global::presentation.Properties.Resources.transparent;
            this.picPicture.Location = new System.Drawing.Point(389, 47);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(158, 150);
            this.picPicture.TabIndex = 108;
            this.picPicture.TabStop = false;
            // 
            // btnLoadimage
            // 
            this.btnLoadimage.Image = global::presentation.Properties.Resources.Pictures_icon;
            this.btnLoadimage.Location = new System.Drawing.Point(554, 47);
            this.btnLoadimage.Name = "btnLoadimage";
            this.btnLoadimage.Size = new System.Drawing.Size(106, 72);
            this.btnLoadimage.TabIndex = 109;
            this.btnLoadimage.UseVisualStyleBackColor = true;
            this.btnLoadimage.Click += new System.EventHandler(this.btnLoadimage_Click);
            // 
            // btnQuitImage
            // 
            this.btnQuitImage.Image = global::presentation.Properties.Resources.picture_delete_icon;
            this.btnQuitImage.Location = new System.Drawing.Point(554, 125);
            this.btnQuitImage.Name = "btnQuitImage";
            this.btnQuitImage.Size = new System.Drawing.Size(106, 72);
            this.btnQuitImage.TabIndex = 110;
            this.btnQuitImage.UseVisualStyleBackColor = true;
            this.btnQuitImage.Click += new System.EventHandler(this.btnQuitImage_Click);
            // 
            // PMantCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 737);
            this.Name = "PMantCombo";
            this.Text = "PMantCombo";
            this.Load += new System.EventHandler(this.PMantCombo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpmantenimiento.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabplistado.ResumeLayout(false);
            this.tabplistado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private utils.ntextbox txtprecio;
        public System.Windows.Forms.Label label4;
        private utils.ntextbox txtnombre;
        private utils.ntextbox txtidcombo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rchdescripcion;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnArticuloInsert;
        public System.Windows.Forms.Button btnQuitImage;
        public System.Windows.Forms.Button btnLoadimage;
        private System.Windows.Forms.PictureBox picPicture;
    }
}