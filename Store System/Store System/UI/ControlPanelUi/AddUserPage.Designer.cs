namespace Store_System.UI
{
    partial class AddUserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserPage));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            userCodeBox = new TextBox();
            saveUserBtn = new Button();
            stockNameLbl = new Label();
            userRoleLbl = new Label();
            passwordLbl = new Label();
            userName = new Label();
            userMailLbl = new Label();
            userPhoneLbl = new Label();
            userNameLbl = new Label();
            userCodeLbl = new Label();
            stockNameBox = new TextBox();
            userMailBox = new TextBox();
            userRoleBox = new TextBox();
            userPhoneBox = new TextBox();
            passwordBox = new TextBox();
            nameUserBox = new TextBox();
            userNameBox = new TextBox();
            panel5 = new Panel();
            existUserLbl = new Label();
            existUsrsGridView = new DataGridView();
            usersPic = new PictureBox();
            searchUserBox = new TextBox();
            saerchUserLbl = new Label();
            pictureBox2 = new PictureBox();
            deleteUserBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)existUsrsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(250, 38);
            label1.TabIndex = 0;
            label1.Text = "إضافة مستخدم جديد";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1366, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1098, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 68);
            panel1.TabIndex = 2;
            // 
            // userCodeBox
            // 
            userCodeBox.Anchor = AnchorStyles.None;
            userCodeBox.BackColor = Color.FromArgb(24, 30, 46);
            userCodeBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userCodeBox.ForeColor = Color.White;
            userCodeBox.Location = new Point(1119, 182);
            userCodeBox.Name = "userCodeBox";
            userCodeBox.RightToLeft = RightToLeft.Yes;
            userCodeBox.Size = new Size(296, 47);
            userCodeBox.TabIndex = 4;
            // 
            // saveUserBtn
            // 
            saveUserBtn.Anchor = AnchorStyles.None;
            saveUserBtn.BackColor = Color.LimeGreen;
            saveUserBtn.FlatStyle = FlatStyle.Flat;
            saveUserBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveUserBtn.ForeColor = Color.White;
            saveUserBtn.Location = new Point(284, 408);
            saveUserBtn.Name = "saveUserBtn";
            saveUserBtn.Size = new Size(194, 57);
            saveUserBtn.TabIndex = 19;
            saveUserBtn.Text = "حفظ";
            saveUserBtn.UseVisualStyleBackColor = false;
            // 
            // stockNameLbl
            // 
            stockNameLbl.Anchor = AnchorStyles.None;
            stockNameLbl.AutoSize = true;
            stockNameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            stockNameLbl.ForeColor = Color.White;
            stockNameLbl.Location = new Point(284, 272);
            stockNameLbl.Name = "stockNameLbl";
            stockNameLbl.Size = new Size(84, 23);
            stockNameLbl.TabIndex = 18;
            stockNameLbl.Text = "اسم الخزنة";
            // 
            // userRoleLbl
            // 
            userRoleLbl.Anchor = AnchorStyles.None;
            userRoleLbl.AutoSize = true;
            userRoleLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            userRoleLbl.ForeColor = Color.White;
            userRoleLbl.Location = new Point(598, 272);
            userRoleLbl.Name = "userRoleLbl";
            userRoleLbl.Size = new Size(109, 23);
            userRoleLbl.TabIndex = 17;
            userRoleLbl.Text = "دور المستخدم";
            // 
            // passwordLbl
            // 
            passwordLbl.Anchor = AnchorStyles.None;
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLbl.ForeColor = Color.White;
            passwordLbl.Location = new Point(962, 272);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(91, 23);
            passwordLbl.TabIndex = 16;
            passwordLbl.Text = "كلمة المرور";
            // 
            // userName
            // 
            userName.Anchor = AnchorStyles.None;
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            userName.ForeColor = Color.White;
            userName.Location = new Point(1333, 272);
            userName.Name = "userName";
            userName.Size = new Size(75, 23);
            userName.TabIndex = 15;
            userName.Text = "اليوزر نيم";
            // 
            // userMailLbl
            // 
            userMailLbl.Anchor = AnchorStyles.None;
            userMailLbl.AutoSize = true;
            userMailLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            userMailLbl.ForeColor = Color.White;
            userMailLbl.Location = new Point(311, 164);
            userMailLbl.Name = "userMailLbl";
            userMailLbl.Size = new Size(57, 23);
            userMailLbl.TabIndex = 14;
            userMailLbl.Text = "الايميل";
            // 
            // userPhoneLbl
            // 
            userPhoneLbl.Anchor = AnchorStyles.None;
            userPhoneLbl.AutoSize = true;
            userPhoneLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            userPhoneLbl.ForeColor = Color.White;
            userPhoneLbl.Location = new Point(620, 164);
            userPhoneLbl.Name = "userPhoneLbl";
            userPhoneLbl.Size = new Size(86, 23);
            userPhoneLbl.TabIndex = 13;
            userPhoneLbl.Text = "رقم الهاتف";
            // 
            // userNameLbl
            // 
            userNameLbl.Anchor = AnchorStyles.None;
            userNameLbl.AutoSize = true;
            userNameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLbl.ForeColor = Color.White;
            userNameLbl.Location = new Point(941, 164);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(112, 23);
            userNameLbl.TabIndex = 12;
            userNameLbl.Text = "اسم المستخدم";
            // 
            // userCodeLbl
            // 
            userCodeLbl.Anchor = AnchorStyles.None;
            userCodeLbl.AutoSize = true;
            userCodeLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            userCodeLbl.ForeColor = Color.White;
            userCodeLbl.Location = new Point(1296, 164);
            userCodeLbl.Name = "userCodeLbl";
            userCodeLbl.Size = new Size(111, 23);
            userCodeLbl.TabIndex = 1;
            userCodeLbl.Text = "كود المستخدم";
            // 
            // stockNameBox
            // 
            stockNameBox.Anchor = AnchorStyles.None;
            stockNameBox.BackColor = Color.FromArgb(24, 30, 46);
            stockNameBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            stockNameBox.ForeColor = Color.White;
            stockNameBox.Location = new Point(85, 290);
            stockNameBox.Name = "stockNameBox";
            stockNameBox.RightToLeft = RightToLeft.Yes;
            stockNameBox.Size = new Size(292, 47);
            stockNameBox.TabIndex = 11;
            // 
            // userMailBox
            // 
            userMailBox.Anchor = AnchorStyles.None;
            userMailBox.BackColor = Color.FromArgb(24, 30, 46);
            userMailBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userMailBox.ForeColor = Color.White;
            userMailBox.Location = new Point(85, 182);
            userMailBox.Name = "userMailBox";
            userMailBox.RightToLeft = RightToLeft.Yes;
            userMailBox.Size = new Size(292, 47);
            userMailBox.TabIndex = 10;
            // 
            // userRoleBox
            // 
            userRoleBox.Anchor = AnchorStyles.None;
            userRoleBox.BackColor = Color.FromArgb(24, 30, 46);
            userRoleBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userRoleBox.ForeColor = Color.White;
            userRoleBox.Location = new Point(431, 290);
            userRoleBox.Name = "userRoleBox";
            userRoleBox.RightToLeft = RightToLeft.Yes;
            userRoleBox.Size = new Size(283, 47);
            userRoleBox.TabIndex = 9;
            // 
            // userPhoneBox
            // 
            userPhoneBox.Anchor = AnchorStyles.None;
            userPhoneBox.BackColor = Color.FromArgb(24, 30, 46);
            userPhoneBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userPhoneBox.ForeColor = Color.White;
            userPhoneBox.Location = new Point(431, 182);
            userPhoneBox.Name = "userPhoneBox";
            userPhoneBox.RightToLeft = RightToLeft.Yes;
            userPhoneBox.Size = new Size(283, 47);
            userPhoneBox.TabIndex = 8;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.None;
            passwordBox.BackColor = Color.FromArgb(24, 30, 46);
            passwordBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.ForeColor = Color.White;
            passwordBox.Location = new Point(768, 290);
            passwordBox.Name = "passwordBox";
            passwordBox.RightToLeft = RightToLeft.Yes;
            passwordBox.Size = new Size(297, 47);
            passwordBox.TabIndex = 7;
            // 
            // nameUserBox
            // 
            nameUserBox.Anchor = AnchorStyles.None;
            nameUserBox.BackColor = Color.FromArgb(24, 30, 46);
            nameUserBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameUserBox.ForeColor = Color.White;
            nameUserBox.Location = new Point(768, 182);
            nameUserBox.Name = "nameUserBox";
            nameUserBox.RightToLeft = RightToLeft.Yes;
            nameUserBox.Size = new Size(297, 47);
            nameUserBox.TabIndex = 6;
            // 
            // userNameBox
            // 
            userNameBox.Anchor = AnchorStyles.None;
            userNameBox.BackColor = Color.FromArgb(24, 30, 46);
            userNameBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userNameBox.ForeColor = Color.White;
            userNameBox.Location = new Point(1119, 290);
            userNameBox.Name = "userNameBox";
            userNameBox.RightToLeft = RightToLeft.Yes;
            userNameBox.Size = new Size(296, 47);
            userNameBox.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(27, 156, 133);
            panel5.Controls.Add(existUserLbl);
            panel5.Location = new Point(1088, 408);
            panel5.Name = "panel5";
            panel5.Size = new Size(253, 57);
            panel5.TabIndex = 4;
            // 
            // existUserLbl
            // 
            existUserLbl.Anchor = AnchorStyles.None;
            existUserLbl.AutoSize = true;
            existUserLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            existUserLbl.ForeColor = Color.Snow;
            existUserLbl.Location = new Point(8, 10);
            existUserLbl.Name = "existUserLbl";
            existUserLbl.Size = new Size(242, 31);
            existUserLbl.TabIndex = 0;
            existUserLbl.Text = "المستخدمون الموجودون";
            // 
            // existUsrsGridView
            // 
            existUsrsGridView.Anchor = AnchorStyles.None;
            existUsrsGridView.BackgroundColor = Color.Snow;
            existUsrsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            existUsrsGridView.Location = new Point(85, 488);
            existUsrsGridView.Name = "existUsrsGridView";
            existUsrsGridView.RowHeadersWidth = 51;
            existUsrsGridView.RowTemplate.Height = 29;
            existUsrsGridView.Size = new Size(1330, 447);
            existUsrsGridView.TabIndex = 6;
            // 
            // usersPic
            // 
            usersPic.Anchor = AnchorStyles.None;
            usersPic.BackColor = Color.FromArgb(24, 30, 46);
            usersPic.Image = (Image)resources.GetObject("usersPic.Image");
            usersPic.Location = new Point(1353, 408);
            usersPic.Name = "usersPic";
            usersPic.Size = new Size(62, 57);
            usersPic.SizeMode = PictureBoxSizeMode.Zoom;
            usersPic.TabIndex = 20;
            usersPic.TabStop = false;
            // 
            // searchUserBox
            // 
            searchUserBox.Anchor = AnchorStyles.None;
            searchUserBox.BackColor = Color.FromArgb(24, 30, 46);
            searchUserBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            searchUserBox.ForeColor = Color.White;
            searchUserBox.Location = new Point(501, 427);
            searchUserBox.Name = "searchUserBox";
            searchUserBox.RightToLeft = RightToLeft.Yes;
            searchUserBox.Size = new Size(213, 38);
            searchUserBox.TabIndex = 21;
            // 
            // saerchUserLbl
            // 
            saerchUserLbl.Anchor = AnchorStyles.None;
            saerchUserLbl.AutoSize = true;
            saerchUserLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            saerchUserLbl.ForeColor = Color.White;
            saerchUserLbl.Location = new Point(613, 408);
            saerchUserLbl.Name = "saerchUserLbl";
            saerchUserLbl.Size = new Size(95, 23);
            saerchUserLbl.TabIndex = 22;
            saerchUserLbl.Text = "ابحث بالاسم";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(719, 427);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // deleteUserBtn
            // 
            deleteUserBtn.Anchor = AnchorStyles.None;
            deleteUserBtn.BackColor = Color.Firebrick;
            deleteUserBtn.FlatStyle = FlatStyle.Flat;
            deleteUserBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteUserBtn.ForeColor = Color.White;
            deleteUserBtn.Location = new Point(85, 408);
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.Size = new Size(183, 57);
            deleteUserBtn.TabIndex = 24;
            deleteUserBtn.Text = "حذف";
            deleteUserBtn.UseVisualStyleBackColor = false;
            deleteUserBtn.Click += deleteUserBtn_Click;
            // 
            // AddUserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(deleteUserBtn);
            Controls.Add(pictureBox2);
            Controls.Add(saerchUserLbl);
            Controls.Add(searchUserBox);
            Controls.Add(usersPic);
            Controls.Add(saveUserBtn);
            Controls.Add(pictureBox1);
            Controls.Add(stockNameLbl);
            Controls.Add(userRoleLbl);
            Controls.Add(existUsrsGridView);
            Controls.Add(passwordLbl);
            Controls.Add(userName);
            Controls.Add(userMailLbl);
            Controls.Add(panel5);
            Controls.Add(userPhoneLbl);
            Controls.Add(panel1);
            Controls.Add(userNameLbl);
            Controls.Add(nameUserBox);
            Controls.Add(userCodeLbl);
            Controls.Add(userCodeBox);
            Controls.Add(stockNameBox);
            Controls.Add(userNameBox);
            Controls.Add(userMailBox);
            Controls.Add(passwordBox);
            Controls.Add(userRoleBox);
            Controls.Add(userPhoneBox);
            MinimumSize = new Size(1496, 949);
            Name = "AddUserPage";
            Size = new Size(1496, 949);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)existUsrsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox userCodeBox;
        private Label userPhoneLbl;
        private Label userNameLbl;
        private Label userCodeLbl;
        private TextBox stockNameBox;
        private TextBox userMailBox;
        private TextBox userRoleBox;
        private TextBox userPhoneBox;
        private TextBox passwordBox;
        private TextBox nameUserBox;
        private TextBox userNameBox;
        private Label userMailLbl;
        private Label userRoleLbl;
        private Label passwordLbl;
        private Label userName;
        private Label stockNameLbl;
        private Button saveUserBtn;
        private Panel panel5;
        private Label existUserLbl;
        private DataGridView existUsrsGridView;
        private PictureBox usersPic;
        private TextBox searchUserBox;
        private Label saerchUserLbl;
        private PictureBox pictureBox2;
        private Button deleteUserBtn;
    }
}
