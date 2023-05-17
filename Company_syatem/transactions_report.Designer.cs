namespace company_system
{
    partial class transactions_report
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
            this.trans_expire_date = new System.Windows.Forms.DateTimePicker();
            this.trans_production_date = new System.Windows.Forms.DateTimePicker();
            this.trans_quantity = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trans_expire_date
            // 
            this.trans_expire_date.Location = new System.Drawing.Point(507, 366);
            this.trans_expire_date.Name = "trans_expire_date";
            this.trans_expire_date.Size = new System.Drawing.Size(200, 22);
            this.trans_expire_date.TabIndex = 17;
            // 
            // trans_production_date
            // 
            this.trans_production_date.Location = new System.Drawing.Point(255, 366);
            this.trans_production_date.Name = "trans_production_date";
            this.trans_production_date.Size = new System.Drawing.Size(200, 22);
            this.trans_production_date.TabIndex = 18;
            // 
            // trans_quantity
            // 
            this.trans_quantity.Location = new System.Drawing.Point(51, 366);
            this.trans_quantity.Name = "trans_quantity";
            this.trans_quantity.Size = new System.Drawing.Size(156, 22);
            this.trans_quantity.TabIndex = 16;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(62, 97);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(102, 16);
            this.label36.TabIndex = 5;
            this.label36.Text = "from warehouse";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(543, 312);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(74, 16);
            this.label38.TabIndex = 6;
            this.label38.Text = "expire date";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(940, 330);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 16);
            this.label27.TabIndex = 7;
            this.label27.Text = "supplier_id";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(275, 312);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(104, 16);
            this.label37.TabIndex = 8;
            this.label37.Text = "prroduction date";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(940, 97);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 16);
            this.label26.TabIndex = 9;
            this.label26.Text = "to warehouse";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(91, 312);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 16);
            this.label28.TabIndex = 10;
            this.label28.Text = "quantity";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(793, 330);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 16);
            this.label25.TabIndex = 11;
            this.label25.Text = "items";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(927, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(765, 368);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(927, 368);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(470, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "transactions";
            // 
            // transactions_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 494);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trans_expire_date);
            this.Controls.Add(this.trans_production_date);
            this.Controls.Add(this.trans_quantity);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label25);
            this.Name = "transactions_report";
            this.Text = "transactions_report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker trans_expire_date;
        private System.Windows.Forms.DateTimePicker trans_production_date;
        private System.Windows.Forms.TextBox trans_quantity;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}