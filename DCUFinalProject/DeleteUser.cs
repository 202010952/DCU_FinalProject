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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER19;Initial Catalog=SecurityWorld;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Usuario where id = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            var option = MessageBox.Show("Usuario eliminado de manera satisfactoria", "Eliminar Usuario");
            if (option == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Hide();
            }
        }

        private void BtnCancelDelete_Click(object sender, EventArgs e)
        {
            var option = MessageBox.Show("Desea salir de la opción de Eliminar Usuario", "Eliminar Usuario", MessageBoxButtons.OKCancel);
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
