namespace bai_3_10_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpProductInfo;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private NumericUpDown nudQuantity;
        private TextBox txtCategory;
        private GroupBox grpFunctions;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnShowAll;
        private DataGridView dgvProducts;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpProductInfo = new GroupBox();
            lblProductId = new Label();
            lblProductName = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            lblCategory = new Label();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtUnitPrice = new TextBox();
            nudQuantity = new NumericUpDown();
            txtCategory = new TextBox();
            grpFunctions = new GroupBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            grpProductInfo.SuspendLayout();
            grpFunctions.SuspendLayout();
            SuspendLayout();

            grpProductInfo.Text = "Thông tin sản phẩm";
            grpProductInfo.Location = new Point(12, 12);
            grpProductInfo.Size = new Size(776, 135);
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(20, 30);
            lblProductId.Text = "Mã SP:";
            txtProductId.Location = new Point(95, 27);
            txtProductId.Size = new Size(180, 23);
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(310, 30);
            lblProductName.Text = "Tên SP:";
            txtProductName.Location = new Point(385, 27);
            txtProductName.Size = new Size(350, 23);
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(20, 72);
            lblUnitPrice.Text = "Đơn giá:";
            txtUnitPrice.Location = new Point(95, 69);
            txtUnitPrice.Size = new Size(180, 23);
            txtUnitPrice.TextAlign = HorizontalAlignment.Right;
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(310, 72);
            lblQuantity.Text = "Số lượng:";
            nudQuantity.Location = new Point(385, 69);
            nudQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudQuantity.Size = new Size(120, 23);
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(535, 72);
            lblCategory.Text = "Danh mục:";
            txtCategory.Location = new Point(610, 69);
            txtCategory.Size = new Size(125, 23);
            grpProductInfo.Controls.AddRange(new Control[] { lblProductId, txtProductId, lblProductName, txtProductName, lblUnitPrice, txtUnitPrice, lblQuantity, nudQuantity, lblCategory, txtCategory });

            grpFunctions.Text = "Chức năng";
            grpFunctions.Location = new Point(12, 153);
            grpFunctions.Size = new Size(776, 62);
            btnAdd.Location = new Point(20, 23);
            btnAdd.Size = new Size(90, 27);
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Location = new Point(120, 23);
            btnEdit.Size = new Size(90, 27);
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Location = new Point(220, 23);
            btnDelete.Size = new Size(90, 27);
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(345, 29);
            lblSearch.Text = "Tìm theo tên SP:";
            txtSearch.Location = new Point(455, 26);
            txtSearch.Size = new Size(150, 23);
            txtSearch.KeyDown += txtSearch_KeyDown;
            btnSearch.Location = new Point(615, 23);
            btnSearch.Size = new Size(70, 27);
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            btnShowAll.Location = new Point(690, 23);
            btnShowAll.Size = new Size(70, 27);
            btnShowAll.Text = "Tất cả";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            grpFunctions.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnDelete, lblSearch, txtSearch, btnSearch, btnShowAll });

            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.Window;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 225);
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(776, 213);
            dgvProducts.CellClick += dgvProducts_CellClick;

            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducts);
            Controls.Add(grpFunctions);
            Controls.Add(grpProductInfo);
            MinimumSize = new Size(816, 489);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh sách sản phẩm";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            grpProductInfo.ResumeLayout(false);
            grpProductInfo.PerformLayout();
            grpFunctions.ResumeLayout(false);
            grpFunctions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
