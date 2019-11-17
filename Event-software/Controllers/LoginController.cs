using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.Controllers
{
    class LoginController
    {

        public static void FieldsValidation(String username,String password)
        {
            if (String.IsNullOrEmpty(username) &&
                String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fill the fields!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid password!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                
            }
        }




    }
}
