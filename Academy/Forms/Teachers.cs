using Academy.Models;
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

namespace Academy.Forms
{
    public partial class Teachers : Form
    {


        Regex onlylettersregex = new Regex(@"^[a-zA-Z]+$");
        Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Regex onlyNumbersRegex = new Regex(@"^\d+$");
        public Teachers()
        {
            InitializeComponent();
            FillGroups();
            ShowTeachers();
            UpdateBtn.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void FillGroups()
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                var data = db.Education_Programs.Select(x => new { x.Name, x.Id }).ToList();

                TSpecialityCmb.DisplayMember = "Name";
                TSpecialityCmb.ValueMember = "Id";

                TSpecialityCmb.DataSource = data.ToList();


            }
        }

        private void ShowTeachers()
        {
            dgvTeachers.Rows.Clear();

            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                List<Teacher> teachers = db.Teachers.Where(t => t.Status == true).ToList();
                List<Models.Group> groups = db.Groups.Where(g => g.Status == true).ToList();
                List<Education_Program> specs = db.Education_Programs.Where(s => s.Status == true).ToList();
                foreach (var teacher in teachers)
                {
                    var TeacherGroups = teacher.Groups.Where(g =>
                   g.TeacherId == teacher.Id).ToList();
                    var TeacherSpecs = specs.Where(
                        e => e.Id == teacher.Speciality
                        );


                    string speciality = "";
                    string GroupsNames = "";
                    foreach (var group in TeacherGroups)
                    {
                        //Comma seperator
                        if (group != TeacherGroups[TeacherGroups.Count - 1])
                        {
                            GroupsNames += group.Name + ", ";
                        }
                        else
                        {
                            GroupsNames += group.Name;
                        }

                    }
                    foreach (var spec in TeacherSpecs)
                    {
                        speciality += spec.Name;
                    }


                    dgvTeachers.Rows.Add(teacher.Id,
                                         teacher.Name,
                                         teacher.Surname,
                                         speciality,
                                         teacher.Email,
                                         teacher.Phone,
                                         GroupsNames
                                         );
                }

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                CreateTeacher();
                ShowTeachers();
            }
            else
            {
                MessageBox.Show("Please fill the form correctlty");
                return;
            }
        }

        private bool CreateTeacher()
        {
            int affectedRows = 0;
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                Teacher newTea = new Teacher
                {
                    Name = TNameTxt.Text,
                    Surname = TSurnameTxt.Text,
                    Speciality = (int)TSpecialityCmb.SelectedValue,
                    Email = TEmailTxt.Text,
                    Phone = TPhoneTxt.Text,
                    Status = true
                };
                db.Teachers.Add(newTea);
                affectedRows = db.SaveChanges();
            }
            if (affectedRows > 0)
            {
                MessageBox.Show("Teacher created");
                ResetInputs();
                return true;

            }
            else
            {
                MessageBox.Show("Teacher could not be created");
                return false;
            }
        }

        private void ResetInputs()
        {
            TNameTxt.Clear();
            TSurnameTxt.Clear();
            TEmailTxt.Clear();
            TPhoneTxt.Clear();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteTeacher();
            ShowTeachers();
        }

        private bool DeleteTeacher()
        {
            if(dgvTeachers.CurrentRow.Index > -1)
            {
                int affectedRows = 0;
                int userid = (int)dgvTeachers.SelectedRows[0].Cells[0].Value;
                using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
                {
                    var user = db.Teachers.Where(t => t.Id == userid).FirstOrDefault();
                    user.Status = false;
                    affectedRows = db.SaveChanges();
                }
                if (!(affectedRows > 0))
                {
                    MessageBox.Show("User deleted");
                    return false;
                }
                return true;
            }
            MessageBox.Show("Choose user firstly");
            return false;
            
        }

        private void TNameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (TNameTxt.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!onlylettersregex.IsMatch(TNameTxt.Text))
            {
                MessageBox.Show("Please type your name correctly");
                e.Cancel = true;
            }
        }

        private void TSurnameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (TSurnameTxt.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!onlylettersregex.IsMatch(TSurnameTxt.Text))
            {
                MessageBox.Show("Please type your surname correctly");
                e.Cancel = true;
            }
        }

        private void TSpecialityCmb_Validating(object sender, CancelEventArgs e)
        {
            if (TSpecialityCmb.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!(TSpecialityCmb.SelectedIndex > -1))
            {
                MessageBox.Show("Choose something from combobox");
                e.Cancel = true;
            }

        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchTeacher();
        }

        private void SearchTeacher()
        {
                var items = dgvTeachers.Rows.Cast<DataGridViewRow>()
               .Where(r => r.Cells[1].Value.ToString() == SearchTxt.Text);

                foreach (DataGridViewRow r in items)
                {
                    dgvTeachers.Rows[0].Cells[1].Style.ForeColor = Color.Red;
                }
            
        }

        private void TEmailTxt_Validating(object sender, CancelEventArgs e)
        {
            if (TEmailTxt.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!emailRegex.IsMatch(TEmailTxt.Text))
            {
                MessageBox.Show("Type your email in the correct format");
                e.Cancel = true;
            }
        }

        private void TPhoneTxt_Validating(object sender, CancelEventArgs e)
        {
            if (TPhoneTxt.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!onlyNumbersRegex.IsMatch(TPhoneTxt.Text))
            {
                MessageBox.Show("Enter your phone number in the correct format");
                e.Cancel = true;
            }
        }

        int teacherid = 0;
        private void dgvTeachers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DeleteBtn.Enabled = false;
            UpdateBtn.Enabled = true;
            SaveBtn.Enabled = false;
            if (dgvTeachers.CurrentRow.Index > 0)
            {
                teacherid = (int)dgvTeachers.SelectedRows[0].Cells[0].Value;
                using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
                {
                    var teacher = db.Teachers.Where(t => t.Id == teacherid).FirstOrDefault();
                    TNameTxt.Text = teacher.Name;
                    TSurnameTxt.Text = teacher.Surname;
                    TSpecialityCmb.Text = dgvTeachers.CurrentRow.Cells[3].Value.ToString();
                    TEmailTxt.Text  = teacher.Email ;
                    TPhoneTxt.Text = teacher.Phone;
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                if (ValidateChildren()){


                    if (teacherid != 0)
                    {
                        var teacher = db.Teachers.Where(t => teacherid == t.Id).First();
                        teacher.Name = TNameTxt.Text;
                        teacher.Surname = TSurnameTxt.Text;
                        teacher.Speciality = (int)TSpecialityCmb.SelectedValue;
                        teacher.Email = TEmailTxt.Text;
                        teacher.Phone = TPhoneTxt.Text;
                        MessageBox.Show("Teacher Updated");
                        SaveBtn.Enabled = true;
                        DeleteBtn.Enabled = true;
                        ResetInputs();
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Teacher could not be updated");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the form");
                    return;
                }
                if (SaveBtn.Enabled == true)
                {
                    UpdateBtn.Enabled = false;
                }
            }
            ShowTeachers();
        }
    }
}