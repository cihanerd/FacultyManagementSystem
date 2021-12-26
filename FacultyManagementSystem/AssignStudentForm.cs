using FacultyManagement.Data;
using FacultyManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace FacultyManagementSystemUI
{
    public partial class AssignStudentForm : Form
    {
        List<Student> _allStudents;
        public List<Student> AddedStudents;


        public AssignStudentForm(List<Student> addedStudents, List<Student> allStudents)
        {
            InitializeComponent();
            AddedStudents = addedStudents;
            _allStudents = allStudents;
        }

        private void AssignStudentForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            lstAll.DataSource = _allStudents.ToList();
            lstAdded.DataSource = AddedStudents.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstAll.SelectedItem is null) return;
            var student = lstAll.SelectedItem as Student;
            AddedStudents.Add(student);
            _allStudents.Remove(student);
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstAdded.SelectedItem is null) return;
            var student = lstAdded.SelectedItem as Student;
            _allStudents.Add(student);
            AddedStudents.Remove(student);
            RefreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
