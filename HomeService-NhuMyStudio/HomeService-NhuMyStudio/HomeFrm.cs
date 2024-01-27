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

        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(filterForm == null)
            {
                filterForm = new frmFilter();
                filterForm.FormClosed += FilterForm_FormClosed;
                filterForm.MdiParent = this;
                filterForm.Dock = DockStyle.Fill;
                filterForm.Show();
            }
            else
            {
                filterForm.Activate();
            }
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
