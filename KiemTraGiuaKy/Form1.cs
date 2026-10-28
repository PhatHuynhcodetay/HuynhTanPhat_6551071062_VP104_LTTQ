using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace KiemTraGiuaKy
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Server=localhost;Database=DuLieu_NhanSu;Integrated Security=True;TrustServerCertificate=True";

        private string maNVChonDeSua = "";

        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaNhanVien, TenNhanVien, LuongCoBan FROM NhanVien";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvNhanVien.DataSource = dt;
                    }
                }
                if (dgvNhanVien.Columns["MaNhanVien"] != null)
                    dgvNhanVien.Columns["MaNhanVien"]!.HeaderText = "Mã Nhân Viên";

                if (dgvNhanVien.Columns["TenNhanVien"] != null)
                    dgvNhanVien.Columns["TenNhanVien"]!.HeaderText = "Tên Nhân Viên";

                if (dgvNhanVien.Columns["LuongCoBan"] != null)
                    dgvNhanVien.Columns["LuongCoBan"]!.HeaderText = "Lương Cơ Bản";

                dgvNhanVien.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLuongCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;
            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                !txtLuongCB.Text.Contains('.') &&
                !txtLuongCB.Text.Contains(','))
            {
                return;
            }
            e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string luongCB = txtLuongCB.Text.Trim();

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(luongCB))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu vào các ô TextBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(maNV)) txtMaNV.Focus();
                else if (string.IsNullOrEmpty(tenNV)) txtTenNV.Focus();
                else txtLuongCB.Focus();
                return;
            }

            if (KiemTraTrungMaNV(maNV))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập lại!", "Trùng mã nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                txtMaNV.SelectAll();
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertSql = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, LuongCoBan) VALUES (@MaNV, @TenNV, @LuongCB)";
                    using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@TenNV", tenNV);
                        cmd.Parameters.AddWithValue("@LuongCB", luongCB);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();    
                XoaRongTextBox();
                btnThem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool KiemTraTrungMaNV(string maNV)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @MaNV";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        object? result = cmd.ExecuteScalar();
                        int count = result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra mã nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                if (row.Cells["MaNhanVien"]?.Value != null)
                {
                    maNVChonDeSua = row.Cells["MaNhanVien"].Value!.ToString() ?? "";

                    txtMaNV.Text = maNVChonDeSua;
                    txtTenNV.Text = row.Cells["TenNhanVien"].Value?.ToString() ?? "";
                    txtLuongCB.Text = row.Cells["LuongCoBan"].Value?.ToString() ?? "";

                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    txtMaNV.ReadOnly = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có muốn xóa nhân viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string deleteSql = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNV";
                        using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", maNV);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            XoaRongTextBox();
            txtMaNV.ReadOnly = false;
            maNVChonDeSua = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = string.IsNullOrEmpty(maNVChonDeSua) ? txtMaNV.Text.Trim() : maNVChonDeSua;
            string tenNV = txtTenNV.Text.Trim();
            string luongCB = txtLuongCB.Text.Trim();

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(luongCB))
            {
                MessageBox.Show("Vui lòng không để trống thông tin Tên nhân viên và Lương cơ bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateSql = "UPDATE NhanVien SET TenNhanVien = @TenNV, LuongCoBan = @LuongCB WHERE MaNhanVien = @MaNV";
                    using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenNV", tenNV);
                        cmd.Parameters.AddWithValue("@LuongCB", luongCB);
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            XoaRongTextBox();
            txtMaNV.ReadOnly = false;
            maNVChonDeSua = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void XoaRongTextBox()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtLuongCB.Clear();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (!btnSua.Enabled && !btnXoa.Enabled && !btnThem.Enabled && !string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                btnThem.Enabled = true;
            }
        }
        
    }
}
