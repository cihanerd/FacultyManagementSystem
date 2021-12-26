using FacultyManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace FacultyManagementSystemUI
{
    public partial class CoordinatorListForm : Form
    {
        FacultyDbContext _context;
        public CoordinatorListForm()
        {
            InitializeComponent();
            _context = new();
        }

        private void CoordinatorListForm_Load(object sender, EventArgs e)
        {
            if (ActiveUser.User.Role != FacultyManagement.Model.Role.Coordinator)
            {
                btnNew.Visible = false;
                btnDelete.Visible = false;
                this.dgvCoordinators.DoubleClick -= dgvCoordinators_DoubleClick;
            }
            RefreshData();
        }
        private async void RefreshData()
        {
            dgvCoordinators.DataSource = await _context.Coordinators.AsNoTracking().ToListAsync();
            dgvCoordinators.Columns[0].Width = 250;
            dgvCoordinators.Columns[1].Width = 200;
            dgvCoordinators.Columns[2].Width = 200;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Record will be deleted permanently. Are you sure?", "Warning", MessageBoxButtons.OKCancel);
            if (res == DialogResult.Cancel) return;
            var id = dgvCoordinators.SelectedRows[0].Cells["Id"].Value as Guid?;
            var coord = await _context.Coordinators.FirstAsync(x => x.Id == id);
            _context.Coordinators.Remove(coord);
            var user = await _context.Users.FirstAsync(x => x.PersonalId == id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            RefreshData();
        }

        private void dgvCoordinators_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvCoordinators.SelectedRows[0].Cells["Id"].Value as Guid?;
            CoordinatorForm studentForm = new CoordinatorForm(id);
            var res = studentForm.ShowDialog();
            if (res == DialogResult.OK)
                RefreshData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CoordinatorForm coordForm = new();
            var res = coordForm.ShowDialog();
            if (res == DialogResult.OK)
                RefreshData();
        }
    }
}
