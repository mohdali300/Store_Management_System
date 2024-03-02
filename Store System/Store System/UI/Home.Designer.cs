namespace Store_System.UI
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            SideBarPanel = new Panel();
            ControlPanel = new Panel();
            addCategoryBtn = new Button();
            addSupplierBtn = new Button();
            addProduct = new Button();
            addUserBtn = new Button();
            controlMenuBtn = new Button();
            supplierCustomerPanel = new Panel();
            supPillsBtn = new Button();
            supplierBtn = new Button();
            customerBtn = new Button();
            supCustBtn = new Button();
            reportsPanel = new Panel();
            profitLossReportBtn = new Button();
            expensesReportBtn = new Button();
            buyingReportBtn = new Button();
            salesReportBtn = new Button();
            reportsMenuBtn = new Button();
            stockPanel = new Panel();
            shortageBtn = new Button();
            stocksBtn = new Button();
            stockMenuBtn = new Button();
            orderPanel = new Panel();
            completeShiftBtn = new Button();
            buyOrderBtn = new Button();
            saleOrderBtn = new Button();
            orderMenuBtn = new Button();
            sideButtonsTimer = new System.Windows.Forms.Timer(components);
            SideBarPanel.SuspendLayout();
            ControlPanel.SuspendLayout();
            supplierCustomerPanel.SuspendLayout();
            reportsPanel.SuspendLayout();
            stockPanel.SuspendLayout();
            orderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SideBarPanel
            // 
            SideBarPanel.BackColor = Color.Maroon;
            SideBarPanel.BorderStyle = BorderStyle.Fixed3D;
            SideBarPanel.Controls.Add(ControlPanel);
            SideBarPanel.Controls.Add(supplierCustomerPanel);
            SideBarPanel.Controls.Add(reportsPanel);
            SideBarPanel.Controls.Add(stockPanel);
            SideBarPanel.Controls.Add(orderPanel);
            SideBarPanel.Dock = DockStyle.Right;
            SideBarPanel.ForeColor = Color.Black;
            SideBarPanel.Location = new Point(962, 0);
            SideBarPanel.MaximumSize = new Size(264, 0);
            SideBarPanel.MinimumSize = new Size(264, 0);
            SideBarPanel.Name = "SideBarPanel";
            SideBarPanel.Size = new Size(264, 705);
            SideBarPanel.TabIndex = 0;
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = SystemColors.Control;
            ControlPanel.Controls.Add(addCategoryBtn);
            ControlPanel.Controls.Add(addSupplierBtn);
            ControlPanel.Controls.Add(addProduct);
            ControlPanel.Controls.Add(addUserBtn);
            ControlPanel.Controls.Add(controlMenuBtn);
            ControlPanel.Location = new Point(0, 194);
            ControlPanel.MaximumSize = new Size(264, 250);
            ControlPanel.MinimumSize = new Size(264, 50);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(264, 50);
            ControlPanel.TabIndex = 10;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.BackColor = Color.MistyRose;
            addCategoryBtn.FlatAppearance.BorderSize = 0;
            addCategoryBtn.FlatStyle = FlatStyle.Flat;
            addCategoryBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addCategoryBtn.ForeColor = Color.Maroon;
            addCategoryBtn.Location = new Point(0, 199);
            addCategoryBtn.MaximumSize = new Size(264, 50);
            addCategoryBtn.MinimumSize = new Size(264, 50);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Padding = new Padding(0, 0, 15, 5);
            addCategoryBtn.Size = new Size(264, 50);
            addCategoryBtn.TabIndex = 7;
            addCategoryBtn.Text = "إضافة وتعديل صنف";
            addCategoryBtn.TextAlign = ContentAlignment.MiddleRight;
            addCategoryBtn.UseVisualStyleBackColor = false;
            // 
            // addSupplierBtn
            // 
            addSupplierBtn.BackColor = Color.MistyRose;
            addSupplierBtn.FlatAppearance.BorderSize = 0;
            addSupplierBtn.FlatStyle = FlatStyle.Flat;
            addSupplierBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addSupplierBtn.ForeColor = Color.Maroon;
            addSupplierBtn.Location = new Point(0, 149);
            addSupplierBtn.MaximumSize = new Size(264, 50);
            addSupplierBtn.MinimumSize = new Size(264, 50);
            addSupplierBtn.Name = "addSupplierBtn";
            addSupplierBtn.Padding = new Padding(0, 0, 15, 5);
            addSupplierBtn.Size = new Size(264, 50);
            addSupplierBtn.TabIndex = 6;
            addSupplierBtn.Text = "إضافة وتعديل مورّد";
            addSupplierBtn.TextAlign = ContentAlignment.MiddleRight;
            addSupplierBtn.UseVisualStyleBackColor = false;
            // 
            // addProduct
            // 
            addProduct.BackColor = Color.MistyRose;
            addProduct.FlatAppearance.BorderSize = 0;
            addProduct.FlatStyle = FlatStyle.Flat;
            addProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProduct.ForeColor = Color.Maroon;
            addProduct.Location = new Point(0, 99);
            addProduct.MaximumSize = new Size(264, 50);
            addProduct.MinimumSize = new Size(264, 50);
            addProduct.Name = "addProduct";
            addProduct.Padding = new Padding(0, 0, 15, 5);
            addProduct.Size = new Size(264, 50);
            addProduct.TabIndex = 5;
            addProduct.Text = "إضافة وتعديل منتج";
            addProduct.TextAlign = ContentAlignment.MiddleRight;
            addProduct.UseVisualStyleBackColor = false;
            // 
            // addUserBtn
            // 
            addUserBtn.BackColor = Color.MistyRose;
            addUserBtn.FlatAppearance.BorderSize = 0;
            addUserBtn.FlatStyle = FlatStyle.Flat;
            addUserBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addUserBtn.ForeColor = Color.Maroon;
            addUserBtn.Location = new Point(0, 49);
            addUserBtn.MaximumSize = new Size(264, 50);
            addUserBtn.MinimumSize = new Size(264, 50);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Padding = new Padding(0, 0, 15, 5);
            addUserBtn.Size = new Size(264, 50);
            addUserBtn.TabIndex = 4;
            addUserBtn.Text = "إضافة وتعديل مستخدم";
            addUserBtn.TextAlign = ContentAlignment.MiddleRight;
            addUserBtn.UseVisualStyleBackColor = false;
            // 
            // controlMenuBtn
            // 
            controlMenuBtn.BackColor = Color.Maroon;
            controlMenuBtn.FlatAppearance.BorderSize = 0;
            controlMenuBtn.FlatStyle = FlatStyle.Flat;
            controlMenuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            controlMenuBtn.ForeColor = Color.Snow;
            controlMenuBtn.Location = new Point(0, 1);
            controlMenuBtn.MaximumSize = new Size(264, 50);
            controlMenuBtn.MinimumSize = new Size(264, 50);
            controlMenuBtn.Name = "controlMenuBtn";
            controlMenuBtn.Padding = new Padding(0, 0, 15, 5);
            controlMenuBtn.Size = new Size(264, 50);
            controlMenuBtn.TabIndex = 3;
            controlMenuBtn.Text = "التحكم";
            controlMenuBtn.TextAlign = ContentAlignment.MiddleRight;
            controlMenuBtn.UseVisualStyleBackColor = false;
            controlMenuBtn.Click += controlMenuBtn_Click;
            // 
            // supplierCustomerPanel
            // 
            supplierCustomerPanel.BackColor = SystemColors.Control;
            supplierCustomerPanel.Controls.Add(supPillsBtn);
            supplierCustomerPanel.Controls.Add(supplierBtn);
            supplierCustomerPanel.Controls.Add(customerBtn);
            supplierCustomerPanel.Controls.Add(supCustBtn);
            supplierCustomerPanel.Location = new Point(0, 146);
            supplierCustomerPanel.MaximumSize = new Size(264, 200);
            supplierCustomerPanel.MinimumSize = new Size(264, 50);
            supplierCustomerPanel.Name = "supplierCustomerPanel";
            supplierCustomerPanel.Size = new Size(264, 50);
            supplierCustomerPanel.TabIndex = 9;
            // 
            // supPillsBtn
            // 
            supPillsBtn.BackColor = Color.MistyRose;
            supPillsBtn.FlatAppearance.BorderSize = 0;
            supPillsBtn.FlatStyle = FlatStyle.Flat;
            supPillsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            supPillsBtn.ForeColor = Color.Maroon;
            supPillsBtn.Location = new Point(0, 149);
            supPillsBtn.MaximumSize = new Size(264, 50);
            supPillsBtn.MinimumSize = new Size(264, 50);
            supPillsBtn.Name = "supPillsBtn";
            supPillsBtn.Padding = new Padding(0, 0, 15, 5);
            supPillsBtn.Size = new Size(264, 50);
            supPillsBtn.TabIndex = 6;
            supPillsBtn.Text = "فواتير موردين";
            supPillsBtn.TextAlign = ContentAlignment.MiddleRight;
            supPillsBtn.UseVisualStyleBackColor = false;
            // 
            // supplierBtn
            // 
            supplierBtn.BackColor = Color.MistyRose;
            supplierBtn.FlatAppearance.BorderSize = 0;
            supplierBtn.FlatStyle = FlatStyle.Flat;
            supplierBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            supplierBtn.ForeColor = Color.Maroon;
            supplierBtn.Location = new Point(0, 99);
            supplierBtn.MaximumSize = new Size(264, 50);
            supplierBtn.MinimumSize = new Size(264, 50);
            supplierBtn.Name = "supplierBtn";
            supplierBtn.Padding = new Padding(0, 0, 15, 5);
            supplierBtn.Size = new Size(264, 50);
            supplierBtn.TabIndex = 5;
            supplierBtn.Text = "موردين";
            supplierBtn.TextAlign = ContentAlignment.MiddleRight;
            supplierBtn.UseVisualStyleBackColor = false;
            // 
            // customerBtn
            // 
            customerBtn.BackColor = Color.MistyRose;
            customerBtn.FlatAppearance.BorderSize = 0;
            customerBtn.FlatStyle = FlatStyle.Flat;
            customerBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customerBtn.ForeColor = Color.Maroon;
            customerBtn.Location = new Point(0, 49);
            customerBtn.MaximumSize = new Size(264, 50);
            customerBtn.MinimumSize = new Size(264, 50);
            customerBtn.Name = "customerBtn";
            customerBtn.Padding = new Padding(0, 0, 15, 5);
            customerBtn.Size = new Size(264, 50);
            customerBtn.TabIndex = 4;
            customerBtn.Text = "عملاء";
            customerBtn.TextAlign = ContentAlignment.MiddleRight;
            customerBtn.UseVisualStyleBackColor = false;
            // 
            // supCustBtn
            // 
            supCustBtn.BackColor = Color.Maroon;
            supCustBtn.FlatAppearance.BorderSize = 0;
            supCustBtn.FlatStyle = FlatStyle.Flat;
            supCustBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            supCustBtn.ForeColor = Color.Snow;
            supCustBtn.Location = new Point(0, 1);
            supCustBtn.MaximumSize = new Size(264, 50);
            supCustBtn.MinimumSize = new Size(264, 50);
            supCustBtn.Name = "supCustBtn";
            supCustBtn.Padding = new Padding(0, 0, 15, 5);
            supCustBtn.Size = new Size(264, 50);
            supCustBtn.TabIndex = 3;
            supCustBtn.Text = "عملاء وموردين";
            supCustBtn.TextAlign = ContentAlignment.MiddleRight;
            supCustBtn.UseVisualStyleBackColor = false;
            supCustBtn.Click += supCustBtn_Click;
            // 
            // reportsPanel
            // 
            reportsPanel.BackColor = SystemColors.Control;
            reportsPanel.Controls.Add(profitLossReportBtn);
            reportsPanel.Controls.Add(expensesReportBtn);
            reportsPanel.Controls.Add(buyingReportBtn);
            reportsPanel.Controls.Add(salesReportBtn);
            reportsPanel.Controls.Add(reportsMenuBtn);
            reportsPanel.Location = new Point(0, 97);
            reportsPanel.MaximumSize = new Size(264, 250);
            reportsPanel.MinimumSize = new Size(264, 50);
            reportsPanel.Name = "reportsPanel";
            reportsPanel.Size = new Size(264, 50);
            reportsPanel.TabIndex = 8;
            // 
            // profitLossReportBtn
            // 
            profitLossReportBtn.BackColor = Color.MistyRose;
            profitLossReportBtn.FlatAppearance.BorderSize = 0;
            profitLossReportBtn.FlatStyle = FlatStyle.Flat;
            profitLossReportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            profitLossReportBtn.ForeColor = Color.Maroon;
            profitLossReportBtn.Location = new Point(0, 199);
            profitLossReportBtn.MaximumSize = new Size(264, 50);
            profitLossReportBtn.MinimumSize = new Size(264, 50);
            profitLossReportBtn.Name = "profitLossReportBtn";
            profitLossReportBtn.Padding = new Padding(0, 0, 15, 5);
            profitLossReportBtn.Size = new Size(264, 50);
            profitLossReportBtn.TabIndex = 7;
            profitLossReportBtn.Text = "تقرير ربح وخسارة";
            profitLossReportBtn.TextAlign = ContentAlignment.MiddleRight;
            profitLossReportBtn.UseVisualStyleBackColor = false;
            // 
            // expensesReportBtn
            // 
            expensesReportBtn.BackColor = Color.MistyRose;
            expensesReportBtn.FlatAppearance.BorderSize = 0;
            expensesReportBtn.FlatStyle = FlatStyle.Flat;
            expensesReportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            expensesReportBtn.ForeColor = Color.Maroon;
            expensesReportBtn.Location = new Point(0, 149);
            expensesReportBtn.MaximumSize = new Size(264, 50);
            expensesReportBtn.MinimumSize = new Size(264, 50);
            expensesReportBtn.Name = "expensesReportBtn";
            expensesReportBtn.Padding = new Padding(0, 0, 15, 5);
            expensesReportBtn.Size = new Size(264, 50);
            expensesReportBtn.TabIndex = 6;
            expensesReportBtn.Text = "تقرير مصروفات";
            expensesReportBtn.TextAlign = ContentAlignment.MiddleRight;
            expensesReportBtn.UseVisualStyleBackColor = false;
            // 
            // buyingReportBtn
            // 
            buyingReportBtn.BackColor = Color.MistyRose;
            buyingReportBtn.FlatAppearance.BorderSize = 0;
            buyingReportBtn.FlatStyle = FlatStyle.Flat;
            buyingReportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buyingReportBtn.ForeColor = Color.Maroon;
            buyingReportBtn.Location = new Point(0, 99);
            buyingReportBtn.MaximumSize = new Size(264, 50);
            buyingReportBtn.MinimumSize = new Size(264, 50);
            buyingReportBtn.Name = "buyingReportBtn";
            buyingReportBtn.Padding = new Padding(0, 0, 15, 5);
            buyingReportBtn.Size = new Size(264, 50);
            buyingReportBtn.TabIndex = 5;
            buyingReportBtn.Text = "تقرير مشتريات";
            buyingReportBtn.TextAlign = ContentAlignment.MiddleRight;
            buyingReportBtn.UseVisualStyleBackColor = false;
            // 
            // salesReportBtn
            // 
            salesReportBtn.BackColor = Color.MistyRose;
            salesReportBtn.FlatAppearance.BorderSize = 0;
            salesReportBtn.FlatStyle = FlatStyle.Flat;
            salesReportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            salesReportBtn.ForeColor = Color.Maroon;
            salesReportBtn.Location = new Point(0, 49);
            salesReportBtn.MaximumSize = new Size(264, 50);
            salesReportBtn.MinimumSize = new Size(264, 50);
            salesReportBtn.Name = "salesReportBtn";
            salesReportBtn.Padding = new Padding(0, 0, 15, 5);
            salesReportBtn.Size = new Size(264, 50);
            salesReportBtn.TabIndex = 4;
            salesReportBtn.Text = "تقرير مبيعات";
            salesReportBtn.TextAlign = ContentAlignment.MiddleRight;
            salesReportBtn.UseVisualStyleBackColor = false;
            // 
            // reportsMenuBtn
            // 
            reportsMenuBtn.BackColor = Color.Maroon;
            reportsMenuBtn.FlatAppearance.BorderSize = 0;
            reportsMenuBtn.FlatStyle = FlatStyle.Flat;
            reportsMenuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reportsMenuBtn.ForeColor = Color.Snow;
            reportsMenuBtn.Location = new Point(0, 1);
            reportsMenuBtn.MaximumSize = new Size(264, 50);
            reportsMenuBtn.MinimumSize = new Size(264, 50);
            reportsMenuBtn.Name = "reportsMenuBtn";
            reportsMenuBtn.Padding = new Padding(0, 0, 15, 5);
            reportsMenuBtn.Size = new Size(264, 50);
            reportsMenuBtn.TabIndex = 3;
            reportsMenuBtn.Text = "تقارير";
            reportsMenuBtn.TextAlign = ContentAlignment.MiddleRight;
            reportsMenuBtn.UseVisualStyleBackColor = false;
            reportsMenuBtn.Click += reportsMenuBtn_Click;
            // 
            // stockPanel
            // 
            stockPanel.BackColor = SystemColors.Control;
            stockPanel.Controls.Add(shortageBtn);
            stockPanel.Controls.Add(stocksBtn);
            stockPanel.Controls.Add(stockMenuBtn);
            stockPanel.Location = new Point(0, 48);
            stockPanel.MaximumSize = new Size(264, 150);
            stockPanel.MinimumSize = new Size(264, 50);
            stockPanel.Name = "stockPanel";
            stockPanel.Size = new Size(264, 50);
            stockPanel.TabIndex = 7;
            // 
            // shortageBtn
            // 
            shortageBtn.BackColor = Color.MistyRose;
            shortageBtn.FlatAppearance.BorderSize = 0;
            shortageBtn.FlatStyle = FlatStyle.Flat;
            shortageBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            shortageBtn.ForeColor = Color.Maroon;
            shortageBtn.Location = new Point(0, 99);
            shortageBtn.MaximumSize = new Size(264, 50);
            shortageBtn.MinimumSize = new Size(264, 50);
            shortageBtn.Name = "shortageBtn";
            shortageBtn.Padding = new Padding(0, 0, 15, 5);
            shortageBtn.Size = new Size(264, 50);
            shortageBtn.TabIndex = 5;
            shortageBtn.Text = "النواقص";
            shortageBtn.TextAlign = ContentAlignment.MiddleRight;
            shortageBtn.UseVisualStyleBackColor = false;
            // 
            // stocksBtn
            // 
            stocksBtn.BackColor = Color.MistyRose;
            stocksBtn.FlatAppearance.BorderSize = 0;
            stocksBtn.FlatStyle = FlatStyle.Flat;
            stocksBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stocksBtn.ForeColor = Color.Maroon;
            stocksBtn.Location = new Point(0, 49);
            stocksBtn.MaximumSize = new Size(264, 50);
            stocksBtn.MinimumSize = new Size(264, 50);
            stocksBtn.Name = "stocksBtn";
            stocksBtn.Padding = new Padding(0, 0, 15, 5);
            stocksBtn.Size = new Size(264, 50);
            stocksBtn.TabIndex = 4;
            stocksBtn.Text = "المخازن";
            stocksBtn.TextAlign = ContentAlignment.MiddleRight;
            stocksBtn.UseVisualStyleBackColor = false;
            // 
            // stockMenuBtn
            // 
            stockMenuBtn.BackColor = Color.Maroon;
            stockMenuBtn.FlatAppearance.BorderSize = 0;
            stockMenuBtn.FlatStyle = FlatStyle.Flat;
            stockMenuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stockMenuBtn.ForeColor = Color.Snow;
            stockMenuBtn.Location = new Point(0, 1);
            stockMenuBtn.MaximumSize = new Size(264, 50);
            stockMenuBtn.MinimumSize = new Size(264, 50);
            stockMenuBtn.Name = "stockMenuBtn";
            stockMenuBtn.Padding = new Padding(0, 0, 15, 5);
            stockMenuBtn.Size = new Size(264, 50);
            stockMenuBtn.TabIndex = 3;
            stockMenuBtn.Text = "المخزن";
            stockMenuBtn.TextAlign = ContentAlignment.MiddleRight;
            stockMenuBtn.UseVisualStyleBackColor = false;
            stockMenuBtn.Click += stockMenuBtn_Click;
            // 
            // orderPanel
            // 
            orderPanel.Controls.Add(completeShiftBtn);
            orderPanel.Controls.Add(buyOrderBtn);
            orderPanel.Controls.Add(saleOrderBtn);
            orderPanel.Controls.Add(orderMenuBtn);
            orderPanel.Location = new Point(0, -1);
            orderPanel.MaximumSize = new Size(264, 200);
            orderPanel.MinimumSize = new Size(264, 50);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(264, 50);
            orderPanel.TabIndex = 2;
            // 
            // completeShiftBtn
            // 
            completeShiftBtn.BackColor = Color.MistyRose;
            completeShiftBtn.FlatAppearance.BorderSize = 0;
            completeShiftBtn.FlatStyle = FlatStyle.Flat;
            completeShiftBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            completeShiftBtn.ForeColor = Color.Maroon;
            completeShiftBtn.Location = new Point(0, 149);
            completeShiftBtn.MaximumSize = new Size(264, 50);
            completeShiftBtn.MinimumSize = new Size(264, 50);
            completeShiftBtn.Name = "completeShiftBtn";
            completeShiftBtn.Padding = new Padding(0, 0, 15, 5);
            completeShiftBtn.Size = new Size(264, 50);
            completeShiftBtn.TabIndex = 6;
            completeShiftBtn.Text = "تقفيل شيفت";
            completeShiftBtn.TextAlign = ContentAlignment.MiddleRight;
            completeShiftBtn.UseVisualStyleBackColor = false;
            // 
            // buyOrderBtn
            // 
            buyOrderBtn.BackColor = Color.MistyRose;
            buyOrderBtn.FlatAppearance.BorderSize = 0;
            buyOrderBtn.FlatStyle = FlatStyle.Flat;
            buyOrderBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buyOrderBtn.ForeColor = Color.Maroon;
            buyOrderBtn.Location = new Point(0, 99);
            buyOrderBtn.MaximumSize = new Size(264, 50);
            buyOrderBtn.MinimumSize = new Size(264, 50);
            buyOrderBtn.Name = "buyOrderBtn";
            buyOrderBtn.Padding = new Padding(0, 0, 15, 5);
            buyOrderBtn.Size = new Size(264, 50);
            buyOrderBtn.TabIndex = 5;
            buyOrderBtn.Text = "فاتورة شراء جديدة";
            buyOrderBtn.TextAlign = ContentAlignment.MiddleRight;
            buyOrderBtn.UseVisualStyleBackColor = false;
            // 
            // saleOrderBtn
            // 
            saleOrderBtn.BackColor = Color.MistyRose;
            saleOrderBtn.FlatAppearance.BorderSize = 0;
            saleOrderBtn.FlatStyle = FlatStyle.Flat;
            saleOrderBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saleOrderBtn.ForeColor = Color.Maroon;
            saleOrderBtn.Location = new Point(0, 49);
            saleOrderBtn.MaximumSize = new Size(264, 50);
            saleOrderBtn.MinimumSize = new Size(264, 50);
            saleOrderBtn.Name = "saleOrderBtn";
            saleOrderBtn.Padding = new Padding(0, 0, 15, 5);
            saleOrderBtn.Size = new Size(264, 50);
            saleOrderBtn.TabIndex = 4;
            saleOrderBtn.Text = "فاتورة بيع جديدة";
            saleOrderBtn.TextAlign = ContentAlignment.MiddleRight;
            saleOrderBtn.UseVisualStyleBackColor = false;
            // 
            // orderMenuBtn
            // 
            orderMenuBtn.BackColor = Color.Maroon;
            orderMenuBtn.FlatAppearance.BorderSize = 0;
            orderMenuBtn.FlatStyle = FlatStyle.Flat;
            orderMenuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderMenuBtn.ForeColor = Color.Snow;
            orderMenuBtn.Location = new Point(0, 1);
            orderMenuBtn.MaximumSize = new Size(264, 50);
            orderMenuBtn.MinimumSize = new Size(264, 50);
            orderMenuBtn.Name = "orderMenuBtn";
            orderMenuBtn.Padding = new Padding(0, 0, 15, 5);
            orderMenuBtn.Size = new Size(264, 50);
            orderMenuBtn.TabIndex = 3;
            orderMenuBtn.Text = "بيع وشراء";
            orderMenuBtn.TextAlign = ContentAlignment.MiddleRight;
            orderMenuBtn.UseVisualStyleBackColor = false;
            orderMenuBtn.Click += orderMenuBtn_Click;
            // 
            // sideButtonsTimer
            // 
            sideButtonsTimer.Interval = 1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1226, 705);
            Controls.Add(SideBarPanel);
            MinimumSize = new Size(1244, 752);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            SideBarPanel.ResumeLayout(false);
            ControlPanel.ResumeLayout(false);
            supplierCustomerPanel.ResumeLayout(false);
            reportsPanel.ResumeLayout(false);
            stockPanel.ResumeLayout(false);
            orderPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel SideBarPanel;
        private Panel orderPanel;
        private Button completeShiftBtn;
        private Button buyOrderBtn;
        private Button saleOrderBtn;
        private Button orderMenuBtn;
        private System.Windows.Forms.Timer sideButtonsTimer;
        private Panel stockPanel;
        private Button shortageBtn;
        private Button stocksBtn;
        private Button stockMenuBtn;
        private Panel reportsPanel;
        private Button profitLossReportBtn;
        private Button expensesReportBtn;
        private Button buyingReportBtn;
        private Button salesReportBtn;
        private Button reportsMenuBtn;
        private Panel supplierCustomerPanel;
        private Button supPillsBtn;
        private Button supplierBtn;
        private Button customerBtn;
        private Button supCustBtn;
        private Panel ControlPanel;
        private Button addCategoryBtn;
        private Button addSupplierBtn;
        private Button addProduct;
        private Button addUserBtn;
        private Button controlMenuBtn;
    }
}