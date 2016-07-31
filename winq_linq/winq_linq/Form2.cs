using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winq_linq
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mydbDataContext dc = new mydbDataContext(@"Data Source=.\sqlexpress;Initial Catalog=my_db;Integrated Security=True");

            customer_table cust = new customer_table();
            cust.customername = textBox2.Text;
            cust.customercity = textBox3.Text;
            cust.customerage = Convert.ToInt32(textBox4.Text);
            dc.customer_tables.InsertOnSubmit(cust);
            dc.SubmitChanges();
            textBox1.Text = cust.customerid.ToString();
            MessageBox.Show("customer added");
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mydbDataContext dc = new mydbDataContext(@"Data Source=.\sqlexpress;Initial Catalog=my_db;Integrated Security=True");
            var q = from cust in dc.customer_tables
           
                    where cust.customercity==textBox3.Text
                    select cust;
            dataGridView1.DataSource = q.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mydbDataContext dc = new mydbDataContext(@"Data Source=.\sqlexpress;Initial Catalog=my_db;Integrated Security=True");
            var cust = (from c in dc.customer_tables
                        where c.customerid == Convert.ToInt32(textBox1.Text)
                        select c).FirstOrDefault();
            if (cust != null)
            {
                textBox2.Text = cust.customername;
                textBox3.Text = cust.customercity;
                textBox4.Text = cust.customerage.ToString();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mydbDataContext dc = new mydbDataContext(@"Data Source=.\sqlexpress;Initial Catalog=my_db;Integrated Security=True");
            var cust = (from c in dc.customer_tables
                        where c.customerid == Convert.ToInt32(textBox1.Text)
                        select c).FirstOrDefault();
            cust.customercity = textBox3.Text;
            cust.customername = textBox2.Text;
            cust.customerage = Convert.ToInt32(textBox4.Text);
            dc.SubmitChanges();
            MessageBox.Show("customer update");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mydbDataContext dc = new mydbDataContext(@"Data Source=.\sqlexpress;Initial Catalog=my_db;Integrated Security=True");
            var cust = (from c in dc.customer_tables
                        where c.customerid == Convert.ToInt32(textBox1.Text)
                        select c).FirstOrDefault();

            dc.customer_tables.DeleteOnSubmit(cust);
            dc.SubmitChanges();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            MessageBox.Show("customer deleted");


        }
    }
}
