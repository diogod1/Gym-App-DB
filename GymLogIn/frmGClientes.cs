using MySql.Data.MySqlClient;
using System.Data;

namespace GymLogIn
{
    public partial class frmGClientes : Form
    {

        MySqlConnection connection;
        MySqlDataAdapter adapter;
        string sql;

        public frmGClientes()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            SHOW_DATA();
            txtId.Visible = false;
            txtNome.Visible = false;
            txtPassword.Visible = false;
            txtUsername.Visible = false;
            btnAdd.Visible = false;
            btnRemover.Visible = false;
        }

        public void SHOW_DATA()
        {
            connection.Open();
            sql = "SELECT * FROM USERS WHERE CARGO = 'C'";
            adapter = new MySqlDataAdapter(sql, connection);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            GridClientes.DataSource = tabela;
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Introduza o id que deseja remover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(Admin.adiciona_cliente(txtUsername.Text, txtPassword.Text, txtNome.Text) == 0)
                {
                    MessageBox.Show("Cliente registado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SHOW_DATA();
                }
                else
                {
                    MessageBox.Show("Username ja está a ser usado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Visible = true;
            txtPassword.Visible = true;
            txtUsername.Visible = true;
            btnAdd.Visible = true;
            txtId.Visible = false;
            btnRemover.Visible = false;
        }

        private void RadioRemover_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Visible = false;
            txtPassword.Visible = false;
            txtUsername.Visible = false;
            btnAdd.Visible = false;
            txtId.Visible = true;
            btnRemover.Visible = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                MessageBox.Show("Introduza o id que deseja remover","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Admin.remove_cliente(txtId.Text) == 0)
                {
                    MessageBox.Show("Cliente removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SHOW_DATA();
                }
                else
                {
                    MessageBox.Show("Cliente inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
