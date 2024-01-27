using HomeService_NhuMyStudio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public frmFilter()
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
            dgvNewFolder.Columns.Add(fileNameColumnV2);

            dgvFolder = updateDataGridView(dgvFolder);
            dgvNewFolder = updateDataGridView(dgvNewFolder);

        }

        private void DgvFolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            selectedRow = dgvFolder.CurrentRow;
            if (selectedRow == null) { return; }

            string exportFolderPath = txtNewFolder.Text;
            if (string.IsNullOrEmpty(exportFolderPath))
            {
                MessageBox.Show("Chọn folder cần được copy!");
            }
            else
            {
                try
                {
                    if (selectedRow != null)
                    {
                        // Lấy dữ liệu từ dòng đã chọn
                        string fileName = selectedRow.Cells[0].Value.ToString();
                        if (fileName == null)
                        {
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
                                dgvFolder.Rows.Remove(selectedRow);
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
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            txtSearch.Text = "";
        }
        private bool isUserWasOpenNewFolder()
        {
            bool check = false;

            if(txtNewFolder.Text != string.Empty)
            {
                check = true;
            }

            return check;
        }


        //private void DgvFolder_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    selectedRow = dgvFolder.CurrentRow;
        //    if (selectedRow == null) { return; }

        //    string exportFolderPath = dgvNewFolder.Text;
        //    if (string.IsNullOrEmpty(exportFolderPath))
        //    {
        //        MessageBox.Show("Chọn folder cần được copy!");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            if (selectedRow != null)
        //            {
        //                // Lấy dữ liệu từ dòng đã chọn
        //                string fileName = selectedRow.Cells[0].Value.ToString();
        //                if (fileName == null)
        //                {
        //                    return;
        //                }
        //                if (!string.IsNullOrEmpty(fileName))
        //                {
        //                    // Thêm dữ liệu từ dòng đã chọn vào DataGridView khác
        //                    // Ví dụ: Thêm vào dgvDestination
        //                    //check có tồn tại trong folder mới này ko
        //                    string destinationFilePath = Path.Combine(exportFolderPath, fileName);
        //                    // Kiểm tra xem tệp đích đã tồn tại hay chưa
        //                    if (File.Exists(destinationFilePath))
        //                    {
        //                        MessageBox.Show($"Tệp {fileName} này đã tồn tại trong folder mới.");
        //                    }
        //                    else
        //                    {
        //                        FileName file = new FileName { TenAnh = fileName };
        //                        jpgFiles2.Add(file);
        //                        showTable2(jpgFiles2);
        //                        dgvFolder.Rows.Remove(selectedRow);
        //                        jpgFiles.RemoveAll(x => x.TenAnh == fileName);

        //                    }

        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Vui lòng chọn một dòng để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Vui lòng chọn một dòng để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    txtSearch.Text = "";
        //}

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


                    // Lọc ra các tệp có đuôi mở rộng là .jpg
                    jpgFiles = new List<FileName>();
                    foreach (string file in files)
                    {
                        if (Path.GetExtension(file).Equals(".jpg", StringComparison.OrdinalIgnoreCase))
                        {
                            // Lấy chỉ tên của tệp và thêm vào danh sách jpgFiles
                            string fileName = Path.GetFileName(file);
                            jpgFiles.Add(new FileName
                            {
                                TenAnh = fileName,
                            });
                        }
                    }
                    // Hiển thị tên ảnh trong DataGridView





                    // Hiển thị số lượng tệp .jpg đã được tìm thấy
                    MessageBox.Show($"Tìm thấy {jpgFiles.Count} tệp .jpg trong thư mục đã chọn.");

                    showTable(jpgFiles);
                }
            }
        }
        private void showTable(List<FileName> list)
        {

            dgvFolder = updateDataGridView(dgvFolder);
            bindingSource = new BindingSource();
            bindingSource.DataSource = list;
            dgvFolder.DataSource = null;
            dgvFolder.DataSource = bindingSource;
            dgvFolder.Height = list.Count * 24;
            //foreach (DataGridViewRow row in dgvFolder.Rows)
            //{
            //    if (row.Cells[0].Value != null)
            //    {
            //        // Nếu hàng không có giá trị hoặc giá trị là rỗng, bạn có thể thực hiện các hành động tương ứng ở đây
            //        // Ví dụ: Thiết lập giá trị cho cột HeaderCell là số thứ tự hàng, tương tự như bạn đã làm trước đó
            //        row.HeaderCell.Value = (row.Index + 1).ToString();
            //    }
            //}
            dgvFolder.ClearSelection();
            dgvNewFolder.ClearSelection();
        }
        private void showTable2(List<FileName> list)
        {
            dgvNewFolder = updateDataGridView(dgvNewFolder);
            bindingSourceV2 = new BindingSource();
            bindingSourceV2.DataSource = list;
            dgvNewFolder.DataSource = null;
            dgvNewFolder.DataSource = bindingSourceV2;

            //foreach (DataGridViewRow row in dgvNewFolder.Rows)
            //{
            //    if (row.Cells[0].Value != null)
            //    {
            //        // Nếu hàng không có giá trị hoặc giá trị là rỗng, bạn có thể thực hiện các hành động tương ứng ở đây
            //        // Ví dụ: Thiết lập giá trị cho cột HeaderCell là số thứ tự hàng, tương tự như bạn đã làm trước đó
            //        row.HeaderCell.Value = (row.Index + 1).ToString();
            //    }
            //}

            dgvFolder.ClearSelection();
            dgvNewFolder.ClearSelection();
        }
        private DataGridView updateDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.BorderStyle = BorderStyle.None;

            dgv.AllowUserToAddRows = false;

            dgv.AllowUserToDeleteRows = false;

            dgv.AllowUserToOrderColumns = false;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgv.RowHeadersVisible = false;

            // Bỏ thanh header
            dgv.ColumnHeadersVisible = false;

            // Bỏ cột kéo lên xuống
            dgv.AllowUserToOrderColumns = false;

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
            } else
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
            // Kiểm tra xem đã chọn thư mục lưu trữ chưa
            if (string.IsNullOrWhiteSpace(txtNewFolder.Text))
            {
                MessageBox.Show("Bạn chưa chọn file để lưu mới tập tin.");
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
                            File.Copy(sourceFilePath, destinationFilePath);
                        }
                        else
                        {
                            MessageBox.Show($"File '{fileName}' không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // Thông báo khi hoàn thành
                MessageBox.Show("Tất cả các tệp ảnh đã được sao chép vào thư mục được chọn.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchAll();
                clearEXPORTAfterSave();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh để thêm vào folder mới này");
            }
        }
        private void clearEXPORTAfterSave()
        {
            // delete dgv
            dgvNewFolder.Rows.Clear();

            // Vô hiệu hóa checkbox trên các dòng đã chọn trong dgvFolder

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedRowV2 = dgvNewFolder.CurrentRow;
            if (selectedRowV2 == null) { return; }
            if (selectedRowV2 != null)
            {
                string fileName = selectedRowV2.Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(fileName))
                {
                    jpgFiles.Add(new FileName { TenAnh = fileName });
                    showTable(jpgFiles);
                    dgvNewFolder.Rows.Remove(selectedRowV2);
                    jpgFiles2.RemoveAll(x => x.TenAnh == fileName);
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            dgvFolder.Rows.Clear();
            dgvNewFolder.Rows.Clear();
            txtFolder.Text = string.Empty;
            txtNewFolder.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
