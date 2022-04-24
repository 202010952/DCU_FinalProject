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

namespace DCUFinalProject
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER19;Initial Catalog=SecurityWorld;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Usuario (nombre, apellido, correo, telefono) values (@nombre, @apellido, @correo, @telefono)", con);
            cmd.Parameters.AddWithValue("@nombre", txtName.Text);
            cmd.Parameters.AddWithValue("@apellido", txtLastName.Text);
            cmd.Parameters.AddWithValue("@correo", txtEmail.Text);
            cmd.Parameters.AddWithValue("@telefono", txtPhoneNumber.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            var option= MessageBox.Show("Usuario creado de manera satisfactoria", "Creación de Usuario");
            if (option == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
                CreateUser createUser = new CreateUser();
                createUser.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var option = MessageBox.Show("Desea salir de la opción de Creación de Usuario", "Creación de Usuario", MessageBoxButtons.OKCancel);
            if (option == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Hide();
            }
            else
            {
                Form1 form1 = new Form1();
                form1.Hide();
            }
        }
    }
}
