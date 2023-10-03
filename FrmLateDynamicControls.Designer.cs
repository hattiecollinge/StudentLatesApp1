namespace StudentLatesApp
{
    partial class FrmLateDynamicControls
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
            this.flpStudents = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpStudents
            // 
            this.flpStudents.Location = new System.Drawing.Point(12, 12);
            this.flpStudents.Name = "flpStudents";
            this.flpStudents.Size = new System.Drawing.Size(776, 426);
            this.flpStudents.TabIndex = 0;
            // 
            // FrmLateDynamicControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpStudents);
            this.Name = "FrmLateDynamicControls";
            this.Text = "FrmLateDynamicControls";
            this.Load += new System.EventHandler(this.FrmLateDynamicControls_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpStudents;
    }
}