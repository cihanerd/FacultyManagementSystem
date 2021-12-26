namespace FacultyManagementSystemUI
{
    partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassAgain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInstructors = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 99;
            this.label2.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(156, 57);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Please Enter First Name";
            this.txtFirstName.Size = new System.Drawing.Size(280, 25);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(156, 114);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Please Enter Last Name";
            this.txtLastName.Size = new System.Drawing.Size(280, 25);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(39, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(398, 50);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 99;
            this.label3.Text = "User Name";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(157, 205);
            this.txtuser.Name = "txtuser";
            this.txtuser.PlaceholderText = "Create a New User Name For Student";
            this.txtuser.Size = new System.Drawing.Size(280, 25);
            this.txtuser.TabIndex = 3;
            this.txtuser.Validating += new System.ComponentModel.CancelEventHandler(this.txtuser_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 99;
            this.label4.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(157, 256);
            this.txtPass.Name = "txtPass";
            this.txtPass.PlaceholderText = "Please Enter New Password";
            this.txtPass.Size = new System.Drawing.Size(280, 25);
            this.txtPass.TabIndex = 4;
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 99;
            this.label5.Text = "Password Again";
            // 
            // txtPassAgain
            // 
            this.txtPassAgain.Location = new System.Drawing.Point(157, 304);
            this.txtPassAgain.Name = "txtPassAgain";
            this.txtPassAgain.PlaceholderText = "Please Enter Same Password Again";
            this.txtPassAgain.Size = new System.Drawing.Size(280, 25);
            this.txtPassAgain.TabIndex = 5;
            this.txtPassAgain.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassAgain_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 99;
            this.label6.Text = "Adviser";
            // 
            // cmbInstructors
            // 
            this.cmbInstructors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstructors.FormattingEnabled = true;
            this.cmbInstructors.Location = new System.Drawing.Point(156, 161);
            this.cmbInstructors.Name = "cmbInstructors";
            this.cmbInstructors.Size = new System.Drawing.Size(280, 25);
            this.cmbInstructors.TabIndex = 100;
            // 
            // StudentForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 422);
            this.Controls.Add(this.cmbInstructors);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPassAgain);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnAdd;
        private Label label3;
        private TextBox txtuser;
        private Label label4;
        private TextBox txtPass;
        private ErrorProvider errProvider;
        private TextBox txtPassAgain;
        private Label label5;
        private ComboBox cmbInstructors;
        private Label label6;
    }
}