
namespace Assignment_2
{
    partial class Student_Details
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
            this.lbl_Student_Deatils = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Student_Deatils
            // 
            this.lbl_Student_Deatils.Location = new System.Drawing.Point(528, 25);
            this.lbl_Student_Deatils.Name = "lbl_Student_Deatils";
            this.lbl_Student_Deatils.Size = new System.Drawing.Size(100, 23);
            this.lbl_Student_Deatils.TabIndex = 0;
            this.lbl_Student_Deatils.Text = "label1";
            this.lbl_Student_Deatils.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 757);
            this.Controls.Add(this.lbl_Student_Deatils);
            this.Name = "Student_Details";
            this.Text = "Student_Details";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Student_Deatils;
    }
}