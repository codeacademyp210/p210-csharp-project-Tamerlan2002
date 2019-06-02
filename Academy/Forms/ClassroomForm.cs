using Academy.Classes;
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
    public partial class ClassroomForm : Form
    {
        Regex onlyNumbersRegex = new Regex(@"^\d+$");

        public ClassroomForm()
        {
            InitializeComponent();
            ShowClassrooms();
            UpdateBtn.Enabled = false;

            if (Session.UserRole == 4)
            {
                UpdateBtn.Enabled = false;
                Reset.Enabled = false;
                SaveBtn.Enabled = false;
                dgvClassroom.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        private void PositionTxt_Validating(object sender, CancelEventArgs e)
        {
            if (ClassroomTxt.Text.Length == 0)
            {
                MessageBox.Show("Please do mot miss classroom name");
                e.Cancel = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Hide();
        }

        private void ShowClassrooms()
        {
            dgvClassroom.Rows.Clear();
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                List<Classroom> classrooms = db.Classrooms.Where(c => c.Status == true).ToList();

                foreach (var item in classrooms)
                {
                    dgvClassroom.Rows.Add(
                        item.Id,
                        item.Name,
                        item.Capacity);
                }

            }
        }

        private void ClearInputs()
        {
            ClassCapTxt.Clear();
            ClassroomTxt.Clear();
        }

        private void NewClassroom()
        {
            int affectedrows = 0;
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                Classroom classroom = new Classroom
                {
                    Name = ClassroomTxt.Text,
                    Capacity = Convert.ToInt32(ClassCapTxt.Text),
                    Status = true
                };
                db.Classrooms.Add(classroom);
                affectedrows = db.SaveChanges();
                if (!(affectedrows > 0))
                {
                    return;
                }
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                NewClassroom();
                ShowClassrooms();
                MessageBox.Show("Room created");
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please fill the form correctly");
                return;
            }
        }

        private void ClassCapTxt_Validating(object sender, CancelEventArgs e)
        {
            if (ClassCapTxt.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!onlyNumbersRegex.IsMatch(ClassCapTxt.Text))
            {
                MessageBox.Show("Only numbers are accepted for classroom");
                e.Cancel = true;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvClassroom.CurrentRow.Index > -1)
            {
                int affectedRows = 0;
                int classId = (int)dgvClassroom.SelectedRows[0].Cells[0].Value;
                using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
                {
                    var user = db.Classrooms.Where(c => c.Id == classId).FirstOrDefault();
                    user.Status = false;
                    affectedRows = db.SaveChanges();
                }
                if (!(affectedRows > 0))
                {
                    MessageBox.Show("Classroom could not be deleted");
                }
                else
                {
                    MessageBox.Show("Classroom deleted");
                    ShowClassrooms();
                }
            }
            else
            {
                MessageBox.Show("Choose classroom firstly");
            }
        }

        int itemId = 0;

        private void dgvClassroom_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateBtn.Enabled = true;
            SaveBtn.Enabled = false;
            DeleteBtn.Enabled = false;
            if (dgvClassroom.CurrentRow.Index > 0)
            {
                itemId = (int)dgvClassroom.SelectedRows[0].Cells[0].Value;
                using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
                {
                    var Curritem = db.Classrooms.Where(p => p.Id == itemId).FirstOrDefault();
                    ClassroomTxt.Text = Curritem.Name;
                    ClassCapTxt.Text = Curritem.Capacity.ToString();
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                if (ValidateChildren())
                {
                    if (itemId != 0)
                    {
                        var classroom = db.Classrooms.Where(t => itemId == t.Id).First();
                        classroom.Name = ClassroomTxt.Text;
                        classroom.Capacity = Convert.ToInt32(ClassCapTxt.Text);
                        MessageBox.Show("Classroom Updated");
                        SaveBtn.Enabled = true;
                        DeleteBtn.Enabled = true;
                        ClearInputs();
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Classroom could not be updated");
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
            ShowClassrooms();
        }
    }
}
