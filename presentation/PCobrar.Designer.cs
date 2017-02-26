namespace presentation
{
    partial class PCobrar
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
            this.txtidarticulo = new utils.ntextbox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ntextbox1 = new utils.ntextbox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ntextbox2 = new utils.ntextbox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(181, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 29);
            this.label8.TabIndex = 48;
            this.label8.Text = "Cobrar";
            // 
            // txtidarticulo
            // 
            this.txtidarticulo.Location = new System.Drawing.Point(186, 101);
            this.txtidarticulo.Name = "txtidarticulo";
            this.txtidarticulo.Size = new System.Drawing.Size(193, 20);
            this.txtidarticulo.TabIndex = 95;
            this.txtidarticulo.validate = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 94;
            this.label3.Text = "Total a Pagar";
            // 
            // ntextbox1
            // 
            this.ntextbox1.Location = new System.Drawing.Point(186, 157);
            this.ntextbox1.Name = "ntextbox1";
            this.ntextbox1.Size = new System.Drawing.Size(193, 20);
            this.ntextbox1.TabIndex = 97;
            this.ntextbox1.validate = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Pagar Con";
            // 
            // ntextbox2
            // 
            this.ntextbox2.Location = new System.Drawing.Point(186, 207);
            this.ntextbox2.Name = "ntextbox2";
            this.ntextbox2.Size = new System.Drawing.Size(193, 20);
            this.ntextbox2.TabIndex = 99;
            this.ntextbox2.validate = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "Cambio";
            // 
            // PCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 379);
            this.Controls.Add(this.ntextbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ntextbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidarticulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Name = "PCobrar";
            this.Text = "PCobrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        private utils.ntextbox txtidarticulo;
        public System.Windows.Forms.Label label3;
        private utils.ntextbox ntextbox1;
        public System.Windows.Forms.Label label1;
        private utils.ntextbox ntextbox2;
        public System.Windows.Forms.Label label2;
    }
}