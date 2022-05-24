using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace year3_collaborative_project.classes
{
    class FormGenerator
    {

        private static frmLogin _frm_Login;            //Static Instance of Form

        //--------------------------------Section-----------------------------------------------------

        //Creates SINGLE use instance of a form, to prevent multi-load and enable recall one form hide
        public static frmLogin frm_Login
        {

            get
            {

                if (_frm_Login == null)
                {

                    _frm_Login = new frmLogin();

                }
                
                if(clsUser.BLoggedIn == true)
                {
                    TextBox txtUsername = Application.OpenForms["frmLogin"].Controls["txtUsername"] as TextBox;
                    TextBox txtPassword = Application.OpenForms["frmLogin"].Controls["txtPassword"] as TextBox;
                    Label lblAlert = Application.OpenForms["frmLogin"].Controls["lblAlert"] as Label;
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    lblAlert.Visible = false;
                }

                return _frm_Login;

            }

        }

        //--------------------------------End Section-----------------------------------------------

    }
}
