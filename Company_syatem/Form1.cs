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
    public partial class Form1 : Form
    {
        public int fr_warehouse ,too_waehouse,tr_items,tr_supplier;

        Trading_CompanyEntities6 tc = new Trading_CompanyEntities6();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void company_Selected(object sender, TabControlEventArgs e)
        {
          
            stores.Items.Clear();

            foreach (var item in tc.warehouses)
            {
                stores.Items.Add(item.ware_id);
            }

            items_id.Items.Clear();

            foreach (var item in tc.Items)
            {
                items_id.Items.Add(item.item_id);
            }

            from_warehouse.Items.Clear();

            foreach (var item in tc.warehouses)
            {
                from_warehouse.Items.Add(item.ware_id);
            }

            to_warehouse.Items.Clear();

            foreach (var item in tc.warehouses)
            {
                to_warehouse.Items.Add(item.ware_id);
            }

            transfer_items.Items.Clear();

            foreach (var item in tc.Items)
            {
                transfer_items.Items.Add(item.item_id);
            }

            from_suppliers.Items.Clear();

            foreach (var item in tc.suppliers)
            {
                from_suppliers.Items.Add(item.sup_id);
            }

            request_item_id.Items.Clear();

            foreach(var item in tc.Items)
            {

                request_item_id.Items.Add(item.item_id);
            }

            request_store_id.Items.Clear();

            foreach(var item in tc.warehouses)
            {

                request_store_id.Items.Add(item.ware_id);
            } 
            request_supplier_id.Items.Clear();

            foreach(var item in tc.suppliers)
            {
                request_supplier_id.Items.Add(item.sup_id);
            }

            issannce_warehouse.Items.Clear();

            foreach(var item in tc.warehouses)
            {
                issannce_warehouse.Items.Add(item.ware_id);

            }

            issuance_item.Items.Clear();

            foreach(var item in tc.Items)
            {

                issuance_item.Items.Add(item.item_id);
            }

            issuance_client.Items.Clear();

            foreach(var item in tc.clients)
            {
                issuance_client.Items.Add(item.cli_id);
            }




        }
        //warehouse------------------------------------------------------------------------------------------------------------->
        private void stores_SelectedIndexChanged(object sender, EventArgs e)
        {

            warehouse_items.Items.Clear();

            stores.SelectedItem.ToString();

            

            var quer = from item in tc.Items where item.warehouse_id == (int)stores.SelectedItem select item;


            foreach (var item in quer)
            {
                warehouse_items.Items.Add(item.item_name);
            }

         
        }

        private void add_warehouse_Click(object sender, EventArgs e)
        {
           warehouse w = new warehouse();
            w.ware_name = warehouse_name.Text;
            w.ware_address= warehouse_address.Text;
            w.manger=warehouse_manger.Text;
            tc.warehouses.Add(w);
            tc.SaveChanges();

            MessageBox.Show("added");
        }

        private void update_warehouse_Click(object sender, EventArgs e)
        {
            int ID = (int)stores.SelectedItem;

            warehouse w = (tc.warehouses.Where(d => d.ware_id == ID).Select(d => d)).FirstOrDefault();
            if (w != null)
            {
                w.ware_name = warehouse_name.Text;
                w.ware_address = warehouse_address.Text;
                w.manger = warehouse_manger.Text;
                tc.SaveChanges();

                MessageBox.Show("updated");

            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }





        //item ------------------------------------------------------------------------------------------------------------->



        private void items_id_SelectedIndexChanged(object sender, EventArgs e)
        {

            var tempname = from item in tc.Items where item.item_id == (int)(items_id.SelectedItem) select item;


            foreach (var item in tempname)
            {
                item_name.Text = item.item_name;
                item_unit.Text = item.unit;
                production_date.Value = item.production_date.Value;
                expire_date.Value = item.expire_date.Value;
            }

        }

        private void add_item_Click(object sender, EventArgs e)
        {
           Item it = new Item();
            it.item_name = item_name.Text;
          it.unit= item_unit.Text;
            it.production_date = production_date.Value;
            it.expire_date = expire_date.Value;
            tc.Items.Add(it);
            tc.SaveChanges();

            MessageBox.Show("added");
        }

        private void update_item_Click(object sender, EventArgs e)
        {
            int ID = (int)items_id.SelectedItem;

            Item it = (tc.Items.Where(d => d.item_id == ID).Select(d => d)).FirstOrDefault();
            if (it != null)
            {
                it.unit = item_unit.Text;
                it.production_date = production_date.Value;
                it.expire_date = expire_date.Value;
                tc.SaveChanges();

                MessageBox.Show("updated");

            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }

        

        //client ------------------------------------------------------------------------------------------------------------->
        private void add_client_Click(object sender, EventArgs e)
        {
           client cl=new client();
            cl.cli_name=client_name.Text;
            cl.email=client_email.Text;
            cl.phone=client_phone.Text;
            cl.moblie=client_mobile.Text;
            cl.fax=client_fax.Text;
            cl.website=client_website.Text;
            tc.clients.Add(cl);
            tc.SaveChanges();

            MessageBox.Show("added");
        }

        private void client_update_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(client_id.Text);

            client cl = (tc.clients.Where(d => d.cli_id == ID).Select(d => d)).FirstOrDefault();
            if (cl != null)
            {
                cl.cli_name = client_name.Text;
                cl.email = client_email.Text;
                cl.phone = client_phone.Text;
                cl.moblie = client_mobile.Text;
                cl.fax = client_fax.Text;
                cl.website = client_website.Text;
                tc.SaveChanges();

                MessageBox.Show("updated");

            }
            else
            {
                MessageBox.Show("Invalid Data");
            }

        }

       



        //supplier ------------------------------------------------------------------------------------------------------------->
        private void add_supplier_Click(object sender, EventArgs e)
        {
            supplier su= new supplier();
            su.sup_name = supplier_name.Text;
           su.email = supplier_email.Text;
            su.phone = supplier_phone.Text;
            su.mobile= supplier_moblie.Text;
            su.website= supplier_website.Text;
            su.fax = supplier_fax.Text;
            tc.suppliers.Add(su);
            tc.SaveChanges();
            MessageBox.Show("added");

        }

      

        private void update_supplier_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(supplier_id.Text);

           supplier su = (tc.suppliers.Where(d => d.sup_id == ID).Select(d => d)).FirstOrDefault();
            if (su != null)
            {
                su.sup_name = supplier_name.Text;
                su.email = supplier_email.Text;
                su.phone = supplier_phone.Text;
                su.mobile = supplier_moblie.Text;
                su.website = supplier_website.Text;
                su.fax = supplier_fax.Text;
                tc.SaveChanges();

                MessageBox.Show("updated");

            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }

       


        //transfer items ------------------------------------------------------------------------------------------------------------->
        private void transfer_Click(object sender, EventArgs e)
        {
            warehouse_trasactions trn= new warehouse_trasactions();
             fr_warehouse=(int)from_warehouse.SelectedItem;
            too_waehouse=(int)to_warehouse.SelectedItem;
            tr_items=(int)transfer_items.SelectedItem;
            tr_supplier=(int)from_suppliers.SelectedItem;
            trn.from_warehouse=fr_warehouse;
            trn.to_warehouse=too_waehouse;
            trn.item_id=tr_items;
            trn.supplier_id=tr_supplier;
            trn.quantity=int.Parse(trans_quantity.Text);
            trn.expire_date = trans_expire_date.Value;
            trn.production_date= trans_production_date.Value;
            tc.warehouse_trasactions.Add(trn);
            tc.SaveChanges();
            MessageBox.Show("transfared");


        }

       


        //supply request ------------------------------------------------------------------------------------------------------------->

        private void add_sup_request_Click(object sender, EventArgs e)
        {
            supply_request sup=new supply_request();

            sup.supplier_id = (int)request_supplier_id.SelectedItem;
            sup.item_id=(int)request_item_id.SelectedItem;
            sup.warehouse_id=(int) request_store_id.SelectedItem;
            sup.quantity = int.Parse(supply_quantity.Text);
            sup.production_date = supply_production_date.Value;
            sup.expire_date= supply_expire_date.Value;
            sup.request_date=request_date.Value;
            tc.supply_request.Add(sup);
            tc.SaveChanges();
            MessageBox.Show("request added");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            items_report warehouse_=new items_report();

            warehouse_.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           transactions_report tr=new transactions_report();
            tr.Show();
        }

        private void update_sup_request_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(supply_request_id.Text);

            supply_request sup = (tc.supply_request.Where(d => d.srequest_id== ID).Select(d => d)).FirstOrDefault();
            if (sup != null)
            {
                sup.supplier_id = (int)request_supplier_id.SelectedItem;
                sup.item_id = (int)request_item_id.SelectedItem;
                sup.warehouse_id = (int)request_store_id.SelectedItem;
                sup.quantity = int.Parse(supply_quantity.Text);
                sup.production_date = supply_production_date.Value;
                sup.expire_date = supply_expire_date.Value;
                sup.request_date = request_date.Value;
                tc.SaveChanges();

                MessageBox.Show("request updated");

            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }



        //issuance request ------------------------------------------------------------------------------------------------------------->


        private void add_issuance_Click(object sender, EventArgs e)
        {
            issuance_request isr = new issuance_request();

            isr.client_id = (int)issuance_client.SelectedItem;
            isr.warehouse_id=(int)issannce_warehouse.SelectedItem;
            isr.item_id=(int)issuance_item.SelectedItem;
            isr.quantity = int.Parse(issuance_quantity.Text);
            isr.is_date=issuance_date.Value;

            tc.issuance_request.Add(isr);
            tc.SaveChanges();
            MessageBox.Show("issuance added");
        }


        private void update_issuance_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(issuance_id.Text);

           issuance_request isr = (tc.issuance_request.Where(d => d.is_id == ID).Select(d => d)).FirstOrDefault();
            if (isr != null)
            {
                isr.client_id = (int)issuance_client.SelectedItem;
                isr.warehouse_id = (int)issannce_warehouse.SelectedItem;
                isr.item_id = (int)issuance_item.SelectedItem;
                isr.quantity = int.Parse(issuance_quantity.Text);
                isr.is_date = issuance_date.Value;

                tc.SaveChanges();

                MessageBox.Show("request updated");

            }
            else
            {
                MessageBox.Show("Invalid Data");
            }


        }


    }

}
