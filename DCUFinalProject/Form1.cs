namespace DCUFinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
        }

        private void btnReadUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadUser readUser = new ReadUser();
            readUser.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadUser readUser = new ReadUser();
            readUser.ShowDialog();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateUser updateUser = new UpdateUser();
            updateUser.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateUser updateUser = new UpdateUser();
            updateUser.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.ShowDialog();
        }
    }
}