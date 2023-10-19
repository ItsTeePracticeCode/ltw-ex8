using QLTV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using DevExpress.Utils.Win.Hook;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace QLTV
{
    public partial class frmSach : Form
    {
        static QLTVDBContext context = new QLTVDBContext();

        List<SACH> bookList = context.SACHes.ToList();

        public frmSach()
        {
            InitializeComponent();
            BingdingToGridView(bookList);
        }


        public void BingdingToGridView(List<SACH> saches)
        {
            // xoa toan bi gridview
            dgvQLS.Rows.Clear();

            // do du lieu xuong 
            foreach (var item in saches)
            {
                int index = dgvQLS.Rows.Add(); // them 1 dong moi
                dgvQLS.Rows[index].Cells[0].Value = item.MaSach;
                dgvQLS.Rows[index].Cells[1].Value = item.TenSach;
                dgvQLS.Rows[index].Cells[2].Value = item.TacGia;
                dgvQLS.Rows[index].Cells[3].Value = item.NamXuatBan;
                dgvQLS.Rows[index].Cells[4].Value = item.NhaXuatBan;
                dgvQLS.Rows[index].Cells[5].Value = item.TriGia;
                dgvQLS.Rows[index].Cells[6].Value = item.NgayNhap;
            }
            txtSLS.Text = (dgvQLS.Rows.Count - 1).ToString();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            txtMaSach.Enabled = false;
            txtSLS.Enabled = false;
        }

        public bool checkNull()
        {
            if (txtNamXB.Text == "" || txtTenSach.Text == "" || txtNhaXB.Text == "" || txtTacGia.Text == "" || txtTriGia.Text == "")
                return true;
            return false;
        }

        public void AddSach(SACH s)
        {
            context.SACHes.Add(s);
            context.SaveChanges();
            MessageBox.Show("Thêm thành công Sách: " + s.TenSach, "Thông báo", MessageBoxButtons.OK);
        }

        public void Reset()
        {
            txtMaSach.Text = string.Empty;
            txtTenSach.Text = string.Empty;
            txtNamXB.Text = string.Empty;
            txtNhaXB.Text = string.Empty;
            txtTacGia.Text = string.Empty;
            txtTriGia.Text = string.Empty;
            dtpNgayNhap.Value = DateTime.Now;
            chkNgayNhap.Checked = false;
            chkNam.Checked = false;
            chkThang.Checked = false;
            chkNgay.Checked = false;
            chkNamXB.Checked = false;
            chkTriGia.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkNull())
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SACH s = new SACH()
                    {

                        TenSach = txtTenSach.Text,
                        TacGia = txtTacGia.Text,
                        NamXuatBan = int.Parse(txtNamXB.Text),
                        NhaXuatBan = txtNhaXB.Text,
                        TriGia = Math.Round(float.Parse(txtTriGia.Text),3),
                        NgayNhap = dtpNgayNhap.Value,
                    };
                    AddSach(s);
                    var saches = context.SACHes.ToList();
                    BingdingToGridView(saches);
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaSach.Text)) // Kiểm tra xem có hàng nào được chọn hay không
                {
                    int rowIndex = dgvQLS.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvQLS.Rows[rowIndex];
                    int maSach = (int)selectedRow.Cells["dgvMaSach"].Value; // Lấy mã sách từ hàng được chọn

                    var deletedBook = context.SACHes.FirstOrDefault(s => s.MaSach == (maSach));
                    if (deletedBook != null)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            context.SACHes.Remove(deletedBook);
                            context.SaveChanges();
                            var books = context.SACHes.ToList();
                            BingdingToGridView(books);
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                            Reset();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sách cần xóa không tồn tại!", "Thông Báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hàng cần xóa trong danh sách!", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void tbnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaSach.Text)) // Kiểm tra xem có hàng nào được chọn hay không
                {
                    int rowIndex = dgvQLS.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvQLS.Rows[rowIndex];
                    int maSach = (int)selectedRow.Cells["dgvMaSach"].Value; // Lấy mã sách từ hàng được chọn

                    var updateSach = context.SACHes.FirstOrDefault(s => s.MaSach.Equals(maSach));
                    if (updateSach != null)
                    {
                        if (checkNull())
                        {
                            MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        DialogResult result = MessageBox.Show("Bạn có muốn cập nhật không?", "Thông Báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            updateSach.TenSach = txtTenSach.Text;
                            updateSach.TacGia = txtTacGia.Text;
                            updateSach.NamXuatBan = int.Parse(txtNamXB.Text);
                            updateSach.NhaXuatBan = txtNhaXB.Text;
                            updateSach.TriGia = Math.Round(float.Parse(txtTriGia.Text),3);
                            updateSach.NgayNhap = dtpNgayNhap.Value;
                            context.SaveChanges();
                            var books = context.SACHes.ToList();
                            BingdingToGridView(books);
                            MessageBox.Show("Cập nhật thông tin thành công ", "Thông báo", MessageBoxButtons.OK);
                            Reset();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hàng cần sửa ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

       private string RemoveDiacritics(string text)
       {
            //chuyển đổi các ký tự có dấu thành dạng phân tách (decomposed form),
            //trong đó ký tự cơ sở và dấu thanh được phân tách thành các ký tự riêng lẻ.
            string decomposed = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            //Duyệt qua từng ký tự trong chuỗi đã được chuẩn hóa (decomposed).
            foreach (char c in decomposed)
            {
                // ký tự hiện tại có phải là một dấu thanh hay không
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    if (c == 'đ' || c == 'Đ' || c == 'Ð')
                    {
                        sb.Append('d');
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
            }
            //gộp các ký tự cơ sở và dấu thanh thành các ký tự hoàn chỉnh.
            string result = sb.ToString().Normalize(NormalizationForm.FormC);
            result = Regex.Replace(result, "[^\\p{L}\\p{N}]", ""); // Chỉ giữ lại chữ cái và chữ số
            return result.ToLower();
       }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            List<SACH> kq2 = bookList;

            if (!string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                string tensach = txtTenSach.Text.Trim();
                tensach = RemoveDiacritics(tensach);
                List<SACH> kq = kq2.Where(s => RemoveDiacritics(s.TenSach).Contains(tensach)).ToList();
                kq2 = kq;
            }
            if(!string.IsNullOrWhiteSpace(txtTacGia.Text))
            {
                string tacgia = txtTacGia.Text.ToString();
                tacgia = RemoveDiacritics(tacgia);
                List<SACH> kq = kq2.Where(s => RemoveDiacritics(s.TacGia).Contains(tacgia)).ToList();
                kq2 = kq;
            }
            if (!string.IsNullOrWhiteSpace(txtNamXB.Text))
            {
                int namxb = int.Parse(txtNamXB.Text);
                List<SACH> kq = kq2.Where(s => s.NamXuatBan == namxb).ToList();
                kq2 = kq;
            }
            if (!string.IsNullOrWhiteSpace(txtNhaXB.Text))
            {
                string nhaxb = txtNhaXB.Text.ToString();
                nhaxb = RemoveDiacritics(nhaxb);
                List<SACH> kq = kq2.Where(s => RemoveDiacritics(s.NhaXuatBan).Contains(nhaxb)).ToList();
                kq2 = kq;
            }
            if (!string.IsNullOrWhiteSpace(txtTriGia.Text))
            {
                float trigia = float.Parse(txtTriGia.Text);
                List<SACH> kq = kq2.Where(s => s.TriGia == trigia).ToList();
                kq2 = kq;
            }
            if (chkNgayNhap.Checked)
            {
                List<SACH> kq = kq2.Where(s =>
                    s.NgayNhap.Value.Year == dtpNgayNhap.Value.Year &&
                    s.NgayNhap.Value.Month == dtpNgayNhap.Value.Month &&
                    s.NgayNhap.Value.Day == dtpNgayNhap.Value.Day).ToList();
                kq2 = kq;
            }
            if(checkNull() && !chkNgayNhap.Checked)
            {
                MessageBox.Show("Không có dữ liệu tìm kiếm sẽ trả về bảng chính", "Thông báo", MessageBoxButtons.OK);
            }
            BingdingToGridView(kq2);
        }


        private void dgvQLS_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvQLS.SelectedCells[0].RowIndex;
            if (index >= 0 && index < dgvQLS.Rows.Count - 1)
            {
                txtMaSach.Text = dgvQLS.Rows[index].Cells[0].Value.ToString();
                txtTenSach.Text = dgvQLS.Rows[index].Cells[1].Value.ToString();
                txtTacGia.Text = dgvQLS.Rows[index].Cells[2].Value.ToString();
                txtNamXB.Text = dgvQLS.Rows[index].Cells[3].Value.ToString();
                txtNhaXB.Text = dgvQLS.Rows[index].Cells[4].Value.ToString();
                txtTriGia.Text = dgvQLS.Rows[index].Cells[5].Value.ToString();
                string ngayNhapStr = dgvQLS.Rows[index].Cells[6].Value.ToString();
                DateTime ngayNhap;
                if (DateTime.TryParse(ngayNhapStr, out ngayNhap))
                {
                    dtpNgayNhap.Value = ngayNhap;
                }
            }
            else
            {
                Reset();
            }
        }

        private void txtNamXB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamXB.Text))
            {
                return;
            }

            // Kiểm tra xem nội dung của TextBox có phải là số không
            if (!int.TryParse(txtNamXB.Text, out int enteredYear))
            {
                MessageBox.Show("Chỉ được nhập số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamXB.Text = "0"; // Xóa nội dung không hợp lệ
                txtNamXB.SelectAll();
                return;
            }
            // Kiểm tra xem số đã nhập có lớn hơn năm hiện tại không
            int currentYear = DateTime.Now.Year;
            if (enteredYear >= currentYear)
            {
                MessageBox.Show("Năm xuất bản phải bé hơn năm hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamXB.Text = "0"; // Xóa nội dung không hợp lệ
                txtNamXB.SelectAll();
                return;
            }
        }

        private void txtTriGia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTriGia.Text))
            {
                return;
            }

            if (!float.TryParse(txtTriGia.Text, out float TriGia))
            {
                MessageBox.Show("Chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTriGia.Text = "0"; // Xóa nội dung không hợp lệ
                txtTriGia.SelectAll();
                return;
            }
        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            DateTime ktNgay = dtpNgayNhap.Value;

            if (ktNgay > DateTime.Now)
            {
                MessageBox.Show("Ngày nhập không được lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayNhap.Value = DateTime.Now; // Đặt lại ngày hiện tại
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            BingdingToGridView(bookList);
            MessageBox.Show("Reset form thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            List<SACH> Loc = bookList;

            if (chkNam.Checked)
            {
                List<SACH> kq = Loc.Where(s => s.NgayNhap.Value.Year == dtpNgayNhap.Value.Year).ToList();
                Loc = kq;
            }
            if (chkThang.Checked)
            {
                List<SACH> kq = Loc.Where(s => s.NgayNhap.Value.Month == dtpNgayNhap.Value.Month).ToList();
                Loc = kq;
            }
            if (chkNgay.Checked)
            {
                List<SACH> kq = Loc.Where(s => s.NgayNhap.Value.Day == dtpNgayNhap.Value.Day).ToList();
                Loc = kq;
            }
            if (chkNamXB.Checked)
            {
                if(!string.IsNullOrEmpty(txtNamXB.Text))
                {
                    List<SACH> kq = Loc.Where(s => s.NamXuatBan >= int.Parse(txtNamXB.Text)).ToList();
                    Loc = kq;
                }
                else
                {
                    MessageBox.Show("Chưa nhập năm xuất bản","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            if (chkTriGia.Checked)
            {
                if (!string.IsNullOrEmpty(txtTriGia.Text))
                {
                    List<SACH> kq = Loc.Where(s => s.TriGia >= float.Parse(txtTriGia.Text)).ToList();
                    Loc = kq;
                }
                else
                {
                    MessageBox.Show("Chưa nhập trị giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!chkNam.Checked && !chkThang.Checked && !chkNgay.Checked && !chkNamXB.Checked && !chkTriGia.Checked)
            {
                MessageBox.Show("Không có dữ liệu để lọc sẽ trả về bảng chính", "Thông báo", MessageBoxButtons.OK);
            }
            BingdingToGridView(Loc);
        }
    }
}
