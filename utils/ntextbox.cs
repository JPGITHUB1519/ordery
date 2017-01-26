using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utils
{
    public partial class ntextbox : TextBox
    {
        public ntextbox()
        {
            InitializeComponent();
        }

        // propiedad para validar
        public Boolean validate
        {
            set;
            get;
        }

        public ntextbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
