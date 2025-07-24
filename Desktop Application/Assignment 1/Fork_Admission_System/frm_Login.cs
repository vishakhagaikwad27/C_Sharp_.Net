using System;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Name.Text = "";
            tb_Password.Text = "";
        }
        private void btn_SUBMIT_Click(object sender, EventArgs e)
        {
            if(tb_Name.Text == "V" && tb_Password.Text == "27" )
            {
                frm_Student_Details Stud_Detail = new frm_Student_Details();
                Stud_Detail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed,Enter Correct User Name Or Password", "Failure");
            }
            tb_Name.Clear();
            tb_Password.Clear();
        }

        private void btn_RESET_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
