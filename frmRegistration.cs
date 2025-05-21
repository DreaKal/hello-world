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

namespace LoginShit
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con  = new SqlConnection("Data Source=DESKTOP-6OKQU8O;Initial Catalog=registrationDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string insertQuery = "INSERT INTO register VALUES (@Fname, @Lname, @gender, @email, @phone, @username, @password)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@Fname", txtFname.Text);
            cmd.Parameters.AddWithValue("@Lname", txtLname.Text);
            cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registration Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogin();
            frm.Show();
        }
    }
}
