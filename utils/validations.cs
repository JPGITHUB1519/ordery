using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utils
{
    class validations
    {
        public static bool validar(Control frm, ErrorProvider errorp)
        {
            bool cond = false;
            foreach (Control obj in frm.Controls)
            {
                if (obj.Controls.Count > 0)
                {
                    cond = validar(obj, errorp);
                }
                else
                {
                    if (obj is ntextbox)
                    {
                        ntextbox obj2 = (ntextbox)obj;

                        if (obj2.validate)
                        {

                            if (String.IsNullOrEmpty(obj2.Text.Trim()))
                            {
                                errorp.SetError(obj, "Campo obligatorio");
                                cond = true;
                            }
                            else
                            {
                                errorp.SetError(obj, "");
                            }

                        }
                    }

                }
            }
            return cond;
        }
    }
}
