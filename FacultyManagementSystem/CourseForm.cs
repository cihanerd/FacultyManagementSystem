using FacultyManagement.Data;
using FacultyManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace FacultyManagementSystemUI
{
    public partial class CourseForm : Form
    {
        Guid? _id;
        Course _course;
        private FacultyDbContext _context;

        public CourseForm()
        {
            InitializeComponent();
            _context = new FacultyDbContext();
        }
        public CourseForm(Guid? id)
        {
            InitializeComponent();
            _context = new FacultyDbContext();
            _id = id;
            _course = _context.Courses.First(x => x.Id == _id);
            txtName.Text = _course.Name;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_id is null)
            {
                _course = new();
                FillProps();
                _context.Courses.Add(_course);
            }
            else
            {
                FillProps();
                _context.Courses.Update(_course);
            }
            await _context.SaveChangesAsync();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void FillProps()
        {
            _course.Name = txtName.Text;
            _course.StartDate = dtpStart.Value;
            _course.FinishDate = dtpEnd.Value;
            _course.Details = txtDetails.Text;
            _course.Instructor = (Instructor)cmbInstructor.SelectedItem;
        }

        private async void CourseForm_Load(object sender, EventArgs e)
        {
            var instructors = await _context.Instructors.ToListAsync();
            cmbInstructor.DataSource = instructors;
        }
    }
}
