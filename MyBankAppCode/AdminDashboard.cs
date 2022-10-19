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
    public partial class AdminDashboard : Form
    {
       

        public AdminDashboard()
        {
            InitializeComponent();
            renderAdminDash();

          
           
        }

       
  
        private void renderAdminDash()
        {
            //Admin main side bar panel
            Panel adminSidePanel = new Panel();
            adminSidePanel.Size = new Size(236, 558);
            adminSidePanel.Dock = DockStyle.Left;
            adminSidePanel.BackColor = Color.Gray;
            adminSidePanel.AutoScroll = true;
            this.Controls.Add(adminSidePanel);

            //picture box panel 
            Panel picturePanel = new Panel();
            picturePanel.Size = new Size(219, 152);
            picturePanel.Dock = DockStyle.Top;
            adminSidePanel.Controls.Add(picturePanel);

            //picturebox with image
            PictureBox AdminImg = new PictureBox();
            AdminImg.Image = MyBankAppCode.Properties.Resources.icons8_circled_user_male_skin_type_7_48;
            AdminImg.BorderStyle = BorderStyle.None;
            AdminImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AdminImg.Location = new Point(53, 12);
            AdminImg.Size = new Size(113, 120);
            picturePanel.Controls.Add(AdminImg);

            //Home Button
            Button HomeBtn = new Button();
            HomeBtn.Text = "Home";
            HomeBtn.ForeColor = Color.White;
            HomeBtn.Dock = DockStyle.Top;
            HomeBtn.Location = new Point(0, 152);
            HomeBtn.Size = new Size(240, 50);
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Font = new Font("Microsoft Sans Serif", 12);
            HomeBtn.FlatAppearance.MouseOverBackColor = Color.Teal;
            HomeBtn.Anchor = AnchorStyles.Bottom;
            adminSidePanel.Controls.Add(HomeBtn);

            //Staff Button
            Button Staffbtn = new Button();
            Staffbtn.Text = "Staff";
            Staffbtn.ForeColor = Color.White;
            Staffbtn.Dock = DockStyle.Top;
            Staffbtn.Location = new Point(0, 202);
            Staffbtn.Size = new Size(240, 50);
            Staffbtn.FlatAppearance.BorderSize = 0;
            Staffbtn.FlatStyle = FlatStyle.Flat;
            Staffbtn.Font = new Font("Microsoft Sans Serif", 12);
            Staffbtn.FlatAppearance.MouseOverBackColor = Color.Teal;
            Staffbtn.Anchor = AnchorStyles.Bottom;
            
            adminSidePanel.Controls.Add(Staffbtn);
           

            //Button for Transactions
            Button Transaction = new Button();
            Transaction.Text = "Transactions";
            Transaction.ForeColor = Color.White;
            Transaction.Dock = DockStyle.Top;
            Transaction.Location = new Point(0, 509);
            Transaction.Size = new Size(240, 50);
            Transaction.FlatAppearance.BorderSize = 0;
            Transaction.FlatStyle = FlatStyle.Flat;
            Transaction.Font = new Font("Microsoft Sans Serif", 12);
            Transaction.FlatAppearance.MouseOverBackColor = Color.Teal;
            Transaction.Anchor = AnchorStyles.Bottom;
            adminSidePanel.Controls.Add(Transaction);

            //Button for Reset Password
            Button ResetPass = new Button();
            ResetPass.Text = "Reset password";
            ResetPass.ForeColor = Color.White;
            ResetPass.Dock = DockStyle.Top;
            ResetPass.Location = new Point(0, 670);
            ResetPass.Size = new Size(240, 50);
            ResetPass.FlatAppearance.BorderSize = 0;
            ResetPass.FlatStyle = FlatStyle.Flat;
            ResetPass.Font = new Font("Microsoft Sans Serif", 12);
            ResetPass.FlatAppearance.MouseOverBackColor = Color.Teal;
            ResetPass.Anchor = AnchorStyles.Bottom;
            adminSidePanel.Controls.Add(ResetPass);

            //Button for Logout
            Button LogOut = new Button();
            LogOut.Text = "Log Out";
            LogOut.ForeColor = Color.White;
            LogOut.Dock = DockStyle.Top;
            LogOut.Location = new Point(0, 724);
            LogOut.Size = new Size(240, 50);
            LogOut.FlatAppearance.BorderSize = 0;
            LogOut.FlatStyle = FlatStyle.Flat;
            LogOut.Font = new Font("Microsoft Sans Serif", 12);
            LogOut.FlatAppearance.MouseOverBackColor = Color.Teal;
            LogOut.Anchor = AnchorStyles.Bottom;
            LogOut.Click += (object sender, EventArgs e) =>
              {
                  this.Hide();
                  AdminLogin adminlog = new AdminLogin();
                  adminlog.Show();
                  Visible = false;

              };
            adminSidePanel.Controls.Add(LogOut);


            //Staff menu panel
            Panel StaffMenuPanel = new Panel();
            StaffMenuPanel.BackColor = Color.Silver;
            StaffMenuPanel.Location = new Point(0, 253);
            StaffMenuPanel.Size = new Size(240, 119);
            StaffMenuPanel.Anchor = AnchorStyles.Bottom;
            
           
            adminSidePanel.Controls.Add(StaffMenuPanel);
            //StaffMenuPanel.Visible = false;
            if (StaffMenuPanel.Visible==true)
            {
                StaffMenuPanel.Visible = false;
            }

            //Staff menu Button
            // button for View staff
            Button viewStaff = new Button();
            viewStaff.Location = new Point(0, 69);
            viewStaff.Text = "View Staff";
            viewStaff.Dock = DockStyle.Top;
            viewStaff.Font = new Font("Microsoft Sans Serif", 12);
            viewStaff.FlatStyle = FlatStyle.Flat;
            viewStaff.FlatAppearance.BorderSize = 0;
            viewStaff.FlatAppearance.MouseOverBackColor = Color.Teal;
            viewStaff.Size = new Size(235, 30);
            viewStaff.ForeColor = Color.White;
            StaffMenuPanel.Controls.Add(viewStaff);

            // button for Delete staff
            Button delStaff = new Button();
            delStaff.Location = new Point(0, 46);
            delStaff.Text = "Delete Staff";
            delStaff.Dock = DockStyle.Top;
            delStaff.Font = new Font("Microsoft Sans Serif", 12);
            delStaff.FlatStyle = FlatStyle.Flat;
            delStaff.FlatAppearance.BorderSize = 0;
            delStaff.FlatAppearance.MouseOverBackColor = Color.Teal;
            delStaff.Size = new Size(235, 30);
            delStaff.ForeColor = Color.White;
            StaffMenuPanel.Controls.Add(delStaff);

            // button for edit staff
            Button editStaff = new Button();
            editStaff.Location = new Point(0, 23);
            editStaff.Text = "Edit Staff";
            editStaff.Dock = DockStyle.Top;
            editStaff.Font = new Font("Microsoft Sans Serif", 12);
            editStaff.FlatStyle = FlatStyle.Flat;
            editStaff.FlatAppearance.BorderSize = 0;
            editStaff.FlatAppearance.MouseOverBackColor = Color.Teal;
            editStaff.Size = new Size(235, 30);
            editStaff.ForeColor = Color.White;
            StaffMenuPanel.Controls.Add(editStaff);

            // Add staff button
            Button Add_Staff = new Button();
            Add_Staff.Text = "Add Staff";
            Add_Staff.Font = new Font("Microsoft Sans Serif", 12);
            Add_Staff.Location = new Point(0, 0);
            Add_Staff.Size = new Size(235, 30);
            Add_Staff.Anchor = AnchorStyles.Bottom;
            Add_Staff.FlatAppearance.BorderSize = 0;
            Add_Staff.FlatStyle = FlatStyle.Flat;
            Add_Staff.Dock = DockStyle.Top;
            Add_Staff.ForeColor = Color.White;
            Add_Staff.FlatAppearance.MouseOverBackColor = Color.Teal;
            StaffMenuPanel.Controls.Add(Add_Staff);

            

            
            //Customer  Button
            Button Customer = new Button();
            Customer.Text = "Customer";
            Customer.ForeColor = Color.White;
            Dock = DockStyle.Top;
            Customer.Location = new Point(0, 364);
            Customer.Size = new Size(240, 50);
            Customer.FlatAppearance.BorderSize = 0;
            Customer.FlatStyle = FlatStyle.Flat;
            Customer.Font = new Font("Microsoft Sans Serif", 12);
            Customer.FlatAppearance.MouseOverBackColor = Color.Teal;
            Customer.Anchor = AnchorStyles.Bottom;
            adminSidePanel.Controls.Add(Customer);

            //Customer menu panel
            Panel CustomerMenuPanel = new Panel();
            CustomerMenuPanel.BackColor = Color.Silver;
            CustomerMenuPanel.Location = new Point(0, 406);
            CustomerMenuPanel.Size = new Size(240, 120);
            CustomerMenuPanel.Anchor = AnchorStyles.Bottom;
  
            adminSidePanel.Controls.Add(CustomerMenuPanel);


            //button View customer account
            Button ViewAcct = new Button();
            ViewAcct.Text = "View Account";
            ViewAcct.Location = new Point(0, 69);
            ViewAcct.Size = new Size(235, 30);
            ViewAcct.Dock = DockStyle.Top;
            ViewAcct.FlatAppearance.BorderSize = 0;
            ViewAcct.FlatStyle = FlatStyle.Flat;
            ViewAcct.FlatAppearance.MouseOverBackColor = Color.Teal;
            ViewAcct.ForeColor = Color.White;
            ViewAcct.Font = new Font("Microsoft Sans Serif", 12);
            CustomerMenuPanel.Controls.Add(ViewAcct);

            //button Delete customer account
            Button DelAcct = new Button();
            DelAcct.Text = "Delete Account";
            DelAcct.Location = new Point(0, 46);
            DelAcct.Size = new Size(235, 30);
            DelAcct.Dock = DockStyle.Top;
            DelAcct.FlatAppearance.BorderSize = 0;
            DelAcct.FlatStyle = FlatStyle.Flat;
            DelAcct.FlatAppearance.MouseOverBackColor = Color.Teal;
            DelAcct.ForeColor = Color.White;
            DelAcct.Font = new Font("Microsoft Sans Serif", 12);
            CustomerMenuPanel.Controls.Add(DelAcct);

            //button Edit customer account
            Button EditAcct = new Button();
            EditAcct.Text = "Edit Account";
            EditAcct.Location = new Point(0, 23);
            EditAcct.Size = new Size(235, 30);
            EditAcct.Dock = DockStyle.Top;
            EditAcct.FlatAppearance.BorderSize = 0;
            EditAcct.FlatStyle = FlatStyle.Flat;
            EditAcct.FlatAppearance.MouseOverBackColor = Color.Teal;
            EditAcct.ForeColor = Color.White;
            EditAcct.Font = new Font("Microsoft Sans Serif", 12);
            CustomerMenuPanel.Controls.Add(EditAcct);

            //button New customer account
            Button NewAcct = new Button();
            NewAcct.Text = "New Account";
            NewAcct.Location = new Point(0, 0);
            NewAcct.Size = new Size(235, 30);
            NewAcct.Dock = DockStyle.Top;
            NewAcct.FlatAppearance.BorderSize = 0;
            NewAcct.FlatStyle = FlatStyle.Flat;
            NewAcct.FlatAppearance.MouseOverBackColor = Color.Teal;
            NewAcct.ForeColor = Color.White;
            NewAcct.Font = new Font("Microsoft Sans Serif", 12);
            CustomerMenuPanel.Controls.Add(NewAcct);

            //Transaction menu panel
            Panel TransMenuPanel = new Panel();
            TransMenuPanel.BackColor = Color.Silver;
            TransMenuPanel.Location = new Point(0, 556);
            TransMenuPanel.Size = new Size(240, 119);
            TransMenuPanel.Anchor = AnchorStyles.Bottom;
            
            adminSidePanel.Controls.Add(TransMenuPanel);

            //button Check customer Balance
            Button AcctBal = new Button();
            AcctBal.Text = "Check Balance";
            AcctBal.Location = new Point(0, 73);
            AcctBal.Size = new Size(235, 30);
            AcctBal.Dock = DockStyle.Top;
            AcctBal.FlatAppearance.BorderSize = 0;
            AcctBal.FlatStyle = FlatStyle.Flat;
            AcctBal.FlatAppearance.MouseOverBackColor = Color.Teal;
            AcctBal.ForeColor = Color.White;
            AcctBal.Font = new Font("Microsoft Sans Serif", 12);
            TransMenuPanel.Controls.Add(AcctBal);

            //button Transfer
            Button Transfer = new Button();
            Transfer.Text = "Transfer";
            Transfer.Location = new Point(0, 46);
            Transfer.Size = new Size(235, 30);
            Transfer.Dock = DockStyle.Top;
            Transfer.FlatAppearance.BorderSize = 0;
            Transfer.FlatStyle = FlatStyle.Flat;
            Transfer.FlatAppearance.MouseOverBackColor = Color.Teal;
            Transfer.ForeColor = Color.White;
            Transfer.Font = new Font("Microsoft Sans Serif", 12);
            TransMenuPanel.Controls.Add(Transfer);

            //Staffbtn.Click += (Object sender, EventArgs e) =>
            //{

            //    if (StaffMenuPanel.Visible == true)
            //        StaffMenuPanel.Visible = false;


            //};

            //StaffMenuPanel.Visible = true;
            //CustomerMenuPanel.Visible = true;
            //TransMenuPanel.Visible = true;


            //    if (StaffMenuPanel.Visible == true)
            //        StaffMenuPanel.Visible = false;
            //    if (CustomerMenuPanel.Visible == true)
            //        CustomerMenuPanel.Visible = false;
            //    if (TransMenuPanel.Visible == true)
            //        TransMenuPanel.Visible = false;






            //button Deposit
            Button Deposit = new Button();
            Deposit.Text = "Deposit";
            Deposit.Location = new Point(0, 23);
            Deposit.Size = new Size(235, 30);
            Deposit.Dock = DockStyle.Top;
            Deposit.FlatAppearance.BorderSize = 0;
            Deposit.FlatStyle = FlatStyle.Flat;
            Deposit.FlatAppearance.MouseOverBackColor = Color.Teal;
            Deposit.ForeColor = Color.White;
            Deposit.Font = new Font("Microsoft Sans Serif", 12);
            TransMenuPanel.Controls.Add(Deposit);

            //button withdrawal
            Button withdrawal = new Button();
            withdrawal.Text = "withdrawal";
            withdrawal.Location = new Point(0, 0);
            withdrawal.Size = new Size(235, 30);
            withdrawal.Dock = DockStyle.Top;
            withdrawal.FlatAppearance.BorderSize = 0;
            withdrawal.FlatStyle = FlatStyle.Flat;
            withdrawal.FlatAppearance.MouseOverBackColor = Color.Teal;
            withdrawal.ForeColor = Color.White;
            withdrawal.Font = new Font("Microsoft Sans Serif", 12);
            TransMenuPanel.Controls.Add(withdrawal);

           
           

            //close and minimize panel
            Panel ClosePanel = new Panel();
            ClosePanel.Dock = DockStyle.Top;
            ClosePanel.BackColor = Color.Gray;
            ClosePanel.Size = new Size(563, 22);
            ClosePanel.Location = new Point(236, 0);
            ClosePanel.Anchor = AnchorStyles.Right;
            this.Controls.Add(ClosePanel);

           

            Button ExitBtn = new Button();
            ExitBtn.BackgroundImage = MyBankAppCode.Properties.Resources.icons8_close_64;
            ExitBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Dock = DockStyle.Right;
            ExitBtn.Location = new Point(541, 0);
            ExitBtn.Size = new Size(22, 22);
            ExitBtn.Padding = new Padding(3, 3, 3, 3);
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            ExitBtn.Anchor = AnchorStyles.Left;
            ExitBtn.Click += (object sender, EventArgs e) =>
            {
                Application.Exit();

            };
            ClosePanel.Controls.Add(ExitBtn);
           
            //minimize window

            Button MiniBtn = new Button();
            MiniBtn.BackgroundImage = MyBankAppCode.Properties.Resources.icons8_subtract_30;
            MiniBtn.BackgroundImageLayout = ImageLayout.Stretch;
            MiniBtn.FlatStyle = FlatStyle.Flat;
            MiniBtn.Location = new Point(511, 2);
            MiniBtn.FlatAppearance.BorderSize = 0;
            MiniBtn.Size = new Size(24, 23);
            MiniBtn.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            MiniBtn.Click += (object sender, EventArgs e) =>
            {
                this.WindowState = FormWindowState.Minimized;
            };

            ClosePanel.Controls.Add(MiniBtn);

            //head Panel
            Panel HeaderPanel = new Panel();
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(236, 22);
            HeaderPanel.BackColor = Color.Gray;
            HeaderPanel.Anchor = AnchorStyles.Right;
            HeaderPanel.Size = new Size(563, 48);
            this.Controls.Add(HeaderPanel);

            //label for welcome admin
            Label AdminWelc = new Label();
            AdminWelc.Text = "Welcome Admin";
            AdminWelc.Font = new Font("Modern No. 20", 30);
            AdminWelc.ForeColor = Color.White;
            AdminWelc.Location = new Point(130, -3);
            AdminWelc.Size = new Size(288, 41);
            HeaderPanel.Controls.Add(AdminWelc); 
        }

    }
}
