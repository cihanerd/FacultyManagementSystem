using FacultyManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace FacultyManagementSystemUI
{
    public partial class StudentsListForm : Form
    {
        FacultyDbContext _context;
        public StudentsListForm()
        {
            InitializeComponent();
        }

        private void StudentsListForm_Load(object sender, EventArgs e)
        {
            if (ActiveUser.User.Role != FacultyManagement.Model.Role.Coordinator)
            {
                btnNew.Visible = false;
                btnDelete.Visible = false;
            }
            _context = new();
            RefreshData();

        }

        private void dgvStudents_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvStudents.SelectedRows[0].Cells["Id"].Value as Guid?;
            StudentForm studentForm = new StudentForm(id);
            var res = studentForm.ShowDialog();
            if (res == DialogResult.OK)
                RefreshData();


        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Record will be deleted permanently. Are you sure?", "Warning", MessageBoxButtons.OKCancel);
            if (res == DialogResult.Cancel) return;
            var id = dgvStudents.SelectedRows[0].Cells["Id"].Value as Guid?;
            var student = await _context.Students.FirstAsync(x => x.Id == id);
            _context.Students.Remove(student);
            var user = await _context.Users.FirstAsync(x => x.PersonalId == id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            RefreshData();
        }

        private async void RefreshData()
        {
            if (ActiveUser.User.Role!=FacultyManagement.Model.Role.Coordinator)
            {
                dgvStudents.DataSource = await _context.Students.Where(x => x.Id == ActiveUser.User.PersonalId).Include(x => x.Advisor).AsNoTracking().ToListAsync();
            }
            else
            {
                dgvStudents.DataSource = await _context.Students.Include(x => x.Advisor).AsNoTracking().ToListAsync();
            }
            
            dgvStudents.Columns[0].Width = 150;
            dgvStudents.Columns[1].Width = 200;
            dgvStudents.Columns[2].Width = 200;
            dgvStudents.Columns[3].Width = 200;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            StudentForm form = new();
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
                RefreshData();
        }
    }
}
