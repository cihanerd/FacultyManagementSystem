using FacultyManagement.Data;
using FacultyManagement.Model;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace FacultyManagementSystemUI
{
    public partial class CoordinatorForm : Form
    {
        private FacultyDbContext _context;
        private Guid? _id;
        private Coordinator _coord;
        private User _user;

        public CoordinatorForm()
        {
            InitializeComponent();
            _context = new FacultyDbContext();
        }
        public CoordinatorForm(Guid? id)
        {
            InitializeComponent();
            _context = new FacultyDbContext();
            _id = id;
            _coord = _context.Coordinators.First(x => x.Id == _id);
            txtFirstName.Text = _coord.FirstName;
            txtLastName.Text = _coord.LastName;
            _user = _context.Users.First(x => x.PersonalId == _id);
            txtuser.Text = _user.UserName;
            txtPass.Text = _user.Password;
            txtPassAgain.Text = _user.Password;
        }

        private void CoordinatorForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateCoord()
        {
            FillCoordProps();
            _context.Coordinators.Update(_coord);
            FillUserProps();
            _context.Users.Update(_user);
        }

        private void FillUserProps()
        {
            _user.UserName = txtuser.Text;
            _user.Password = txtPass.Text;
            _user.PersonalId = _coord.Id;
            _user.Role = Role.Coordinator;
        }

        private void FillCoordProps()
        {
            _coord.FirstName = txtFirstName.Text;
            _coord.LastName = txtLastName.Text;
        }

        private void AddCoord()
        {
            _coord = new();
            FillCoordProps();
            _context.Coordinators.Add(_coord);
            _user = new();
            FillUserProps();
            _context.Users.Add(_user);
        }

        private bool ValidateFields()
        {
            foreach (var item in this.Controls)
            {
                var err = errProvider.GetError((Control)item);
                if (errProvider.GetError((Control)item) != "")
                {
                    return false;
                }
            }
            return true;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Please fill all the fields correctly");
                return;
            }
            if (_id == null)
                AddCoord();
            else
                UpdateCoord();
            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtFirstName_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text.Length < 1)
            {
                errProvider.SetError(txtFirstName, "You should provide a name");
            }
            else
            {
                errProvider.SetError(txtFirstName, null);
            }
        }

        private void txtLastName_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text.Length < 1)
            {
                errProvider.SetError(txtLastName, "You should provide a last name");
            }
            else
            {
                errProvider.SetError(txtLastName, null);
            }
        }

        private async void txtuser_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtuser.Text.Length < 1)
            {
                errProvider.SetError(txtuser, "You should provide a user name");
            }
            else
            {
                errProvider.SetError(txtuser, null);
            }
            if (_id is not null) return;
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == txtuser.Text);
            if (user != null)
                errProvider.SetError(txtuser, "This user name already taken");
            else
                errProvider.SetError(txtuser, null);
        }

        private void txtPass_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtPass.Text.Length < 6)
            {
                errProvider.SetError(txtPass, "Password should be at least 6 character");
            }
            else
            {
                errProvider.SetError(txtPass, null);
            }
        }

        private void txtPassAgain_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtPass.Text != txtPassAgain.Text)
            {
                errProvider.SetError(txtPassAgain, "Passwords should be same ");
            }
            else
            {
                errProvider.SetError(txtPassAgain, null);
            }
        }
    }
}
