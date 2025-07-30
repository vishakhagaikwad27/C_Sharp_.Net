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

namespace Assignment_2
{
    public partial class frm_Student_Search : Form
    {
        public frm_Student_Search()
        {
            InitializeComponent();
        }

        SqlConnection FCon = new SqlConnection(@"Data Source=LAPTOP-9K1QB8VR;Initial Catalog=Fork_Student_Admission_System;Integrated Security=True");
        
        void FCon_Start()
        {
            if(FCon.State != ConnectionState.Open)
            {
                FCon.Open();
            }
        }

        void FCon_Stop()
        {
            if(FCon.State != ConnectionState.Closed)
            {
                FCon.Close();
            }
        }

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_Date_Of_Birth.Text = "27-Oct-2001";
        }
        private void btn_RESET_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            FCon_Start();

            if(tb_Roll_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Select * From Student_Details Where Roll_No = @RNo";

                Cmd.Connection = FCon;

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader DR = Cmd.ExecuteReader();

                if(DR.Read())
                {
                    tb_Name.Text = DR.GetString(DR.GetOrdinal("Name"));
                    dtp_Date_Of_Birth.Text = DR["Date_of_Birth"].ToString();
                    tb_Mobile_No.Text = (DR["Mob_No"].ToString());
                    cmb_Course.Text = DR.GetString(DR.GetOrdinal("Course"));
                }
                else
                {
                    MessageBox.Show("Invalid Roll No", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Roll_No.Clear();
                }
            }
            FCon_Stop();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_Search Stud_Search = new frm_Student_Search();
            Stud_Search.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Student_Search Search_Stud = new frm_Student_Search();
            Search_Stud.Show();
            this.Hide();
        }
        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Student_Details S_Details = new frm_Student_Details();
            S_Details.Show();
            this.Hide();
        }

        private void frm_Student_Search_Load(object sender, EventArgs e)
        {
            
        }
    }
}
