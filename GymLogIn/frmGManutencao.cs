using MySql.Data.MySqlClient;
using System.Data;

namespace GymLogIn
{
    public partial class frmGManutencao : Form
    {

        MySqlConnection connection;
        MySqlDataAdapter adapter;
        string sql;

        public frmGManutencao()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            SHOW_DATA();
            txtId.Visible = false;
            txtNomeMan.Visible = false;
            txtHoraMan.Visible = false;
            btnRemover.Visible = false;
            btnAdd.Visible = false;
        }

        public void SHOW_DATA()
        {
            connection.Open();
            sql = "SELECT * FROM manutencao";
            adapter = new MySqlDataAdapter(sql, connection);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            GridManutencao.DataSource = tabela;
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNomeMan.Text == "" || txtHoraMan.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(Admin.adiciona_manutencao(txtNomeMan.Text,txtHoraMan.Text) == 0)
                {
                    MessageBox.Show("Manutenção registada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SHOW_DATA();
                }
                else
                {
                    MessageBox.Show("Falha no registo da manutenção", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtNomeMan.Visible = true;
            txtHoraMan.Visible = true;
            btnAdd.Visible = true;
            txtId.Visible = false;
            btnRemover.Visible = false;
        }

        private void RadioRemover_CheckedChanged(object sender, EventArgs e)
        {
            txtNomeMan.Visible = false;
            txtHoraMan.Visible = false;
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
                if (Admin.remove_manutencao(txtId.Text) == 0)
                {
                    MessageBox.Show("Manutenção removida com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SHOW_DATA();
                }
                else
                {
                    MessageBox.Show("Falha na remoção da manutenção", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
