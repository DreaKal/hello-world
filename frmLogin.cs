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


namespace LoginForm
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection();
        public frmLogin()
        { 
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6OKQU8O;Initial Catalog=loginsamp;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM userlog WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Login Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form frm = new Menu();
                frm.Show();
            }
            else 
            {
                MessageBox.Show("Error in Login");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnklblClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();

            txtUser.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lnklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmRegistration();
            frm.Show();
        }
    }
}
