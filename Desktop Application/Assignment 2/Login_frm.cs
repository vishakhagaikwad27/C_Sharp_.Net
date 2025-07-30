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
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        private void frm_Login_Form_Load(object sender, EventArgs e)
        {
            tb_User_Name.Focus();
        }

        private void tb_User_Name_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Error.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_SUBMIT.Enabled = true;
        }

        void Clear_Controls()
        {
            tb_User_Name.Text = "";
            tb_Password.Text = "";
        }

        private void btn_RESET_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_SUBMIT_Click(object sender, EventArgs e)
        {
            if((tb_User_Name.Text == "Admin" && tb_Password.Text == "a123") || (tb_User_Name.Text == "V" && tb_Password.Text == "27"))
            {
                MessageBox.Show("Welcome To Fork Admission App", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared_Content.UserName = tb_User_Name.Text;

                frm_Student_Details S_Detail = new frm_Student_Details();
                S_Detail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed,Enter Correct User Name or Password", "Failure");
            }
            tb_User_Name.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_SUBMIT.Enabled = false;

            tb_User_Name.Focus();
        }
    }
}
