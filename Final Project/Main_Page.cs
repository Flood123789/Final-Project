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
            // TODO: This line of code loads data into the 'medsDataSet.Selection' table. You can move, or remove it, as needed.
            this.selectionTableAdapter.Fill(this.medsDataSet.Selection);
            //Patient_Selection.Items.AddRange(MedsDataSet.SelectionDataTable)
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
    }
}