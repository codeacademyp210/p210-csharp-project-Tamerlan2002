using System;
using System.Collections.Generic;
using Academy.Models;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academy.Classes;

namespace Academy.Forms
{
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();
            ShowGroups();
            FillTeachers();
            FillClassrooms();
            FillMentors();
            FillPrograms();
            UpdateBtn.Enabled = false;

            if (Session.UserRole == 4)
            {
                UpdateBtn.Enabled = false;
                Reset.Enabled = false;
                SaveBtn.Enabled = false;
                dgvGroups.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Hide();
        }


        private void ShowGroups()
        {
            dgvGroups.Rows.Clear();

            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                var allgroups = db.Groups.Where(g => g.Status == true).ToList();
                var Classrooms = db.Classrooms.Where(c => c.Status == true).ToList(); ;
                var Teachers = db.Teachers.Where(c => c.Status == true).ToList();
                var Employees = db.Employees.Where(c => c.Status == true).ToList();
                var Programs = db.Education_Programs.Where(c => c.Status == true).ToList();
                foreach (var item in allgroups)
                {
                    var list = Classrooms.Where(a => a.Id == item.ClasroomId);

                    string classroomname = "";
                    foreach (var classroom in list)
                    {
                        classroom.Name = classroomname;
                    }


                    dgvGroups.Rows.Add(
                            item.Id,
                            item.Name,
                            classroomname,
                            item.TeacherId,
                            item.MentorId,
                            item.Capacity,
                            item.EducationId
                        );
                }



            }
        }
        private void FillTeachers()
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                var data = db.Teachers.Select(x => new { x.Name, x.Id }).ToList();
                GrTeacherCmb.DisplayMember = "Name";
                GrTeacherCmb.ValueMember = "Id";
                GrTeacherCmb.DataSource = data.ToList();
            }
        }

        private void FillClassrooms()
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                var data = db.Classrooms.Select(x => new { x.Name, x.Id }).ToList();
                GrClassCmb.DisplayMember = "Name";
                GrClassCmb.ValueMember = "Id";
                GrClassCmb.DataSource = data.ToList();
            }
        }

        private void FillMentors()
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                var data = db.Employees.Where(e => e.PositionId == 7).Select(x => new { x.Name, x.Id }).ToList();
                GrMentorCmb.DisplayMember = "Name";
                GrMentorCmb.ValueMember = "Id";
                GrMentorCmb.DataSource = data.ToList();
            }
        }

        private void FillPrograms()
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                var data = db.Education_Programs.Select(x => new { x.Name, x.Id }).ToList();
                GrEducCmb.DisplayMember = "Name";
                GrEducCmb.ValueMember = "Id";
                GrEducCmb.DataSource = data.ToList();
            }
        }
    }
}
