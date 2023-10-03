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
    public partial class FrmLateDynamicControls : Form
    {
        public FrmLateDynamicControls()
        {
            InitializeComponent();
        }

        private void FrmLateDynamicControls_Load(object sender, EventArgs e)
        {
            int i = 0;
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT studentID, (firstName & " + " " + "surName) as studentName FROM tblStudent";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                Button btn = new Button();
                btn.BackColor = Color.Lime;
                btn.ForeColor = Color.Black;
                btn.Size = new Size(100, 90);
                btn.Visible = true;
                btn.Tag = dr[0].ToString();
                btn.Text = dr[1].ToString();
                btn.Name = "btn_ " + i;
                i++;
                btn.Click += Btn_Click; // type in btn.Click += <TAB><TAB>
                flpStudents.Controls.Add(btn);
            }
            dbConnector.Close();

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
        
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
            else if (minsFrom9am > 350 && minsFrom9am < 439)
            {
                period = 4;
                minsLate = minsLate - 350;
            }
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"INSERT INTO tblLate  (studentID,period, dateOfLate,minsLate) " +
                $"VALUES ('{(sender as Button).Tag.ToString()}' , '{period}', '{DateTime.Today}','{minsLate}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["Form1"] as Form1).DisplayData();
           
       
            MessageBox.Show(button.Text + " is " + minsLate + " mins late");
            dbConnector.Close();

        }
    }
}
