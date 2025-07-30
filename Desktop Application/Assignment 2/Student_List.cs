using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login_Form Log_Frm = new frm_Login_Form();
            Log_Frm.Show();
            this.Hide();
        }

        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Student_Details Add_Stud = new frm_Student_Details();
            Add_Stud.Show();
            this.Hide();
        }

        private void frm_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fork_Student_Admission_SystemDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.fork_Student_Admission_SystemDataSet1.Student_Details);
            // TODO: This line of code loads data into the 'fork_Student_Admission_SystemDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.fork_Student_Admission_SystemDataSet.Student_Details);

        }
    }
}
