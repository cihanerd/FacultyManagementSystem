namespace FacultyManagementSystemUI
{
    partial class AssignStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstAll = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstAdded = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAll
            // 
            this.lstAll.FormattingEnabled = true;
            this.lstAll.ItemHeight = 17;
            this.lstAll.Location = new System.Drawing.Point(14, 14);
            this.lstAll.Name = "lstAll";
            this.lstAll.Size = new System.Drawing.Size(278, 752);
            this.lstAll.Sorted = true;
            this.lstAll.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::FacultyManagementSystemUI.Properties.Resources.right;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(299, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 92);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Image = global::FacultyManagementSystemUI.Properties.Resources.left;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(299, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 92);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remove";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstAdded
            // 
            this.lstAdded.FormattingEnabled = true;
            this.lstAdded.ItemHeight = 17;
            this.lstAdded.Location = new System.Drawing.Point(391, 14);
            this.lstAdded.Name = "lstAdded";
            this.lstAdded.Size = new System.Drawing.Size(278, 752);
            this.lstAdded.Sorted = true;
            this.lstAdded.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(14, 793);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(655, 70);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AssignStudentForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 902);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstAdded);
            this.Controls.Add(this.lstAll);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssignStudentForm";
            this.Text = "AssignStudentForm";
            this.Load += new System.EventHandler(this.AssignStudentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstAll;
        private Button btnAdd;
        private Button button2;
        private ListBox lstAdded;
        private Button btnSave;
    }
}