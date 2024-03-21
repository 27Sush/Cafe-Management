namespace Cafemanage2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSignUpUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSignUpUsername = new System.Windows.Forms.TextBox();
            this.txtSignUpPassword = new System.Windows.Forms.TextBox();
            this.txtSignUpConfirmPass = new System.Windows.Forms.TextBox();
            this.btnSignUp2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblSignUpUserName
            // 
            this.lblSignUpUserName.AutoSize = true;
            this.lblSignUpUserName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpUserName.ForeColor = System.Drawing.Color.White;
            this.lblSignUpUserName.Location = new System.Drawing.Point(142, 195);
            this.lblSignUpUserName.Name = "lblSignUpUserName";
            this.lblSignUpUserName.Size = new System.Drawing.Size(104, 28);
            this.lblSignUpUserName.TabIndex = 2;
            this.lblSignUpUserName.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtSignUpUsername
            // 
            this.txtSignUpUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpUsername.Location = new System.Drawing.Point(97, 237);
            this.txtSignUpUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignUpUsername.Name = "txtSignUpUsername";
            this.txtSignUpUsername.Size = new System.Drawing.Size(190, 28);
            this.txtSignUpUsername.TabIndex = 9;
            this.txtSignUpUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSignUpUsername.TextChanged += new System.EventHandler(this.txtSignUpUsername_TextChanged);
            // 
            // txtSignUpPassword
            // 
            this.txtSignUpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpPassword.Location = new System.Drawing.Point(94, 328);
            this.txtSignUpPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignUpPassword.Name = "txtSignUpPassword";
            this.txtSignUpPassword.Size = new System.Drawing.Size(190, 28);
            this.txtSignUpPassword.TabIndex = 10;
            this.txtSignUpPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSignUpPassword.TextChanged += new System.EventHandler(this.txtSignUpPassword_TextChanged);
            // 
            // txtSignUpConfirmPass
            // 
            this.txtSignUpConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpConfirmPass.Location = new System.Drawing.Point(95, 423);
            this.txtSignUpConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignUpConfirmPass.Name = "txtSignUpConfirmPass";
            this.txtSignUpConfirmPass.Size = new System.Drawing.Size(190, 28);
            this.txtSignUpConfirmPass.TabIndex = 11;
            this.txtSignUpConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSignUp2
            // 
            this.btnSignUp2.BackColor = System.Drawing.Color.Red;
            this.btnSignUp2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp2.Location = new System.Drawing.Point(134, 492);
            this.btnSignUp2.Name = "btnSignUp2";
            this.btnSignUp2.Size = new System.Drawing.Size(112, 35);
            this.btnSignUp2.TabIndex = 13;
            this.btnSignUp2.Text = "SignUp";
            this.btnSignUp2.UseVisualStyleBackColor = false;
            this.btnSignUp2.Click += new System.EventHandler(this.btnSignUp2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(373, 617);
            this.Controls.Add(this.btnSignUp2);
            this.Controls.Add(this.txtSignUpConfirmPass);
            this.Controls.Add(this.txtSignUpPassword);
            this.Controls.Add(this.txtSignUpUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSignUpUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSignUpUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSignUpUsername;
        private System.Windows.Forms.TextBox txtSignUpPassword;
        private System.Windows.Forms.TextBox txtSignUpConfirmPass;
        private System.Windows.Forms.Button btnSignUp2;
    }
}