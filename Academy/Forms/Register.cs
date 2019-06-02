using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academy.Classes;
using Academy.Models;

namespace Academy.Forms
{
    public partial class Register : Form
    {
        Regex emailregex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public Register()
        {
            InitializeComponent();
            
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            Hide();
        }

        private void EmailTxtReg_Validating(object sender, CancelEventArgs e)
        {
            if (EmailTxtReg.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!emailregex.IsMatch(EmailTxtReg.Text))
            {
                MessageBox.Show("Write your email correctly");
                e.Cancel = true;
            }
        }

        private void PassReg_Validating(object sender, CancelEventArgs e)
        {
            if(PassReg.Text.Length == 0)
            {
                e.Cancel = true;
            }
        }

        private void Pass2Reg_Validating(object sender, CancelEventArgs e)
        {
            if (Pass2Reg.Text.Length == 0)
            {
                e.Cancel = true;
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                List<User> allusers = db.Users.ToList();

                if (Pass2Reg.Text == PassReg.Text)
                {
                    if (ValidateChildren())
                    {
                        foreach (var item in allusers)
                        {
                            if(item.Email == EmailTxtReg.Text.ToLower())
                            {
                                MessageBox.Show("This user is already created");
                                return;
                            }
                        }

                        if (ChooseRole() != 0)
                        {
                            User newuser = new User
                            {
                                Email = EmailTxtReg.Text,
                                Password = PassReg.Text,
                                RoleId = ChooseRole()
                            };
                            db.Users.Add(newuser);
                            db.SaveChanges();
                            MessageBox.Show("User created");
                            MainForm mf = new MainForm();
                            mf.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Choose one them below");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not create user");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are not matching");
                    return;
                }
            }
        }

        private int ChooseRole()
        {
            int value = 0;
            if (StudentRbtn.Checked == true)
            {
                value = 4;
                Session.UserRole = 4;
            }
            if (TeacherRbtn.Checked == true)
            {
                value = 3;
                Session.UserRole = 3;
            }
            if (CoordinatorRbtn.Checked == true)
            {
                value = 2;
                Session.UserRole = 2;
            }


            return value;
        }
    }
}
