using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLatesApp
{
    public partial class FrmLatesV2 : Form
    {
        public FrmLatesV2()
        {
            InitializeComponent();
        }

        private void FrmLatesV2_Load(object sender, EventArgs e)
        {
            // list to hold the studetid and the student name
            List<CLsStudent> studentList = new List<CLsStudent>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT studentid, (surName & " + "', '" + "& firstname) as studentName From tblStudent";
            dr = dbConnector.DoSQL(sqlStr);
            // add all the students to the list
            while (dr.Read())
            {
                studentList.Add(new CLsStudent { studentID = Convert.ToInt32(dr[0]), studentname = dr[1].ToString() });
            }
            cmbStudentID.DisplayMember = "studentname";
            cmbStudentID.ValueMember = "studentid";
            cmbStudentID.DataSource = studentList;
            dbConnector.Close();
            for (int i = 1; i < 7; i++)
            {
                cmbPeriod.Items.Add(i);

            }
        }
        class CLsStudent
        {
            public int studentID { get; set; }
            public string studentname { get; set; }
        }

        private void cmbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStudentID.SelectedValue != null)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;
                dbConnector.Connect();
                sqlStr = "SELECT studentID, firstName, surName, StudentDOB" +
                    " FROM tblStudent" +
                    " WHERE studentID = " + cmbStudentID.SelectedValue;
                dr = dbConnector.DoSQL(sqlStr);

                dbConnector.Close();
            }
        }

        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dtpLateDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"INSERT INTO tblLate  (studentID,period, dateOfLate,minsLate) " +
                $"VALUES ('{cmbStudentID.SelectedValue}' , '{cmbPeriod.Text}', '{dtpLateDate.Value.Date}','{txtMinsLate.Text}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["Form1"] as Form1).DisplayData();
        }
    }
}
