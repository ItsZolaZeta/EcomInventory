namespace EcomInventory
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ClientID = new System.Windows.Forms.ComboBox();
            this.OrdersListView = new System.Windows.Forms.DataGridView();
            this.resetProd = new System.Windows.Forms.Button();
            this.AddProdBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ProductQty = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ProductsListView = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ODate = new System.Windows.Forms.DateTimePicker();
            this.OrderProductsView = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderProductsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(86, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Name";
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutLabel.Location = new System.Drawing.Point(12, 584);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(63, 20);
            this.logoutLabel.TabIndex = 36;
            this.logoutLabel.Text = "Log out";
            this.logoutLabel.Click += new System.EventHandler(this.logoutLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(66, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Staff";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(66, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Clients";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(66, 265);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(87, 35);
            this.label3.TabIndex = 33;
            this.label3.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(66, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Products";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.StaffName);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.ClientID);
            this.panel1.Controls.Add(this.OrdersListView);
            this.panel1.Controls.Add(this.resetProd);
            this.panel1.Controls.Add(this.AddProdBtn);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.ProductPrice);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.ProductQty);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.ProductName);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.ProductsListView);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.ODate);
            this.panel1.Controls.Add(this.OrderProductsView);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.ClientName);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TotalPrice);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(227, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 589);
            this.panel1.TabIndex = 38;
            // 
            // StaffName
            // 
            this.StaffName.Location = new System.Drawing.Point(320, 301);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(192, 20);
            this.StaffName.TabIndex = 80;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Navy;
            this.label20.Location = new System.Drawing.Point(316, 273);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 20);
            this.label20.TabIndex = 81;
            this.label20.Text = "Staff Name";
            // 
            // ClientID
            // 
            this.ClientID.FormattingEnabled = true;
            this.ClientID.Items.AddRange(new object[] {
            "Mobile Phones",
            "PC parts",
            "TVs"});
            this.ClientID.Location = new System.Drawing.Point(31, 193);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(172, 21);
            this.ClientID.TabIndex = 79;
            this.ClientID.SelectedIndexChanged += new System.EventHandler(this.ClientID_SelectedIndexChanged);
            // 
            // OrdersListView
            // 
            this.OrdersListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersListView.Location = new System.Drawing.Point(537, 108);
            this.OrdersListView.Name = "OrdersListView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrdersListView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.OrdersListView.Size = new System.Drawing.Size(401, 226);
            this.OrdersListView.TabIndex = 78;
            this.OrdersListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersListView_CellContentClick);
            // 
            // resetProd
            // 
            this.resetProd.BackColor = System.Drawing.Color.Navy;
            this.resetProd.FlatAppearance.BorderSize = 0;
            this.resetProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetProd.Location = new System.Drawing.Point(452, 532);
            this.resetProd.Name = "resetProd";
            this.resetProd.Size = new System.Drawing.Size(60, 30);
            this.resetProd.TabIndex = 76;
            this.resetProd.Text = "Reset";
            this.resetProd.UseVisualStyleBackColor = false;
            this.resetProd.Click += new System.EventHandler(this.resetProd_Click);
            // 
            // AddProdBtn
            // 
            this.AddProdBtn.BackColor = System.Drawing.Color.Navy;
            this.AddProdBtn.FlatAppearance.BorderSize = 0;
            this.AddProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddProdBtn.Location = new System.Drawing.Point(320, 533);
            this.AddProdBtn.Name = "AddProdBtn";
            this.AddProdBtn.Size = new System.Drawing.Size(126, 30);
            this.AddProdBtn.TabIndex = 75;
            this.AddProdBtn.Text = "Add to Order";
            this.AddProdBtn.UseVisualStyleBackColor = false;
            this.AddProdBtn.Click += new System.EventHandler(this.AddProdBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(532, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 25);
            this.label11.TabIndex = 77;
            this.label11.Text = "Orders Master List";
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(320, 502);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(192, 20);
            this.ProductPrice.TabIndex = 73;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Navy;
            this.label19.Location = new System.Drawing.Point(316, 480);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 20);
            this.label19.TabIndex = 74;
            this.label19.Text = "Product Price";
            // 
            // ProductQty
            // 
            this.ProductQty.Location = new System.Drawing.Point(320, 447);
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.Size = new System.Drawing.Size(192, 20);
            this.ProductQty.TabIndex = 71;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Navy;
            this.label18.Location = new System.Drawing.Point(316, 425);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 20);
            this.label18.TabIndex = 72;
            this.label18.Text = "Product Qty";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(320, 397);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(192, 20);
            this.ProductName.TabIndex = 69;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(316, 369);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 20);
            this.label17.TabIndex = 70;
            this.label17.Text = "Product Name";
            // 
            // ProductsListView
            // 
            this.ProductsListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsListView.Location = new System.Drawing.Point(537, 397);
            this.ProductsListView.Name = "ProductsListView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductsListView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ProductsListView.Size = new System.Drawing.Size(401, 165);
            this.ProductsListView.TabIndex = 68;
            this.ProductsListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsListView_CellContentClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(532, 369);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(209, 25);
            this.label16.TabIndex = 67;
            this.label16.Text = "Products Master List";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(27, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 65;
            this.label12.Text = "Client ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(205, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 20);
            this.label15.TabIndex = 63;
            this.label15.Text = "Order Date";
            // 
            // ODate
            // 
            this.ODate.Location = new System.Drawing.Point(209, 194);
            this.ODate.Name = "ODate";
            this.ODate.Size = new System.Drawing.Size(200, 20);
            this.ODate.TabIndex = 62;
            // 
            // OrderProductsView
            // 
            this.OrderProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderProductsView.Location = new System.Drawing.Point(31, 273);
            this.OrderProductsView.Name = "OrderProductsView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrderProductsView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.OrderProductsView.Size = new System.Drawing.Size(264, 299);
            this.OrderProductsView.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(26, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 25);
            this.label14.TabIndex = 60;
            this.label14.Text = "Ordered Products";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(269, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(442, 31);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ecommerce Inventory Management";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Navy;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveBtn.Location = new System.Drawing.Point(441, 144);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(60, 30);
            this.SaveBtn.TabIndex = 56;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(26, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 48;
            this.label9.Text = "Order Details";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Navy;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditBtn.Location = new System.Drawing.Point(441, 180);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(60, 30);
            this.EditBtn.TabIndex = 57;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(31, 144);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(169, 20);
            this.ClientName.TabIndex = 49;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Navy;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.Location = new System.Drawing.Point(441, 216);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(66, 30);
            this.DeleteBtn.TabIndex = 58;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(27, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Client Name";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Location = new System.Drawing.Point(209, 144);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(169, 20);
            this.TotalPrice.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(205, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 53;
            this.label13.Text = "Total Price";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1195, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderProductsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView OrderProductsView;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker ODate;
        private System.Windows.Forms.DataGridView ProductsListView;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ProductQty;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button AddProdBtn;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button resetProd;
        private System.Windows.Forms.DataGridView OrdersListView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ClientID;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.Label label20;
    }
}