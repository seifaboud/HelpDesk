using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    public partial class HelpDeskMain : Form
    {

        public HelpDeskMain()
        {
            InitializeComponent();
        }

        bool close = true;

        private void HelpDeskMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (close)
            {
                DialogResult dr = MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }

                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach(Form f in Application.OpenForms)
            {
                if(f.Text == "Store")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                Store st = new Store();
                st.MdiParent = this;
                st.Show();
            }
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Records")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                Records rc = new Records();
                rc.MdiParent = this;
                rc.Show();
            }
        }

        private void itemsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Stock Report")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                ReportForm.StockReport stockReport = new ReportForm.StockReport();
                stockReport.MdiParent = this;
                stockReport.StartPosition = FormStartPosition.CenterScreen;
                stockReport.Show();
            }
        }

        private void itemLendingRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Records Report")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                RecordsReport recordsReport = new RecordsReport();
                recordsReport.MdiParent = this;
                recordsReport.StartPosition = FormStartPosition.CenterScreen;
                recordsReport.Show();
            }
        }

        private void aboutHelpDeskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "About SAM IT Help Desk")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                  AboutApp aa = new AboutApp();
            aa.MdiParent = this;
            aa.StartPosition = FormStartPosition.CenterScreen;
            aa.Show();
            }
         
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Change Password")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                PassWordChange pc = new PassWordChange();
                pc.MdiParent = this;
                pc.Show();
            }
        }
    }
}
