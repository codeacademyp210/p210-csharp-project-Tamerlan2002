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
    public partial class EducationProgramsForm : Form
    {

        Regex onlyNumbersRegex = new Regex(@"^\d+$");

        public EducationProgramsForm()
        {
            InitializeComponent();
            ShowPrograms();
            UpdateBtn.Enabled = false;


            if (Session.UserRole == 4)
            {
                UpdateBtn.Enabled = false;
                Reset.Enabled = false;
                SaveBtn.Enabled = false;
                dgvPrograms.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Hide();
        }

        private void ShowPrograms()
        {
            dgvPrograms.Rows.Clear();
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                var positionslist = db.Education_Programs.Where(p => p.Status == true).ToList();

                foreach (var item in positionslist)
                {
                    dgvPrograms.Rows.Add(
                            item.Id,
                            item.Name,
                            item.Price
                        );
                }
            }
        }

        private void ResetInputs()
        {
            EPNameTxt.Clear();
            EPPriceTxt.Clear();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                CreateEducationProgram();
                ShowPrograms();
                ResetInputs();
            }

        }

        private void CreateEducationProgram()
        {
            int affectedrows = 0;
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                Education_Program EP = new Education_Program
                {
                    Name = EPNameTxt.Text,
                    Price = Convert.ToInt32(EPPriceTxt.Text),
                    Status = true
                };
                db.Education_Programs.Add(EP);
                affectedrows = db.SaveChanges();
            }
            if (affectedrows > 0)
            {
                MessageBox.Show("Program created");
                ResetInputs();
                dgvPrograms.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Program could not be created");
                return;
            }
        }

        private void EPNameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (EPNameTxt.Text.Length == 0)
            {
                e.Cancel = true;
                MessageBox.Show("You missed name area");
            }
        }

        private void EPPriceTxt_Validating(object sender, CancelEventArgs e)
        {
            if (EPPriceTxt.Text.Length == 0)
            {
                e.Cancel = true;
                MessageBox.Show("You missed price area");
            }
            else if (!onlyNumbersRegex.IsMatch(EPPriceTxt.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Please import only numbers for price box");
            }
        }


        private void DeleteProgram()
        {
            if (dgvPrograms.CurrentRow.Index > -1)
            {
                int affectedRows = 0;
                int itemid = (int)dgvPrograms.SelectedRows[0].Cells[0].Value;
                using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
                {
                    var program = db.Education_Programs.Where(ep => ep.Id == itemid).FirstOrDefault();
                    program.Status = false;
                    affectedRows = db.SaveChanges();
                }
                if (!(affectedRows > 0))
                {
                    MessageBox.Show("program deleted");
                    dgvPrograms.Rows.Clear();
                }
                return;
            }
            else
            {
                MessageBox.Show("Choose program firstly");
            }
            return;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteProgram();
            ShowPrograms();
        }

        int itemid = 0;

        private void dgvPrograms_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateBtn.Enabled = true;
            SaveBtn.Enabled = false;
            DeleteBtn.Enabled = false;
            if (dgvPrograms.CurrentRow.Index > 0)
            {
                itemid = (int)dgvPrograms.SelectedRows[0].Cells[0].Value;
                using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
                {
                    var Curritem = db.Education_Programs.Where(p => p.Id == itemid).FirstOrDefault();
                    EPNameTxt.Text = Curritem.Name;
                    EPPriceTxt.Text = Curritem.Price.ToString();
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                if (ValidateChildren())
                {
                    if (itemid != 0)
                    {
                        var Curritem = db.Education_Programs.Where(p => itemid == p.Id).First();
                        Curritem.Name = EPNameTxt.Text;
                        Curritem.Price = Convert.ToInt32(EPPriceTxt.Text);
                        MessageBox.Show("Program Updated");
                        SaveBtn.Enabled = true;
                        DeleteBtn.Enabled = true;
                        ResetInputs();
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Program could not be updated");
                        return;
                    }
                }
                else
                {
                    return;
                }
                if (SaveBtn.Enabled == true)
                {
                    UpdateBtn.Enabled = false;
                }
            }
            dgvPrograms.Rows.Clear();
            ShowPrograms();
        }
    
    }
}