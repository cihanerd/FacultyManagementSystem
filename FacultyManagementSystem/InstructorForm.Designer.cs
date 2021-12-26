namespace FacultyManagementSystemUI
{
    partial class InstructorForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPassAgain = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(28, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(455, 57);
            this.btnAdd.TabIndex = 106;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassAgain
            // 
            this.txtPassAgain.Location = new System.Drawing.Point(163, 278);
            this.txtPassAgain.Name = "txtPassAgain";
            this.txtPassAgain.PlaceholderText = "Please Enter Same Password Again";
            this.txtPassAgain.Size = new System.Drawing.Size(319, 25);
            this.txtPassAgain.TabIndex = 105;
            this.txtPassAgain.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassAgain_Validating_1);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(163, 224);
            this.txtPass.Name = "txtPass";
            this.txtPass.PlaceholderText = "Please Enter New Password";
            this.txtPass.Size = new System.Drawing.Size(319, 25);
            this.txtPass.TabIndex = 104;
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating_1);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(163, 166);
            this.txtuser.Name = "txtuser";
            this.txtuser.PlaceholderText = "Create a New User Name For Instructor";
            this.txtuser.Size = new System.Drawing.Size(319, 25);
            this.txtuser.TabIndex = 103;
            this.txtuser.Validating += new System.ComponentModel.CancelEventHandler(this.txtuser_Validating_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 107;
            this.label5.Text = "Password Again";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(163, 109);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Please Enter Last Name";
            this.txtLastName.Size = new System.Drawing.Size(319, 25);
            this.txtLastName.TabIndex = 102;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Password";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(163, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Please Enter First Name";
            this.txtFirstName.Size = new System.Drawing.Size(319, 25);
            this.txtFirstName.TabIndex = 101;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 111;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "First Name";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // InstructorForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 439);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPassAgain);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAdd;
        private TextBox txtPassAgain;
        private TextBox txtPass;
        private TextBox txtuser;
        private Label label5;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private Label label1;
        private ErrorProvider errProvider;
    }
}