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
    public partial class FrmLatesV3 : Form
    {
        public FrmLatesV3()
        {
            InitializeComponent();
        }

        private void FrmLatesV3_Load(object sender, EventArgs e)
        {
            int period = 0, minsLate = 0, minsFrom9am = 0;
            DateTime nineOclockDate = DateTime.Today; // the time at midnight this morning
            nineOclockDate = nineOclockDate.AddHours(9); // the date and time at 9:00am
            minsFrom9am = Convert.ToInt32((DateTime.Now - nineOclockDate).TotalMinutes);
            if (minsFrom9am > 0 && minsFrom9am < 89)
            {
                period = 1;
                minsLate = minsFrom9am;
            }
            else if (minsFrom9am > 110 && minsFrom9am < 199)
            {
                period = 2;
                minsLate = minsFrom9am - 110;
            }
            else if (minsFrom9am > 250 && minsFrom9am < 339)
            {
                period = 3;
                minsLate = minsFrom9am - 250;
            }
            else if (minsFrom9am > 350 && minsFrom9am <439)
            {
                period = 4;
                minsLate = minsLate - 350;
            }



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
        }
        class CLsStudent
        {
            public int studentID { get; set; }
            public string studentname { get; set; }
        }

        private void btnSaveLate_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"INSERT INTO tblLate  (studentID,period, dateOfLate,minsLate) " +
                $"VALUES ('{cmbStudentID.SelectedValue}' , '{}', '{dtpLateDate.Value.Date}','{txtMinsLate.Text}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["Form1"] as Form1).DisplayData();
        }
    }
}
