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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            renderLeftPanel();
            
        }

        public void renderLeftPanel()
        {
            Panel HomeSidePanel = new Panel();
            HomeSidePanel.Size = new Size(304, 558);
            HomeSidePanel.Dock = DockStyle.Left;
            HomeSidePanel.BackColor = Color.Teal;
            this.Controls.Add(HomeSidePanel);


            //picture box panal

            Panel PicturePanel = new Panel();
            PicturePanel.Size = new Size(304, 316);
            PicturePanel.BackColor = Color.Transparent;
            PicturePanel.Dock = DockStyle.Top;
            HomeSidePanel.Controls.Add(PicturePanel);

            //the picture in Picture panel
            PictureBox HomePic = new PictureBox();
            HomePic.Image = MyBankAppCode.Properties.Resources.bankimg;
            HomePic.Size = new Size(249, 253);
            HomePic.SizeMode = PictureBoxSizeMode.StretchImage;

            HomePic.Location = new Point(29, 28);
            PicturePanel.Controls.Add(HomePic);

            //Welcome to bank Message
            Label welcomeMSg = new Label();
            welcomeMSg.Text = "WELCOME TO BANK";
            welcomeMSg.Location = new Point(331, 76);
            welcomeMSg.ForeColor = Color.White;
            welcomeMSg.BackColor = Color.Teal;
            welcomeMSg.Font = new Font("Microsoft Sans Serif", 30);
            welcomeMSg.Size = new Size(413, 46);
            this.Controls.Add(welcomeMSg);
            

            Panel ExitPanel = new Panel();
            ExitPanel.Dock = DockStyle.Top;
            ExitPanel.Location = new Point(304, 0);
            ExitPanel.Margin = new Padding(3, 3, 3, 3);
            ExitPanel.Size = new Size(495, 33);
            ExitPanel.BackColor = Color.Transparent;
            ExitPanel.Anchor = AnchorStyles.Top;
            this.Controls.Add(ExitPanel);

            Button ExitBtn = new Button();
            ExitBtn.BackgroundImage = MyBankAppCode.Properties.Resources.icons8_close_64;
            ExitBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Dock = DockStyle.Right;
            ExitBtn.Location = new Point(450, 0);
            ExitBtn.Size = new Size(28, 33);
            ExitBtn.Padding = new Padding(3, 3, 3, 3);
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatAppearance.MouseOverBackColor = Color.Teal;
            ExitBtn.Anchor = AnchorStyles.Left;
            ExitBtn.Click += (object sender, EventArgs e) =>
            {
                this.Close();

            };
            ExitPanel.Controls.Add(ExitBtn);

            //minimize window
            Button MinimizeBtn = new Button();
            MinimizeBtn.BackgroundImage = MyBankAppCode.Properties.Resources.icons8_subtract_30;
            MinimizeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            MinimizeBtn.FlatStyle = FlatStyle.Flat;
            //MinimizeBtn.Dock = DockStyle.Right;
            MinimizeBtn.Location = new Point(400, 3);
            MinimizeBtn.Size = new Size(29, 27);
            MinimizeBtn.FlatAppearance.BorderSize = 0;
            MinimizeBtn.FlatAppearance.MouseOverBackColor = Color.Teal;
            MinimizeBtn.Click += (object sender, EventArgs e) =>
              {
                  this.WindowState = FormWindowState.Minimized;
              };


            ExitPanel.Controls.Add(MinimizeBtn);

            //Login Button for admin
            Button Admin_Login = new Button();
            Admin_Login.BackgroundImage = MyBankAppCode.Properties.Resources.icons8_administrator_male_48;
            Admin_Login.BackgroundImageLayout = ImageLayout.Center;
            Admin_Login.ForeColor = Color.White;
            Admin_Login.Location = new Point(390, 235);
            Admin_Login.Size = new Size(102, 63);
            Admin_Login.FlatStyle = FlatStyle.Flat;
            Admin_Login.FlatAppearance.BorderSize = 0;
            Admin_Login.FlatAppearance.MouseOverBackColor = Color.Teal;
            Admin_Login.Click += (Object sender, EventArgs e) =>
              {
                  AdminLogin AdminLogin = new AdminLogin();
                  this.Hide();
                  AdminLogin.Show();
                  Visible = false;


              };
            this.Controls.Add(Admin_Login);

            //Login button for staff
            Button StaffLogin = new Button();
            StaffLogin.BackgroundImage = MyBankAppCode.Properties.Resources.icons8_staff_48;
            StaffLogin.BackgroundImageLayout = ImageLayout.Center;
            StaffLogin.Location = new Point(615, 235);
            StaffLogin.Size = new Size(102, 63);
            StaffLogin.FlatStyle = FlatStyle.Flat;
            StaffLogin.FlatAppearance.BorderSize = 0;
            StaffLogin.FlatAppearance.MouseOverBackColor = Color.Teal;
            this.Controls.Add(StaffLogin);

            //Admin login Label
            Label AdminLoginLabel = new Label();
            AdminLoginLabel.Text = "ADMIN LOGIN";
            AdminLoginLabel.BackColor = Color.Teal;
            AdminLoginLabel.BorderStyle = BorderStyle.None;
            AdminLoginLabel.ForeColor = Color.White;
            AdminLoginLabel.Location = new Point(386, 308);
            AdminLoginLabel.Font = new Font("Microsoft Sans Serif", 14);
            AdminLoginLabel.Size = new Size(132, 24);
            this.Controls.Add(AdminLoginLabel);

            //Staff Login label
            Label staffLoginLabel = new Label();
            staffLoginLabel.Text = "STAFF LOGIN";
            staffLoginLabel.BackColor = Color.Teal;
            staffLoginLabel.BorderStyle = BorderStyle.None;
            staffLoginLabel.ForeColor = Color.White;
            staffLoginLabel.Location = new Point(611, 308);
            staffLoginLabel.Font = new Font("Microsoft Sans Serif", 14);
            staffLoginLabel.Size = new Size(133, 24);
            this.Controls.Add(staffLoginLabel);

            //label for develop by
            Label Devby = new Label();
            Devby.Text = "Developed by Gorip Wushiba Habila";
            Devby.Font = new Font("Microsoft Sans Serif", 10);
            Devby.Location = new Point(36, 530);
            Devby.Size = new Size(242, 20);
            Devby.ForeColor = Color.White;
            HomeSidePanel.Controls.Add(Devby);

            //label for Copyright
            Label copyRight = new Label();
            copyRight.Text = "All Right Reserved @ 2022";
            copyRight.Location = new Point(420, 530);
            copyRight.Size = new Size(200, 20);
            copyRight.Font = new Font("Microsoft Sans Serif", 10);
            copyRight.BackColor = Color.Teal;
            copyRight.ForeColor = Color.White;
            this.Controls.Add(copyRight);



        }

       
       
    }


}
