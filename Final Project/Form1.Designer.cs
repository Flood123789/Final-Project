
namespace Final_Project
{
    partial class Form1
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
            this.selectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medsDataSet = new Final_Project.MedsDataSet();
            this.selectionTableAdapter = new Final_Project.MedsDataSetTableAdapters.SelectionTableAdapter();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_Button_F1 = new System.Windows.Forms.Button();
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
            // Update_Button_F1
            // 
            this.Update_Button_F1.Location = new System.Drawing.Point(12, 201);
            this.Update_Button_F1.Name = "Update_Button_F1";
            this.Update_Button_F1.Size = new System.Drawing.Size(75, 23);
            this.Update_Button_F1.TabIndex = 2;
            this.Update_Button_F1.Text = "Update";
            this.Update_Button_F1.UseVisualStyleBackColor = true;
            this.Update_Button_F1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update_Button_F1);
            this.Controls.Add(this.Select_box);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button Update_Button_F1;
    }
}

