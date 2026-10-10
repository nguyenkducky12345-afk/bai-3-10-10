namespace bai_3_10_10
{
    public partial class Form1 : Form
    {
        private readonly List<Product> products = new();
        private readonly BindingSource productBindingSource = new();

        public Form1()
        {
            InitializeComponent();
            productBindingSource.DataSource = products;
            dgvProducts.DataSource = productBindingSource;
            ConfigureGridColumns();
        }

        private void ConfigureGridColumns()
        {
            if (dgvProducts.Columns.Count == 0)
            {
                return;
            }

            dgvProducts.Columns[nameof(Product.ProductId)].HeaderText = "Mã SP";
            dgvProducts.Columns[nameof(Product.ProductName)].HeaderText = "Tên SP";
            dgvProducts.Columns[nameof(Product.UnitPrice)].HeaderText = "Đơn giá";
            dgvProducts.Columns[nameof(Product.Quantity)].HeaderText = "Số lượng";
            dgvProducts.Columns[nameof(Product.Category)].HeaderText = "Danh mục";
            dgvProducts.Columns[nameof(Product.UnitPrice)].DefaultCellStyle.Format = "N0";
        }

        private bool TryReadProduct(out Product product)
        {
            product = new Product();
            string productId = txtProductId.Text.Trim();
            string productName = txtProductName.Text.Trim();
            string category = txtCategory.Text.Trim();

            if (string.IsNullOrWhiteSpace(productId) || string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã, tên và danh mục sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return false;
            }

            product = new Product
            {
                ProductId = productId,
                ProductName = productName,
                UnitPrice = unitPrice,
                Quantity = (int)nudQuantity.Value,
                Category = category
            };
            return true;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!TryReadProduct(out Product product))
            {
                return;
            }

            if (products.Any(item => item.ProductId.Equals(product.ProductId, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại.", "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductId.Focus();
                return;
            }

            products.Add(product);
            productBindingSource.ResetBindings(false);
            ClearInputs();
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is not Product selectedProduct)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryReadProduct(out Product updatedProduct))
            {
                return;
            }

            bool duplicateId = products.Any(item => item != selectedProduct && item.ProductId.Equals(updatedProduct.ProductId, StringComparison.OrdinalIgnoreCase));
            if (duplicateId)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại.", "Không thể sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedProduct.ProductId = updatedProduct.ProductId;
            selectedProduct.ProductName = updatedProduct.ProductName;
            selectedProduct.UnitPrice = updatedProduct.UnitPrice;
            selectedProduct.Quantity = updatedProduct.Quantity;
            selectedProduct.Category = updatedProduct.Category;
            productBindingSource.ResetBindings(false);
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is not Product selectedProduct)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa sản phẩm \"{selectedProduct.ProductName}\" không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            products.Remove(selectedProduct);
            productBindingSource.ResetBindings(false);
            ClearInputs();
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (keyword.Length == 0)
            {
                ShowAllProducts();
                return;
            }

            List<Product> filteredProducts = products
                .Where(product => product.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
            productBindingSource.DataSource = filteredProducts;
            ConfigureGridColumns();
        }

        private void btnShowAll_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            ShowAllProducts();
        }

        private void txtSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void ShowAllProducts()
        {
            productBindingSource.DataSource = products;
            productBindingSource.ResetBindings(false);
            ConfigureGridColumns();
        }

        private void dgvProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvProducts.Rows[e.RowIndex].DataBoundItem is not Product selectedProduct)
            {
                return;
            }

            txtProductId.Text = selectedProduct.ProductId;
            txtProductName.Text = selectedProduct.ProductName;
            txtUnitPrice.Text = selectedProduct.UnitPrice.ToString("0.##");
            nudQuantity.Value = Math.Min(nudQuantity.Maximum, selectedProduct.Quantity);
            txtCategory.Text = selectedProduct.Category;
        }

        private void ClearInputs()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            nudQuantity.Value = 0;
            txtCategory.Clear();
            txtProductId.Focus();
        }
    }
}
