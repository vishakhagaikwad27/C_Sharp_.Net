
namespace Fork_Admission_System
{
    partial class frm_Student_List
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
            this.lbl_StudentList = new System.Windows.Forms.Label();
            this.lbl_Logout = new System.Windows.Forms.Label();
            this.studentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);

            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();

            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);


            this.studentDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fork_Student_Admission_SystemDataSet3 = new Fork_Admission_System.Fork_Student_Admission_SystemDataSet3();
            this.studentDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);


            this.student_DetailsTableAdapter3 = new Fork_Admission_System.Fork_Student_Admission_SystemDataSet3TableAdapters.Student_DetailsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fork_Student_Admission_SystemDataSet4 = new Fork_Admission_System.Fork_Student_Admission_SystemDataSet4();
            this.studentDetailsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.student_DetailsTableAdapter4 = new Fork_Admission_System.Fork_Student_Admission_SystemDataSet4TableAdapters.Student_DetailsTableAdapter();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).BeginInit();


            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Student_Admission_SystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource2)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Student_Admission_SystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_StudentList
            // 
            this.lbl_StudentList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_StudentList.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentList.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_StudentList.Location = new System.Drawing.Point(423, 22);
            this.lbl_StudentList.Name = "lbl_StudentList";
            this.lbl_StudentList.Size = new System.Drawing.Size(476, 78);
            this.lbl_StudentList.TabIndex = 1;
            this.lbl_StudentList.Text = "Student_List";
            this.lbl_StudentList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Logout
            // 
            this.lbl_Logout.BackColor = System.Drawing.Color.Azure;
            this.lbl_Logout.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logout.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Logout.Location = new System.Drawing.Point(1165, 22);
            this.lbl_Logout.Name = "lbl_Logout";
            this.lbl_Logout.Size = new System.Drawing.Size(166, 54);
            this.lbl_Logout.TabIndex = 3;
            this.lbl_Logout.Text = "Logout";
            this.lbl_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Logout.Click += new System.EventHandler(this.lbl_Logout_Click);
            // 
            // studentDetailsBindingSource1
            // 
            this.studentDetailsBindingSource1.DataMember = "Student_Details";

            // 
            // fork_Student_Admission_SystemDataSet1
            // 


            // 
            // fork_Student_Admission_SystemDataSet
            // 


            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";

            // 
            // student_DetailsTableAdapter
            // 

            // 
            // student_DetailsTableAdapter1
            // 

            // 
            // studentDetailsBindingSource3
            // 
            this.studentDetailsBindingSource3.DataMember = "Student_Details";
            this.studentDetailsBindingSource3.DataSource = this.fork_Student_Admission_SystemDataSet3;
            // 
            // fork_Student_Admission_SystemDataSet3
            // 
            this.fork_Student_Admission_SystemDataSet3.DataSetName = "Fork_Student_Admission_SystemDataSet3";
            this.fork_Student_Admission_SystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource2
            // 
            this.studentDetailsBindingSource2.DataMember = "Student_Details";

            // 
            // fork_Student_Admission_SystemDataSet2
            // 


            // 
            // student_DetailsTableAdapter2
            // 

            // 
            // student_DetailsTableAdapter3
            // 
            this.student_DetailsTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateofBirthDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentDetailsBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(28, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1285, 503);
            this.dataGridView1.TabIndex = 4;
            // 
            // fork_Student_Admission_SystemDataSet4
            // 
            this.fork_Student_Admission_SystemDataSet4.DataSetName = "Fork_Student_Admission_SystemDataSet4";
            this.fork_Student_Admission_SystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource4
            // 
            this.studentDetailsBindingSource4.DataMember = "Student_Details";
            this.studentDetailsBindingSource4.DataSource = this.fork_Student_Admission_SystemDataSet4;
            // 
            // student_DetailsTableAdapter4
            // 
            this.student_DetailsTableAdapter4.ClearBeforeFill = true;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofBirthDataGridViewTextBoxColumn
            // 
            this.dateofBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Birth";
            this.dateofBirthDataGridViewTextBoxColumn.HeaderText = "Date_of_Birth";
            this.dateofBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofBirthDataGridViewTextBoxColumn.Name = "dateofBirthDataGridViewTextBoxColumn";
            this.dateofBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            this.mobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1376, 760);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Logout);
            this.Controls.Add(this.lbl_StudentList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Student_List";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.frm_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).EndInit();


            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Student_Admission_SystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource2)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Student_Admission_SystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_StudentList;
        private System.Windows.Forms.Label lbl_Logout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        private System.Windows.Forms.BindingSource studentDetailsBindingSource;


        private System.Windows.Forms.BindingSource studentDetailsBindingSource1;


        private System.Windows.Forms.BindingSource studentDetailsBindingSource2;

        private Fork_Student_Admission_SystemDataSet3 fork_Student_Admission_SystemDataSet3;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource3;
        private Fork_Student_Admission_SystemDataSet3TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Fork_Student_Admission_SystemDataSet4 fork_Student_Admission_SystemDataSet4;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource4;
        private Fork_Student_Admission_SystemDataSet4TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}