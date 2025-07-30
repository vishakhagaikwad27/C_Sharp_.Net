
namespace Assignment_2
{
    partial class frm_Login_Form
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
            this.lbl_Login_Form = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_User_Name = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_RESET = new System.Windows.Forms.Button();
            this.btn_SUBMIT = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Login_Form
            // 
            this.lbl_Login_Form.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_Login_Form.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Form.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Login_Form.Location = new System.Drawing.Point(454, 33);
            this.lbl_Login_Form.Name = "lbl_Login_Form";
            this.lbl_Login_Form.Size = new System.Drawing.Size(439, 84);
            this.lbl_Login_Form.TabIndex = 0;
            this.lbl_Login_Form.Text = "Login Form";
            this.lbl_Login_Form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.lbl_Login_Form);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 156);
            this.panel1.TabIndex = 1;
            // 
            // lbl_Username
            // 
            this.lbl_Username.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_Username.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Username.Location = new System.Drawing.Point(212, 241);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(168, 55);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Password
            // 
            this.lbl_Password.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_Password.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Password.Location = new System.Drawing.Point(207, 408);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(173, 55);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_User_Name
            // 
            this.tb_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User_Name.Location = new System.Drawing.Point(873, 234);
            this.tb_User_Name.MaxLength = 16;
            this.tb_User_Name.Name = "tb_User_Name";
            this.tb_User_Name.Size = new System.Drawing.Size(392, 55);
            this.tb_User_Name.TabIndex = 1;
            this.tb_User_Name.TextChanged += new System.EventHandler(this.tb_User_Name_TextChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(873, 401);
            this.tb_Password.MaxLength = 5;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '#';
            this.tb_Password.Size = new System.Drawing.Size(392, 55);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // btn_RESET
            // 
            this.btn_RESET.BackColor = System.Drawing.Color.Ivory;
            this.btn_RESET.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RESET.ForeColor = System.Drawing.Color.Crimson;
            this.btn_RESET.Location = new System.Drawing.Point(340, 637);
            this.btn_RESET.Name = "btn_RESET";
            this.btn_RESET.Size = new System.Drawing.Size(160, 52);
            this.btn_RESET.TabIndex = 3;
            this.btn_RESET.Text = "RESET";
            this.btn_RESET.UseVisualStyleBackColor = false;
            this.btn_RESET.Click += new System.EventHandler(this.btn_RESET_Click);
            // 
            // btn_SUBMIT
            // 
            this.btn_SUBMIT.BackColor = System.Drawing.Color.Ivory;
            this.btn_SUBMIT.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SUBMIT.ForeColor = System.Drawing.Color.Crimson;
            this.btn_SUBMIT.Location = new System.Drawing.Point(833, 637);
            this.btn_SUBMIT.Name = "btn_SUBMIT";
            this.btn_SUBMIT.Size = new System.Drawing.Size(160, 52);
            this.btn_SUBMIT.TabIndex = 4;
            this.btn_SUBMIT.Text = "SUBMIT";
            this.btn_SUBMIT.UseVisualStyleBackColor = false;
            this.btn_SUBMIT.Click += new System.EventHandler(this.btn_SUBMIT_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.Enabled = false;
            this.lbl_Error.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_Error.Location = new System.Drawing.Point(408, 562);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(541, 28);
            this.lbl_Error.TabIndex = 5;
            this.lbl_Error.Text = "Note : Enter correct UserName and Password";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_SUBMIT);
            this.Controls.Add(this.btn_RESET);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_User_Name);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login_Form";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.frm_Login_Form_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login_Form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_User_Name;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_RESET;
        private System.Windows.Forms.Button btn_SUBMIT;
        private System.Windows.Forms.Label lbl_Error;
    }
}

