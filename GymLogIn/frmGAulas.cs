using MySql.Data.MySqlClient;
using System.Data;

namespace GymLogIn
{
    public partial class frmGAulas : Form
    {

        MySqlConnection connection;
        MySqlDataAdapter adapter;
        string sql;

        public frmGAulas()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            SHOW_DATA();
            txtId.Visible = false;
            txtNome.Visible = false;
            txtData.Visible = false;
            btnRemover.Visible = false;
            btnAdd.Visible = false;
        }

        public void SHOW_DATA()
        {
            connection.Open();
            sql = "SELECT * FROM aulas";
            adapter = new MySqlDataAdapter(sql, connection);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            GridAulas.DataSource = tabela;
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtData.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(Admin.adiciona_aula(txtNome.Text,txtData.Text) == 0)
                {
                    MessageBox.Show("Aula registada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SHOW_DATA();
                }
                else
                {
                    MessageBox.Show("Falha no registo da aula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Visible = true;
            txtData.Visible = true;
            btnAdd.Visible = true;
            txtId.Visible = false;
            btnRemover.Visible = false;
        }

        private void RadioRemover_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Visible = false;
            txtData.Visible = false;
            txtId.Visible = true;
            btnRemover.Visible = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Admin.remove_aula(txtId.Text) == 0)
                {
                    MessageBox.Show("Aula removida com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SHOW_DATA();
                }
                else
                {
                    MessageBox.Show("Falha na remoção da aula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
