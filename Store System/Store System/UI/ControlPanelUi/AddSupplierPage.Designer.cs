namespace Store_System.UI
{
    partial class AddSupplierPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplierPage));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            SupMailLbl = new Label();
            SupPhoneLbl = new Label();
            SupNameLbl = new Label();
            nameUserBox = new TextBox();
            SupCodeLbl = new Label();
            SupCodeBox = new TextBox();
            SupMailBox = new TextBox();
            SupPhoneBox = new TextBox();
            contractDateBox = new DateTimePicker();
            contractDate = new Label();
            SupAddressLbl = new Label();
            SupAddressBox = new TextBox();
            saveSupplierBtn = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            textBox2 = new TextBox();
            usersPic = new PictureBox();
            existUsrsGridView = new DataGridView();
            panel5 = new Panel();
            existUserLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)existUsrsGridView).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1372, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1133, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 57);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(14, 6);
            label1.Name = "label1";
            label1.Size = new Size(210, 38);
            label1.TabIndex = 0;
            label1.Text = "إضافة مورد جديد";
            // 
            // SupMailLbl
            // 
            SupMailLbl.Anchor = AnchorStyles.None;
            SupMailLbl.AutoSize = true;
            SupMailLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SupMailLbl.ForeColor = Color.White;
            SupMailLbl.Location = new Point(313, 200);
            SupMailLbl.Name = "SupMailLbl";
            SupMailLbl.Size = new Size(57, 23);
            SupMailLbl.TabIndex = 22;
            SupMailLbl.Text = "الايميل";
            // 
            // SupPhoneLbl
            // 
            SupPhoneLbl.Anchor = AnchorStyles.None;
            SupPhoneLbl.AutoSize = true;
            SupPhoneLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SupPhoneLbl.ForeColor = Color.White;
            SupPhoneLbl.Location = new Point(625, 200);
            SupPhoneLbl.Name = "SupPhoneLbl";
            SupPhoneLbl.Size = new Size(86, 23);
            SupPhoneLbl.TabIndex = 21;
            SupPhoneLbl.Text = "رقم الهاتف";
            // 
            // SupNameLbl
            // 
            SupNameLbl.Anchor = AnchorStyles.None;
            SupNameLbl.AutoSize = true;
            SupNameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SupNameLbl.ForeColor = Color.White;
            SupNameLbl.Location = new Point(973, 200);
            SupNameLbl.Name = "SupNameLbl";
            SupNameLbl.Size = new Size(87, 23);
            SupNameLbl.TabIndex = 20;
            SupNameLbl.Text = "اسم المورد";
            // 
            // nameUserBox
            // 
            nameUserBox.Anchor = AnchorStyles.None;
            nameUserBox.BackColor = Color.FromArgb(24, 30, 46);
            nameUserBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameUserBox.ForeColor = Color.White;
            nameUserBox.Location = new Point(773, 218);
            nameUserBox.Name = "nameUserBox";
            nameUserBox.RightToLeft = RightToLeft.Yes;
            nameUserBox.Size = new Size(297, 47);
            nameUserBox.TabIndex = 17;
            // 
            // SupCodeLbl
            // 
            SupCodeLbl.Anchor = AnchorStyles.None;
            SupCodeLbl.AutoSize = true;
            SupCodeLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SupCodeLbl.ForeColor = Color.White;
            SupCodeLbl.Location = new Point(1326, 200);
            SupCodeLbl.Name = "SupCodeLbl";
            SupCodeLbl.Size = new Size(86, 23);
            SupCodeLbl.TabIndex = 15;
            SupCodeLbl.Text = "كود المورد";
            // 
            // SupCodeBox
            // 
            SupCodeBox.Anchor = AnchorStyles.None;
            SupCodeBox.BackColor = Color.FromArgb(24, 30, 46);
            SupCodeBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SupCodeBox.ForeColor = Color.White;
            SupCodeBox.Location = new Point(1124, 218);
            SupCodeBox.Name = "SupCodeBox";
            SupCodeBox.RightToLeft = RightToLeft.Yes;
            SupCodeBox.Size = new Size(296, 47);
            SupCodeBox.TabIndex = 16;
            // 
            // SupMailBox
            // 
            SupMailBox.Anchor = AnchorStyles.None;
            SupMailBox.BackColor = Color.FromArgb(24, 30, 46);
            SupMailBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SupMailBox.ForeColor = Color.White;
            SupMailBox.Location = new Point(87, 218);
            SupMailBox.Name = "SupMailBox";
            SupMailBox.RightToLeft = RightToLeft.Yes;
            SupMailBox.Size = new Size(292, 47);
            SupMailBox.TabIndex = 19;
            // 
            // SupPhoneBox
            // 
            SupPhoneBox.Anchor = AnchorStyles.None;
            SupPhoneBox.BackColor = Color.FromArgb(24, 30, 46);
            SupPhoneBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SupPhoneBox.ForeColor = Color.White;
            SupPhoneBox.Location = new Point(436, 218);
            SupPhoneBox.Name = "SupPhoneBox";
            SupPhoneBox.RightToLeft = RightToLeft.Yes;
            SupPhoneBox.Size = new Size(283, 47);
            SupPhoneBox.TabIndex = 18;
            // 
            // contractDateBox
            // 
            contractDateBox.Anchor = AnchorStyles.None;
            contractDateBox.CalendarMonthBackground = Color.Snow;
            contractDateBox.CalendarTitleBackColor = Color.Snow;
            contractDateBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            contractDateBox.Format = DateTimePickerFormat.Short;
            contractDateBox.Location = new Point(612, 310);
            contractDateBox.Name = "contractDateBox";
            contractDateBox.RightToLeft = RightToLeft.Yes;
            contractDateBox.Size = new Size(277, 47);
            contractDateBox.TabIndex = 30;
            // 
            // contractDate
            // 
            contractDate.Anchor = AnchorStyles.None;
            contractDate.AutoSize = true;
            contractDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            contractDate.ForeColor = Color.White;
            contractDate.Location = new Point(783, 291);
            contractDate.Name = "contractDate";
            contractDate.Size = new Size(97, 23);
            contractDate.TabIndex = 31;
            contractDate.Text = "تاريخ التعاقد";
            // 
            // SupAddressLbl
            // 
            SupAddressLbl.Anchor = AnchorStyles.None;
            SupAddressLbl.AutoSize = true;
            SupAddressLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SupAddressLbl.ForeColor = Color.White;
            SupAddressLbl.Location = new Point(1210, 292);
            SupAddressLbl.Name = "SupAddressLbl";
            SupAddressLbl.Size = new Size(60, 23);
            SupAddressLbl.TabIndex = 32;
            SupAddressLbl.Text = "العنوان";
            // 
            // SupAddressBox
            // 
            SupAddressBox.Anchor = AnchorStyles.None;
            SupAddressBox.BackColor = Color.FromArgb(24, 30, 46);
            SupAddressBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SupAddressBox.ForeColor = Color.White;
            SupAddressBox.Location = new Point(984, 312);
            SupAddressBox.Name = "SupAddressBox";
            SupAddressBox.RightToLeft = RightToLeft.Yes;
            SupAddressBox.Size = new Size(296, 47);
            SupAddressBox.TabIndex = 33;
            // 
            // saveSupplierBtn
            // 
            saveSupplierBtn.Anchor = AnchorStyles.None;
            saveSupplierBtn.BackColor = Color.LimeGreen;
            saveSupplierBtn.FlatAppearance.BorderColor = Color.White;
            saveSupplierBtn.FlatStyle = FlatStyle.Popup;
            saveSupplierBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            saveSupplierBtn.ForeColor = Color.White;
            saveSupplierBtn.Location = new Point(222, 312);
            saveSupplierBtn.Name = "saveSupplierBtn";
            saveSupplierBtn.RightToLeft = RightToLeft.Yes;
            saveSupplierBtn.Size = new Size(295, 47);
            saveSupplierBtn.TabIndex = 34;
            saveSupplierBtn.Text = "حفظ";
            saveSupplierBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(305, 433);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(199, 414);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 39;
            label4.Text = "ابحث بالاسم";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.FromArgb(24, 30, 46);
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(87, 433);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(213, 38);
            textBox2.TabIndex = 38;
            // 
            // usersPic
            // 
            usersPic.Anchor = AnchorStyles.None;
            usersPic.BackColor = Color.FromArgb(24, 30, 46);
            usersPic.Image = (Image)resources.GetObject("usersPic.Image");
            usersPic.Location = new Point(1356, 415);
            usersPic.Name = "usersPic";
            usersPic.Size = new Size(62, 57);
            usersPic.SizeMode = PictureBoxSizeMode.Zoom;
            usersPic.TabIndex = 37;
            usersPic.TabStop = false;
            // 
            // existUsrsGridView
            // 
            existUsrsGridView.Anchor = AnchorStyles.None;
            existUsrsGridView.BackgroundColor = Color.Snow;
            existUsrsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            existUsrsGridView.Location = new Point(87, 481);
            existUsrsGridView.Name = "existUsrsGridView";
            existUsrsGridView.RowHeadersWidth = 51;
            existUsrsGridView.RowTemplate.Height = 29;
            existUsrsGridView.Size = new Size(1333, 452);
            existUsrsGridView.TabIndex = 36;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(27, 156, 133);
            panel5.Controls.Add(existUserLbl);
            panel5.Location = new Point(1120, 418);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 45);
            panel5.TabIndex = 35;
            // 
            // existUserLbl
            // 
            existUserLbl.Anchor = AnchorStyles.None;
            existUserLbl.AutoSize = true;
            existUserLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            existUserLbl.ForeColor = Color.Snow;
            existUserLbl.Location = new Point(10, 4);
            existUserLbl.Name = "existUserLbl";
            existUserLbl.Size = new Size(209, 31);
            existUserLbl.TabIndex = 0;
            existUserLbl.Text = "الموردون الموجودون";
            // 
            // AddSupplierPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(usersPic);
            Controls.Add(existUsrsGridView);
            Controls.Add(panel5);
            Controls.Add(saveSupplierBtn);
            Controls.Add(SupAddressLbl);
            Controls.Add(SupAddressBox);
            Controls.Add(contractDate);
            Controls.Add(contractDateBox);
            Controls.Add(SupMailLbl);
            Controls.Add(SupPhoneLbl);
            Controls.Add(SupNameLbl);
            Controls.Add(nameUserBox);
            Controls.Add(SupCodeLbl);
            Controls.Add(SupCodeBox);
            Controls.Add(SupMailBox);
            Controls.Add(SupPhoneBox);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(1496, 949);
            Name = "AddSupplierPage";
            Size = new Size(1496, 949);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)existUsrsGridView).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label SupMailLbl;
        private Label SupPhoneLbl;
        private Label SupNameLbl;
        private TextBox nameUserBox;
        private Label SupCodeLbl;
        private TextBox SupCodeBox;
        private TextBox SupMailBox;
        private TextBox SupPhoneBox;
        private DateTimePicker contractDateBox;
        private Label contractDate;
        private Label SupAddressLbl;
        private TextBox SupAddressBox;
        private Button saveSupplierBtn;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox textBox2;
        private PictureBox usersPic;
        private DataGridView existUsrsGridView;
        private Panel panel5;
        private Label existUserLbl;
    }
}
