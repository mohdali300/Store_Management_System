namespace Store_System.UI
{
    partial class AddProductPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductPage));
            barCodeLbl = new Label();
            productsBtn = new Button();
            barCodeBox = new TextBox();
            suppliersBtn = new Button();
            addProductPanel = new Panel();
            saveProductBtn = new Button();
            notesLbl = new Label();
            noteBox = new TextBox();
            stockLbl = new Label();
            stockBox = new TextBox();
            toDateLbl = new Label();
            toDateBox = new DateTimePicker();
            fromDateLbl = new Label();
            fromDateBox = new DateTimePicker();
            discountLbl = new Label();
            discountBox = new TextBox();
            sellingPriceLbl = new Label();
            costLbl = new Label();
            sellingPriceBox = new TextBox();
            costBox = new TextBox();
            supplierLbl = new Label();
            SupplierComboBox = new ComboBox();
            categoryLbl = new Label();
            CatComboBox = new ComboBox();
            pNameLbl = new Label();
            productNameBox = new TextBox();
            addSupplierPanel = new Panel();
            saveSupplierBtn = new Button();
            contractDateLbl = new Label();
            contractDateBox = new DateTimePicker();
            supCodeLbl = new Label();
            supNameLbl = new Label();
            supPhoneLbl = new Label();
            supMailLbl = new Label();
            supMailBox = new TextBox();
            supCodeBox = new TextBox();
            supAddressLbl = new Label();
            supNameBox = new TextBox();
            supAddressBox = new TextBox();
            supPhoneBox = new TextBox();
            dataGridView1 = new DataGridView();
            existProductsLbl = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            existSupsLbl = new Label();
            productGridViewPanel = new Panel();
            addProductPanel.SuspendLayout();
            addSupplierPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            productGridViewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // barCodeLbl
            // 
            barCodeLbl.Anchor = AnchorStyles.None;
            barCodeLbl.AutoSize = true;
            barCodeLbl.BackColor = Color.Snow;
            barCodeLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            barCodeLbl.ForeColor = Color.Maroon;
            barCodeLbl.Location = new Point(1115, 47);
            barCodeLbl.Name = "barCodeLbl";
            barCodeLbl.Padding = new Padding(0, 0, 0, 5);
            barCodeLbl.RightToLeft = RightToLeft.Yes;
            barCodeLbl.Size = new Size(63, 28);
            barCodeLbl.TabIndex = 14;
            barCodeLbl.Text = "الباركود";
            // 
            // productsBtn
            // 
            productsBtn.Anchor = AnchorStyles.None;
            productsBtn.BackColor = Color.Maroon;
            productsBtn.BackgroundImageLayout = ImageLayout.Zoom;
            productsBtn.FlatStyle = FlatStyle.Flat;
            productsBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            productsBtn.ForeColor = Color.Snow;
            productsBtn.ImageAlign = ContentAlignment.MiddleRight;
            productsBtn.Location = new Point(641, 59);
            productsBtn.Name = "productsBtn";
            productsBtn.RightToLeft = RightToLeft.Yes;
            productsBtn.Size = new Size(546, 66);
            productsBtn.TabIndex = 15;
            productsBtn.Text = "المنتجات";
            productsBtn.UseVisualStyleBackColor = false;
            productsBtn.Click += productsBtn_Click;
            // 
            // barCodeBox
            // 
            barCodeBox.Anchor = AnchorStyles.None;
            barCodeBox.BackColor = Color.Snow;
            barCodeBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            barCodeBox.Location = new Point(945, 68);
            barCodeBox.Name = "barCodeBox";
            barCodeBox.Size = new Size(242, 38);
            barCodeBox.TabIndex = 16;
            // 
            // suppliersBtn
            // 
            suppliersBtn.Anchor = AnchorStyles.None;
            suppliersBtn.BackColor = Color.Maroon;
            suppliersBtn.FlatStyle = FlatStyle.Flat;
            suppliersBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            suppliersBtn.ForeColor = Color.Snow;
            suppliersBtn.Location = new Point(69, 59);
            suppliersBtn.Name = "suppliersBtn";
            suppliersBtn.RightToLeft = RightToLeft.Yes;
            suppliersBtn.Size = new Size(531, 66);
            suppliersBtn.TabIndex = 18;
            suppliersBtn.Text = "الموردين";
            suppliersBtn.UseVisualStyleBackColor = false;
            suppliersBtn.Click += suppliersBtn_Click;
            // 
            // addProductPanel
            // 
            addProductPanel.Anchor = AnchorStyles.None;
            addProductPanel.BackColor = Color.Snow;
            addProductPanel.Controls.Add(saveProductBtn);
            addProductPanel.Controls.Add(notesLbl);
            addProductPanel.Controls.Add(noteBox);
            addProductPanel.Controls.Add(stockLbl);
            addProductPanel.Controls.Add(stockBox);
            addProductPanel.Controls.Add(toDateLbl);
            addProductPanel.Controls.Add(toDateBox);
            addProductPanel.Controls.Add(fromDateLbl);
            addProductPanel.Controls.Add(fromDateBox);
            addProductPanel.Controls.Add(discountLbl);
            addProductPanel.Controls.Add(discountBox);
            addProductPanel.Controls.Add(sellingPriceLbl);
            addProductPanel.Controls.Add(costLbl);
            addProductPanel.Controls.Add(sellingPriceBox);
            addProductPanel.Controls.Add(costBox);
            addProductPanel.Controls.Add(supplierLbl);
            addProductPanel.Controls.Add(SupplierComboBox);
            addProductPanel.Controls.Add(categoryLbl);
            addProductPanel.Controls.Add(CatComboBox);
            addProductPanel.Controls.Add(pNameLbl);
            addProductPanel.Controls.Add(productNameBox);
            addProductPanel.Controls.Add(barCodeLbl);
            addProductPanel.Controls.Add(barCodeBox);
            addProductPanel.Location = new Point(3, 131);
            addProductPanel.MinimumSize = new Size(1238, 263);
            addProductPanel.Name = "addProductPanel";
            addProductPanel.Size = new Size(1238, 324);
            addProductPanel.TabIndex = 19;
            // 
            // saveProductBtn
            // 
            saveProductBtn.Anchor = AnchorStyles.None;
            saveProductBtn.BackColor = Color.Green;
            saveProductBtn.FlatStyle = FlatStyle.Popup;
            saveProductBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            saveProductBtn.ForeColor = Color.Snow;
            saveProductBtn.Location = new Point(69, 232);
            saveProductBtn.Name = "saveProductBtn";
            saveProductBtn.RightToLeft = RightToLeft.Yes;
            saveProductBtn.Size = new Size(231, 47);
            saveProductBtn.TabIndex = 21;
            saveProductBtn.Text = "حفظ";
            saveProductBtn.UseVisualStyleBackColor = false;
            // 
            // notesLbl
            // 
            notesLbl.Anchor = AnchorStyles.None;
            notesLbl.AutoSize = true;
            notesLbl.BackColor = Color.Snow;
            notesLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            notesLbl.ForeColor = Color.Maroon;
            notesLbl.Location = new Point(212, 133);
            notesLbl.Name = "notesLbl";
            notesLbl.Padding = new Padding(0, 0, 0, 5);
            notesLbl.RightToLeft = RightToLeft.Yes;
            notesLbl.Size = new Size(74, 28);
            notesLbl.TabIndex = 35;
            notesLbl.Text = "ملاحظات";
            // 
            // noteBox
            // 
            noteBox.Anchor = AnchorStyles.None;
            noteBox.BackColor = Color.Snow;
            noteBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            noteBox.Location = new Point(69, 156);
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(231, 38);
            noteBox.TabIndex = 36;
            // 
            // stockLbl
            // 
            stockLbl.Anchor = AnchorStyles.None;
            stockLbl.AutoSize = true;
            stockLbl.BackColor = Color.Snow;
            stockLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            stockLbl.ForeColor = Color.Maroon;
            stockLbl.Location = new Point(510, 133);
            stockLbl.Name = "stockLbl";
            stockLbl.Padding = new Padding(0, 0, 0, 5);
            stockLbl.RightToLeft = RightToLeft.Yes;
            stockLbl.Size = new Size(54, 28);
            stockLbl.TabIndex = 33;
            stockLbl.Text = "الكمية";
            // 
            // stockBox
            // 
            stockBox.Anchor = AnchorStyles.None;
            stockBox.BackColor = Color.Snow;
            stockBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            stockBox.Location = new Point(363, 156);
            stockBox.Name = "stockBox";
            stockBox.Size = new Size(210, 38);
            stockBox.TabIndex = 34;
            // 
            // toDateLbl
            // 
            toDateLbl.Anchor = AnchorStyles.None;
            toDateLbl.AutoSize = true;
            toDateLbl.BackColor = Color.Snow;
            toDateLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            toDateLbl.ForeColor = Color.Maroon;
            toDateLbl.Location = new Point(519, 216);
            toDateLbl.Name = "toDateLbl";
            toDateLbl.Padding = new Padding(0, 0, 0, 5);
            toDateLbl.RightToLeft = RightToLeft.Yes;
            toDateLbl.Size = new Size(44, 28);
            toDateLbl.TabIndex = 32;
            toDateLbl.Text = "إلى :";
            // 
            // toDateBox
            // 
            toDateBox.Anchor = AnchorStyles.None;
            toDateBox.CalendarMonthBackground = Color.Snow;
            toDateBox.CalendarTitleBackColor = Color.Snow;
            toDateBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            toDateBox.Format = DateTimePickerFormat.Short;
            toDateBox.Location = new Point(363, 241);
            toDateBox.Name = "toDateBox";
            toDateBox.RightToLeft = RightToLeft.Yes;
            toDateBox.Size = new Size(210, 38);
            toDateBox.TabIndex = 31;
            // 
            // fromDateLbl
            // 
            fromDateLbl.Anchor = AnchorStyles.None;
            fromDateLbl.AutoSize = true;
            fromDateLbl.BackColor = Color.Snow;
            fromDateLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            fromDateLbl.ForeColor = Color.Maroon;
            fromDateLbl.Location = new Point(744, 220);
            fromDateLbl.Name = "fromDateLbl";
            fromDateLbl.Padding = new Padding(0, 0, 0, 5);
            fromDateLbl.RightToLeft = RightToLeft.Yes;
            fromDateLbl.Size = new Size(128, 28);
            fromDateLbl.TabIndex = 30;
            fromDateLbl.Text = "فترة الخصم من :";
            // 
            // fromDateBox
            // 
            fromDateBox.Anchor = AnchorStyles.None;
            fromDateBox.CalendarMonthBackground = Color.Snow;
            fromDateBox.CalendarTitleBackColor = Color.Snow;
            fromDateBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            fromDateBox.Format = DateTimePickerFormat.Short;
            fromDateBox.Location = new Point(638, 244);
            fromDateBox.Name = "fromDateBox";
            fromDateBox.RightToLeft = RightToLeft.Yes;
            fromDateBox.Size = new Size(242, 38);
            fromDateBox.TabIndex = 29;
            // 
            // discountLbl
            // 
            discountLbl.Anchor = AnchorStyles.None;
            discountLbl.AutoSize = true;
            discountLbl.BackColor = Color.Snow;
            discountLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            discountLbl.ForeColor = Color.Maroon;
            discountLbl.Location = new Point(1084, 222);
            discountLbl.Name = "discountLbl";
            discountLbl.Padding = new Padding(0, 0, 0, 5);
            discountLbl.RightToLeft = RightToLeft.Yes;
            discountLbl.Size = new Size(97, 28);
            discountLbl.TabIndex = 27;
            discountLbl.Text = "نسبة الخصم";
            // 
            // discountBox
            // 
            discountBox.Anchor = AnchorStyles.None;
            discountBox.BackColor = Color.Snow;
            discountBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            discountBox.Location = new Point(948, 244);
            discountBox.Name = "discountBox";
            discountBox.Size = new Size(236, 38);
            discountBox.TabIndex = 28;
            // 
            // sellingPriceLbl
            // 
            sellingPriceLbl.Anchor = AnchorStyles.None;
            sellingPriceLbl.AutoSize = true;
            sellingPriceLbl.BackColor = Color.Snow;
            sellingPriceLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            sellingPriceLbl.ForeColor = Color.Maroon;
            sellingPriceLbl.Location = new Point(792, 133);
            sellingPriceLbl.Name = "sellingPriceLbl";
            sellingPriceLbl.Padding = new Padding(0, 0, 0, 5);
            sellingPriceLbl.RightToLeft = RightToLeft.Yes;
            sellingPriceLbl.Size = new Size(78, 28);
            sellingPriceLbl.TabIndex = 23;
            sellingPriceLbl.Text = "سعر البيع";
            // 
            // costLbl
            // 
            costLbl.Anchor = AnchorStyles.None;
            costLbl.AutoSize = true;
            costLbl.BackColor = Color.Snow;
            costLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            costLbl.ForeColor = Color.Maroon;
            costLbl.Location = new Point(1095, 135);
            costLbl.Name = "costLbl";
            costLbl.Padding = new Padding(0, 0, 0, 5);
            costLbl.RightToLeft = RightToLeft.Yes;
            costLbl.Size = new Size(86, 28);
            costLbl.TabIndex = 25;
            costLbl.Text = "سعر الشراء";
            // 
            // sellingPriceBox
            // 
            sellingPriceBox.Anchor = AnchorStyles.None;
            sellingPriceBox.BackColor = Color.Snow;
            sellingPriceBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            sellingPriceBox.Location = new Point(638, 156);
            sellingPriceBox.Name = "sellingPriceBox";
            sellingPriceBox.Size = new Size(242, 38);
            sellingPriceBox.TabIndex = 26;
            // 
            // costBox
            // 
            costBox.Anchor = AnchorStyles.None;
            costBox.BackColor = Color.Snow;
            costBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            costBox.Location = new Point(945, 156);
            costBox.Name = "costBox";
            costBox.Size = new Size(239, 38);
            costBox.TabIndex = 24;
            // 
            // supplierLbl
            // 
            supplierLbl.Anchor = AnchorStyles.None;
            supplierLbl.AutoSize = true;
            supplierLbl.BackColor = Color.Snow;
            supplierLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            supplierLbl.ForeColor = Color.Maroon;
            supplierLbl.Location = new Point(232, 46);
            supplierLbl.Name = "supplierLbl";
            supplierLbl.Padding = new Padding(0, 0, 0, 5);
            supplierLbl.RightToLeft = RightToLeft.Yes;
            supplierLbl.Size = new Size(54, 28);
            supplierLbl.TabIndex = 22;
            supplierLbl.Text = "المورد";
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.Anchor = AnchorStyles.None;
            SupplierComboBox.BackColor = Color.Snow;
            SupplierComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Location = new Point(69, 68);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.RightToLeft = RightToLeft.Yes;
            SupplierComboBox.Size = new Size(231, 39);
            SupplierComboBox.TabIndex = 21;
            // 
            // categoryLbl
            // 
            categoryLbl.Anchor = AnchorStyles.None;
            categoryLbl.AutoSize = true;
            categoryLbl.BackColor = Color.Snow;
            categoryLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            categoryLbl.ForeColor = Color.Maroon;
            categoryLbl.Location = new Point(503, 47);
            categoryLbl.Name = "categoryLbl";
            categoryLbl.Padding = new Padding(0, 0, 0, 5);
            categoryLbl.RightToLeft = RightToLeft.Yes;
            categoryLbl.Size = new Size(60, 28);
            categoryLbl.TabIndex = 20;
            categoryLbl.Text = "الصنف";
            // 
            // CatComboBox
            // 
            CatComboBox.Anchor = AnchorStyles.None;
            CatComboBox.BackColor = Color.Snow;
            CatComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CatComboBox.FormattingEnabled = true;
            CatComboBox.Location = new Point(363, 68);
            CatComboBox.Name = "CatComboBox";
            CatComboBox.RightToLeft = RightToLeft.Yes;
            CatComboBox.Size = new Size(216, 39);
            CatComboBox.TabIndex = 19;
            // 
            // pNameLbl
            // 
            pNameLbl.Anchor = AnchorStyles.None;
            pNameLbl.AutoSize = true;
            pNameLbl.BackColor = Color.Snow;
            pNameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            pNameLbl.ForeColor = Color.Maroon;
            pNameLbl.Location = new Point(787, 44);
            pNameLbl.Name = "pNameLbl";
            pNameLbl.Padding = new Padding(0, 0, 0, 5);
            pNameLbl.RightToLeft = RightToLeft.Yes;
            pNameLbl.Size = new Size(85, 28);
            pNameLbl.TabIndex = 17;
            pNameLbl.Text = "اسم المنتج";
            // 
            // productNameBox
            // 
            productNameBox.Anchor = AnchorStyles.None;
            productNameBox.BackColor = Color.Snow;
            productNameBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            productNameBox.Location = new Point(638, 67);
            productNameBox.Name = "productNameBox";
            productNameBox.Size = new Size(242, 38);
            productNameBox.TabIndex = 18;
            // 
            // addSupplierPanel
            // 
            addSupplierPanel.Anchor = AnchorStyles.None;
            addSupplierPanel.Controls.Add(saveSupplierBtn);
            addSupplierPanel.Controls.Add(contractDateLbl);
            addSupplierPanel.Controls.Add(contractDateBox);
            addSupplierPanel.Controls.Add(supCodeLbl);
            addSupplierPanel.Controls.Add(supNameLbl);
            addSupplierPanel.Controls.Add(supPhoneLbl);
            addSupplierPanel.Controls.Add(supMailLbl);
            addSupplierPanel.Controls.Add(supMailBox);
            addSupplierPanel.Controls.Add(supCodeBox);
            addSupplierPanel.Controls.Add(supAddressLbl);
            addSupplierPanel.Controls.Add(supNameBox);
            addSupplierPanel.Controls.Add(supAddressBox);
            addSupplierPanel.Controls.Add(supPhoneBox);
            addSupplierPanel.Location = new Point(3, 135);
            addSupplierPanel.MinimumSize = new Size(1238, 263);
            addSupplierPanel.Name = "addSupplierPanel";
            addSupplierPanel.RightToLeft = RightToLeft.Yes;
            addSupplierPanel.Size = new Size(1238, 263);
            addSupplierPanel.TabIndex = 20;
            // 
            // saveSupplierBtn
            // 
            saveSupplierBtn.Anchor = AnchorStyles.None;
            saveSupplierBtn.BackColor = Color.Green;
            saveSupplierBtn.FlatStyle = FlatStyle.Popup;
            saveSupplierBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            saveSupplierBtn.ForeColor = Color.Snow;
            saveSupplierBtn.Location = new Point(69, 95);
            saveSupplierBtn.Name = "saveSupplierBtn";
            saveSupplierBtn.RightToLeft = RightToLeft.Yes;
            saveSupplierBtn.Size = new Size(231, 60);
            saveSupplierBtn.TabIndex = 37;
            saveSupplierBtn.Text = "حفظ";
            saveSupplierBtn.UseVisualStyleBackColor = false;
            // 
            // contractDateLbl
            // 
            contractDateLbl.Anchor = AnchorStyles.None;
            contractDateLbl.AutoSize = true;
            contractDateLbl.BackColor = Color.Snow;
            contractDateLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            contractDateLbl.ForeColor = Color.Maroon;
            contractDateLbl.Location = new Point(1084, 129);
            contractDateLbl.Name = "contractDateLbl";
            contractDateLbl.Padding = new Padding(0, 0, 0, 5);
            contractDateLbl.RightToLeft = RightToLeft.Yes;
            contractDateLbl.Size = new Size(97, 28);
            contractDateLbl.TabIndex = 45;
            contractDateLbl.Text = "تاريخ التعاقد";
            // 
            // contractDateBox
            // 
            contractDateBox.Anchor = AnchorStyles.None;
            contractDateBox.CalendarMonthBackground = Color.Snow;
            contractDateBox.CalendarTitleBackColor = Color.Snow;
            contractDateBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            contractDateBox.Format = DateTimePickerFormat.Short;
            contractDateBox.Location = new Point(945, 150);
            contractDateBox.Name = "contractDateBox";
            contractDateBox.RightToLeft = RightToLeft.Yes;
            contractDateBox.Size = new Size(245, 38);
            contractDateBox.TabIndex = 37;
            // 
            // supCodeLbl
            // 
            supCodeLbl.Anchor = AnchorStyles.None;
            supCodeLbl.AutoSize = true;
            supCodeLbl.BackColor = Color.Snow;
            supCodeLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            supCodeLbl.ForeColor = Color.Maroon;
            supCodeLbl.Location = new Point(1093, 42);
            supCodeLbl.Name = "supCodeLbl";
            supCodeLbl.Padding = new Padding(0, 0, 0, 5);
            supCodeLbl.RightToLeft = RightToLeft.Yes;
            supCodeLbl.Size = new Size(86, 28);
            supCodeLbl.TabIndex = 37;
            supCodeLbl.Text = "كود المورد";
            // 
            // supNameLbl
            // 
            supNameLbl.Anchor = AnchorStyles.None;
            supNameLbl.AutoSize = true;
            supNameLbl.BackColor = Color.Snow;
            supNameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            supNameLbl.ForeColor = Color.Maroon;
            supNameLbl.Location = new Point(790, 42);
            supNameLbl.Name = "supNameLbl";
            supNameLbl.Padding = new Padding(0, 0, 0, 5);
            supNameLbl.RightToLeft = RightToLeft.Yes;
            supNameLbl.Size = new Size(87, 28);
            supNameLbl.TabIndex = 39;
            supNameLbl.Text = "اسم المورد";
            // 
            // supPhoneLbl
            // 
            supPhoneLbl.Anchor = AnchorStyles.None;
            supPhoneLbl.AutoSize = true;
            supPhoneLbl.BackColor = Color.Snow;
            supPhoneLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            supPhoneLbl.ForeColor = Color.Maroon;
            supPhoneLbl.Location = new Point(483, 42);
            supPhoneLbl.Name = "supPhoneLbl";
            supPhoneLbl.Padding = new Padding(0, 0, 0, 5);
            supPhoneLbl.RightToLeft = RightToLeft.Yes;
            supPhoneLbl.Size = new Size(86, 28);
            supPhoneLbl.TabIndex = 42;
            supPhoneLbl.Text = "رقم الهاتف";
            // 
            // supMailLbl
            // 
            supMailLbl.Anchor = AnchorStyles.None;
            supMailLbl.AutoSize = true;
            supMailLbl.BackColor = Color.Snow;
            supMailLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            supMailLbl.ForeColor = Color.Maroon;
            supMailLbl.Location = new Point(523, 127);
            supMailLbl.Name = "supMailLbl";
            supMailLbl.Padding = new Padding(0, 0, 0, 5);
            supMailLbl.RightToLeft = RightToLeft.Yes;
            supMailLbl.Size = new Size(47, 28);
            supMailLbl.TabIndex = 47;
            supMailLbl.Text = "ايميل";
            // 
            // supMailBox
            // 
            supMailBox.Anchor = AnchorStyles.None;
            supMailBox.BackColor = Color.Snow;
            supMailBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            supMailBox.Location = new Point(337, 150);
            supMailBox.Name = "supMailBox";
            supMailBox.Size = new Size(242, 38);
            supMailBox.TabIndex = 48;
            // 
            // supCodeBox
            // 
            supCodeBox.Anchor = AnchorStyles.None;
            supCodeBox.BackColor = Color.Snow;
            supCodeBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            supCodeBox.Location = new Point(947, 62);
            supCodeBox.Name = "supCodeBox";
            supCodeBox.Size = new Size(243, 38);
            supCodeBox.TabIndex = 38;
            // 
            // supAddressLbl
            // 
            supAddressLbl.Anchor = AnchorStyles.None;
            supAddressLbl.AutoSize = true;
            supAddressLbl.BackColor = Color.Snow;
            supAddressLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            supAddressLbl.ForeColor = Color.Maroon;
            supAddressLbl.Location = new Point(816, 129);
            supAddressLbl.Name = "supAddressLbl";
            supAddressLbl.Padding = new Padding(0, 0, 0, 5);
            supAddressLbl.RightToLeft = RightToLeft.Yes;
            supAddressLbl.Size = new Size(60, 28);
            supAddressLbl.TabIndex = 43;
            supAddressLbl.Text = "العنوان";
            // 
            // supNameBox
            // 
            supNameBox.Anchor = AnchorStyles.None;
            supNameBox.BackColor = Color.Snow;
            supNameBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            supNameBox.Location = new Point(642, 62);
            supNameBox.Name = "supNameBox";
            supNameBox.Size = new Size(242, 38);
            supNameBox.TabIndex = 40;
            // 
            // supAddressBox
            // 
            supAddressBox.Anchor = AnchorStyles.None;
            supAddressBox.BackColor = Color.Snow;
            supAddressBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            supAddressBox.Location = new Point(643, 150);
            supAddressBox.Name = "supAddressBox";
            supAddressBox.Size = new Size(242, 38);
            supAddressBox.TabIndex = 46;
            // 
            // supPhoneBox
            // 
            supPhoneBox.Anchor = AnchorStyles.None;
            supPhoneBox.BackColor = Color.Snow;
            supPhoneBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            supPhoneBox.Location = new Point(337, 62);
            supPhoneBox.Name = "supPhoneBox";
            supPhoneBox.Size = new Size(242, 38);
            supPhoneBox.TabIndex = 49;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1244, 403);
            dataGridView1.TabIndex = 21;
            // 
            // existProductsLbl
            // 
            existProductsLbl.Anchor = AnchorStyles.None;
            existProductsLbl.AutoSize = true;
            existProductsLbl.BackColor = Color.Snow;
            existProductsLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            existProductsLbl.ForeColor = Color.Maroon;
            existProductsLbl.Location = new Point(952, 23);
            existProductsLbl.Name = "existProductsLbl";
            existProductsLbl.Padding = new Padding(0, 0, 0, 5);
            existProductsLbl.RightToLeft = RightToLeft.Yes;
            existProductsLbl.Size = new Size(228, 43);
            existProductsLbl.TabIndex = 50;
            existProductsLbl.Text = "المنتجات الموجودة";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 61);
            panel1.TabIndex = 51;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(271, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.Snow;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(22, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 38);
            textBox1.TabIndex = 50;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(323, 18);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 5);
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(167, 28);
            label1.TabIndex = 50;
            label1.Text = "ابحث عن المراد تعديله";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1183, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // existSupsLbl
            // 
            existSupsLbl.Anchor = AnchorStyles.None;
            existSupsLbl.AutoSize = true;
            existSupsLbl.BackColor = Color.Snow;
            existSupsLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            existSupsLbl.ForeColor = Color.Maroon;
            existSupsLbl.Location = new Point(936, 23);
            existSupsLbl.Name = "existSupsLbl";
            existSupsLbl.Padding = new Padding(0, 0, 0, 5);
            existSupsLbl.RightToLeft = RightToLeft.Yes;
            existSupsLbl.Size = new Size(241, 43);
            existSupsLbl.TabIndex = 53;
            existSupsLbl.Text = "الموردين الموجودين";
            // 
            // productGridViewPanel
            // 
            productGridViewPanel.Anchor = AnchorStyles.None;
            productGridViewPanel.Controls.Add(pictureBox1);
            productGridViewPanel.Controls.Add(existSupsLbl);
            productGridViewPanel.Controls.Add(panel1);
            productGridViewPanel.Controls.Add(dataGridView1);
            productGridViewPanel.Controls.Add(existProductsLbl);
            productGridViewPanel.Location = new Point(0, 488);
            productGridViewPanel.Name = "productGridViewPanel";
            productGridViewPanel.Size = new Size(1244, 488);
            productGridViewPanel.TabIndex = 54;
            // 
            // AddProductPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(addSupplierPanel);
            Controls.Add(addProductPanel);
            Controls.Add(suppliersBtn);
            Controls.Add(productsBtn);
            Controls.Add(productGridViewPanel);
            MinimumSize = new Size(1244, 752);
            Name = "AddProductPage";
            Size = new Size(1244, 976);
            Load += AddProductPage_Load;
            addProductPanel.ResumeLayout(false);
            addProductPanel.PerformLayout();
            addSupplierPanel.ResumeLayout(false);
            addSupplierPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            productGridViewPanel.ResumeLayout(false);
            productGridViewPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label barCodeLbl;
        private Button productsBtn;
        private TextBox barCodeBox;
        private Button suppliersBtn;
        private Panel addProductPanel;
        private Label categoryLbl;
        private ComboBox CatComboBox;
        private Label pNameLbl;
        private TextBox productNameBox;
        private Panel addSupplierPanel;
        private Label costLbl;
        private TextBox sellingPriceBox;
        private Label sellingPriceLbl;
        private TextBox costBox;
        private Label supplierLbl;
        private ComboBox SupplierComboBox;
        private Label stockLbl;
        private TextBox stockBox;
        private Label toDateLbl;
        private DateTimePicker toDateBox;
        private Label fromDateLbl;
        private DateTimePicker fromDateBox;
        private Label discountLbl;
        private TextBox discountBox;
        private Button saveProductBtn;
        private Label notesLbl;
        private TextBox noteBox;
        private Label contractDateLbl;
        private Label supCodeLbl;
        private Label supNameLbl;
        private Label supPhoneLbl;
        private Label supMailLbl;
        private TextBox supMailBox;
        private TextBox supCodeBox;
        private Label supAddressLbl;
        private TextBox supNameBox;
        private TextBox supAddressBox;
        private DateTimePicker contractDateBox;
        private Button saveSupplierBtn;
        private TextBox supPhoneBox;
        private DataGridView dataGridView1;
        private Label existProductsLbl;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label existSupsLbl;
        private Panel productGridViewPanel;
    }
}
