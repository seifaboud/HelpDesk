using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HelpDesk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
    

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var authentucationQuery = @"SELECT * FROM [helpdesk].[dbo].[logindetails] where username = '" + txtUsername.Text + "' and userpassword = '" + txtPassword.Text + "'";

            try
            {
                SqlConnection conn = Connection.GetSqlConnection();
                SqlDataAdapter sda = new SqlDataAdapter(authentucationQuery, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    HelpDeskMain main = new HelpDeskMain();
                    main.Show();
                }

                else
                {
                    MessageBox.Show("Invalid Username Or Password, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_cancel_Click(sender, e);
                }
            }

            catch
            {
                MessageBox.Show("Something Went Wrong While Logging In. Please Try Again.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

           
        }

        private void create_acc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
