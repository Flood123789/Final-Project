
namespace Final_Project
{
    partial class Main_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Gen_Hist_Tb = new System.Windows.Forms.TabPage();
            this.Undo_btn_F1 = new System.Windows.Forms.Button();
            this.Select_Pt = new System.Windows.Forms.Button();
            this.Save_Button_F1 = new System.Windows.Forms.Button();
            this.Select_box = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medsDataSet = new Final_Project.MedsDataSet();
            this.genMedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectionTableAdapter = new Final_Project.MedsDataSetTableAdapters.SelectionTableAdapter();
            this.genMedTableAdapter = new Final_Project.MedsDataSetTableAdapters.GenMedTableAdapter();
            this.Save_Gen = new System.Windows.Forms.Button();
            this.patientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Gen_Hist_Tb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Select_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genMedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Gen_Hist_Tb);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 434);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Undo_btn_F1);
            this.tabPage1.Controls.Add(this.Select_Pt);
            this.tabPage1.Controls.Add(this.Save_Button_F1);
            this.tabPage1.Controls.Add(this.Select_box);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Gen_Hist_Tb
            // 
            this.Gen_Hist_Tb.Controls.Add(this.Save_Gen);
            this.Gen_Hist_Tb.Controls.Add(this.dataGridView1);
            this.Gen_Hist_Tb.Location = new System.Drawing.Point(4, 22);
            this.Gen_Hist_Tb.Name = "Gen_Hist_Tb";
            this.Gen_Hist_Tb.Padding = new System.Windows.Forms.Padding(3);
            this.Gen_Hist_Tb.Size = new System.Drawing.Size(774, 408);
            this.Gen_Hist_Tb.TabIndex = 1;
            this.Gen_Hist_Tb.Text = "General Medical History";
            this.Gen_Hist_Tb.UseVisualStyleBackColor = true;
            // 
            // Undo_btn_F1
            // 
            this.Undo_btn_F1.Location = new System.Drawing.Point(295, 177);
            this.Undo_btn_F1.Name = "Undo_btn_F1";
            this.Undo_btn_F1.Size = new System.Drawing.Size(75, 23);
            this.Undo_btn_F1.TabIndex = 8;
            this.Undo_btn_F1.Text = "Undo";
            this.Undo_btn_F1.UseVisualStyleBackColor = true;
            // 
            // Select_Pt
            // 
            this.Select_Pt.Location = new System.Drawing.Point(17, 177);
            this.Select_Pt.Name = "Select_Pt";
            this.Select_Pt.Size = new System.Drawing.Size(75, 23);
            this.Select_Pt.TabIndex = 7;
            this.Select_Pt.Text = "Select";
            this.Select_Pt.UseVisualStyleBackColor = true;
            // 
            // Save_Button_F1
            // 
            this.Save_Button_F1.Location = new System.Drawing.Point(214, 177);
            this.Save_Button_F1.Name = "Save_Button_F1";
            this.Save_Button_F1.Size = new System.Drawing.Size(75, 23);
            this.Save_Button_F1.TabIndex = 6;
            this.Save_Button_F1.Text = "Save";
            this.Save_Button_F1.UseVisualStyleBackColor = true;
            // 
            // Select_box
            // 
            this.Select_box.AutoGenerateColumns = false;
            this.Select_box.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Select_box.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn});
            this.Select_box.DataSource = this.selectionBindingSource;
            this.Select_box.Location = new System.Drawing.Point(6, 6);
            this.Select_box.Name = "Select_box";
            this.Select_box.Size = new System.Drawing.Size(346, 150);
            this.Select_box.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn1,
            this.generalMedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.genMedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(198, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // selectionBindingSource
            // 
            this.selectionBindingSource.DataMember = "Selection";
            this.selectionBindingSource.DataSource = this.medsDataSet;
            // 
            // medsDataSet
            // 
            this.medsDataSet.DataSetName = "MedsDataSet";
            this.medsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genMedBindingSource
            // 
            this.genMedBindingSource.DataMember = "GenMed";
            this.genMedBindingSource.DataSource = this.medsDataSet;
            // 
            // selectionTableAdapter
            // 
            this.selectionTableAdapter.ClearBeforeFill = true;
            // 
            // genMedTableAdapter
            // 
            this.genMedTableAdapter.ClearBeforeFill = true;
            // 
            // Save_Gen
            // 
            this.Save_Gen.Location = new System.Drawing.Point(444, 293);
            this.Save_Gen.Name = "Save_Gen";
            this.Save_Gen.Size = new System.Drawing.Size(75, 23);
            this.Save_Gen.TabIndex = 7;
            this.Save_Gen.Text = "Save";
            this.Save_Gen.UseVisualStyleBackColor = true;
            this.Save_Gen.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // patientIDDataGridViewTextBoxColumn1
            // 
            this.patientIDDataGridViewTextBoxColumn1.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn1.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn1.Name = "patientIDDataGridViewTextBoxColumn1";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // generalMedDataGridViewTextBoxColumn
            // 
            this.generalMedDataGridViewTextBoxColumn.DataPropertyName = "General_Med";
            this.generalMedDataGridViewTextBoxColumn.HeaderText = "General_Med";
            this.generalMedDataGridViewTextBoxColumn.Name = "generalMedDataGridViewTextBoxColumn";
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main_Page";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Gen_Hist_Tb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Select_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genMedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MedsDataSet medsDataSet;
        private System.Windows.Forms.BindingSource selectionBindingSource;
        private MedsDataSetTableAdapters.SelectionTableAdapter selectionTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Undo_btn_F1;
        private System.Windows.Forms.Button Select_Pt;
        private System.Windows.Forms.Button Save_Button_F1;
        private System.Windows.Forms.DataGridView Select_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage Gen_Hist_Tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource genMedBindingSource;
        private MedsDataSetTableAdapters.GenMedTableAdapter genMedTableAdapter;
        private System.Windows.Forms.Button Save_Gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn generalMedDataGridViewTextBoxColumn;
    }
}

