using HomeService_NhuMyStudio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeService_NhuMyStudio
{
    public partial class HomeFrm : Form
    {
        frmChangeFile changeFileForm;
        frmFilter filterForm;
        frmRename renameForm;

        
        public HomeFrm()
        {
            InitializeComponent();
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 62)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 253 )
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

   

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void HomeFrm_Load(object sender, EventArgs e)
        {
        }

        private void btnChangeFiles_Click(object sender, EventArgs e)
        {

        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            //CloseEveryOrder();
            if (renameForm == null)
            {
                
                renameForm = new frmRename();
                renameForm.FormClosed += RenameForm_FormClosed;
                renameForm.MdiParent = this;
                renameForm.Dock = DockStyle.Fill;
                renameForm.Show();
                if (filterForm != null)
                {
                    filterForm.Close();
                }
            }
            
        }
        private void CloseEveryOrder()
        {
            if (renameForm !=null)
            {
                filterForm.Close();
            }
            if (renameForm.Visible)
            {
                renameForm.Close();
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            //CloseEveryOrder();
            if (filterForm == null)
            {
                
                filterForm = new frmFilter();
                filterForm.FormClosed += FilterForm_FormClosed;
                
                filterForm.MdiParent = this;
                filterForm.Dock = DockStyle.Fill;
                


                filterForm.Show();
                if(renameForm != null)
                {
                    renameForm.Close();
                }
            }
            
        }

        private void RenameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            renameForm = null;
        }

        private void FilterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            filterForm = null;
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
