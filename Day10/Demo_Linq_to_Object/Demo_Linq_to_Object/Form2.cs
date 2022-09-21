using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Demo_Linq_to_Object
{

    [Table(Name = "Person.Person")]

    public class Contact

    {

        [Column]

        public string Title;

        [Column]

        public string FirstName;

        [Column]

        public string LastName;



    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //connection string  

            string conn = "Data Source=192.168.1.230;Initial Catalog=AdventureWorks2017;Persist Security Info=True;User ID=trainee2022;Password=trainee@2022";

            try

            {
                //Creating Data Context 

                DataContext db = new DataContext(conn);

            Table<Contact> contacts = db.GetTable<Contact>();//Retunrs the table of similar type 



            //Query DB 

            var contactDetails =

                                   from c in contacts

                                   where c.Title == "Mr."

                                   orderby c.FirstName

                                   select c;



            //DISPLAY Contact details 

            foreach (var c in contactDetails)

            {

                //textBox1.AppendText(c.Title); 

                //textBox1.AppendText("\t"); 

                richTextBox1.AppendText(c.FirstName);

                richTextBox1.AppendText("\t \t");

                richTextBox1.AppendText(c.LastName);

                richTextBox1.AppendText("\n");

                richTextBox1.AppendText("\n");

            }

        } 

            catch (Exception ex) 

            { 

  

                MessageBox.Show(ex.Message); 

            }

        } 

    } 
}
    

