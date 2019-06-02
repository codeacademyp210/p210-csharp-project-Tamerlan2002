using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Academy.Classes;
using System.Linq;
using System.Text;
using Academy.Models;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (Session.UserRole == 4)
            {
                teachersToolStripMenuItem.Enabled = false;
                employeeToolStripMenuItem.Enabled = false;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(Session.UserRole == 0))
            {
                MessageBox.Show(Session.UserRole.ToString());
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                List<Info> infolist = db.Infoes.ToList();
                foreach (var item in infolist)
                {
                    AcaName.Text = item.Name;
                    AcaAdress.Text = item.Adress;
                    AcaEmail.Text = item.Contemail;

                }
            }
            if(Session.UserRole == 1)
            {
                teachersToolStripMenuItem.Enabled = false;
                employeeToolStripMenuItem.Enabled = false;
                positionToolStripMenuItem.Enabled = false;
            }
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachers teacherwf = new Teachers();
            teacherwf.Show();
            Hide();
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Positions pos = new Positions();
            pos.Show();
            Hide();
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            AcaName.ForeColor = Color.White;
            AcaEmail.ForeColor = Color.White;
            AcaAdress.ForeColor = Color.White;
        }

        private void whiteModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            AcaName.ForeColor = Color.Black;
            AcaEmail.ForeColor = Color.Black;
            AcaAdress.ForeColor = Color.Black;
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm Sf = new StudentForm();
            Sf.Show();
            Hide();
        }

        private void classroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassroomForm cf = new ClassroomForm();
            cf.Show();
            Hide();
        }

        private void educationProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EducationProgramsForm epf = new EducationProgramsForm();
            epf.Show();
            Hide();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupForm gf = new GroupForm();
            gf.Show();
            Hide();
        }
    }
}
