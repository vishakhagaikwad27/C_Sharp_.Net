
namespace Fork_Admission_System
{
    partial class frm_Login
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btn_RESET = new System.Windows.Forms.Button();
            this.btn_SUBMIT = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Login.Location = new System.Drawing.Point(361, 28);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(657, 121);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Login Form";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Password
            // 
            this.lbl_Password.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Password.Location = new System.Drawing.Point(166, 406);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(206, 53);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Username
            // 
            this.lbl_Username.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Username.Location = new System.Drawing.Point(165, 281);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(207, 55);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "UserName";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_RESET
            // 
            this.btn_RESET.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_RESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RESET.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btn_RESET.Location = new System.Drawing.Point(390, 590);
            this.btn_RESET.Name = "btn_RESET";
            this.btn_RESET.Size = new System.Drawing.Size(169, 61);
            this.btn_RESET.TabIndex = 3;
            this.btn_RESET.Text = "RESET";
            this.btn_RESET.UseVisualStyleBackColor = false;
            this.btn_RESET.Click += new System.EventHandler(this.btn_RESET_Click);
            // 
            // btn_SUBMIT
            // 
            this.btn_SUBMIT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SUBMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SUBMIT.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btn_SUBMIT.Location = new System.Drawing.Point(818, 590);
            this.btn_SUBMIT.Name = "btn_SUBMIT";
            this.btn_SUBMIT.Size = new System.Drawing.Size(169, 61);
            this.btn_SUBMIT.TabIndex = 4;
            this.btn_SUBMIT.Text = "SUBMIT";
            this.btn_SUBMIT.UseVisualStyleBackColor = false;
            this.btn_SUBMIT.Click += new System.EventHandler(this.btn_SUBMIT_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(966, 421);
            this.tb_Password.MaxLength = 6;
            this.tb_Password.Multiline = true;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '#';
            this.tb_Password.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_Password.Size = new System.Drawing.Size(310, 55);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TabStop = false;
            this.tb_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Name.Location = new System.Drawing.Point(966, 291);
            this.tb_Name.MaxLength = 16;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(310, 55);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1376, 760);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.btn_RESET);
            this.Controls.Add(this.btn_SUBMIT);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.Text = "Login Form";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btn_RESET;
        private System.Windows.Forms.Button btn_SUBMIT;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Name;
    }
}

