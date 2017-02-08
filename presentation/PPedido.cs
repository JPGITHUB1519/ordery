using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using data;

namespace presentation
{
    public partial class PPedido : Form
    {
        public void setImageToButtonFromDatabase(Button button, DataRow dr)
        {
            byte[] imagenBuffer = (byte[])dr["image"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            button.BackgroundImage = Image.FromStream(ms);
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public PPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void PPedido_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = database.executeQuery("SELECT * from combos").Tables[0];
            int cont = 0;
            foreach (DataRow dr in dt.Rows)
            {
                cont++;
                switch(cont)
                {
                    case 1:
                    {
                        this.setImageToButtonFromDatabase(this.btncombo1, dr);
                        break;
                    }
                    case 2:
                    {
                        this.setImageToButtonFromDatabase(this.btncombo2, dr);
                        break;
                    }
                    case 3:
                    {
                        this.setImageToButtonFromDatabase(this.btncombo3, dr);
                        break;
                    }
                    case 4:
                    {
                        this.setImageToButtonFromDatabase(this.btncombo4, dr);
                        break;
                    }
                    case 5:
                    {
                        this.setImageToButtonFromDatabase(this.btncombo5, dr);
                        break;
                    }
                    case 6:
                    {
                        this.setImageToButtonFromDatabase(this.btncombo6, dr);
                        break;
                    }
                    case 7:
                    {
                        this.setImageToButtonFromDatabase(this.btncombo7, dr);
                        break;
                    }
                    case 8:
                    {
                        this.setImageToButtonFromDatabase(this.btncombo8, dr);
                        break;
                    }
                    case 9:
                    {
                        this.setImageToButtonFromDatabase(this.btncombo9, dr);
                        break;
                    }
                    case 10:
                    {
                        this.setImageToButtonFromDatabase(this.btncombo10, dr);
                        break;
                    }
                    case 11:
                    {
                        this.setImageToButtonFromDatabase(this.btncombo11, dr);
                        break;
                    }
                    case 12:
                    {
                        this.setImageToButtonFromDatabase(this.btncombo12, dr);
                        break;
                    }

                }
               
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
