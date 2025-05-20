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

namespace ManagementSample
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6OKQU8O;Initial Catalog=EmployeesDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeManage VALUES (@employeeid, @employeename, @email, @salary)", con);
            cmd.Parameters.AddWithValue("@EmployeeId", int.Parse(txtEmployeeID.Text));
            cmd.Parameters.AddWithValue("@EmployeeName", txtEmployeeName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Inserted Successfully");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6OKQU8O;Initial Catalog=EmployeesDB;Integrated Security=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM EmployeeManage", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6OKQU8O;Initial Catalog=EmployeesDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE EmployeeManage WHERE employeeid=@employeeid", con);
            cmd.Parameters.AddWithValue("@EmployeeId", int.Parse(txtEmployeeID.Text));
            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
            txtEmail.Text = "";
            txtSalary.Text = "";
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6OKQU8O;Initial Catalog=EmployeesDB;Integrated Security=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM EmployeeManage", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
