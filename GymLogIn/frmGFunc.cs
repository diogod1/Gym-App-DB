using MySql.Data.MySqlClient;
using System.Data;

namespace GymLogIn
{
    public partial class frmGFunc : Form
    {

        MySqlConnection connection;
        MySqlDataAdapter adapter;
        string sql;

        public frmGFunc()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            SHOW_DATA();
            txtIdFunc.Visible = false;
            txtNomeFunc.Visible = false;
            txtPasswordFunc.Visible = false;
            txtUsernameFunc.Visible = false;
            btnAddFunc.Visible = false;
            btnRemoverFunc.Visible = false;
        }

        public void SHOW_DATA()
        {
            connection.Open();
            sql = "SELECT * FROM users WHERE cargo = 'S'";
            adapter = new MySqlDataAdapter(sql, connection);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            GridFunc.DataSource = tabela;
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsernameFunc.Text == "" || txtPasswordFunc.Text == "")
            {
                MessageBox.Show("Introduza o id que deseja remover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(Admin.adiciona_func(txtNomeFunc.Text,txtUsernameFunc.Text,txtPasswordFunc.Text) == 0)
                {
                    MessageBox.Show("Funcionario registado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtNomeFunc.Visible = true;
            txtPasswordFunc.Visible = true;
            txtUsernameFunc.Visible = true;
            btnAddFunc.Visible = true;
            txtIdFunc.Visible = false;
            btnRemoverFunc.Visible = false;
        }

        private void RadioRemover_CheckedChanged(object sender, EventArgs e)
        {
            txtNomeFunc.Visible = false;
            txtPasswordFunc.Visible = false;
            txtUsernameFunc.Visible = false;
            btnAddFunc.Visible = false;
            txtIdFunc.Visible = true;
            btnRemoverFunc.Visible = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(txtIdFunc.Text == "")
            {
                MessageBox.Show("Introduza o id que deseja remover","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Admin.remove_func(Convert.ToInt16(txtIdFunc.Text)) == 0)
                {
                    MessageBox.Show("Funcionário removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SHOW_DATA();
                }
                else
                {
                    MessageBox.Show("Funcionário inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
