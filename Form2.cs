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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
        }
    
        class CLsStudent
        {
            public int studentID { get; set; }
            public string studentname { get; set; }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"INSERT INTO tblLate  (studentID,period, dateOfLate,minsLate) " +
                $"VALUES ('{txtStudentID.Text}' , '{txtPeriod.Text}', '{dtpLate.Value.Date}','{txtMinsLate.Text}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["Form1"] as Form1).DisplayData();
        }

        private void txtPeriod_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpLate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
