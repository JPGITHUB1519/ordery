using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation
{
    public partial class testing : Form
    {
        public testing()
        {
            InitializeComponent();
        }

        private void testing_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int top = 50;
            int left = 100;
            int cant = 10;
            for(int i = 0; i < 10; i++)
            {
                Button boton = new Button();
                boton.Left = left;
                boton.Top = top;
                this.Controls.Add(boton);
                top += boton.Height + 2;
            }
        }
    }
}
