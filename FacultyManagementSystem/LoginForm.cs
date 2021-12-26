using FacultyManagement.Data;

namespace FacultyManagementSystemUI
{
    public partial class LoginForm : Form
    {
        FacultyDbContext _context;
        public LoginForm()
        {
            InitializeComponent();
            _context = new FacultyDbContext();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _context.Users.FirstOrDefault(user => user.UserName == txtUserName.Text);
            if (user is null)
            {
                MessageBox.Show("User not found!");
                return;
            }
            if (user.Password == txtPassword.Text)
            {
                ActiveUser.User =user;
                this.Close();
            }
            else
            {
                MessageBox.Show("Password is not correct");
                return;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
