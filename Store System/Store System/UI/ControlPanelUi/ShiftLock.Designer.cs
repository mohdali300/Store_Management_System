namespace Store_System.UI.ControlPanelUi
{
    partial class ShiftLock
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
            panel1 = new Panel();
            label1 = new Label();
            label11 = new Label();
            DiscountBox = new TextBox();
            label10 = new Label();
            PriceBox = new TextBox();
            Addbtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1274, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 49);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(35, 2);
            label1.Name = "label1";
            label1.Size = new Size(162, 38);
            label1.TabIndex = 0;
            label1.Text = "تقفيل شيفت";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(1042, 135);
            label11.Name = "label11";
            label11.Size = new Size(105, 23);
            label11.TabIndex = 64;
            label11.Text = "خزنة مستخدم";
            // 
            // DiscountBox
            // 
            DiscountBox.Anchor = AnchorStyles.None;
            DiscountBox.BackColor = Color.FromArgb(24, 30, 46);
            DiscountBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DiscountBox.ForeColor = Color.White;
            DiscountBox.Location = new Point(934, 153);
            DiscountBox.Name = "DiscountBox";
            DiscountBox.RightToLeft = RightToLeft.Yes;
            DiscountBox.Size = new Size(209, 34);
            DiscountBox.TabIndex = 65;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(1319, 135);
            label10.Name = "label10";
            label10.Size = new Size(93, 23);
            label10.TabIndex = 62;
            label10.Text = "خزنة رئيسية";
            // 
            // PriceBox
            // 
            PriceBox.Anchor = AnchorStyles.None;
            PriceBox.BackColor = Color.FromArgb(24, 30, 46);
            PriceBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceBox.ForeColor = Color.White;
            PriceBox.Location = new Point(1188, 153);
            PriceBox.Name = "PriceBox";
            PriceBox.RightToLeft = RightToLeft.Yes;
            PriceBox.Size = new Size(209, 34);
            PriceBox.TabIndex = 63;
            // 
            // Addbtn
            // 
            Addbtn.Anchor = AnchorStyles.None;
            Addbtn.BackColor = Color.LimeGreen;
            Addbtn.FlatStyle = FlatStyle.Flat;
            Addbtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            Addbtn.ForeColor = Color.White;
            Addbtn.Location = new Point(1033, 316);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(278, 38);
            Addbtn.TabIndex = 82;
            Addbtn.Text = "تقفيل الشيفت";
            Addbtn.UseVisualStyleBackColor = false;
            // 
            // ShiftLock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(Addbtn);
            Controls.Add(label11);
            Controls.Add(DiscountBox);
            Controls.Add(label10);
            Controls.Add(PriceBox);
            Controls.Add(panel1);
            Name = "ShiftLock";
            Size = new Size(1496, 949);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label11;
        private TextBox DiscountBox;
        private Label label10;
        private TextBox PriceBox;
        private Button Addbtn;
    }
}
