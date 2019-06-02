using Academy.Classes;
using Academy.Forms;
using Academy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            Hide();
        }

        private void emailTxt_Validating(object sender, CancelEventArgs e)
        {
            if (emailTxt.Text.Length == 0)
            {
                e.Cancel = true;
            }
        }

        private void passwordTxt_Validating(object sender, CancelEventArgs e)
        {
            if (passwordTxt.Text.Length == 0)
            {
                e.Cancel = true;
            }
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                //Session sess = new Session();
                if (ValidateChildren())
                {
                    List<User> allUsers = db.Users.ToList();
                    if(allUsers.Any(u => u.Email == emailTxt.Text.Trim().ToLower() && u.Password == passwordTxt.Text.Trim()))
                    {
                        var user = allUsers.Find(u => u.Email == emailTxt.Text.Trim().ToLower() && u.Password == passwordTxt.Text.Trim());
                        Session.UserRole = user.RoleId;
                        MainForm mf = new MainForm();
                        mf.Show();
                        Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("This user does not exist.Please register");
                    }
                }


                else
                {
                    MessageBox.Show("Fill the form");
                }
            }
        }
    }
}
