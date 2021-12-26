using FacultyManagement.Data;
using FacultyManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace FacultyManagementSystemUI
{
    public partial class CourseListForm : Form
    {
        FacultyDbContext _context;
        List<Course> _courses;
        List<Student> _students;
        public CourseListForm()
        {
            InitializeComponent();
        }

        private void CourseListForm_Load(object sender, EventArgs e)
        {
            if (ActiveUser.User.Role != Role.Coordinator)
            {
                btnNew.Visible = false;
                btnDelete.Visible = false;
                dgvCourses.DoubleClick -= dgvCourses_DoubleClick;
            }
            if (ActiveUser.User.Role == Role.Student)
            {
                btnAssign.Visible = false;
            }
            _context = new FacultyDbContext();
            RefreshData();
        }
        private async void RefreshData()
        {
            if (ActiveUser.User.Role == Role.Instructor)
                _courses = await _context.Courses.Where(x => x.Instructor.Id == ActiveUser.User.PersonalId).Include(x => x.Students).Include(x => x.Instructor).ToListAsync();
            else if (ActiveUser.User.Role == Role.Student)
            {
                _courses = await _context.Courses.Include(x => x.Students).Include(x => x.Instructor).ToListAsync();
                _courses = _courses.Where(x => x.Students.Any(x => x.Id == ActiveUser.User.PersonalId)).ToList();
            }
            else
                _courses = await _context.Courses.Include(x => x.Students).Include(x => x.Instructor).ToListAsync();
            _students = await _context.Students.ToListAsync();
            dgvCourses.DataSource = _courses;
            dgvCourses.Columns[0].Width = 50;
            dgvCourses.Columns[1].Width = 200;
            dgvCourses.Columns[2].Width = 200;
            dgvCourses.Columns[3].Width = 250;
            dgvCourses.Columns[4].Width = 250;
            if (dgvCourses.SelectedRows.Count == 0) return;
            var id = (dgvCourses.SelectedRows[0].Cells["Id"].Value as Guid?) ?? Guid.Empty;
            var students = _courses.First(x => x.Id == id).Students;
            lstStudents.DataSource = students;
        }

        private void dgvCourses_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvCourses.SelectedRows[0].Cells["Id"].Value as Guid?;
            CourseForm courseForm = new CourseForm(id);
            var res = courseForm.ShowDialog();
            if (res == DialogResult.OK)
                RefreshData();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Record will be deleted permanently. Are you sure?", "Warning", MessageBoxButtons.OKCancel);
            if (res == DialogResult.Cancel) return;
            var id = dgvCourses.SelectedRows[0].Cells["Id"].Value as Guid?;
            var course = await _context.Courses.FirstAsync(x => x.Id == id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0) return;
            var id = (dgvCourses.SelectedRows[0].Cells["Id"].Value as Guid?) ?? Guid.Empty;
            var students = _courses.First(x => x.Id == id).Students;
            lstStudents.DataSource = students;

        }

        private async void btnAssign_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0) return;
            var id = (dgvCourses.SelectedRows[0].Cells["Id"].Value as Guid?) ?? Guid.Empty;
            var course = _courses.First(x => x.Id == id);
            course.Students.ForEach(x => _students.Remove(x));
            AssignStudentForm assignStudentForm = new AssignStudentForm(course.Students, _students);
            var res = assignStudentForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                course.Students = assignStudentForm.AddedStudents;
                await _context.SaveChangesAsync();
                RefreshData();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new();
            var res = courseForm.ShowDialog();
            if (res == DialogResult.OK)
                RefreshData();
        }
    }
}
