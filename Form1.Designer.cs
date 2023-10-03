namespace StudentLatesApp
{
    partial class Form1
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
            this.lstVStudents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.BasicLateForm = new System.Windows.Forms.Button();
            this.btnBetterLateFrm = new System.Windows.Forms.Button();
            this.btnAdvancedLate = new System.Windows.Forms.Button();
            this.dtnDynamicControls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVStudents
            // 
            this.lstVStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstVStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVStudents.FullRowSelect = true;
            this.lstVStudents.HideSelection = false;
            this.lstVStudents.Location = new System.Drawing.Point(26, 35);
            this.lstVStudents.Name = "lstVStudents";
            this.lstVStudents.Size = new System.Drawing.Size(596, 236);
            this.lstVStudents.TabIndex = 0;
            this.lstVStudents.UseCompatibleStateImageBehavior = false;
            this.lstVStudents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "StudentID";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FirstName";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SurName";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "studentDOB";
            this.columnHeader4.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit Students";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BasicLateForm
            // 
            this.BasicLateForm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BasicLateForm.Location = new System.Drawing.Point(167, 278);
            this.BasicLateForm.Name = "BasicLateForm";
            this.BasicLateForm.Size = new System.Drawing.Size(82, 43);
            this.BasicLateForm.TabIndex = 2;
            this.BasicLateForm.Text = "Basic Late Form";
            this.BasicLateForm.UseVisualStyleBackColor = true;
            this.BasicLateForm.Click += new System.EventHandler(this.BasicLateForm_Click);
            // 
            // btnBetterLateFrm
            // 
            this.btnBetterLateFrm.Location = new System.Drawing.Point(255, 278);
            this.btnBetterLateFrm.Name = "btnBetterLateFrm";
            this.btnBetterLateFrm.Size = new System.Drawing.Size(79, 43);
            this.btnBetterLateFrm.TabIndex = 3;
            this.btnBetterLateFrm.Text = "Slightly better Late Form";
            this.btnBetterLateFrm.UseVisualStyleBackColor = true;
            this.btnBetterLateFrm.Click += new System.EventHandler(this.btnBetterLateFrm_Click);
            // 
            // btnAdvancedLate
            // 
            this.btnAdvancedLate.Location = new System.Drawing.Point(340, 278);
            this.btnAdvancedLate.Name = "btnAdvancedLate";
            this.btnAdvancedLate.Size = new System.Drawing.Size(79, 43);
            this.btnAdvancedLate.TabIndex = 4;
            this.btnAdvancedLate.Text = "Even Better Late Form";
            this.btnAdvancedLate.UseVisualStyleBackColor = true;
            this.btnAdvancedLate.Click += new System.EventHandler(this.btnAdvancedLate_Click);
            // 
            // dtnDynamicControls
            // 
            this.dtnDynamicControls.Location = new System.Drawing.Point(426, 278);
            this.dtnDynamicControls.Name = "dtnDynamicControls";
            this.dtnDynamicControls.Size = new System.Drawing.Size(108, 43);
            this.dtnDynamicControls.TabIndex = 5;
            this.dtnDynamicControls.Text = "Even Even Better Late Form";
            this.dtnDynamicControls.UseVisualStyleBackColor = true;
            this.dtnDynamicControls.Click += new System.EventHandler(this.dtnDynamicControls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtnDynamicControls);
            this.Controls.Add(this.btnAdvancedLate);
            this.Controls.Add(this.btnBetterLateFrm);
            this.Controls.Add(this.BasicLateForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstVStudents);
            this.Name = "Form1";
            this.Text = "X";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstVStudents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BasicLateForm;
        private System.Windows.Forms.Button btnBetterLateFrm;
        private System.Windows.Forms.Button btnAdvancedLate;
        private System.Windows.Forms.Button dtnDynamicControls;
    }
}

