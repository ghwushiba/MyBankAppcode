using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBankAppCode
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            renderLoginSidePanel();
            renderLoginDetails();
           
           
        }

        //public Label renderLabel()
        //{
        //    Label ErrowMsg = new Label();
        //    ErrowMsg.Location = new Point(393, 156);
        //    ErrowMsg.Size = new Size(0, 17);
        //    ErrowMsg.Text = "Incorect username or password";
        //    ErrowMsg.Font = new Font("Microsoft Sans Serif", 10);
        //    ErrowMsg.ForeColor = Color.Red;
        //    this.Controls.Add(ErrowMsg);

        //    return ErrowMsg;
        //}

        private void renderLoginDetails()
        {
            //Username panel
            Panel UserNamePanel = new Panel();
            UserNamePanel.Location = new Point(292, 208);
            UserNamePanel.Size = new Size(446, 32);
            UserNamePanel.BackColor = Color.White;//SystemColors.Control;
            UserNamePanel.BorderStyle = BorderStyle.None;
            this.Controls.Add(UserNamePanel);

            //Username Panel pictureBox
            PictureBox UsernameImg = new PictureBox();
            UsernameImg.Image = MyBankAppCode.Properties.Resources.icons8_administrator_male_48;
            UsernameImg.SizeMode = PictureBoxSizeMode.StretchImage;
            UsernameImg.Size = new Size(41, 35);
            UsernameImg.Location = new Point(0, 0);
            UserNamePanel.Controls.Add(UsernameImg);

            //TextBox for Username in username panel
            TextBox txtUsername = new TextBox();
            txtUsername.Size = new Size(388, 20);
            txtUsername.Location = new Point(47, 9);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Microsoft Sans Serif", 12);
            txtUsername.BackColor = Color.White;//SystemColors.Control;
          
            UserNamePanel.Controls.Add(txtUsername);
           

            //Panel for Password
            Panel PasswordPanel = new Panel();
            PasswordPanel.Location = new Point(292, 249);
            PasswordPanel.Size = new Size(446, 32);
            PasswordPanel.BackColor = Color.White;//SystemColors.Control;
            PasswordPanel.BorderStyle = BorderStyle.None;
            this.Controls.Add(PasswordPanel);

            //Password panel pictureBox
            PictureBox PassImg = new PictureBox();
            PassImg.Image = MyBankAppCode.Properties.Resources.icons8_password_30;
            PassImg.SizeMode = PictureBoxSizeMode.StretchImage;
            PassImg.Size = new Size(41, 35);
            PasswordPanel.Controls.Add(PassImg);

            //TextBox for Password in Password panel
            TextBox txtPassword = new TextBox();
            txtPassword.Size = new Size(388, 20);
            txtPassword.Location = new Point(47, 9);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 12);
            txtPassword.BackColor = Color.White;//SystemColors.Control;
            txtPassword.UseSystemPasswordChar = true;
            PasswordPanel.Controls.Add(txtPassword);
            

            //Login Button
            Button LoginBtn = new Button();
            LoginBtn.Text = "Login";
            LoginBtn.Location = new Point(285, 320);
            LoginBtn.Size = new Size(450, 42);
            LoginBtn.Font = new Font("Microsoft Sans Serif", 14);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.BackColor = Color.Teal;
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Cursor = Cursors.Hand;

            LoginBtn.Click += (object sender, EventArgs e) =>
              {
                  MyNewBankAppEntities BSE = new MyNewBankAppEntities();

                  if (txtUsername.Text!=string.Empty && txtPassword.Text!=string.Empty)
                  {
                      var admin1 = BSE.Admin_logins.FirstOrDefault(a => a.UserName.Equals(txtUsername.Text));
                      if (admin1!=null)
                      {
                          if (admin1.UserName==txtUsername.Text && admin1.Password==txtPassword.Text)
                          {
                              this.Hide();
                              AdminDashboard AdminDash = new AdminDashboard();
                              AdminDash.Show();
                              Visible = false;
                          }
                          else
                          {
                              //Label Errowlbl = renderLabel();
                              MessageBox.Show("Incorect username or password");
                              txtPassword.Text = "";
                              txtUsername.Text = "";
                          }

                      }
                      else
                      {
                          //Label get = renderLabel();
                          MessageBox.Show("Incorect Username or Password");
                          txtPassword.Text = "";
                          txtUsername.Text = "";
                      }

                  }

                  else
                  {
                      MessageBox.Show("Password or Username can't be empty");
                      txtPassword.Text = "";
                      txtUsername.Text = "";
                  }
                 

              };
            this.Controls.Add(LoginBtn);

            //Exit button
            Button ExitBtn = new Button();
            ExitBtn.Text = "Exit";
            ExitBtn.Location = new Point(285, 390);
            ExitBtn.Size = new Size(450, 42);
            ExitBtn.Font = new Font("Microsoft Sans Serif", 14);
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.BackColor = Color.Teal;
            ExitBtn.ForeColor = Color.White;
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.Click += (Object sender, EventArgs e) =>
              {
                  Application.Exit();
              };
            this.Controls.Add(ExitBtn);



        }

        private void renderLoginSidePanel()
        {
            //side bar panel
            Panel loginSidePanel = new Panel();
            loginSidePanel.Location = new Point(256, 558);
            loginSidePanel.Size = new Size(256, 558);
            loginSidePanel.Dock = DockStyle.Left;
            loginSidePanel.BackColor = Color.Teal;
            this.Controls.Add(loginSidePanel);

            //picture box
            PictureBox loginPic = new PictureBox();
            loginPic.Image = MyBankAppCode.Properties.Resources.icons8_administrator_male_48;
            loginPic.Size = new Size(200, 231);
            loginPic.SizeMode = PictureBoxSizeMode.StretchImage;
            loginPic.Location = new Point(27, 32);
            loginPic.SizeMode = PictureBoxSizeMode.StretchImage;
            loginPic.Anchor = AnchorStyles.Left;
            loginSidePanel.Controls.Add(loginPic);

            // label for login welcome
            Label Welcome = new Label();
            Welcome.Text = "WELCOME";
            Welcome.Size = new Size(160, 31);
            Welcome.Location = new Point(47, 270);
            Welcome.BackColor = Color.Teal;
            Welcome.ForeColor = Color.White;
            Welcome.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            loginSidePanel.Controls.Add(Welcome);

            // label for login To
            Label To = new Label();
            To.Text = "To";
            To.Size = new Size(160, 31);
            To.Location = new Point(93, 330);
            To.BackColor = Color.Teal;
            To.ForeColor = Color.White;
            To.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            loginSidePanel.Controls.Add(To);

            // label for login page
            Label LoginPAge = new Label();
            LoginPAge.Text = "LOGIN PAGE";
            LoginPAge.Size = new Size(191, 31);
            LoginPAge.Location = new Point(36, 390);
            LoginPAge.BackColor = Color.Teal;
            LoginPAge.ForeColor = Color.White;
            LoginPAge.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            loginSidePanel.Controls.Add(LoginPAge);

            //exit and minimize panel
            Panel ExitPanel = new Panel();
            ExitPanel.Dock = DockStyle.Top;
            ExitPanel.Location = new Point(304, 0);
            ExitPanel.Margin = new Padding(3, 3, 3, 3);
            ExitPanel.Size = new Size(495, 33);
            ExitPanel.BackColor = Color.Transparent;
            ExitPanel.Anchor = AnchorStyles.Top;
            this.Controls.Add(ExitPanel);

            //exit btn
            Button ExitBtn = new Button();
            ExitBtn.BackgroundImage = MyBankAppCode.Properties.Resources.icons8_close_64;
            ExitBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Dock = DockStyle.Right;
            ExitBtn.Location = new Point(430, 0);
            ExitBtn.Size = new Size(28, 33);
            ExitBtn.Padding = new Padding(3, 3, 3, 3);
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatAppearance.MouseOverBackColor = Color.Teal;
            ExitBtn.Anchor = AnchorStyles.Left;
            ExitBtn.Click += (object sender, EventArgs e) =>
            {
                Application.Exit();

            };
            ExitPanel.Controls.Add(ExitBtn);

            //minimize window

            Button MiniBtn = new Button();
            MiniBtn.BackgroundImage = MyBankAppCode.Properties.Resources.icons8_subtract_30;
            MiniBtn.BackgroundImageLayout = ImageLayout.Stretch;
            MiniBtn.FlatStyle = FlatStyle.Flat;
            MiniBtn.Location = new Point(400, 3);
            MiniBtn.FlatAppearance.BorderSize = 0;
            MiniBtn.Size = new Size(24, 23);
            MiniBtn.FlatAppearance.MouseOverBackColor = Color.Teal;
            MiniBtn.Click += (object sender, EventArgs e) =>
            {
                this.WindowState = FormWindowState.Minimized;
            };


            ExitPanel.Controls.Add(MiniBtn);

            //label for Admin Login
            Label AdminLogin = new Label();
            AdminLogin.Text = "ADMIN LOGIN";
            AdminLogin.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
            AdminLogin.Location = new Point(365, 63);
            AdminLogin.Size = new Size(293, 46);
            AdminLogin.BackColor = Color.Teal;
            AdminLogin.ForeColor = Color.White;
            this.Controls.Add(AdminLogin);
        }
    }
}
