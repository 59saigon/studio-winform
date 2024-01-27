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
            //dgvFolder.KeyPress += DgvFolder_KeyPress; ;

            DataGridViewTextBoxColumn fileNameColumn = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn dgvcCheckBox = new DataGridViewCheckBoxColumn();
            // Đặt tên cho cột
            fileNameColumn.DataPropertyName = "TenAnh";
            fileNameColumn.HeaderText = "TenAnh";
            dgvcCheckBox.HeaderText = "Select";

            dgvFolder.Columns.Add(fileNameColumn);
            dgvFolder.Columns.Add(dgvcCheckBox);





            DataGridViewTextBoxColumn fileNameColumnV2 = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn dgvcCheckBoxV2 = new DataGridViewCheckBoxColumn();
            // Đặt tên cho cột
            fileNameColumnV2.DataPropertyName = "TenAnh";
            fileNameColumnV2.HeaderText = "TenAnh";
            dgvcCheckBoxV2.HeaderText = "SelectV2";
            //dgvFolder.Controls.Add(new CheckBox()

            dgvNewFolder.Columns.Add(fileNameColumnV2);
            dgvNewFolder.Columns.Add(dgvcCheckBoxV2);

            // Thêm checkbox vào header của cột Select
            AddHeaderCheckBox(dgvFolder, dgvcCheckBox);

            dgvFolder = updateDataGridView(dgvFolder);
            dgvNewFolder = updateDataGridView(dgvNewFolder);

        }
        private void AddHeaderCheckBox(DataGridView dataGridView, DataGridViewCheckBoxColumn checkBoxColumn)
        {
            Rectangle rect = dataGridView.GetCellDisplayRectangle(checkBoxColumn.Index, -1, true);
            rect.X = rect.Location.X + (rect.Width - 16) / 2;
            rect.Y = rect.Location.Y + (rect.Height - 16) / 2;

            CheckBox headerCheckBox = new CheckBox();
            headerCheckBox.Name = "headerCheckBox";
            headerCheckBox.Size = new Size(16, 16);
            headerCheckBox.Location = rect.Location;
            headerCheckBox.CheckedChanged += (s, e) =>
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    DataGridViewCheckBoxCell checkBox = row.Cells[checkBoxColumn.Index] as DataGridViewCheckBoxCell;
                    checkBox.Value = headerCheckBox.Checked;
                }
            };

            dataGridView.Controls.Add(headerCheckBox);
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
            
            //bindingSource = new BindingSource();
            //bindingSource.DataSource = list;
            //dgvFolder.DataSource = null;
            //dgvFolder.DataSource = bindingSource;
            
            for (int i = 0; i < list.Count; i++)
            {
                dgvFolder.Rows.Add(list[i].TenAnh.ToString(), false);
            }
            //dgvFolder.ClearSelection();
            dgvNewFolder.ClearSelection();
        }
        private void showTable2(List<FileName> list)
        {
            
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

            //dgv.ReadOnly = true;

            return dgv;
        }
        private void DisplayImages()
        {
            List<FileName> list = new List<FileName>();
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên ảnh");
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
        private void DisplayAll()
        {
            txtSearch.Text = "";
            showTable(jpgFiles);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.TextAlign > 0)
            {
                DisplayImages();
            }
            else
            {
                DisplayAll();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgvFolder.Rows.Count - 1; i++)
            {

                bool rowAlreadyExist = false;
                bool checkedCell = (bool)dgvFolder.Rows[i].Cells[1].Value;
                DataGridViewRow row = dgvFolder.Rows[i];
                if (checkedCell)
                {
                    
                    if (dgvNewFolder.Rows.Count > 0)
                    {
                        for (int j = 0; j < dgvNewFolder.Rows.Count; j++)
                        {
                            DataGridViewRow rowV2 = dgvNewFolder.Rows[j];
                            if (rowV2.Cells[0].Value != null && row.Cells[0].Value != null)
                            {
                                if (row.Cells[0].Value.ToString() == rowV2.Cells[0].Value.ToString())
                                {
                                    rowAlreadyExist = true;
                                    break;
                                }
                            }

                        }


                        if (rowAlreadyExist == false)
                        {
                            dgvNewFolder.Rows.Add(row.Cells[0].Value.ToString());
                                                 
                        }
                    }

                    else
                    {
                        dgvNewFolder.Rows.Add(row.Cells[0].Value.ToString());
                    }
                }
                else
                {
                    if (dgvNewFolder.Rows.Count > 0)
                    {
                        for (int j = 0; j < dgvNewFolder.Rows.Count; j++)
                        {
                            DataGridViewRow rowV2 = dgvNewFolder.Rows[j];
                            if (rowV2.Cells[0].Value != null && row.Cells[0].Value != null)
                            {
                                if (row.Cells[0].Value.ToString() == rowV2.Cells[0].Value.ToString())
                                {
                                    dgvNewFolder.Rows.RemoveAt(j);
                                    break;
                                }
                            }

                        }


                       
                    }
                }
            }
        }

        private void txtFolder_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgvNewFolder.Rows.Count - 1; i++)
            {
                bool rowAlreadyExist = false;
                bool checkedCell = (bool)dgvNewFolder.Rows[i].Cells[1].Value;
                if (checkedCell)
                {
                    DataGridViewRow row = dgvNewFolder.Rows[i];

                    if (dgvFolder.Rows.Count > 0)
                    {
                        for (int j = 0; j < dgvFolder.Rows.Count; j++)
                        {
                            DataGridViewRow rowV2 = dgvFolder.Rows[j];
                            if (rowV2.Cells[0].Value != null && row.Cells[0].Value != null)
                            {
                                if (row.Cells[0].Value.ToString() == rowV2.Cells[0].Value.ToString())
                                {
                                    rowAlreadyExist = true;
                                    break;
                                }
                            }

                        }


                        if (rowAlreadyExist == false)
                        {
                            dgvFolder.Rows.Add(row.Cells[0].Value.ToString());

                        }
                    }

                    else
                    {
                        dgvFolder.Rows.Add(row.Cells[0].Value.ToString());
                    }
                }
            }
        }
    }
}
