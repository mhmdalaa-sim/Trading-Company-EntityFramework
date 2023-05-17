using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company_system
{
    public partial class transactions_report : Form
    {

        Trading_CompanyEntities6 context2 = new Trading_CompanyEntities6();
        public transactions_report()
        {
            

          
            InitializeComponent();

            var query = context2.warehouse_trasactions.Select(d => d.trans_id);
            foreach (int item in query)
            {
                comboBox1.Items.Add(item);
            }
          

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           int ID = (int)comboBox1.SelectedItem;
            warehouse_trasactions w2 = (context2.warehouse_trasactions.Where(d => d.trans_id == ID).Select(d => d).FirstOrDefault());
            if (w2 != null)
            {
                textBox1.Text = w2.from_warehouse.ToString();
                textBox2.Text = w2.to_warehouse.ToString();
                textBox3.Text = w2.item_id.ToString();
                textBox4.Text = w2.supplier_id.ToString();
                trans_quantity.Text = w2.quantity.ToString();
                trans_production_date.Value = w2.production_date.Value;
                trans_expire_date.Value= w2.expire_date.Value;
                    
            }
            else
            {
                MessageBox.Show("no data yet");
            }
        }
    }
}
