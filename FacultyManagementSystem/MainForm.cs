using FacultyManagement.Data;
using FacultyManagement.Model;

namespace FacultyManagementSystemUI
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;
        FacultyDbContext _context;
        public MainForm()
        {
            InitializeComponent();
            _context = new FacultyDbContext();
            _context.Database.EnsureCreated();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new();
            login.ShowDialog();
            statusStrip.Text = ActiveUser.User.UserName;
            if (ActiveUser.User.Role == Role.Student)
            {
                coordinatorToolStripMenuItem.Visible = instructorToolStripMenuItem.Visible = false;
            }
            else if(ActiveUser.User.Role == Role.Instructor)
            {
                coordinatorToolStripMenuItem.Visible = false ;
                studentsToolStripMenuItem.Visible=false;
            }
        }



        private void coordinatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoordinatorListForm coordListForm = new();
            coordListForm.MdiParent = this;
            coordListForm.Show();
        }

        private void instructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstructorsListForm instructorsListForm = new();
            instructorsListForm.MdiParent = this;
            instructorsListForm.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsListForm studentsListForm = new();
            studentsListForm.MdiParent = this;
            studentsListForm.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseListForm coursesListForm = new();
            coursesListForm.MdiParent = this;
            coursesListForm.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
