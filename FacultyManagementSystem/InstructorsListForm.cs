using FacultyManagement.Data;
using FacultyManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace FacultyManagementSystemUI
{
    public partial class InstructorsListForm : Form
    {
        FacultyDbContext _context;
        List<Instructor> _instructors;
        public InstructorsListForm()
        {
            InitializeComponent();
        }

        private void InstructorsListForm_Load(object sender, EventArgs e)
        {
            if (ActiveUser.User.Role != Role.Coordinator)
            {
                btnNew.Visible = false;
                btnDelete.Visible = false;
            }
            _context = new FacultyDbContext();
            RefreshData();
        }
        private async void RefreshData()
        {
            if (ActiveUser.User.Role == Role.Instructor)
                _instructors = await _context.Instructors.Where(x=>x.Id==ActiveUser.User.PersonalId).Include(x=>x.Courses).ToListAsync();
            else
                _instructors = await _context.Instructors.Include(x=>x.Courses).ToListAsync();
            dgvInstructors.DataSource = _instructors;
            for (int i = 0; i < 3; i++)
            {
                dgvInstructors.Columns[i].Width = 250;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Record will be deleted permanently. Are you sure?", "Warning", MessageBoxButtons.OKCancel);
            if (res == DialogResult.Cancel) return;
            try
            {
                var id = dgvInstructors.SelectedRows[0].Cells["Id"].Value as Guid?;
                var instructor = await _context.Instructors.FirstAsync(x => x.Id == id);
                _context.Instructors.Remove(instructor);
                var user = await _context.Users.FirstAsync(x => x.PersonalId == id);
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                MessageBox.Show("The record could not be deleted! There are related records with this record");
            }
            
            RefreshData();
        }

        private void dgvInstructors_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvInstructors.SelectedRows[0].Cells["Id"].Value as Guid?;
            InstructorForm instructorForm = new InstructorForm(id);
            var res = instructorForm.ShowDialog();
            if (res == DialogResult.OK)
                RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvInstructors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInstructors.SelectedRows.Count == 0) return;
            var id = (dgvInstructors.SelectedRows[0].Cells["Id"].Value as Guid?) ?? Guid.Empty;
            var courses = _instructors.First(x => x.Id == id).Courses;
            lstCourses.DataSource = courses;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InstructorForm form = new();
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
                RefreshData();
        }
    }
}
