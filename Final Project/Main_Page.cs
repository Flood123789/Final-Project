﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void Patient_Selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //To be removed
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medsDataSet.GenMed' table. You can move, or remove it, as needed.
            this.genMedTableAdapter.Fill(this.medsDataSet.GenMed);
            // TODO: This line of code loads data into the 'medsDataSet.Selection' table. You can move, or remove it, as needed.
            this.selectionTableAdapter.Fill(this.medsDataSet.Selection);
            this.GenMedDataView.ClearSelection();
            var tab = Gen_Hist_Tb;
            //this.tabControl1.TabPages.Remove(Gen_Hist_Tb);

            Gen_Hist_Tb.Visible = false;
            //Patient_Selection.Items.AddRange(MedsDataSet.SelectionDataTable)
            GenMedDataView.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //to be removed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Will save to DataBase 
                this.selectionTableAdapter.Update(this.medsDataSet.Selection);
            }
            catch(Exception error)
            {
                MessageBox.Show(Convert.ToString(error.Message));
            }
          
        }

        private void Select_Pt_Click(object sender, EventArgs e)
        {
            //Select any cell in the row and it will auto select the ID of the patient 
            int RowIndex = Select_box.CurrentCell.RowIndex;

            // This is a proof of concept to pick what ID is selected to bring up information for the Patient on other pages.
            MessageBox.Show(Convert.ToString(Select_box.Rows[RowIndex].Cells[2].Value)); // messagebox for debug
        }

        private void Undo_btn_F1_Click(object sender, EventArgs e)
        {
            //Will reload the table from the database, erasing unsaved edits.
            this.selectionTableAdapter.Fill(this.medsDataSet.Selection);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Will save to DataBase 
                this.genMedTableAdapter.Update(this.medsDataSet.GenMed);
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error.Message));
            }
        }

        private void Select_Pt_Click_1(object sender, EventArgs e)
        {
            //Select any cell in the row and it will auto select the ID of the patient 
            int RowIndex = Select_box.CurrentCell.RowIndex;

            // This is a proof of concept to pick what ID is selected to bring up information for the Patient on other pages.
            MessageBox.Show(Convert.ToString(Select_box.Rows[RowIndex].Cells[2].Value)); // messagebox for debug
            var patient = (Convert.ToString(Select_box.Rows[RowIndex].Cells[2].Value));

            try
            {
                //Deselects prievious stuff
                GenMedDataView.ClearSelection();
                foreach (DataGridViewRow row in GenMedDataView.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(patient))
                    {
                        RowIndex = row.Index;
                        //MessageBox.Show(Convert.ToString(RowIndex));
                        GenMedDataView.Rows[RowIndex].Selected = true;
                        //GenMedDataView.CurrentCell = GenMedDataView[RowIndex, 1];
                        break;
                    }

                }
                //Sets Gen hist tab
                if(tabControl1.TabPages.Contains(Gen_Hist_Tb) == true)
                {
                    tabControl1.SelectedTab = Gen_Hist_Tb;
                }
                else
                {
                    this.tabControl1.TabPages.Add(Gen_Hist_Tb);  //re-adds tab
                    tabControl1.SelectedTab = Gen_Hist_Tb;
                }

                //Updates tab
                Patient_IdLbl.Text = "Patient: " + patient;
                Gen_Hist_txt_Bx.Text = Convert.ToString(GenMedDataView.Rows[RowIndex].Cells[1].Value);
                Gen_Hist_Tb.Visible = true;
            }
            catch(Exception error)
            {
                MessageBox.Show(Convert.ToString(error.Message));
            }
        }

        private void Save_Button_F1_Click(object sender, EventArgs e)
        {
            try
            {
                //Will save to DataBase 
                this.selectionTableAdapter.Update(this.medsDataSet.Selection);
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error.Message));
            }
        }
    }
}
