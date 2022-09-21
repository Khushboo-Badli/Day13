using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo_ADO_NET_DATAGRID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating a Connection Object 

            string connectionString = "Data Source=192.168.1.230;Initial Catalog=Freshers_Training2022;Persist Security Info=True;User ID=trainee2022;Password=trainee@2022";

            SqlConnection myConnection = new SqlConnection();

            myConnection.ConnectionString = connectionString;



            myConnection.Open();



            //creating a SQL string and Data adapter object 

            string queryString = "select * from kb_Worker";

            SqlDataAdapter mydataAdapter = new SqlDataAdapter(queryString, myConnection.ConnectionString);

            //myConnection.Close(); 



            //creating dataset/datatable andf filling it 

            DataSet dataSet = new DataSet("worker1");

            //DataTable dt = new DataTable("student1"); 

            //mydataAdapter.Fill(dt); 

            mydataAdapter.Fill(dataSet);



            //Binding the DataGrid control to DataSet 

            dataGridView1.DataSource = dataSet.Tables[0];//Showing the First table of the Dataset 



            //myConnection.Dispose(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'freshers_Training2022DataSet1.kb_Worker' table. You can move, or remove it, as needed.
            this.kb_WorkerTableAdapter.Fill(this.freshers_Training2022DataSet1.kb_Worker);
            // TODO: This line of code loads data into the 'freshers_Training2022DataSet.khushboo_empolyee' table. You can move, or remove it, as needed.
            //this.khushboo_empolyeeTableAdapter.Fill(this.freshers_Training2022DataSet.khushboo_empolyee);

        }
    }
}
