using BakerySystem.Properties.Form;


namespace BakerySystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Usernametxt = new TextBox();
            Passwordtxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            Loginbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Usernametxt
            // 
            Usernametxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Usernametxt.BackColor = Color.Linen;
            Usernametxt.BorderStyle = BorderStyle.FixedSingle;
            Usernametxt.Location = new Point(237, 242);
            Usernametxt.Name = "Usernametxt";
            Usernametxt.Size = new Size(258, 31);
            Usernametxt.TabIndex = 0;
            // 
            // Passwordtxt
            // 
            Passwordtxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Passwordtxt.BackColor = Color.Linen;
            Passwordtxt.BorderStyle = BorderStyle.FixedSingle;
            Passwordtxt.Location = new Point(237, 303);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.PasswordChar = '*';
            Passwordtxt.Size = new Size(258, 31);
            Passwordtxt.TabIndex = 1;
            Passwordtxt.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 276);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(234, 215);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(291, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 139);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Loginbtn
            // 
            Loginbtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Loginbtn.BackColor = Color.Linen;
            Loginbtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbtn.Location = new Point(237, 340);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(258, 36);
            Loginbtn.TabIndex = 5;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // LoginForm
            // 
            AcceptButton = Loginbtn;
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(754, 461);
            Controls.Add(Loginbtn);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Passwordtxt);
            Controls.Add(Usernametxt);
            Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "LoginForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Capua's Bakery";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usernametxt;
        private TextBox Passwordtxt;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button Loginbtn;

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = Usernametxt.Text;
            string password = Passwordtxt.Text;
            if (username == "d" && password == "d")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
