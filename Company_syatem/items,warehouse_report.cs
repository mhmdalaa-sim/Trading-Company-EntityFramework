using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace company_system
{
    public partial class items_report : Form
    {
        Trading_CompanyEntities6 context = new Trading_CompanyEntities6();
        public items_report()
        {
            InitializeComponent();

            items.DropDownStyle = ComboBoxStyle.DropDownList;
            items.SelectedIndex = -1;

            var query = context.Items.Select(d => d.item_id);
            foreach (int item in query)
            {
                items.Items.Add(item);
            }
        }

        private void items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (items.SelectedIndex == -1)
            {
                item_name.Text = string.Empty;
                return;
            }
            int id = int.Parse(items.SelectedItem.ToString());
           var query = context.Items
                .FirstOrDefault(d => d.item_id == id);

            item_name.Text = query.item_name;
            warehouse_name.Text = query.warehouse_id.ToString();

            //MessageBox.Show(query.warehouse_id.ToString());

            warehouse w2 = (context.warehouses.Where(d => d.ware_id == query.warehouse_id).Select(d => d).FirstOrDefault());


                textBox1.Text = w2.ware_name;
                textBox2.Text= w2.ware_address;
                textBox3.Text = w2.manger;

            listBox1.Items.Clear();

            



            var quer = from item in context.Items where item.warehouse_id == query.warehouse_id select item;


            foreach (var item in quer)
            {
                listBox1.Items.Add(item.item_name);
            }







            production_date.Text = query.production_date.ToString();
            DateTime currentDate = DateTime.Now;
            TimeSpan timeDifference = currentDate - query.production_date.Value;
            int daysDifference = timeDifference.Days;

            item_duration.Text = daysDifference.ToString();
        }
    }
}
