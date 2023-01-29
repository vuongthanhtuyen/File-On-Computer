namespace QuanLysQuaCafe
{
    partial class fTableManeger
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adiminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cbSwicthTable = new System.Windows.Forms.ComboBox();
            this.btnChuyenban = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.nmFoodcount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodcount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adiminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(941, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adiminToolStripMenuItem
            // 
            this.adiminToolStripMenuItem.Name = "adiminToolStripMenuItem";
            this.adiminToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.adiminToolStripMenuItem.Text = "Adim";
            this.adiminToolStripMenuItem.Click += new System.EventHandler(this.adimToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(449, 116);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 299);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Location = new System.Drawing.Point(2, 0);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(2);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(460, 297);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 100;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.cbSwicthTable);
            this.panel3.Controls.Add(this.btnChuyenban);
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Location = new System.Drawing.Point(449, 419);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 92);
            this.panel3.TabIndex = 3;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.txtTotalPrice.Location = new System.Drawing.Point(215, 21);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(135, 30);
            this.txtTotalPrice.TabIndex = 9;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbSwicthTable
            // 
            this.cbSwicthTable.FormattingEnabled = true;
            this.cbSwicthTable.Location = new System.Drawing.Point(7, 43);
            this.cbSwicthTable.Margin = new System.Windows.Forms.Padding(2);
            this.cbSwicthTable.Name = "cbSwicthTable";
            this.cbSwicthTable.Size = new System.Drawing.Size(107, 31);
            this.cbSwicthTable.TabIndex = 6;
            // 
            // btnChuyenban
            // 
            this.btnChuyenban.Location = new System.Drawing.Point(7, 8);
            this.btnChuyenban.Margin = new System.Windows.Forms.Padding(2);
            this.btnChuyenban.Name = "btnChuyenban";
            this.btnChuyenban.Size = new System.Drawing.Size(107, 31);
            this.btnChuyenban.TabIndex = 8;
            this.btnChuyenban.Text = "Chuyển bàn";
            this.btnChuyenban.UseVisualStyleBackColor = true;
            this.btnChuyenban.Click += new System.EventHandler(this.btnChuyenban_Click);
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(118, 43);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(7);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(92, 30);
            this.nmDiscount.TabIndex = 6;
            this.nmDiscount.UseWaitCursor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(11151, 4395);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(420, 495, 420, 495);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(7368, 30);
            this.numericUpDown1.TabIndex = 7;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(118, 8);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(92, 31);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckOut.Location = new System.Drawing.Point(355, 4);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(107, 64);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // CbCategory
            // 
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(7, 2);
            this.CbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(287, 31);
            this.CbCategory.TabIndex = 1;
            this.CbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmCount);
            this.panel4.Controls.Add(this.nmFoodcount);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.CbCategory);
            this.panel4.Location = new System.Drawing.Point(449, 30);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 73);
            this.panel4.TabIndex = 4;
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(415, 19);
            this.nmCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(49, 30);
            this.nmCount.TabIndex = 5;
            this.nmCount.UseWaitCursor = true;
            this.nmCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmFoodcount
            // 
            this.nmFoodcount.Location = new System.Drawing.Point(1249, 80);
            this.nmFoodcount.Margin = new System.Windows.Forms.Padding(12);
            this.nmFoodcount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodcount.Name = "nmFoodcount";
            this.nmFoodcount.Size = new System.Drawing.Size(187, 30);
            this.nmFoodcount.TabIndex = 4;
            this.nmFoodcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(301, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 64);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm Món";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(7, 37);
            this.cbFood.Margin = new System.Windows.Forms.Padding(2);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(287, 31);
            this.cbFood.TabIndex = 2;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(17, 29);
            this.flpTable.Margin = new System.Windows.Forms.Padding(2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(413, 474);
            this.flpTable.TabIndex = 5;
            // 
            // fTableManeger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 522);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManeger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mền quản lý quán cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adiminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel3;
        private ComboBox cbSwicthTable;
        private Button btnChuyenban;
        private NumericUpDown nmDiscount;
        private NumericUpDown numericUpDown1;
        private Button btnDiscount;
        private Button btnCheckOut;
        private ComboBox CbCategory;
        private Panel panel4;
        private NumericUpDown nmCount;
        private NumericUpDown nmFoodcount;
        private Button btnAdd;
        private ComboBox cbFood;
        private FlowLayoutPanel flpTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtTotalPrice;
    }
}