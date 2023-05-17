namespace company_system
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.company = new System.Windows.Forms.TabControl();
            this.warehouses = new System.Windows.Forms.TabPage();
            this.update_warehouse = new System.Windows.Forms.Button();
            this.add_warehouse = new System.Windows.Forms.Button();
            this.warehouse_manger = new System.Windows.Forms.TextBox();
            this.warehouse_address = new System.Windows.Forms.TextBox();
            this.warehouse_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.warehouse_items = new System.Windows.Forms.ListBox();
            this.stores = new System.Windows.Forms.ComboBox();
            this.items = new System.Windows.Forms.TabPage();
            this.update_item = new System.Windows.Forms.Button();
            this.add_item = new System.Windows.Forms.Button();
            this.expire_date = new System.Windows.Forms.DateTimePicker();
            this.production_date = new System.Windows.Forms.DateTimePicker();
            this.items_id = new System.Windows.Forms.ComboBox();
            this.item_unit = new System.Windows.Forms.TextBox();
            this.item_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clients = new System.Windows.Forms.TabPage();
            this.client_update = new System.Windows.Forms.Button();
            this.add_client = new System.Windows.Forms.Button();
            this.client_mobile = new System.Windows.Forms.TextBox();
            this.client_fax = new System.Windows.Forms.TextBox();
            this.client_website = new System.Windows.Forms.TextBox();
            this.client_email = new System.Windows.Forms.TextBox();
            this.client_phone = new System.Windows.Forms.TextBox();
            this.client_name = new System.Windows.Forms.TextBox();
            this.client_id = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.suppliers = new System.Windows.Forms.TabPage();
            this.update_supplier = new System.Windows.Forms.Button();
            this.add_supplier = new System.Windows.Forms.Button();
            this.supplier_moblie = new System.Windows.Forms.TextBox();
            this.supplier_fax = new System.Windows.Forms.TextBox();
            this.supplier_website = new System.Windows.Forms.TextBox();
            this.supplier_phone = new System.Windows.Forms.TextBox();
            this.supplier_email = new System.Windows.Forms.TextBox();
            this.supplier_name = new System.Windows.Forms.TextBox();
            this.supplier_id = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.transfer_item = new System.Windows.Forms.TabPage();
            this.trans_expire_date = new System.Windows.Forms.DateTimePicker();
            this.trans_production_date = new System.Windows.Forms.DateTimePicker();
            this.transfer = new System.Windows.Forms.Button();
            this.trans_quantity = new System.Windows.Forms.TextBox();
            this.from_suppliers = new System.Windows.Forms.ComboBox();
            this.from_warehouse = new System.Windows.Forms.ComboBox();
            this.to_warehouse = new System.Windows.Forms.ComboBox();
            this.transfer_items = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.supply_request = new System.Windows.Forms.TabPage();
            this.supply_request_id = new System.Windows.Forms.TextBox();
            this.update_sup_request = new System.Windows.Forms.Button();
            this.add_sup_request = new System.Windows.Forms.Button();
            this.request_item_id = new System.Windows.Forms.ComboBox();
            this.request_supplier_id = new System.Windows.Forms.ComboBox();
            this.request_store_id = new System.Windows.Forms.ComboBox();
            this.supply_quantity = new System.Windows.Forms.TextBox();
            this.supply_expire_date = new System.Windows.Forms.DateTimePicker();
            this.supply_production_date = new System.Windows.Forms.DateTimePicker();
            this.request_date = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.issuance_request = new System.Windows.Forms.TabPage();
            this.issuance_quantity = new System.Windows.Forms.TextBox();
            this.issuance_id = new System.Windows.Forms.TextBox();
            this.update_issuance = new System.Windows.Forms.Button();
            this.add_issuance = new System.Windows.Forms.Button();
            this.issuance_item = new System.Windows.Forms.ComboBox();
            this.issuance_client = new System.Windows.Forms.ComboBox();
            this.issannce_warehouse = new System.Windows.Forms.ComboBox();
            this.issuance_date = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.company.SuspendLayout();
            this.warehouses.SuspendLayout();
            this.items.SuspendLayout();
            this.clients.SuspendLayout();
            this.suppliers.SuspendLayout();
            this.transfer_item.SuspendLayout();
            this.supply_request.SuspendLayout();
            this.issuance_request.SuspendLayout();
            this.SuspendLayout();
            // 
            // company
            // 
            this.company.AccessibleName = "";
            this.company.Controls.Add(this.warehouses);
            this.company.Controls.Add(this.items);
            this.company.Controls.Add(this.clients);
            this.company.Controls.Add(this.suppliers);
            this.company.Controls.Add(this.transfer_item);
            this.company.Controls.Add(this.supply_request);
            this.company.Controls.Add(this.issuance_request);
            this.company.Cursor = System.Windows.Forms.Cursors.Default;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.Location = new System.Drawing.Point(98, 175);
            this.company.Name = "company";
            this.company.SelectedIndex = 0;
            this.company.Size = new System.Drawing.Size(1226, 455);
            this.company.TabIndex = 0;
            this.company.Selected += new System.Windows.Forms.TabControlEventHandler(this.company_Selected);
            // 
            // warehouses
            // 
            this.warehouses.Controls.Add(this.update_warehouse);
            this.warehouses.Controls.Add(this.add_warehouse);
            this.warehouses.Controls.Add(this.warehouse_manger);
            this.warehouses.Controls.Add(this.warehouse_address);
            this.warehouses.Controls.Add(this.warehouse_name);
            this.warehouses.Controls.Add(this.label2);
            this.warehouses.Controls.Add(this.label5);
            this.warehouses.Controls.Add(this.label4);
            this.warehouses.Controls.Add(this.label3);
            this.warehouses.Controls.Add(this.label1);
            this.warehouses.Controls.Add(this.warehouse_items);
            this.warehouses.Controls.Add(this.stores);
            this.warehouses.Location = new System.Drawing.Point(4, 34);
            this.warehouses.Name = "warehouses";
            this.warehouses.Padding = new System.Windows.Forms.Padding(3);
            this.warehouses.Size = new System.Drawing.Size(1218, 417);
            this.warehouses.TabIndex = 0;
            this.warehouses.Text = "warehouses";
            this.warehouses.UseVisualStyleBackColor = true;
            // 
            // update_warehouse
            // 
            this.update_warehouse.Location = new System.Drawing.Point(509, 431);
            this.update_warehouse.Name = "update_warehouse";
            this.update_warehouse.Size = new System.Drawing.Size(113, 48);
            this.update_warehouse.TabIndex = 4;
            this.update_warehouse.Text = "update";
            this.update_warehouse.UseVisualStyleBackColor = true;
            this.update_warehouse.Click += new System.EventHandler(this.update_warehouse_Click);
            // 
            // add_warehouse
            // 
            this.add_warehouse.Location = new System.Drawing.Point(249, 431);
            this.add_warehouse.Name = "add_warehouse";
            this.add_warehouse.Size = new System.Drawing.Size(113, 48);
            this.add_warehouse.TabIndex = 4;
            this.add_warehouse.Text = "add";
            this.add_warehouse.UseVisualStyleBackColor = true;
            this.add_warehouse.Click += new System.EventHandler(this.add_warehouse_Click);
            // 
            // warehouse_manger
            // 
            this.warehouse_manger.Location = new System.Drawing.Point(184, 275);
            this.warehouse_manger.Name = "warehouse_manger";
            this.warehouse_manger.Size = new System.Drawing.Size(178, 30);
            this.warehouse_manger.TabIndex = 3;
            // 
            // warehouse_address
            // 
            this.warehouse_address.Location = new System.Drawing.Point(184, 214);
            this.warehouse_address.Name = "warehouse_address";
            this.warehouse_address.Size = new System.Drawing.Size(178, 30);
            this.warehouse_address.TabIndex = 3;
            // 
            // warehouse_name
            // 
            this.warehouse_name.Location = new System.Drawing.Point(184, 151);
            this.warehouse_name.Name = "warehouse_name";
            this.warehouse_name.Size = new System.Drawing.Size(178, 30);
            this.warehouse_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(843, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "manger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "warehouses";
            // 
            // warehouse_items
            // 
            this.warehouse_items.FormattingEnabled = true;
            this.warehouse_items.ItemHeight = 25;
            this.warehouse_items.Location = new System.Drawing.Point(733, 92);
            this.warehouse_items.Name = "warehouse_items";
            this.warehouse_items.Size = new System.Drawing.Size(330, 279);
            this.warehouse_items.TabIndex = 1;
            // 
            // stores
            // 
            this.stores.FormattingEnabled = true;
            this.stores.Location = new System.Drawing.Point(450, 69);
            this.stores.Name = "stores";
            this.stores.Size = new System.Drawing.Size(172, 33);
            this.stores.TabIndex = 0;
            this.stores.SelectedIndexChanged += new System.EventHandler(this.stores_SelectedIndexChanged);
            // 
            // items
            // 
            this.items.Controls.Add(this.update_item);
            this.items.Controls.Add(this.add_item);
            this.items.Controls.Add(this.expire_date);
            this.items.Controls.Add(this.production_date);
            this.items.Controls.Add(this.items_id);
            this.items.Controls.Add(this.item_unit);
            this.items.Controls.Add(this.item_name);
            this.items.Controls.Add(this.label10);
            this.items.Controls.Add(this.label9);
            this.items.Controls.Add(this.label8);
            this.items.Controls.Add(this.label6);
            this.items.Controls.Add(this.label7);
            this.items.Location = new System.Drawing.Point(4, 34);
            this.items.Name = "items";
            this.items.Padding = new System.Windows.Forms.Padding(3);
            this.items.Size = new System.Drawing.Size(1218, 417);
            this.items.TabIndex = 1;
            this.items.Text = "items";
            this.items.UseVisualStyleBackColor = true;
            // 
            // update_item
            // 
            this.update_item.Location = new System.Drawing.Point(605, 413);
            this.update_item.Name = "update_item";
            this.update_item.Size = new System.Drawing.Size(103, 46);
            this.update_item.TabIndex = 4;
            this.update_item.Text = "update";
            this.update_item.UseVisualStyleBackColor = true;
            this.update_item.Click += new System.EventHandler(this.update_item_Click);
            // 
            // add_item
            // 
            this.add_item.Location = new System.Drawing.Point(837, 413);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(103, 46);
            this.add_item.TabIndex = 4;
            this.add_item.Text = "add";
            this.add_item.UseVisualStyleBackColor = true;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // expire_date
            // 
            this.expire_date.Location = new System.Drawing.Point(252, 301);
            this.expire_date.Name = "expire_date";
            this.expire_date.Size = new System.Drawing.Size(245, 30);
            this.expire_date.TabIndex = 3;
            // 
            // production_date
            // 
            this.production_date.Location = new System.Drawing.Point(252, 252);
            this.production_date.Name = "production_date";
            this.production_date.Size = new System.Drawing.Size(245, 30);
            this.production_date.TabIndex = 3;
            // 
            // items_id
            // 
            this.items_id.FormattingEnabled = true;
            this.items_id.Location = new System.Drawing.Point(726, 71);
            this.items_id.Name = "items_id";
            this.items_id.Size = new System.Drawing.Size(121, 33);
            this.items_id.TabIndex = 2;
            this.items_id.SelectedIndexChanged += new System.EventHandler(this.items_id_SelectedIndexChanged);
            // 
            // item_unit
            // 
            this.item_unit.Location = new System.Drawing.Point(285, 201);
            this.item_unit.Name = "item_unit";
            this.item_unit.Size = new System.Drawing.Size(157, 30);
            this.item_unit.TabIndex = 1;
            // 
            // item_name
            // 
            this.item_name.Location = new System.Drawing.Point(285, 154);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(157, 30);
            this.item_name.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "expire_date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "production_date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(746, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "items id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "name";
            // 
            // clients
            // 
            this.clients.Controls.Add(this.client_update);
            this.clients.Controls.Add(this.add_client);
            this.clients.Controls.Add(this.client_mobile);
            this.clients.Controls.Add(this.client_fax);
            this.clients.Controls.Add(this.client_website);
            this.clients.Controls.Add(this.client_email);
            this.clients.Controls.Add(this.client_phone);
            this.clients.Controls.Add(this.client_name);
            this.clients.Controls.Add(this.client_id);
            this.clients.Controls.Add(this.label17);
            this.clients.Controls.Add(this.label16);
            this.clients.Controls.Add(this.label15);
            this.clients.Controls.Add(this.label14);
            this.clients.Controls.Add(this.label13);
            this.clients.Controls.Add(this.label12);
            this.clients.Controls.Add(this.label46);
            this.clients.Controls.Add(this.label11);
            this.clients.Location = new System.Drawing.Point(4, 34);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(1218, 417);
            this.clients.TabIndex = 2;
            this.clients.Text = "clients";
            this.clients.UseVisualStyleBackColor = true;
            // 
            // client_update
            // 
            this.client_update.Location = new System.Drawing.Point(872, 117);
            this.client_update.Name = "client_update";
            this.client_update.Size = new System.Drawing.Size(95, 38);
            this.client_update.TabIndex = 2;
            this.client_update.Text = "update";
            this.client_update.UseVisualStyleBackColor = true;
            this.client_update.Click += new System.EventHandler(this.client_update_Click);
            // 
            // add_client
            // 
            this.add_client.Location = new System.Drawing.Point(872, 54);
            this.add_client.Name = "add_client";
            this.add_client.Size = new System.Drawing.Size(95, 38);
            this.add_client.TabIndex = 2;
            this.add_client.Text = "add";
            this.add_client.UseVisualStyleBackColor = true;
            this.add_client.Click += new System.EventHandler(this.add_client_Click);
            // 
            // client_mobile
            // 
            this.client_mobile.Location = new System.Drawing.Point(163, 352);
            this.client_mobile.Name = "client_mobile";
            this.client_mobile.Size = new System.Drawing.Size(185, 30);
            this.client_mobile.TabIndex = 1;
            // 
            // client_fax
            // 
            this.client_fax.Location = new System.Drawing.Point(163, 296);
            this.client_fax.Name = "client_fax";
            this.client_fax.Size = new System.Drawing.Size(185, 30);
            this.client_fax.TabIndex = 1;
            // 
            // client_website
            // 
            this.client_website.Location = new System.Drawing.Point(163, 248);
            this.client_website.Name = "client_website";
            this.client_website.Size = new System.Drawing.Size(185, 30);
            this.client_website.TabIndex = 1;
            // 
            // client_email
            // 
            this.client_email.Location = new System.Drawing.Point(163, 189);
            this.client_email.Name = "client_email";
            this.client_email.Size = new System.Drawing.Size(185, 30);
            this.client_email.TabIndex = 1;
            // 
            // client_phone
            // 
            this.client_phone.Location = new System.Drawing.Point(163, 138);
            this.client_phone.Name = "client_phone";
            this.client_phone.Size = new System.Drawing.Size(185, 30);
            this.client_phone.TabIndex = 1;
            // 
            // client_name
            // 
            this.client_name.Location = new System.Drawing.Point(163, 88);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(185, 30);
            this.client_name.TabIndex = 1;
            // 
            // client_id
            // 
            this.client_id.Location = new System.Drawing.Point(163, 48);
            this.client_id.Name = "client_id";
            this.client_id.Size = new System.Drawing.Size(185, 30);
            this.client_id.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 355);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "mobile";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 299);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "fax";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 251);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "website";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "id";
            // 
            // suppliers
            // 
            this.suppliers.Controls.Add(this.label47);
            this.suppliers.Controls.Add(this.update_supplier);
            this.suppliers.Controls.Add(this.add_supplier);
            this.suppliers.Controls.Add(this.supplier_moblie);
            this.suppliers.Controls.Add(this.supplier_fax);
            this.suppliers.Controls.Add(this.supplier_website);
            this.suppliers.Controls.Add(this.supplier_phone);
            this.suppliers.Controls.Add(this.supplier_email);
            this.suppliers.Controls.Add(this.supplier_name);
            this.suppliers.Controls.Add(this.supplier_id);
            this.suppliers.Controls.Add(this.label24);
            this.suppliers.Controls.Add(this.label23);
            this.suppliers.Controls.Add(this.label22);
            this.suppliers.Controls.Add(this.label21);
            this.suppliers.Controls.Add(this.label20);
            this.suppliers.Controls.Add(this.label19);
            this.suppliers.Controls.Add(this.label18);
            this.suppliers.Location = new System.Drawing.Point(4, 34);
            this.suppliers.Name = "suppliers";
            this.suppliers.Size = new System.Drawing.Size(1218, 417);
            this.suppliers.TabIndex = 3;
            this.suppliers.Text = "suppliers";
            this.suppliers.UseVisualStyleBackColor = true;
            // 
            // update_supplier
            // 
            this.update_supplier.Location = new System.Drawing.Point(660, 152);
            this.update_supplier.Name = "update_supplier";
            this.update_supplier.Size = new System.Drawing.Size(90, 31);
            this.update_supplier.TabIndex = 2;
            this.update_supplier.Text = "update";
            this.update_supplier.UseVisualStyleBackColor = true;
            this.update_supplier.Click += new System.EventHandler(this.update_supplier_Click);
            // 
            // add_supplier
            // 
            this.add_supplier.Location = new System.Drawing.Point(660, 62);
            this.add_supplier.Name = "add_supplier";
            this.add_supplier.Size = new System.Drawing.Size(90, 31);
            this.add_supplier.TabIndex = 2;
            this.add_supplier.Text = "add";
            this.add_supplier.UseVisualStyleBackColor = true;
            this.add_supplier.Click += new System.EventHandler(this.add_supplier_Click);
            // 
            // supplier_moblie
            // 
            this.supplier_moblie.Location = new System.Drawing.Point(168, 345);
            this.supplier_moblie.Name = "supplier_moblie";
            this.supplier_moblie.Size = new System.Drawing.Size(150, 30);
            this.supplier_moblie.TabIndex = 1;
            // 
            // supplier_fax
            // 
            this.supplier_fax.Location = new System.Drawing.Point(168, 296);
            this.supplier_fax.Name = "supplier_fax";
            this.supplier_fax.Size = new System.Drawing.Size(150, 30);
            this.supplier_fax.TabIndex = 1;
            // 
            // supplier_website
            // 
            this.supplier_website.Location = new System.Drawing.Point(168, 246);
            this.supplier_website.Name = "supplier_website";
            this.supplier_website.Size = new System.Drawing.Size(150, 30);
            this.supplier_website.TabIndex = 1;
            // 
            // supplier_phone
            // 
            this.supplier_phone.Location = new System.Drawing.Point(168, 202);
            this.supplier_phone.Name = "supplier_phone";
            this.supplier_phone.Size = new System.Drawing.Size(150, 30);
            this.supplier_phone.TabIndex = 1;
            // 
            // supplier_email
            // 
            this.supplier_email.Location = new System.Drawing.Point(168, 155);
            this.supplier_email.Name = "supplier_email";
            this.supplier_email.Size = new System.Drawing.Size(150, 30);
            this.supplier_email.TabIndex = 1;
            // 
            // supplier_name
            // 
            this.supplier_name.Location = new System.Drawing.Point(168, 112);
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.Size = new System.Drawing.Size(150, 30);
            this.supplier_name.TabIndex = 1;
            // 
            // supplier_id
            // 
            this.supplier_id.Location = new System.Drawing.Point(168, 63);
            this.supplier_id.Name = "supplier_id";
            this.supplier_id.Size = new System.Drawing.Size(150, 30);
            this.supplier_id.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(51, 350);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 25);
            this.label24.TabIndex = 0;
            this.label24.Text = "mobile";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(51, 296);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 25);
            this.label23.TabIndex = 0;
            this.label23.Text = "fax";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(51, 246);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 25);
            this.label22.TabIndex = 0;
            this.label22.Text = "website";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(48, 112);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 25);
            this.label21.TabIndex = 0;
            this.label21.Text = "name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(51, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 25);
            this.label20.TabIndex = 0;
            this.label20.Text = "email";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(51, 202);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "phone";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(51, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "id";
            // 
            // transfer_item
            // 
            this.transfer_item.Controls.Add(this.trans_expire_date);
            this.transfer_item.Controls.Add(this.trans_production_date);
            this.transfer_item.Controls.Add(this.transfer);
            this.transfer_item.Controls.Add(this.trans_quantity);
            this.transfer_item.Controls.Add(this.from_suppliers);
            this.transfer_item.Controls.Add(this.from_warehouse);
            this.transfer_item.Controls.Add(this.to_warehouse);
            this.transfer_item.Controls.Add(this.transfer_items);
            this.transfer_item.Controls.Add(this.label36);
            this.transfer_item.Controls.Add(this.label38);
            this.transfer_item.Controls.Add(this.label27);
            this.transfer_item.Controls.Add(this.label37);
            this.transfer_item.Controls.Add(this.label26);
            this.transfer_item.Controls.Add(this.label28);
            this.transfer_item.Controls.Add(this.label25);
            this.transfer_item.Location = new System.Drawing.Point(4, 34);
            this.transfer_item.Name = "transfer_item";
            this.transfer_item.Size = new System.Drawing.Size(1218, 417);
            this.transfer_item.TabIndex = 4;
            this.transfer_item.Text = "transfer item";
            this.transfer_item.UseVisualStyleBackColor = true;
            // 
            // trans_expire_date
            // 
            this.trans_expire_date.Location = new System.Drawing.Point(607, 332);
            this.trans_expire_date.Name = "trans_expire_date";
            this.trans_expire_date.Size = new System.Drawing.Size(200, 30);
            this.trans_expire_date.TabIndex = 4;
            // 
            // trans_production_date
            // 
            this.trans_production_date.Location = new System.Drawing.Point(342, 332);
            this.trans_production_date.Name = "trans_production_date";
            this.trans_production_date.Size = new System.Drawing.Size(200, 30);
            this.trans_production_date.TabIndex = 4;
            // 
            // transfer
            // 
            this.transfer.Location = new System.Drawing.Point(543, 429);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(101, 35);
            this.transfer.TabIndex = 3;
            this.transfer.Text = "Transfer";
            this.transfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transfer.UseVisualStyleBackColor = true;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // trans_quantity
            // 
            this.trans_quantity.Location = new System.Drawing.Point(84, 332);
            this.trans_quantity.Name = "trans_quantity";
            this.trans_quantity.Size = new System.Drawing.Size(156, 30);
            this.trans_quantity.TabIndex = 2;
            // 
            // from_suppliers
            // 
            this.from_suppliers.FormattingEnabled = true;
            this.from_suppliers.Location = new System.Drawing.Point(961, 124);
            this.from_suppliers.Name = "from_suppliers";
            this.from_suppliers.Size = new System.Drawing.Size(156, 33);
            this.from_suppliers.TabIndex = 1;
            // 
            // from_warehouse
            // 
            this.from_warehouse.FormattingEnabled = true;
            this.from_warehouse.Location = new System.Drawing.Point(84, 124);
            this.from_warehouse.Name = "from_warehouse";
            this.from_warehouse.Size = new System.Drawing.Size(156, 33);
            this.from_warehouse.TabIndex = 1;
            // 
            // to_warehouse
            // 
            this.to_warehouse.FormattingEnabled = true;
            this.to_warehouse.Location = new System.Drawing.Point(342, 124);
            this.to_warehouse.Name = "to_warehouse";
            this.to_warehouse.Size = new System.Drawing.Size(156, 33);
            this.to_warehouse.TabIndex = 1;
            // 
            // transfer_items
            // 
            this.transfer_items.FormattingEnabled = true;
            this.transfer_items.Location = new System.Drawing.Point(624, 124);
            this.transfer_items.Name = "transfer_items";
            this.transfer_items.Size = new System.Drawing.Size(156, 33);
            this.transfer_items.TabIndex = 1;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(95, 73);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(151, 25);
            this.label36.TabIndex = 0;
            this.label36.Text = "from warehouse";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(643, 278);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(108, 25);
            this.label38.TabIndex = 0;
            this.label38.Text = "expire date";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(986, 73);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(106, 25);
            this.label27.TabIndex = 0;
            this.label27.Text = "supplier_id";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(362, 278);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(152, 25);
            this.label37.TabIndex = 0;
            this.label37.Text = "prroduction date";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(353, 73);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(129, 25);
            this.label26.TabIndex = 0;
            this.label26.Text = "to warehouse";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(124, 278);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 25);
            this.label28.TabIndex = 0;
            this.label28.Text = "quantity";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(661, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 25);
            this.label25.TabIndex = 0;
            this.label25.Text = "items";
            // 
            // supply_request
            // 
            this.supply_request.Controls.Add(this.label48);
            this.supply_request.Controls.Add(this.supply_request_id);
            this.supply_request.Controls.Add(this.update_sup_request);
            this.supply_request.Controls.Add(this.add_sup_request);
            this.supply_request.Controls.Add(this.request_item_id);
            this.supply_request.Controls.Add(this.request_supplier_id);
            this.supply_request.Controls.Add(this.request_store_id);
            this.supply_request.Controls.Add(this.supply_quantity);
            this.supply_request.Controls.Add(this.supply_expire_date);
            this.supply_request.Controls.Add(this.supply_production_date);
            this.supply_request.Controls.Add(this.request_date);
            this.supply_request.Controls.Add(this.label31);
            this.supply_request.Controls.Add(this.label30);
            this.supply_request.Controls.Add(this.label35);
            this.supply_request.Controls.Add(this.label34);
            this.supply_request.Controls.Add(this.label33);
            this.supply_request.Controls.Add(this.label43);
            this.supply_request.Controls.Add(this.label32);
            this.supply_request.Controls.Add(this.label29);
            this.supply_request.Location = new System.Drawing.Point(4, 34);
            this.supply_request.Name = "supply_request";
            this.supply_request.Size = new System.Drawing.Size(1218, 417);
            this.supply_request.TabIndex = 5;
            this.supply_request.Text = "supply request";
            this.supply_request.UseVisualStyleBackColor = true;
            // 
            // supply_request_id
            // 
            this.supply_request_id.Location = new System.Drawing.Point(251, 362);
            this.supply_request_id.Name = "supply_request_id";
            this.supply_request_id.Size = new System.Drawing.Size(269, 30);
            this.supply_request_id.TabIndex = 5;
            // 
            // update_sup_request
            // 
            this.update_sup_request.Location = new System.Drawing.Point(716, 436);
            this.update_sup_request.Name = "update_sup_request";
            this.update_sup_request.Size = new System.Drawing.Size(99, 37);
            this.update_sup_request.TabIndex = 4;
            this.update_sup_request.Text = "update";
            this.update_sup_request.UseVisualStyleBackColor = true;
            this.update_sup_request.Click += new System.EventHandler(this.update_sup_request_Click);
            // 
            // add_sup_request
            // 
            this.add_sup_request.Location = new System.Drawing.Point(293, 436);
            this.add_sup_request.Name = "add_sup_request";
            this.add_sup_request.Size = new System.Drawing.Size(99, 37);
            this.add_sup_request.TabIndex = 4;
            this.add_sup_request.Text = "add";
            this.add_sup_request.UseVisualStyleBackColor = true;
            this.add_sup_request.Click += new System.EventHandler(this.add_sup_request_Click);
            // 
            // request_item_id
            // 
            this.request_item_id.FormattingEnabled = true;
            this.request_item_id.Location = new System.Drawing.Point(797, 256);
            this.request_item_id.Name = "request_item_id";
            this.request_item_id.Size = new System.Drawing.Size(192, 33);
            this.request_item_id.TabIndex = 3;
            // 
            // request_supplier_id
            // 
            this.request_supplier_id.FormattingEnabled = true;
            this.request_supplier_id.Location = new System.Drawing.Point(797, 157);
            this.request_supplier_id.Name = "request_supplier_id";
            this.request_supplier_id.Size = new System.Drawing.Size(192, 33);
            this.request_supplier_id.TabIndex = 3;
            // 
            // request_store_id
            // 
            this.request_store_id.FormattingEnabled = true;
            this.request_store_id.Location = new System.Drawing.Point(797, 71);
            this.request_store_id.Name = "request_store_id";
            this.request_store_id.Size = new System.Drawing.Size(192, 33);
            this.request_store_id.TabIndex = 3;
            // 
            // supply_quantity
            // 
            this.supply_quantity.Location = new System.Drawing.Point(799, 355);
            this.supply_quantity.Name = "supply_quantity";
            this.supply_quantity.Size = new System.Drawing.Size(190, 30);
            this.supply_quantity.TabIndex = 2;
            // 
            // supply_expire_date
            // 
            this.supply_expire_date.Location = new System.Drawing.Point(251, 274);
            this.supply_expire_date.Name = "supply_expire_date";
            this.supply_expire_date.Size = new System.Drawing.Size(269, 30);
            this.supply_expire_date.TabIndex = 1;
            // 
            // supply_production_date
            // 
            this.supply_production_date.Location = new System.Drawing.Point(251, 165);
            this.supply_production_date.Name = "supply_production_date";
            this.supply_production_date.Size = new System.Drawing.Size(269, 30);
            this.supply_production_date.TabIndex = 1;
            // 
            // request_date
            // 
            this.request_date.Location = new System.Drawing.Point(251, 66);
            this.request_date.Name = "request_date";
            this.request_date.Size = new System.Drawing.Size(269, 30);
            this.request_date.TabIndex = 1;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(78, 274);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(114, 25);
            this.label31.TabIndex = 0;
            this.label31.Text = "expire_date";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(78, 170);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(152, 25);
            this.label30.TabIndex = 0;
            this.label30.Text = "production_date";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(661, 355);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 25);
            this.label35.TabIndex = 0;
            this.label35.Text = "quantity";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(661, 264);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(68, 25);
            this.label34.TabIndex = 0;
            this.label34.Text = "item id";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(661, 165);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(100, 25);
            this.label33.TabIndex = 0;
            this.label33.Text = "supplier id";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(45, 360);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(159, 25);
            this.label43.TabIndex = 0;
            this.label43.Text = "supply request id";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(661, 71);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(75, 25);
            this.label32.TabIndex = 0;
            this.label32.Text = "store id";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(78, 66);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(126, 25);
            this.label29.TabIndex = 0;
            this.label29.Text = "request_date";
            // 
            // issuance_request
            // 
            this.issuance_request.Controls.Add(this.label49);
            this.issuance_request.Controls.Add(this.issuance_quantity);
            this.issuance_request.Controls.Add(this.issuance_id);
            this.issuance_request.Controls.Add(this.update_issuance);
            this.issuance_request.Controls.Add(this.add_issuance);
            this.issuance_request.Controls.Add(this.issuance_item);
            this.issuance_request.Controls.Add(this.issuance_client);
            this.issuance_request.Controls.Add(this.issannce_warehouse);
            this.issuance_request.Controls.Add(this.issuance_date);
            this.issuance_request.Controls.Add(this.label45);
            this.issuance_request.Controls.Add(this.label39);
            this.issuance_request.Controls.Add(this.label44);
            this.issuance_request.Controls.Add(this.label40);
            this.issuance_request.Controls.Add(this.label41);
            this.issuance_request.Controls.Add(this.label42);
            this.issuance_request.Location = new System.Drawing.Point(4, 34);
            this.issuance_request.Name = "issuance_request";
            this.issuance_request.Size = new System.Drawing.Size(1218, 417);
            this.issuance_request.TabIndex = 6;
            this.issuance_request.Text = "issuance request";
            this.issuance_request.UseVisualStyleBackColor = true;
            // 
            // issuance_quantity
            // 
            this.issuance_quantity.Location = new System.Drawing.Point(286, 338);
            this.issuance_quantity.Name = "issuance_quantity";
            this.issuance_quantity.Size = new System.Drawing.Size(192, 30);
            this.issuance_quantity.TabIndex = 21;
            // 
            // issuance_id
            // 
            this.issuance_id.Location = new System.Drawing.Point(873, 338);
            this.issuance_id.Name = "issuance_id";
            this.issuance_id.Size = new System.Drawing.Size(192, 30);
            this.issuance_id.TabIndex = 21;
            // 
            // update_issuance
            // 
            this.update_issuance.Location = new System.Drawing.Point(792, 426);
            this.update_issuance.Name = "update_issuance";
            this.update_issuance.Size = new System.Drawing.Size(99, 37);
            this.update_issuance.TabIndex = 19;
            this.update_issuance.Text = "update";
            this.update_issuance.UseVisualStyleBackColor = true;
            this.update_issuance.Click += new System.EventHandler(this.update_issuance_Click);
            // 
            // add_issuance
            // 
            this.add_issuance.Location = new System.Drawing.Point(369, 426);
            this.add_issuance.Name = "add_issuance";
            this.add_issuance.Size = new System.Drawing.Size(99, 37);
            this.add_issuance.TabIndex = 20;
            this.add_issuance.Text = "add";
            this.add_issuance.UseVisualStyleBackColor = true;
            this.add_issuance.Click += new System.EventHandler(this.add_issuance_Click);
            // 
            // issuance_item
            // 
            this.issuance_item.FormattingEnabled = true;
            this.issuance_item.Location = new System.Drawing.Point(873, 246);
            this.issuance_item.Name = "issuance_item";
            this.issuance_item.Size = new System.Drawing.Size(192, 33);
            this.issuance_item.TabIndex = 16;
            // 
            // issuance_client
            // 
            this.issuance_client.FormattingEnabled = true;
            this.issuance_client.Location = new System.Drawing.Point(873, 147);
            this.issuance_client.Name = "issuance_client";
            this.issuance_client.Size = new System.Drawing.Size(192, 33);
            this.issuance_client.TabIndex = 17;
            // 
            // issannce_warehouse
            // 
            this.issannce_warehouse.FormattingEnabled = true;
            this.issannce_warehouse.Location = new System.Drawing.Point(873, 61);
            this.issannce_warehouse.Name = "issannce_warehouse";
            this.issannce_warehouse.Size = new System.Drawing.Size(192, 33);
            this.issannce_warehouse.TabIndex = 18;
            // 
            // issuance_date
            // 
            this.issuance_date.Location = new System.Drawing.Point(327, 56);
            this.issuance_date.Name = "issuance_date";
            this.issuance_date.Size = new System.Drawing.Size(269, 30);
            this.issuance_date.TabIndex = 14;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(172, 336);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(80, 25);
            this.label45.TabIndex = 8;
            this.label45.Text = "quantity";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(737, 254);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(68, 25);
            this.label39.TabIndex = 8;
            this.label39.Text = "item id";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(689, 336);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(116, 25);
            this.label44.TabIndex = 9;
            this.label44.Text = "issuance_id";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(738, 155);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(77, 25);
            this.label40.TabIndex = 9;
            this.label40.Text = "client id";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(737, 61);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(75, 25);
            this.label41.TabIndex = 10;
            this.label41.Text = "store id";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(155, 56);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(139, 25);
            this.label42.TabIndex = 11;
            this.label42.Text = "issuance_date";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "items/warehouse report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(981, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "transactions report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(394, 51);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(270, 25);
            this.label46.TabIndex = 0;
            this.label46.Text = "enter id in case of update only";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(343, 68);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(270, 25);
            this.label47.TabIndex = 3;
            this.label47.Text = "enter id in case of update only";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(250, 325);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(270, 25);
            this.label48.TabIndex = 6;
            this.label48.Text = "enter id in case of update only";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(827, 300);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(270, 25);
            this.label49.TabIndex = 22;
            this.label49.Text = "enter id in case of update only";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 672);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.company);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.company.ResumeLayout(false);
            this.warehouses.ResumeLayout(false);
            this.warehouses.PerformLayout();
            this.items.ResumeLayout(false);
            this.items.PerformLayout();
            this.clients.ResumeLayout(false);
            this.clients.PerformLayout();
            this.suppliers.ResumeLayout(false);
            this.suppliers.PerformLayout();
            this.transfer_item.ResumeLayout(false);
            this.transfer_item.PerformLayout();
            this.supply_request.ResumeLayout(false);
            this.supply_request.PerformLayout();
            this.issuance_request.ResumeLayout(false);
            this.issuance_request.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl company;
        private System.Windows.Forms.TabPage warehouses;
        private System.Windows.Forms.TabPage items;
        private System.Windows.Forms.ComboBox stores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox warehouse_items;
        private System.Windows.Forms.TextBox warehouse_manger;
        private System.Windows.Forms.TextBox warehouse_address;
        private System.Windows.Forms.TextBox warehouse_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button update_warehouse;
        private System.Windows.Forms.Button add_warehouse;
        private System.Windows.Forms.Button update_item;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.DateTimePicker expire_date;
        private System.Windows.Forms.DateTimePicker production_date;
        private System.Windows.Forms.ComboBox items_id;
        private System.Windows.Forms.TextBox item_unit;
        private System.Windows.Forms.TextBox item_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage clients;
        private System.Windows.Forms.TabPage suppliers;
        private System.Windows.Forms.Button client_update;
        private System.Windows.Forms.Button add_client;
        private System.Windows.Forms.TextBox client_mobile;
        private System.Windows.Forms.TextBox client_fax;
        private System.Windows.Forms.TextBox client_website;
        private System.Windows.Forms.TextBox client_email;
        private System.Windows.Forms.TextBox client_phone;
        private System.Windows.Forms.TextBox client_name;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TextBox supplier_moblie;
        private System.Windows.Forms.TextBox supplier_fax;
        private System.Windows.Forms.TextBox supplier_website;
        private System.Windows.Forms.TextBox supplier_phone;
        private System.Windows.Forms.TextBox supplier_email;
        private System.Windows.Forms.TextBox supplier_name;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage transfer_item;
        private System.Windows.Forms.TabPage supply_request;
        private System.Windows.Forms.TabPage issuance_request;
        private System.Windows.Forms.TextBox trans_quantity;
        private System.Windows.Forms.ComboBox from_suppliers;
        private System.Windows.Forms.ComboBox to_warehouse;
        private System.Windows.Forms.ComboBox transfer_items;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.Button update_supplier;
        private System.Windows.Forms.Button add_supplier;
        private System.Windows.Forms.DateTimePicker supply_expire_date;
        private System.Windows.Forms.DateTimePicker supply_production_date;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox request_store_id;
        private System.Windows.Forms.TextBox supply_quantity;
        private System.Windows.Forms.ComboBox request_item_id;
        private System.Windows.Forms.ComboBox request_supplier_id;
        private System.Windows.Forms.Button update_sup_request;
        private System.Windows.Forms.Button add_sup_request;
        private System.Windows.Forms.Button update_issuance;
        private System.Windows.Forms.Button add_issuance;
        private System.Windows.Forms.ComboBox issuance_item;
        private System.Windows.Forms.ComboBox issuance_client;
        private System.Windows.Forms.ComboBox issannce_warehouse;
        private System.Windows.Forms.DateTimePicker issuance_date;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox client_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox supplier_id;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker trans_expire_date;
        private System.Windows.Forms.DateTimePicker trans_production_date;
        private System.Windows.Forms.ComboBox from_warehouse;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DateTimePicker request_date;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox supply_request_id;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox issuance_id;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox issuance_quantity;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
    }
}

