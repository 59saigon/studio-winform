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
    public partial class frmFilter : Form
    {
        private List<FileName> jpgFiles;
        private BindingSource bindingSource;
        private BindingSource bindingSourceV2;
        private List<FileName> jpgFiles2 = new List<FileName>();
        // Biến để lưu dòng được chọn
        private DataGridViewRow selectedRow;
        private DataGridViewRow selectedRowV2;

        private string filesDot = null;
        private string mode = null;



        public frmFilter()
        {
            InitializeComponent();
        }



        private void frmFilter_Load(object sender, EventArgs e)
        {
            dgvFolder.KeyPress += DgvFolder_KeyPress;
            dgvNewFolder.KeyPress += DgvNewFolder_KeyPress;
            DataGridViewTextBoxColumn fileNameColumn = new DataGridViewTextBoxColumn();
            // Đặt tên cho cột
            fileNameColumn.DataPropertyName = "TenAnh";
            fileNameColumn.HeaderText = "TenAnh";
            DataGridViewTextBoxColumn fileNameColumnV2 = new DataGridViewTextBoxColumn();
            // Đặt tên cho cột
            fileNameColumnV2.DataPropertyName = "TenAnh";
            fileNameColumnV2.HeaderText = "TenAnh";
            dgvFolder.Columns.Add(fileNameColumn);
            dgvNewFolder.Columns.Add(fileNameColumnV2);

            dgvFolder = updateDataGridView(dgvFolder);
            dgvNewFolder = updateDataGridView(dgvNewFolder);


            checkEnableAfterSelectFindFolder();
            checkEnableAfterSelectFindNewFolder();
        }



        private void DgvNewFolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                string exportFolderPath = txtNewFolder.Text;
                if (string.IsNullOrEmpty(exportFolderPath))
                {
                    MessageBox.Show("Bạn chưa chọn folder.");
                }
                else
                {
                    foreach (DataGridViewRow row in dgvNewFolder.SelectedRows)
                    {
                        if (!row.IsNewRow && row != null)
                        {
                            string fileName = row.Cells[0].Value.ToString();
                            if (!string.IsNullOrEmpty(fileName))
                            {
                                jpgFiles.Add(new FileName { TenAnh = fileName });
                                showTable(jpgFiles);
                                dgvNewFolder.Rows.Remove(row);
                                jpgFiles2.RemoveAll(x => x.TenAnh == fileName);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn một dòng để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            txtSearch.Text = "";

        }

        private void DgvFolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                string exportFolderPath = txtNewFolder.Text;
                if (string.IsNullOrEmpty(exportFolderPath))
                {
                    MessageBox.Show("Bạn chưa chọn folder.");
                }
                else
                {
                    foreach (DataGridViewRow row in dgvFolder.SelectedRows)
                    {
                        if (!row.IsNewRow && row != null)
                        {
                            // Lấy dữ liệu từ dòng đã chọn
                            string fileName = row.Cells[0].Value.ToString();
                            if (fileName == null)
                            {
                                MessageBox.Show("Error");
                                return;
                            }
                            if (!string.IsNullOrEmpty(fileName))
                            {
                                // Thêm dữ liệu từ dòng đã chọn vào DataGridView khác
                                // Ví dụ: Thêm vào dgvDestination
                                //check có tồn tại trong folder mới này ko
                                string destinationFilePath = Path.Combine(exportFolderPath, fileName);
                                // Kiểm tra xem tệp đích đã tồn tại hay chưa
                                if (File.Exists(destinationFilePath))
                                {
                                    MessageBox.Show($"Tệp {fileName} này đã tồn tại trong folder mới.");
                                }
                                else
                                {
                                    FileName file = new FileName { TenAnh = fileName };
                                    jpgFiles2.Add(file);
                                    showTable2(jpgFiles2);
                                    dgvFolder.Rows.Remove(row);
                                    jpgFiles.RemoveAll(x => x.TenAnh == fileName);
                                    dgvFolder.Height = jpgFiles.Count * 24;
                                }

                            }

                            // (Tùy chọn) Xóa dòng đã chọn trong DataGridView nguồn

                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn một dòng để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Nhấn phím cách để chuyển ảnh.");
            }

            txtSearch.Text = "";
        }
        private bool isUserWasOpenNewFolder()
        {
            bool check = false;

            if (txtNewFolder.Text != string.Empty)
            {
                check = true;
            }

            return check;
        }


        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại chọn thư mục
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                // Nếu người dùng chọn một thư mục và nhấn OK
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    // Set lên txt
                    txtNewFolder.Text = folderBrowserDialog.SelectedPath;
                    checkEnableAfterSelectFindNewFolder();
                }
            }
            
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
                    if(filesDot == null)
                    {
                        MessageBox.Show("Bạn chưa chọn .file trong menu.");
                    }
                    if (filesDot == string.Empty)
                    {
                        selectAllFiles(files);
                        MessageBox.Show($"Tìm thấy {jpgFiles.Count} tệp {filesDot} trong thư mục đã chọn.");
                        showTable(jpgFiles);
                    }
                    else if(!string.IsNullOrWhiteSpace(filesDot))
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
            dgvNewFolder.ClearSelection();
        }
        private void showTable2(List<FileName> list)
        {
            bindingSourceV2 = new BindingSource();
            bindingSourceV2.DataSource = list;
            dgvNewFolder.DataSource = null;
            dgvNewFolder.DataSource = bindingSourceV2;


            dgvFolder.ClearSelection();
            dgvNewFolder.ClearSelection();
        }
        private DataGridView updateDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.BorderStyle = BorderStyle.None;

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
        private void SearchImages()
        {
            List<FileName> list = new List<FileName>();
            // Kiểm tra xem đã chọn thư mục lưu trữ chưa
            if (string.IsNullOrWhiteSpace(txtNewFolder.Text))
            {
                MessageBox.Show("Bạn chưa chọn folder.");
                return;
            }
            else
            {
                string search = txtSearch.Text;
                if (jpgFiles.Count > 0)
                {
                    foreach (var file in jpgFiles)
                    {
                        if (file.TenAnh.ToLower().Contains(search.ToLower()))
                        {
                            list.Add(file);
                        }
                    }
                }
                if (list.Count > 0)
                {
                    showTable(list);

                }
            }
        }
        private void SearchAll()
        {
            txtSearch.Text = "";
            showTable(jpgFiles);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                SearchImages();
            }
            else
            {
                SearchAll();
            }
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
                if (string.IsNullOrWhiteSpace(txtNewFolder.Text))
                {
                    MessageBox.Show("Bạn chưa chọn folder để lưu mới tập tin.");
                    return;
                }
                if (dgvNewFolder.Rows.Count > 0)
                {
                    // Lưu đường dẫn thư mục đã chọn
                    string exportFolderPath = txtNewFolder.Text;

                    // Lưu tất cả các file ảnh .jpg từ DataGridView vào thư mục đã chọn
                    foreach (DataGridViewRow row in dgvNewFolder.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {

                            string fileName = row.Cells[0].Value.ToString(); // Điều chỉnh tên cột nếu cần

                            // Kiểm tra xem tệp có tồn tại không trước khi sao chép
                            string sourceFilePath = Path.Combine(txtFolder.Text, fileName);
                            if (File.Exists(sourceFilePath))
                            {
                                string destinationFilePath = Path.Combine(exportFolderPath, fileName);
                                if (string.IsNullOrEmpty(mode))
                                {
                                    MessageBox.Show("Bạn chưa chọn chế độ trong menu");
                                    break;
                                } else
                                if (mode.Equals("copy"))
                                {
                                    File.Copy(sourceFilePath, destinationFilePath);

                                }
                                else if(mode.Equals("cut"))
                                {
                                    File.Move(sourceFilePath, destinationFilePath);

                                }

                            }
                            else
                            {
                                MessageBox.Show($"File '{fileName}' không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    // Thông báo khi hoàn thành
                    if (!string.IsNullOrEmpty(mode))
                    {
                        MessageBox.Show("Tất cả các tệp ảnh đã được sao chép vào thư mục được chọn.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SearchAll();
                        clearEXPORTAfterSave();
                    }
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
            dgvNewFolder.Rows.Clear();

            // Vô hiệu hóa checkbox trên các dòng đã chọn trong dgvFolder

        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn khởi động lại không?", "Xác nhận", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                dgvFolder.Rows.Clear();
                dgvNewFolder.Rows.Clear();
                txtFolder.Text = string.Empty;
                txtNewFolder.Text = string.Empty;
                checkEnableAfterSelectFindNewFolder();
                checkEnableAfterSelectFindFolder();
            }
        }



        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục không?", "Xác nhận", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                // Người dùng đã chọn OK, thực hiện các hành động tiếp theo ở đây
                bool check = false;
                bool checkV2 = false;
                bool checkV3 = false;
                while (dgvFolder.Rows.Count > 0 && check == false && checkV2 == false && checkV3 == false)
                {
                    string exportFolderPath = txtNewFolder.Text;

                    if (string.IsNullOrEmpty(exportFolderPath))
                    {
                        check = true;
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dgvFolder.Rows)
                        {
                            if (row != null)
                            {
                                // Lấy dữ liệu từ dòng đã chọn
                                string fileName = row.Cells[0].Value.ToString();
                                if (!string.IsNullOrEmpty(fileName))
                                {
                                    // Thêm dữ liệu từ dòng đã chọn vào DataGridView khác
                                    // Ví dụ: Thêm vào dgvDestination
                                    //check có tồn tại trong folder mới này ko
                                    string destinationFilePath = Path.Combine(exportFolderPath, fileName);
                                    // Kiểm tra xem tệp đích đã tồn tại hay chưa
                                    if (File.Exists(destinationFilePath))
                                    {
                                        checkV2 = true;
                                    }
                                    else
                                    {
                                        FileName file = new FileName { TenAnh = fileName };
                                        jpgFiles2.Add(file);
                                        showTable2(jpgFiles2);
                                        dgvFolder.Rows.Remove(row);
                                        jpgFiles.RemoveAll(x => x.TenAnh == fileName);
                                        dgvFolder.Height = jpgFiles.Count * 24;
                                        checkV2 = false;
                                    }

                                }

                                // (Tùy chọn) Xóa dòng đã chọn trong DataGridView nguồn
                                checkV3 = false;
                            }
                            else
                            {
                                checkV3 = true;
                            }
                        }

                        check = false;
                    }
                }
                if (checkV2)
                {
                    MessageBox.Show("Có những File folder cũ đã tồn tại trong folder mới");
                }
                if (checkV3)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (check)
                {
                    MessageBox.Show("Bạn chưa chọn folder.");
                }

                txtSearch.Text = "";
            }

        }



        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            bool check = false;
            bool checkV2 = false;

            while (dgvNewFolder.Rows.Count > 0 && check == false && checkV2 == false)
            {
                string exportFolderPath = txtNewFolder.Text;
                if (string.IsNullOrEmpty(exportFolderPath))
                {
                    check = true;
                }
                else
                {
                    //MessageBox.Show($"{dgvNewFolder.Rows.Count}");
                    foreach (DataGridViewRow row in dgvNewFolder.Rows)
                    {
                        if (row != null)
                        {
                            string fileName = row.Cells[0].Value.ToString();
                            if (!string.IsNullOrEmpty(fileName))
                            {
                                jpgFiles.Add(new FileName { TenAnh = fileName });
                                showTable(jpgFiles);
                                dgvNewFolder.Rows.Remove(row);
                                jpgFiles2.RemoveAll(x => x.TenAnh == fileName);
                                checkV2 = false;
                            }
                        }
                        else
                        {
                            checkV2 = true;
                        }
                    }
                    check = false;
                }
            }
            if (checkV2)
            {
                MessageBox.Show("Vui lòng chọn một dòng để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (check)
            {
                MessageBox.Show("Bạn chưa chọn folder.");
            }

            txtSearch.Text = "";
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
            // Kiểm tra xem đã có đường dẫn thư mục được chọn từ trước không
            if (!string.IsNullOrEmpty(txtNewFolder.Text))
            {
                // Mở thư mục được chọn trên máy tính của bạn
                Process.Start(txtNewFolder.Text);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thư mục nào để review.");
            }
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
        private void checkEnableAfterSelectFindNewFolder()
        {
            if (txtNewFolder.Text == string.Empty || filesDot == null)
            {
                txtNewFolder.Text = string.Empty;
                btnReviewNewFolder.Enabled = false;
            }
            else
            {
                btnReviewNewFolder.Enabled = true;
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
            btnCut.Checked = false;
            mode = "copy";

            btnCopy.Checked = true;
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            btnCopy.Checked = false;
            mode = "cut";

            btnCut.Checked = true;
        }
    }
}
