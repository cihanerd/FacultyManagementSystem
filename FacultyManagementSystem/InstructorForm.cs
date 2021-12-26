using FacultyManagement.Data;
using FacultyManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace FacultyManagementSystemUI
{
    public partial class InstructorForm : Form
    {
        FacultyDbContext _context;
        Guid? _id;
        Instructor _instructor;
        User _user;

        public InstructorForm(Guid? id)
        {
            InitializeComponent();
            _id = id;
            _context = new FacultyDbContext();
            _instructor = _context.Instructors.First(x => x.Id == _id);
            txtFirstName.Text = _instructor.FirstName;
            txtLastName.Text = _instructor.LastName;
            _user = _context.Users.First(x => x.PersonalId == _id);
            txtuser.Text = _user.UserName;
            txtPass.Text = _user.Password;
            txtPassAgain.Text = _user.Password;
        }

        public InstructorForm()
        {
            InitializeComponent();
            _context = new FacultyDbContext();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Please fill all the fields correctly");
                return;
            }
            if (_id == null)
                AddInstructor();
            else
                UpdateInstructor();
            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            Close();
        }
        private void UpdateInstructor()
        {
            FillStudentProps();
            _context.Instructors.Update(_instructor);
            FillUserProps();
            _context.Users.Update(_user);
        }

        private void FillUserProps()
        {
            _user.UserName = txtuser.Text;
            _user.Password = txtPass.Text;
            _user.PersonalId = _instructor.Id;
            _user.Role = Role.Instructor;
        }

        private void FillStudentProps()
        {
            _instructor.FirstName = txtFirstName.Text;
            _instructor.LastName = txtLastName.Text;
        }

        private void AddInstructor()
        {
            _instructor = new Instructor();
            FillStudentProps();
            _context.Instructors.Add(_instructor);
            _user = new User();
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





        private void txtFirstName_Validating_1(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void txtLastName_Validating_1(object sender, System.ComponentModel.CancelEventArgs e)
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

        private async void txtuser_Validating_1(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void txtPass_Validating_1(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void txtPassAgain_Validating_1(object sender, System.ComponentModel.CancelEventArgs e)
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
