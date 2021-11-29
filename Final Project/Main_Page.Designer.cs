
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
            this.New_PatientTb = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Undo_btn_F1 = new System.Windows.Forms.Button();
            this.Select_Pt = new System.Windows.Forms.Button();
            this.Save_Button_Main = new System.Windows.Forms.Button();
            this.Select_box = new System.Windows.Forms.DataGridView();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medsDataSet = new Final_Project.MedsDataSet();
            this.Gen_Hist_Tb = new System.Windows.Forms.TabPage();
            this.Gen_Hist_txt_Bx = new System.Windows.Forms.RichTextBox();
            this.Patient_IdLbl = new System.Windows.Forms.Label();
            this.Save_Gen = new System.Windows.Forms.Button();
            this.GenMedDataView = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genMedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectionTableAdapter = new Final_Project.MedsDataSetTableAdapters.SelectionTableAdapter();
            this.genMedTableAdapter = new Final_Project.MedsDataSetTableAdapters.GenMedTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New_PatientTb.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Select_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medsDataSet)).BeginInit();
            this.Gen_Hist_Tb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenMedDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genMedBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // New_PatientTb
            // 
            this.New_PatientTb.Controls.Add(this.tabPage1);
            this.New_PatientTb.Controls.Add(this.Gen_Hist_Tb);
            this.New_PatientTb.Controls.Add(this.tabPage2);
            this.New_PatientTb.Location = new System.Drawing.Point(6, 34);
            this.New_PatientTb.Name = "New_PatientTb";
            this.New_PatientTb.SelectedIndex = 0;
            this.New_PatientTb.Size = new System.Drawing.Size(782, 434);
            this.New_PatientTb.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Undo_btn_F1);
            this.tabPage1.Controls.Add(this.Select_Pt);
            this.tabPage1.Controls.Add(this.Save_Button_Main);
            this.tabPage1.Controls.Add(this.Select_box);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.Select_Pt.Click += new System.EventHandler(this.Select_Pt_Click_1);
            // 
            // Save_Button_Main
            // 
            this.Save_Button_Main.Location = new System.Drawing.Point(214, 177);
            this.Save_Button_Main.Name = "Save_Button_Main";
            this.Save_Button_Main.Size = new System.Drawing.Size(75, 23);
            this.Save_Button_Main.TabIndex = 6;
            this.Save_Button_Main.Text = "Save";
            this.Save_Button_Main.UseVisualStyleBackColor = true;
            this.Save_Button_Main.Click += new System.EventHandler(this.Save_Button_F1_Click);
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
            // Gen_Hist_Tb
            // 
            this.Gen_Hist_Tb.Controls.Add(this.Gen_Hist_txt_Bx);
            this.Gen_Hist_Tb.Controls.Add(this.Patient_IdLbl);
            this.Gen_Hist_Tb.Controls.Add(this.Save_Gen);
            this.Gen_Hist_Tb.Controls.Add(this.GenMedDataView);
            this.Gen_Hist_Tb.Location = new System.Drawing.Point(4, 22);
            this.Gen_Hist_Tb.Name = "Gen_Hist_Tb";
            this.Gen_Hist_Tb.Padding = new System.Windows.Forms.Padding(3);
            this.Gen_Hist_Tb.Size = new System.Drawing.Size(774, 408);
            this.Gen_Hist_Tb.TabIndex = 1;
            this.Gen_Hist_Tb.Text = "General Medical History";
            this.Gen_Hist_Tb.UseVisualStyleBackColor = true;
            // 
            // Gen_Hist_txt_Bx
            // 
            this.Gen_Hist_txt_Bx.Location = new System.Drawing.Point(6, 69);
            this.Gen_Hist_txt_Bx.Name = "Gen_Hist_txt_Bx";
            this.Gen_Hist_txt_Bx.Size = new System.Drawing.Size(750, 275);
            this.Gen_Hist_txt_Bx.TabIndex = 9;
            this.Gen_Hist_txt_Bx.Text = "";
            // 
            // Patient_IdLbl
            // 
            this.Patient_IdLbl.AutoSize = true;
            this.Patient_IdLbl.Location = new System.Drawing.Point(13, 27);
            this.Patient_IdLbl.Name = "Patient_IdLbl";
            this.Patient_IdLbl.Size = new System.Drawing.Size(25, 13);
            this.Patient_IdLbl.TabIndex = 8;
            this.Patient_IdLbl.Text = "Null";
            // 
            // Save_Gen
            // 
            this.Save_Gen.Location = new System.Drawing.Point(16, 362);
            this.Save_Gen.Name = "Save_Gen";
            this.Save_Gen.Size = new System.Drawing.Size(75, 23);
            this.Save_Gen.TabIndex = 7;
            this.Save_Gen.Text = "Save";
            this.Save_Gen.UseVisualStyleBackColor = true;
            this.Save_Gen.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GenMedDataView
            // 
            this.GenMedDataView.AutoGenerateColumns = false;
            this.GenMedDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GenMedDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn1,
            this.generalMedDataGridViewTextBoxColumn});
            this.GenMedDataView.DataSource = this.genMedBindingSource;
            this.GenMedDataView.Location = new System.Drawing.Point(509, 15);
            this.GenMedDataView.Name = "GenMedDataView";
            this.GenMedDataView.Size = new System.Drawing.Size(247, 150);
            this.GenMedDataView.TabIndex = 0;
            // 
            // patientIDDataGridViewTextBoxColumn1
            // 
            this.patientIDDataGridViewTextBoxColumn1.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn1.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn1.Name = "patientIDDataGridViewTextBoxColumn1";
            // 
            // generalMedDataGridViewTextBoxColumn
            // 
            this.generalMedDataGridViewTextBoxColumn.DataPropertyName = "General_Med";
            this.generalMedDataGridViewTextBoxColumn.HeaderText = "General_Med";
            this.generalMedDataGridViewTextBoxColumn.Name = "generalMedDataGridViewTextBoxColumn";
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 408);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Admit New Patient";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.New_PatientTb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Page";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.New_PatientTb.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Select_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medsDataSet)).EndInit();
            this.Gen_Hist_Tb.ResumeLayout(false);
            this.Gen_Hist_Tb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenMedDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genMedBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MedsDataSet medsDataSet;
        private System.Windows.Forms.BindingSource selectionBindingSource;
        private MedsDataSetTableAdapters.SelectionTableAdapter selectionTableAdapter;
        private System.Windows.Forms.TabControl New_PatientTb;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Undo_btn_F1;
        private System.Windows.Forms.Button Select_Pt;
        private System.Windows.Forms.Button Save_Button_Main;
        private System.Windows.Forms.DataGridView Select_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage Gen_Hist_Tb;
        private System.Windows.Forms.DataGridView GenMedDataView;
        private System.Windows.Forms.BindingSource genMedBindingSource;
        private MedsDataSetTableAdapters.GenMedTableAdapter genMedTableAdapter;
        private System.Windows.Forms.Button Save_Gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn generalMedDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox Gen_Hist_txt_Bx;
        private System.Windows.Forms.Label Patient_IdLbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

