using FacultyManagement.Data;
using FacultyManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace FacultyManagementSystemUI
{
    public partial class StudentForm : Form
    {
        FacultyDbContext _context;
        Guid? _id;
        Student _student;
        User _user;
        public StudentForm()
        {
            InitializeComponent();
            _context = new FacultyDbContext();
        }
        public StudentForm(Guid? id)
        {
            InitializeComponent();
            _context = new FacultyDbContext();
            _id = id;
            _student = _context.Students.First(x => x.Id == _id);
            txtFirstName.Text = _student.FirstName;
            txtLastName.Text = _student.LastName;
            cmbInstructors.SelectedItem = _student.Advisor;
            _user = _context.Users.First(x => x.PersonalId == _id);
            txtuser.Text = _user.UserName;
            txtPass.Text = _user.Password;
            txtPassAgain.Text = _user.Password;
        }

        private async void StudentForm_Load(object sender, EventArgs e)
        {
            var instructors = await _context.Instructors.ToListAsync();
            cmbInstructors.DataSource= instructors;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            if (_id == null)
                AddStudent();
            else
                UpdateStudent();
            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateStudent()
        {
            FillStudentProps();
            _context.Students.Update(_student);
            FillUserProps();
            _context.Users.Update(_user);
        }

        private void FillUserProps()
        {
            _user.UserName = txtuser.Text;
            _user.Password = txtPass.Text;
            _user.PersonalId = _student.Id;
            _user.Role = Role.Student;
        }

        private void FillStudentProps()
        {
            _student.FirstName = txtFirstName.Text;
            _student.LastName = txtLastName.Text;
            _student.Advisor = cmbInstructors.SelectedItem as Instructor;
        }

        private void AddStudent()
        {
            _student = new Student();
            FillStudentProps();
            _context.Students.Add(_student);
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

   

        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private async void txtuser_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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



        private void txtPass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void txtPassAgain_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
