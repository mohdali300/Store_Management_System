namespace Store_System.UI
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            button7 = new Button();
            button3 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            shortFallsBtn = new Button();
            mainStockBtn = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button11 = new Button();
            button12 = new Button();
            button9 = new Button();
            button10 = new Button();
            button4 = new Button();
            button8 = new Button();
            addSupplierBtn = new Button();
            addProductBtn = new Button();
            addCategoryBtn = new Button();
            addUserBtn = new Button();
            groupBox5 = new GroupBox();
            panel1 = new Panel();
            backHomeBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            logOutBtn = new Button();
            addProductPage1 = new AddProductPage();
            addUserPage1 = new AddUserPage();
            addCategoryPage1 = new AddCategoryPage();
            addSupplierPage1 = new AddSupplierPage();
            mainStockPage1 = new MainStockPage();
            shortFallsPage1 = new ShortFallsPage();
            welcomePage1 = new WelcomePage();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(36, 80);
            button7.Name = "button7";
            button7.Size = new Size(143, 41);
            button7.TabIndex = 3;
            button7.Text = "تقفيل شيفت";
            button7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(206, 80);
            button3.Name = "button3";
            button3.Size = new Size(152, 41);
            button3.TabIndex = 2;
            button3.Text = "مرتجع بيع";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(206, 27);
            button1.Name = "button1";
            button1.Size = new Size(152, 41);
            button1.TabIndex = 0;
            button1.Text = "فاتورة بيع";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(16, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "بيع وشراء";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(36, 27);
            button2.Name = "button2";
            button2.Size = new Size(143, 41);
            button2.TabIndex = 1;
            button2.Text = "فاتورة شراء";
            button2.UseVisualStyleBackColor = false;
            // 
            // shortFallsBtn
            // 
            shortFallsBtn.BackColor = Color.White;
            shortFallsBtn.FlatStyle = FlatStyle.Flat;
            shortFallsBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            shortFallsBtn.ForeColor = Color.Black;
            shortFallsBtn.Location = new Point(37, 75);
            shortFallsBtn.Name = "shortFallsBtn";
            shortFallsBtn.Size = new Size(321, 41);
            shortFallsBtn.TabIndex = 2;
            shortFallsBtn.Text = "جدول النواقص";
            shortFallsBtn.UseVisualStyleBackColor = false;
            shortFallsBtn.Click += shortFallsBtn_Click;
            // 
            // mainStockBtn
            // 
            mainStockBtn.BackColor = Color.White;
            mainStockBtn.FlatStyle = FlatStyle.Flat;
            mainStockBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            mainStockBtn.ForeColor = Color.Black;
            mainStockBtn.Location = new Point(37, 26);
            mainStockBtn.Name = "mainStockBtn";
            mainStockBtn.Size = new Size(321, 41);
            mainStockBtn.TabIndex = 1;
            mainStockBtn.Text = "المخزن الرئيسى";
            mainStockBtn.UseVisualStyleBackColor = false;
            mainStockBtn.Click += mainStockBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(shortFallsBtn);
            groupBox2.Controls.Add(mainStockBtn);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(16, 302);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 130);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "المخازن";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button11);
            groupBox3.Controls.Add(button12);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(button10);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button8);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(16, 446);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(391, 244);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "التقارير";
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = Color.Black;
            button11.Location = new Point(37, 182);
            button11.Name = "button11";
            button11.Size = new Size(321, 41);
            button11.TabIndex = 4;
            button11.Text = "موردين";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.White;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button12.ForeColor = Color.Black;
            button12.Location = new Point(37, 130);
            button12.Name = "button12";
            button12.Size = new Size(321, 41);
            button12.TabIndex = 3;
            button12.Text = "عملاء";
            button12.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(36, 78);
            button9.Name = "button9";
            button9.Size = new Size(143, 41);
            button9.TabIndex = 4;
            button9.Text = " ربح وخسارة";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(206, 78);
            button10.Name = "button10";
            button10.Size = new Size(152, 41);
            button10.TabIndex = 3;
            button10.Text = "تقرير مصروفات";
            button10.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(36, 26);
            button4.Name = "button4";
            button4.Size = new Size(143, 41);
            button4.TabIndex = 2;
            button4.Text = "تقرير مشتريات";
            button4.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(207, 26);
            button8.Name = "button8";
            button8.Size = new Size(152, 41);
            button8.TabIndex = 1;
            button8.Text = "تقرير مبيعات";
            button8.UseVisualStyleBackColor = false;
            // 
            // addSupplierBtn
            // 
            addSupplierBtn.BackColor = Color.White;
            addSupplierBtn.FlatStyle = FlatStyle.Flat;
            addSupplierBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addSupplierBtn.ForeColor = Color.Black;
            addSupplierBtn.Location = new Point(39, 174);
            addSupplierBtn.Name = "addSupplierBtn";
            addSupplierBtn.Size = new Size(320, 41);
            addSupplierBtn.TabIndex = 4;
            addSupplierBtn.Text = "إضافة وتعديل مورد";
            addSupplierBtn.UseVisualStyleBackColor = false;
            addSupplierBtn.Click += addSupplierBtn_Click;
            // 
            // addProductBtn
            // 
            addProductBtn.BackColor = Color.White;
            addProductBtn.FlatStyle = FlatStyle.Flat;
            addProductBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addProductBtn.ForeColor = Color.Black;
            addProductBtn.Location = new Point(37, 74);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(320, 41);
            addProductBtn.TabIndex = 3;
            addProductBtn.Text = "إضافة وتعديل منتج";
            addProductBtn.UseVisualStyleBackColor = false;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.BackColor = Color.White;
            addCategoryBtn.FlatStyle = FlatStyle.Flat;
            addCategoryBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addCategoryBtn.ForeColor = Color.Black;
            addCategoryBtn.Location = new Point(39, 124);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Size = new Size(320, 41);
            addCategoryBtn.TabIndex = 2;
            addCategoryBtn.Text = "إضافة وتعديل صنف";
            addCategoryBtn.UseVisualStyleBackColor = false;
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // addUserBtn
            // 
            addUserBtn.BackColor = Color.White;
            addUserBtn.FlatStyle = FlatStyle.Flat;
            addUserBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addUserBtn.ForeColor = Color.Black;
            addUserBtn.Location = new Point(38, 24);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new Size(320, 41);
            addUserBtn.TabIndex = 1;
            addUserBtn.Text = "إضافة وتعديل مستخدم";
            addUserBtn.UseVisualStyleBackColor = false;
            addUserBtn.Click += addUserBtn_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(addSupplierBtn);
            groupBox5.Controls.Add(addProductBtn);
            groupBox5.Controls.Add(addCategoryBtn);
            groupBox5.Controls.Add(addUserBtn);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(16, 704);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(391, 231);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "التحكم";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(24, 30, 46);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(backHomeBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(1493, 48);
            panel1.MaximumSize = new Size(429, 952);
            panel1.MinimumSize = new Size(429, 952);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 952);
            panel1.TabIndex = 1;
            // 
            // backHomeBtn
            // 
            backHomeBtn.BackColor = Color.FromArgb(24, 30, 46);
            backHomeBtn.BackgroundImage = (Image)resources.GetObject("backHomeBtn.BackgroundImage");
            backHomeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            backHomeBtn.FlatAppearance.BorderSize = 0;
            backHomeBtn.FlatStyle = FlatStyle.Flat;
            backHomeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backHomeBtn.ForeColor = Color.White;
            backHomeBtn.Location = new Point(16, 56);
            backHomeBtn.Name = "backHomeBtn";
            backHomeBtn.Size = new Size(84, 62);
            backHomeBtn.TabIndex = 11;
            backHomeBtn.UseVisualStyleBackColor = false;
            backHomeBtn.Click += backHomeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(254, 68);
            label1.Name = "label1";
            label1.Size = new Size(66, 31);
            label1.TabIndex = 9;
            label1.Text = "الاسم";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 156, 133);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(logOutBtn);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1919, 45);
            panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.Firebrick;
            logOutBtn.FlatStyle = FlatStyle.Flat;
            logOutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logOutBtn.ForeColor = Color.White;
            logOutBtn.Location = new Point(64, 6);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(119, 35);
            logOutBtn.TabIndex = 10;
            logOutBtn.Text = "تسجيل الخروج";
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // addProductPage1
            // 
            addProductPage1.BackColor = Color.FromArgb(24, 30, 46);
            addProductPage1.Location = new Point(-5, 51);
            addProductPage1.MinimumSize = new Size(1496, 949);
            addProductPage1.Name = "addProductPage1";
            addProductPage1.Size = new Size(1496, 949);
            addProductPage1.TabIndex = 3;
            // 
            // addUserPage1
            // 
            addUserPage1.BackColor = Color.FromArgb(24, 30, 46);
            addUserPage1.Location = new Point(-5, 51);
            addUserPage1.MinimumSize = new Size(1496, 949);
            addUserPage1.Name = "addUserPage1";
            addUserPage1.Size = new Size(1496, 949);
            addUserPage1.TabIndex = 4;
            // 
            // addCategoryPage1
            // 
            addCategoryPage1.BackColor = Color.FromArgb(24, 30, 46);
            addCategoryPage1.Location = new Point(-5, 51);
            addCategoryPage1.MinimumSize = new Size(1496, 949);
            addCategoryPage1.Name = "addCategoryPage1";
            addCategoryPage1.Size = new Size(1496, 949);
            addCategoryPage1.TabIndex = 5;
            // 
            // addSupplierPage1
            // 
            addSupplierPage1.BackColor = Color.FromArgb(24, 30, 46);
            addSupplierPage1.Location = new Point(-5, 50);
            addSupplierPage1.MinimumSize = new Size(1496, 949);
            addSupplierPage1.Name = "addSupplierPage1";
            addSupplierPage1.Size = new Size(1496, 949);
            addSupplierPage1.TabIndex = 6;
            // 
            // mainStockPage1
            // 
            mainStockPage1.BackColor = Color.FromArgb(24, 30, 46);
            mainStockPage1.Location = new Point(-5, 51);
            mainStockPage1.MinimumSize = new Size(1496, 949);
            mainStockPage1.Name = "mainStockPage1";
            mainStockPage1.Size = new Size(1496, 949);
            mainStockPage1.TabIndex = 11;
            // 
            // shortFallsPage1
            // 
            shortFallsPage1.BackColor = Color.FromArgb(24, 30, 46);
            shortFallsPage1.Location = new Point(-5, 52);
            shortFallsPage1.MinimumSize = new Size(1496, 949);
            shortFallsPage1.Name = "shortFallsPage1";
            shortFallsPage1.Size = new Size(1496, 949);
            shortFallsPage1.TabIndex = 12;
            // 
            // welcomePage1
            // 
            welcomePage1.BackColor = Color.FromArgb(24, 30, 46);
            welcomePage1.Location = new Point(-5, 51);
            welcomePage1.MinimumSize = new Size(1496, 949);
            welcomePage1.Name = "welcomePage1";
            welcomePage1.Size = new Size(1496, 949);
            welcomePage1.TabIndex = 13;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            ClientSize = new Size(1924, 1004);
            Controls.Add(welcomePage1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(addUserPage1);
            Controls.Add(shortFallsPage1);
            Controls.Add(mainStockPage1);
            Controls.Add(addSupplierPage1);
            Controls.Add(addCategoryPage1);
            Controls.Add(addProductPage1);
            MinimumSize = new Size(1918, 1040);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += AdminDashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Button button3;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Button shortFallsBtn;
        private Button mainStockBtn;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button9;
        private Button button10;
        private Button button4;
        private Button button8;
        private Button button11;
        private Button button12;
        private Button addSupplierBtn;
        private Button addProductBtn;
        private Button addCategoryBtn;
        private Button addUserBtn;
        private GroupBox groupBox5;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button logOutBtn;
        private AddProductPage addProductPage1;
        private AddUserPage addUserPage1;
        private AddCategoryPage addCategoryPage1;
        private AddSupplierPage addSupplierPage1;
        private MainStockPage mainStockPage1;
        private ShortFallsPage shortFallsPage1;
        private PictureBox pictureBox3;
        private WelcomePage welcomePage1;
        private Button backHomeBtn;
    }
}