using HomeService_NhuMyStudio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeService_NhuMyStudio
{
    public partial class frmRename : Form
    {
        private List<FileName> jpgFiles;
        private BindingSource bindingSource;
        private BindingSource bindingSourceV2;
        private List<FileName> jpgFiles2 = new List<FileName>();
        // Biến để lưu dòng được chọn
        private DataGridViewRow selectedRow;
        private DataGridViewRow selectedRowV2;
        private int codeStart = 0;
        private string filesDot = null;
        private string mode = null;



        public frmRename()
        {
            InitializeComponent();
        }



        private void frmFilter_Load(object sender, EventArgs e)
        {
            dgvFolder.KeyPress += DgvFolder_KeyPress;
            DataGridViewTextBoxColumn fileNameColumn = new DataGridViewTextBoxColumn();
            // Đặt tên cho cột
            fileNameColumn.DataPropertyName = "TenAnh";
            fileNameColumn.HeaderText = "TenAnh";
            DataGridViewTextBoxColumn fileNameColumnV2 = new DataGridViewTextBoxColumn();
            // Đặt tên cho cột
            fileNameColumnV2.DataPropertyName = "TenAnh";
            fileNameColumnV2.HeaderText = "TenAnh";
            dgvFolder.Columns.Add(fileNameColumn);

            dgvFolder = updateDataGridView(dgvFolder);



            checkEnableAfterSelectFindFolder();
        }



        private void DgvNewFolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void DgvFolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }



        private void btnNewFolder_Click(object sender, EventArgs e)
        {

        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại chọn thư mục
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                // Nếu người dùng chọn một thư mục và nhấn OK
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    // Set lên txt
                    txtFolder.Text = folderBrowserDialog.SelectedPath.ToString();
                    // Lấy danh sách tất cả các tệp trong thư mục
                    string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                    if (filesDot == null)
                    {
                        MessageBox.Show("Bạn chưa chọn .file trong menu.");
                    }
                    if (filesDot == string.Empty)
                    {
                        selectAllFiles(files);
                        MessageBox.Show($"Tìm thấy {jpgFiles.Count} tệp {filesDot} trong thư mục đã chọn.");
                        showTable(jpgFiles);
                    }
                    else if (!string.IsNullOrWhiteSpace(filesDot))
                    {
                        selectOneFiles(files);
                        MessageBox.Show($"Tìm thấy {jpgFiles.Count} tệp {filesDot} trong thư mục đã chọn.");
                        showTable(jpgFiles);
                    }


                    checkEnableAfterSelectFindFolder();
                }
            }

        }
        private void selectAllFiles(string[] files)
        {
            jpgFiles = new List<FileName>();
            foreach (string file in files)
            {
                if (Path.GetExtension(file).Equals(".jpg", StringComparison.OrdinalIgnoreCase) ||
                    Path.GetExtension(file).Equals(".cr3", StringComparison.OrdinalIgnoreCase) ||
                    Path.GetExtension(file).Equals(".png", StringComparison.OrdinalIgnoreCase) ||
                    Path.GetExtension(file).Equals(".jpeg", StringComparison.OrdinalIgnoreCase))
                {
                    // Lấy chỉ tên của tệp và thêm vào danh sách jpgFiles
                    string fileName = Path.GetFileName(file);
                    jpgFiles.Add(new FileName
                    {
                        TenAnh = fileName,
                    });
                }
            }
        }
        private void selectOneFiles(string[] files)
        {
            jpgFiles = new List<FileName>();
            foreach (string file in files)
            {
                if (Path.GetExtension(file).Equals(filesDot, StringComparison.OrdinalIgnoreCase))
                {
                    // Lấy chỉ tên của tệp và thêm vào danh sách jpgFiles
                    string fileName = Path.GetFileName(file);
                    jpgFiles.Add(new FileName
                    {
                        TenAnh = fileName,
                    });
                }
            }
        }
        private void showTable(List<FileName> list)
        {

            bindingSource = new BindingSource();
            bindingSource.DataSource = list;
            dgvFolder.DataSource = null;
            dgvFolder.DataSource = bindingSource;
            dgvFolder.Height = list.Count * 24;
            dgvFolder.ClearSelection();
        }
        private DataGridView updateDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.BorderStyle = BorderStyle.None;

            //important
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            int maxRows = 12;
            int rowHeight = dgv.RowTemplate.Height;
            int headerHeight = dgv.ColumnHeadersHeight;
            int totalRowHeight = rowHeight * maxRows + headerHeight;

            dgv.MaximumSize = new Size(int.MaxValue, totalRowHeight);
            dgv.AllowUserToAddRows = false;

            dgv.AllowUserToDeleteRows = false;

            dgv.AllowUserToOrderColumns = false;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgv.RowHeadersVisible = false;

            // Bỏ thanh header
            dgv.ColumnHeadersVisible = false;

            // Bỏ cột kéo lên xuống
            dgv.AllowUserToOrderColumns = false;
            //dgv.ScrollBars = ScrollBars.;











            dgv.ReadOnly = true;

            dgv.DefaultCellStyle.BackColor = Color.Pink;

            return dgv;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtFolder_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắn chắn lưu tại folder này không?", "Xác nhận", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                // Kiểm tra xem đã chọn thư mục lưu trữ chưa
                if (string.IsNullOrWhiteSpace(txtFolder.Text))
                {
                    MessageBox.Show("Bạn chưa chọn folder để lưu mới tập tin.");
                    return;
                }
                if (dgvFolder.Rows.Count > 0)
                {
                    // Lưu đường dẫn thư mục đã chọn
                    string exportFolderPath = txtFolder.Text;

                    // Lưu tất cả các file ảnh .jpg từ DataGridView vào thư mục đã chọn
                    foreach (DataGridViewRow row in dgvFolder.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {

                            string fileName = row.Cells[0].Value.ToString(); // Điều chỉnh tên cột nếu cần

                            // Kiểm tra xem tệp có tồn tại không trước khi sao chép
                            string sourceFilePath = Path.Combine(exportFolderPath, fileName);
                            if (File.Exists(sourceFilePath))
                            {
                                fileName = txtFileName.Text + codeStart.ToString() + Path.GetExtension(fileName);

                                string destinationFilePath = Path.Combine(exportFolderPath, fileName);
                                File.Move(sourceFilePath, destinationFilePath);
                                
                            }
                            else
                            {
                                MessageBox.Show($"File '{fileName}' không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        codeStart++;
                    }
                    MessageBox.Show($"Tất cả ảnh đã đổi tên: format {txtFileName.Text}:CodeStart++", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearEXPORTAfterSave();

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ảnh để thêm vào folder mới này");
                }
            }
        }
        private void clearEXPORTAfterSave()
        {
            // delete dgv
            dgvFolder.Rows.Clear();

            // Vô hiệu hóa checkbox trên các dòng đã chọn trong dgvFolder

        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn khởi động lại không?", "Xác nhận", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                dgvFolder.Rows.Clear();
                txtFolder.Text = string.Empty;
                checkEnableAfterSelectFindFolder();
            }
        }



        private void btnSelectAll_Click(object sender, EventArgs e)
        {

        }



        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
        }

        private void btnReviewFolder_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã có đường dẫn thư mục được chọn từ trước không
            if (!string.IsNullOrEmpty(txtFolder.Text))
            {
                // Mở thư mục được chọn trên máy tính của bạn
                Process.Start(txtFolder.Text);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thư mục nào để review.");
            }
        }

        private void btnReviewNewFolder_Click(object sender, EventArgs e)
        {
        }
        private void checkEnableAfterSelectFindFolder()
        {
            if (txtFolder.Text == string.Empty || filesDot == null)
            {
                txtFolder.Text = string.Empty;
                btnReviewFolder.Enabled = false;
            }
            else
            {
                btnReviewFolder.Enabled = true;
            }
        }


        private void btnCr3_Click(object sender, EventArgs e)
        {
            // Bỏ chọn tất cả các button khác
            btnJpg.Checked = false;
            btnAll.Checked = false;

            // Đặt button hiện tại thành đã chọn
            btnCr3.Checked = true;

            // Cập nhật giá trị filesDot
            filesDot = ".cr3";
        }

        private void btnJpg_Click(object sender, EventArgs e)
        {
            // Bỏ chọn tất cả các button khác
            btnCr3.Checked = false;
            btnAll.Checked = false;

            // Đặt button hiện tại thành đã chọn
            btnJpg.Checked = true;

            // Cập nhật giá trị filesDot
            filesDot = ".jpg";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            // Bỏ chọn tất cả các button khác
            btnCr3.Checked = false;
            btnJpg.Checked = false;

            // Đặt button hiện tại thành đã chọn
            btnAll.Checked = true;

            // Cập nhật giá trị filesDot
            filesDot = "";
        }

        private void btnFile_Click(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }

        private void btnCut_Click(object sender, EventArgs e)
        {

        }

        private void dgvNewFolder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cr3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvFolder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodeStart_TextChanged(object sender, EventArgs e)
        {
            codeStart = Convert.ToInt32(txtCodeStart.Text);
        }
    }
}
