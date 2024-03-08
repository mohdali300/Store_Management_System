namespace Store_System.UI.ControlPanelUi
{
    partial class BuyBill
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
            Items = new DataGridView();
            Printbtn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            BillCodeBox = new TextBox();
            SupplierBox = new ComboBox();
            label3 = new Label();
            SearchBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ProductCodeBox = new TextBox();
            label6 = new Label();
            ProductnameBox = new TextBox();
            label7 = new Label();
            ClassificationBox = new ComboBox();
            label8 = new Label();
            QuantityBox = new TextBox();
            label9 = new Label();
            CostBox = new TextBox();
            label10 = new Label();
            PriceBox = new TextBox();
            label11 = new Label();
            DiscountBox = new TextBox();
            label12 = new Label();
            SizeBox = new ComboBox();
            label13 = new Label();
            ColorBox = new ComboBox();
            label14 = new Label();
            NotesBox = new TextBox();
            label15 = new Label();
            TotalPriceBox = new TextBox();
            label16 = new Label();
            PaidUp = new TextBox();
            label17 = new Label();
            AfterDiscount = new TextBox();
            label18 = new Label();
            FaturaDiscountBox = new TextBox();
            label19 = new Label();
            CustomerBox = new ComboBox();
            label20 = new Label();
            StockBox = new ComboBox();
            Savebtn = new Button();
            Addbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Items).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Items
            // 
            Items.Anchor = AnchorStyles.None;
            Items.BackgroundColor = Color.Snow;
            Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items.Location = new Point(39, 335);
            Items.Name = "Items";
            Items.RowHeadersWidth = 51;
            Items.RowTemplate.Height = 29;
            Items.Size = new Size(1397, 489);
            Items.TabIndex = 36;
            // 
            // Printbtn
            // 
            Printbtn.Anchor = AnchorStyles.None;
            Printbtn.BackColor = Color.LimeGreen;
            Printbtn.FlatStyle = FlatStyle.Flat;
            Printbtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            Printbtn.ForeColor = Color.White;
            Printbtn.Location = new Point(39, 899);
            Printbtn.Name = "Printbtn";
            Printbtn.Size = new Size(131, 36);
            Printbtn.TabIndex = 35;
            Printbtn.Text = "طباعة";
            Printbtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1273, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 49);
            panel1.TabIndex = 28;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(38, -2);
            label1.Name = "label1";
            label1.Size = new Size(143, 38);
            label1.TabIndex = 0;
            label1.Text = "فاتورة شراء";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1108, 37);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 42;
            label2.Text = "رقم الفاتورة";
            // 
            // BillCodeBox
            // 
            BillCodeBox.Anchor = AnchorStyles.None;
            BillCodeBox.BackColor = Color.FromArgb(24, 30, 46);
            BillCodeBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BillCodeBox.ForeColor = Color.White;
            BillCodeBox.Location = new Point(984, 55);
            BillCodeBox.Name = "BillCodeBox";
            BillCodeBox.RightToLeft = RightToLeft.Yes;
            BillCodeBox.Size = new Size(225, 39);
            BillCodeBox.TabIndex = 43;
            // 
            // SupplierBox
            // 
            SupplierBox.BackColor = Color.FromArgb(24, 30, 46);
            SupplierBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SupplierBox.FormattingEnabled = true;
            SupplierBox.Location = new Point(612, 55);
            SupplierBox.Name = "SupplierBox";
            SupplierBox.Size = new Size(356, 39);
            SupplierBox.TabIndex = 44;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(858, 37);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 45;
            label3.Text = "المورد";
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.None;
            SearchBox.BackColor = Color.FromArgb(24, 30, 46);
            SearchBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBox.ForeColor = Color.White;
            SearchBox.Location = new Point(39, 55);
            SearchBox.Name = "SearchBox";
            SearchBox.RightToLeft = RightToLeft.Yes;
            SearchBox.Size = new Size(567, 39);
            SearchBox.TabIndex = 46;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(536, 37);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 47;
            label4.Text = "البحث";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1335, 122);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 48;
            label5.Text = "كود المنتج";
            // 
            // ProductCodeBox
            // 
            ProductCodeBox.Anchor = AnchorStyles.None;
            ProductCodeBox.BackColor = Color.FromArgb(24, 30, 46);
            ProductCodeBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductCodeBox.ForeColor = Color.White;
            ProductCodeBox.Location = new Point(1227, 140);
            ProductCodeBox.Name = "ProductCodeBox";
            ProductCodeBox.RightToLeft = RightToLeft.Yes;
            ProductCodeBox.Size = new Size(209, 34);
            ProductCodeBox.TabIndex = 49;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1108, 122);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 50;
            label6.Text = "إسم المنتج";
            // 
            // ProductnameBox
            // 
            ProductnameBox.Anchor = AnchorStyles.None;
            ProductnameBox.BackColor = Color.FromArgb(24, 30, 46);
            ProductnameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductnameBox.ForeColor = Color.White;
            ProductnameBox.Location = new Point(898, 140);
            ProductnameBox.Name = "ProductnameBox";
            ProductnameBox.RightToLeft = RightToLeft.Yes;
            ProductnameBox.Size = new Size(303, 34);
            ProductnameBox.TabIndex = 51;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(764, 122);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 53;
            label7.Text = "التصنيف";
            // 
            // ClassificationBox
            // 
            ClassificationBox.BackColor = Color.FromArgb(24, 30, 46);
            ClassificationBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClassificationBox.FormattingEnabled = true;
            ClassificationBox.Location = new Point(572, 139);
            ClassificationBox.Name = "ClassificationBox";
            ClassificationBox.Size = new Size(289, 36);
            ClassificationBox.TabIndex = 52;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(464, 122);
            label8.Name = "label8";
            label8.Size = new Size(54, 23);
            label8.TabIndex = 54;
            label8.Text = "الكمية";
            // 
            // QuantityBox
            // 
            QuantityBox.Anchor = AnchorStyles.None;
            QuantityBox.BackColor = Color.FromArgb(24, 30, 46);
            QuantityBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityBox.ForeColor = Color.White;
            QuantityBox.Location = new Point(326, 140);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.RightToLeft = RightToLeft.Yes;
            QuantityBox.Size = new Size(210, 34);
            QuantityBox.TabIndex = 55;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(202, 122);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 56;
            label9.Text = "سعر الشراء";
            // 
            // CostBox
            // 
            CostBox.Anchor = AnchorStyles.None;
            CostBox.BackColor = Color.FromArgb(24, 30, 46);
            CostBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CostBox.ForeColor = Color.White;
            CostBox.Location = new Point(39, 140);
            CostBox.Name = "CostBox";
            CostBox.RightToLeft = RightToLeft.Yes;
            CostBox.Size = new Size(249, 34);
            CostBox.TabIndex = 57;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(1358, 222);
            label10.Name = "label10";
            label10.Size = new Size(78, 23);
            label10.TabIndex = 58;
            label10.Text = "سعر البيع";
            // 
            // PriceBox
            // 
            PriceBox.Anchor = AnchorStyles.None;
            PriceBox.BackColor = Color.FromArgb(24, 30, 46);
            PriceBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceBox.ForeColor = Color.White;
            PriceBox.Location = new Point(1227, 240);
            PriceBox.Name = "PriceBox";
            PriceBox.RightToLeft = RightToLeft.Yes;
            PriceBox.Size = new Size(209, 34);
            PriceBox.TabIndex = 59;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(1120, 222);
            label11.Name = "label11";
            label11.Size = new Size(57, 23);
            label11.TabIndex = 60;
            label11.Text = "الخصم";
            // 
            // DiscountBox
            // 
            DiscountBox.Anchor = AnchorStyles.None;
            DiscountBox.BackColor = Color.FromArgb(24, 30, 46);
            DiscountBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DiscountBox.ForeColor = Color.White;
            DiscountBox.Location = new Point(1052, 240);
            DiscountBox.Name = "DiscountBox";
            DiscountBox.RightToLeft = RightToLeft.Yes;
            DiscountBox.Size = new Size(169, 34);
            DiscountBox.TabIndex = 61;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(644, 222);
            label12.Name = "label12";
            label12.Size = new Size(53, 23);
            label12.TabIndex = 65;
            label12.Text = "مقاس";
            // 
            // SizeBox
            // 
            SizeBox.BackColor = Color.FromArgb(24, 30, 46);
            SizeBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SizeBox.FormattingEnabled = true;
            SizeBox.Location = new Point(442, 240);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(290, 36);
            SizeBox.TabIndex = 64;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(903, 222);
            label13.Name = "label13";
            label13.Size = new Size(46, 23);
            label13.TabIndex = 63;
            label13.Text = "اللون";
            // 
            // ColorBox
            // 
            ColorBox.BackColor = Color.FromArgb(24, 30, 46);
            ColorBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ColorBox.FormattingEnabled = true;
            ColorBox.Location = new Point(747, 240);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new Size(290, 36);
            ColorBox.TabIndex = 62;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(251, 222);
            label14.Name = "label14";
            label14.Size = new Size(74, 23);
            label14.TabIndex = 66;
            label14.Text = "ملاحظات";
            // 
            // NotesBox
            // 
            NotesBox.Anchor = AnchorStyles.None;
            NotesBox.BackColor = Color.FromArgb(24, 30, 46);
            NotesBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NotesBox.ForeColor = Color.White;
            NotesBox.Location = new Point(39, 240);
            NotesBox.Name = "NotesBox";
            NotesBox.RightToLeft = RightToLeft.Yes;
            NotesBox.Size = new Size(397, 34);
            NotesBox.TabIndex = 67;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(1358, 830);
            label15.Name = "label15";
            label15.Size = new Size(58, 23);
            label15.TabIndex = 68;
            label15.Text = "إجمالى";
            // 
            // TotalPriceBox
            // 
            TotalPriceBox.Anchor = AnchorStyles.None;
            TotalPriceBox.BackColor = Color.FromArgb(24, 30, 46);
            TotalPriceBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalPriceBox.ForeColor = Color.White;
            TotalPriceBox.Location = new Point(1227, 848);
            TotalPriceBox.Name = "TotalPriceBox";
            TotalPriceBox.RightToLeft = RightToLeft.Yes;
            TotalPriceBox.Size = new Size(209, 34);
            TotalPriceBox.TabIndex = 69;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(677, 830);
            label16.Name = "label16";
            label16.Size = new Size(67, 23);
            label16.TabIndex = 70;
            label16.Text = "المدفوع";
            // 
            // PaidUp
            // 
            PaidUp.Anchor = AnchorStyles.None;
            PaidUp.BackColor = Color.FromArgb(24, 30, 46);
            PaidUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PaidUp.ForeColor = Color.White;
            PaidUp.Location = new Point(546, 848);
            PaidUp.Name = "PaidUp";
            PaidUp.RightToLeft = RightToLeft.Yes;
            PaidUp.Size = new Size(209, 34);
            PaidUp.TabIndex = 71;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(906, 830);
            label17.Name = "label17";
            label17.Size = new Size(87, 23);
            label17.TabIndex = 72;
            label17.Text = "بعد الخصم";
            // 
            // AfterDiscount
            // 
            AfterDiscount.Anchor = AnchorStyles.None;
            AfterDiscount.BackColor = Color.FromArgb(24, 30, 46);
            AfterDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AfterDiscount.ForeColor = Color.White;
            AfterDiscount.Location = new Point(775, 848);
            AfterDiscount.Name = "AfterDiscount";
            AfterDiscount.RightToLeft = RightToLeft.Yes;
            AfterDiscount.Size = new Size(209, 34);
            AfterDiscount.TabIndex = 73;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(1131, 830);
            label18.Name = "label18";
            label18.Size = new Size(57, 23);
            label18.TabIndex = 74;
            label18.Text = "الخصم";
            // 
            // FaturaDiscountBox
            // 
            FaturaDiscountBox.Anchor = AnchorStyles.None;
            FaturaDiscountBox.BackColor = Color.FromArgb(24, 30, 46);
            FaturaDiscountBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FaturaDiscountBox.ForeColor = Color.White;
            FaturaDiscountBox.Location = new Point(1000, 848);
            FaturaDiscountBox.Name = "FaturaDiscountBox";
            FaturaDiscountBox.RightToLeft = RightToLeft.Yes;
            FaturaDiscountBox.Size = new Size(209, 34);
            FaturaDiscountBox.TabIndex = 75;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(402, 828);
            label19.Name = "label19";
            label19.Size = new Size(70, 23);
            label19.TabIndex = 77;
            label19.Text = "الموظف";
            // 
            // CustomerBox
            // 
            CustomerBox.BackColor = Color.FromArgb(24, 30, 46);
            CustomerBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerBox.FormattingEnabled = true;
            CustomerBox.Location = new Point(270, 846);
            CustomerBox.Name = "CustomerBox";
            CustomerBox.Size = new Size(266, 36);
            CustomerBox.TabIndex = 76;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(186, 830);
            label20.Name = "label20";
            label20.Size = new Size(51, 23);
            label20.TabIndex = 79;
            label20.Text = "الخزنة";
            // 
            // StockBox
            // 
            StockBox.BackColor = Color.FromArgb(24, 30, 46);
            StockBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StockBox.FormattingEnabled = true;
            StockBox.Location = new Point(39, 847);
            StockBox.Name = "StockBox";
            StockBox.Size = new Size(225, 36);
            StockBox.TabIndex = 78;
            // 
            // Savebtn
            // 
            Savebtn.Anchor = AnchorStyles.None;
            Savebtn.BackColor = Color.LimeGreen;
            Savebtn.FlatStyle = FlatStyle.Flat;
            Savebtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            Savebtn.ForeColor = Color.White;
            Savebtn.Location = new Point(186, 899);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(131, 36);
            Savebtn.TabIndex = 80;
            Savebtn.Text = "حفظ";
            Savebtn.UseVisualStyleBackColor = false;
            // 
            // Addbtn
            // 
            Addbtn.Anchor = AnchorStyles.None;
            Addbtn.BackColor = Color.LimeGreen;
            Addbtn.FlatStyle = FlatStyle.Flat;
            Addbtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            Addbtn.ForeColor = Color.White;
            Addbtn.Location = new Point(39, 291);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(131, 38);
            Addbtn.TabIndex = 81;
            Addbtn.Text = "إضافة";
            Addbtn.UseVisualStyleBackColor = false;
            // 
            // BuyBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(Addbtn);
            Controls.Add(Savebtn);
            Controls.Add(label20);
            Controls.Add(StockBox);
            Controls.Add(label19);
            Controls.Add(CustomerBox);
            Controls.Add(label18);
            Controls.Add(FaturaDiscountBox);
            Controls.Add(label17);
            Controls.Add(AfterDiscount);
            Controls.Add(label16);
            Controls.Add(PaidUp);
            Controls.Add(label15);
            Controls.Add(TotalPriceBox);
            Controls.Add(label14);
            Controls.Add(NotesBox);
            Controls.Add(label12);
            Controls.Add(SizeBox);
            Controls.Add(label13);
            Controls.Add(ColorBox);
            Controls.Add(label11);
            Controls.Add(DiscountBox);
            Controls.Add(label10);
            Controls.Add(PriceBox);
            Controls.Add(label9);
            Controls.Add(CostBox);
            Controls.Add(label8);
            Controls.Add(QuantityBox);
            Controls.Add(label7);
            Controls.Add(ClassificationBox);
            Controls.Add(label6);
            Controls.Add(ProductnameBox);
            Controls.Add(label5);
            Controls.Add(ProductCodeBox);
            Controls.Add(label4);
            Controls.Add(SearchBox);
            Controls.Add(label3);
            Controls.Add(SupplierBox);
            Controls.Add(label2);
            Controls.Add(BillCodeBox);
            Controls.Add(Items);
            Controls.Add(Printbtn);
            Controls.Add(panel1);
            Name = "BuyBill";
            Size = new Size(1496, 949);
            Load += BuyBill_Load;
            ((System.ComponentModel.ISupportInitialize)Items).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView Items;
        private Button Printbtn;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox BillCodeBox;
        private ComboBox SupplierBox;
        private Label label3;
        private TextBox SearchBox;
        private Label label4;
        private Label label5;
        private TextBox ProductCodeBox;
        private Label label6;
        private TextBox ProductnameBox;
        private Label label7;
        private ComboBox ClassificationBox;
        private Label label8;
        private TextBox QuantityBox;
        private Label label9;
        private TextBox CostBox;
        private Label label10;
        private TextBox PriceBox;
        private Label label11;
        private TextBox DiscountBox;
        private Label label12;
        private ComboBox SizeBox;
        private Label label13;
        private ComboBox ColorBox;
        private Label label14;
        private TextBox NotesBox;
        private Label label15;
        private TextBox TotalPriceBox;
        private Label label16;
        private TextBox PaidUp;
        private Label label17;
        private TextBox AfterDiscount;
        private Label label18;
        private TextBox FaturaDiscountBox;
        private Label label19;
        private ComboBox CustomerBox;
        private Label label20;
        private ComboBox StockBox;
        private Button Savebtn;
        private Button Addbtn;
    }
}
