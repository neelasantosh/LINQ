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
    public partial class Form1 : Form
    {
        List<order> orders = new List<order>();
        public Form1()
        {
            InitializeComponent();
            orders.Add(new order { orderid = "0121", cusid = "c123", orderamt = 2390, ordercity = "pune" });
            orders.Add(new order { orderid = "0221", cusid = "c133", orderamt = 2300, ordercity = "delhi" });
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q = from ord in orders
                    where ord.ordercity == textBox1.Text
                    select new { orderid = ord.orderid, cusid = ord.cusid };

                    //select ord;
            dataGridView1.DataSource = q.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var orderobj = (from ord in orders
                           where ord.orderid == textBox1.Text
                           select ord).FirstOrDefault();
            if (orderobj != null)
            {

                MessageBox.Show(orderobj.orderid + " " + orderobj.ordercity);
            }
        }
    }
}
