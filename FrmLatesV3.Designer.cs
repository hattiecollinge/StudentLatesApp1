namespace StudentLatesApp
{
    partial class FrmLatesV3
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
            this.cmbStudentID = new System.Windows.Forms.ComboBox();
            this.btnSaveLate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbStudentID
            // 
            this.cmbStudentID.FormattingEnabled = true;
            this.cmbStudentID.Location = new System.Drawing.Point(325, 203);
            this.cmbStudentID.Name = "cmbStudentID";
            this.cmbStudentID.Size = new System.Drawing.Size(121, 21);
            this.cmbStudentID.TabIndex = 0;
            // 
            // btnSaveLate
            // 
            this.btnSaveLate.Location = new System.Drawing.Point(351, 241);
            this.btnSaveLate.Name = "btnSaveLate";
            this.btnSaveLate.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLate.TabIndex = 1;
            this.btnSaveLate.Text = "Save Late";
            this.btnSaveLate.UseVisualStyleBackColor = true;
            this.btnSaveLate.Click += new System.EventHandler(this.btnSaveLate_Click);
            // 
            // FrmLatesV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveLate);
            this.Controls.Add(this.cmbStudentID);
            this.Name = "FrmLatesV3";
            this.Text = "FrmLatesV3";
            this.Load += new System.EventHandler(this.FrmLatesV3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudentID;
        private System.Windows.Forms.Button btnSaveLate;
    }
}