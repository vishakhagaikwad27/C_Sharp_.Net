﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fork_Admission_System
{
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
        {
            InitializeComponent();
        }

        private void frm_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fork_Student_Admission_SystemDataSet4.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter4.Fill(this.fork_Student_Admission_SystemDataSet4.Student_Details);
            // TODO: This line of code loads data into the 'fork_Student_Admission_SystemDataSet3.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter3.Fill(this.fork_Student_Admission_SystemDataSet3.Student_Details);
            // TODO: This line of code loads data into the 'fork_Student_Admission_SystemDataSet2.Student_Details' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'fork_Student_Admission_SystemDataSet1.Student_Details' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'fork_Student_Admission_SystemDataSet.Student_Details' table. You can move, or remove it, as needed.


        }

        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            frm_Login L_Frm = new frm_Login();
            L_Frm.Show();
            this.Hide();
        }
    }
}
