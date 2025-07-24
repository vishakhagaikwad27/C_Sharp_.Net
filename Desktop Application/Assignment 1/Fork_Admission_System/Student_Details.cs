using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fork_Admission_System
{
    public partial class frm_Student_Details : Form
    {
        public frm_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection FCon = new SqlConnection(@"Data Source=LAPTOP-9K1QB8VR;Initial Catalog=Fork_Student_Admission_System;Integrated Security=True");
        void Fcon_Start()
        {
            if (FCon.State != ConnectionState.Open)
            {
                FCon.Open();
            }
        }
        void Fcon_Stop()
        {
            if (FCon.State != ConnectionState.Closed)
            {
                FCon.Close();
            }
        }

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_Date_of_Birth.Text = "01-02-2005";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List Stud_List = new frm_Student_List();
            Stud_List.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login L_Frm  = new frm_Login();
            L_Frm.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Fcon_Start();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && dtp_Date_of_Birth.Text != "" && tb_Mob_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = FCon;
                cmd.CommandText = "Insert Into Student_Details Values(@Rno,@Nm,@Dob,@Mno,@Course)";

                cmd.Parameters.Add("Rno",SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm",SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Dob",SqlDbType.Date).Value = dtp_Date_of_Birth.Text;
                cmd.Parameters.Add("Mno",SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("Course",SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student Details Saved Successfully ", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill all Fields");
            }
            Fcon_Stop();
        }

        private void frm_Student_Details_Load(object sender, EventArgs e)
        {

        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

    }
}
