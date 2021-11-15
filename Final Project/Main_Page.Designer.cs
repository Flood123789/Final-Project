
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
            this.Select_box = new System.Windows.Forms.DataGridView();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medsDataSet = new Final_Project.MedsDataSet();
            this.selectionTableAdapter = new Final_Project.MedsDataSetTableAdapters.SelectionTableAdapter();
            this.Save_Button_F1 = new System.Windows.Forms.Button();
            this.Select_Pt = new System.Windows.Forms.Button();
            this.Undo_btn_F1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Select_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medsDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.Select_box.Location = new System.Drawing.Point(12, 30);
            this.Select_box.Name = "Select_box";
            this.Select_box.Size = new System.Drawing.Size(346, 150);
            this.Select_box.TabIndex = 1;
            this.Select_box.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // selectionTableAdapter
            // 
            this.selectionTableAdapter.ClearBeforeFill = true;
            // 
            // Save_Button_F1
            // 
            this.Save_Button_F1.Location = new System.Drawing.Point(220, 201);
            this.Save_Button_F1.Name = "Save_Button_F1";
            this.Save_Button_F1.Size = new System.Drawing.Size(75, 23);
            this.Save_Button_F1.TabIndex = 2;
            this.Save_Button_F1.Text = "Save";
            this.Save_Button_F1.UseVisualStyleBackColor = true;
            this.Save_Button_F1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Select_Pt
            // 
            this.Select_Pt.Location = new System.Drawing.Point(23, 201);
            this.Select_Pt.Name = "Select_Pt";
            this.Select_Pt.Size = new System.Drawing.Size(75, 23);
            this.Select_Pt.TabIndex = 3;
            this.Select_Pt.Text = "Select";
            this.Select_Pt.UseVisualStyleBackColor = true;
            this.Select_Pt.Click += new System.EventHandler(this.Select_Pt_Click);
            // 
            // Undo_btn_F1
            // 
            this.Undo_btn_F1.Location = new System.Drawing.Point(301, 201);
            this.Undo_btn_F1.Name = "Undo_btn_F1";
            this.Undo_btn_F1.Size = new System.Drawing.Size(75, 23);
            this.Undo_btn_F1.TabIndex = 4;
            this.Undo_btn_F1.Text = "Undo";
            this.Undo_btn_F1.UseVisualStyleBackColor = true;
            this.Undo_btn_F1.Click += new System.EventHandler(this.Undo_btn_F1_Click);
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Undo_btn_F1);
            this.Controls.Add(this.Select_Pt);
            this.Controls.Add(this.Save_Button_F1);
            this.Controls.Add(this.Select_box);
            this.Name = "Main_Page";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Select_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Select_box;
        private MedsDataSet medsDataSet;
        private System.Windows.Forms.BindingSource selectionBindingSource;
        private MedsDataSetTableAdapters.SelectionTableAdapter selectionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Save_Button_F1;
        private System.Windows.Forms.Button Select_Pt;
        private System.Windows.Forms.Button Undo_btn_F1;
    }
}

