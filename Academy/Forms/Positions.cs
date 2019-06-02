using Academy.Classes;
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

namespace Academy.Forms
{
    public partial class Positions : Form
    {

        public Positions()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Hide();

            if (Session.UserRole == 4)
            {
                UpdateBtn.Enabled = false;
                Reset.Enabled = false;
                SaveBtn.Enabled = false;
                dgvPosition.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        private void Positions_Load(object sender, EventArgs e)
        {
            FillPositions();
            UpdateBtn.Enabled = false;
        }

        private void ResetInputs()
        {
            PositionTxt.Clear();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }
        private void FillPositions()
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                var positionslist = db.Positions.Where(p => p.Status == true).ToList();

                foreach (var item in positionslist)
                {
                    dgvPosition.Rows.Add(
                            item.Id,
                            item.Name
                        );

                }

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                CreatePosition();
                FillPositions();
            }

        }

        private void CreatePosition()
        {
            int affectedrows = 0;
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                Position NewPos = new Position
                {
                    Name = PositionTxt.Text,
                    Status = true
                };
                db.Positions.Add(NewPos);
                affectedrows = db.SaveChanges();
            }
            if (affectedrows > 0)
            {
                MessageBox.Show("Position created");
                ResetInputs();
                dgvPosition.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Position could not be created");
                return;
            }
        }

        private void PositionTxt_Validating(object sender, CancelEventArgs e)
        {
            if (PositionTxt.Text.Length == 0)
            {
                MessageBox.Show("Do not miss any empty area");
                e.Cancel = true;
            }
        }
        

        private void DeletePosition()
        {
            if (dgvPosition.CurrentRow.Index > -1)
            {
                int affectedRows = 0;
                int userid = (int)dgvPosition.SelectedRows[0].Cells[0].Value;
                using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
                {
                    var user = db.Positions.Where(t => t.Id == userid).FirstOrDefault();
                    user.Status = false;
                    affectedRows = db.SaveChanges();
                }
                if (!(affectedRows > 0))
                {
                    MessageBox.Show("Position deleted");
                    dgvPosition.Rows.Clear();
                }
                return;
            }
            else
            {
            MessageBox.Show("Choose position firstly");
            return;
            }
            

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeletePosition();
            dgvPosition.Rows.Clear();
            FillPositions();
        }


        int PosId = 0;

        private void dgvPosition_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateBtn.Enabled = true;
            SaveBtn.Enabled = false;
            DeleteBtn.Enabled = false;
            if (dgvPosition.CurrentRow.Index > 0)
            {
                PosId = (int)dgvPosition.SelectedRows[0].Cells[0].Value;
                using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
                {
                    var Currposition = db.Positions.Where(p => p.Id == PosId).FirstOrDefault();
                    PositionTxt.Text = Currposition.Name;
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (CodeAcademyEntities1 db = new CodeAcademyEntities1())
            {
                if (ValidateChildren())
                {
                    if (PosId != 0)
                    {
                        var CurrPosition = db.Positions.Where(p => PosId == p.Id).First();
                        CurrPosition.Name = PositionTxt.Text;
                        MessageBox.Show("Position Updated");
                        SaveBtn.Enabled = true;
                        DeleteBtn.Enabled = true;
                        ResetInputs();
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Position could not be updated");
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
            dgvPosition.Rows.Clear();
            FillPositions();
        }
    }
}
