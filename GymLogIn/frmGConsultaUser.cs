using MySql.Data.MySqlClient;
using System.Data;

namespace GymLogIn
{
    public partial class frmGConsultaUser : Form
    {

        MySqlConnection connection;
        MySqlDataAdapter adapter;
        string sql;

        public frmGConsultaUser()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            SHOW_DATA();
            txtDataMarc.Visible = false;
            txtIdTipoMarc.Visible = false;
            txtIdMarc.Visible = false;
            btnAddMarc.Visible = false;
            btnRemoveMarc.Visible = false;
        }

        public void SHOW_DATA()
        {
            connection.Open();
            sql = "SELECT * FROM consultas";
            adapter = new MySqlDataAdapter(sql, connection);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            GridTipoConsulta.DataSource = tabela;
            connection.Close();

            connection.Open();
            sql = "SELECT * FROM marcacao_consulta WHERE id_cliente = @id";
            adapter = new MySqlDataAdapter(sql, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@id",user.id);
            DataTable tabela1 = new DataTable();
            adapter.Fill(tabela1);
            GridMarcConsulta.DataSource = tabela1;
            connection.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtDataMarc.Visible = false;
            txtIdTipoMarc.Visible = false;
            txtIdMarc.Visible = false;
            btnAddMarc.Visible = false;
            btnRemoveMarc.Visible = false;
        }

        private void RadioRemover_CheckedChanged(object sender, EventArgs e)
        {

            btnRemoveMarc.Visible = false;
            txtIdMarc.Visible = false;
            txtDataMarc.Visible = false;
            txtIdTipoMarc.Visible = false;
            btnAddMarc.Visible = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
        }

        private void btnRemoveMarc_Click(object sender, EventArgs e)
        {
            if (txtIdMarc.Text == "")
            {
                MessageBox.Show("Introduza o id que deseja remover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (user.remover_consulta(txtIdMarc.Text) == 0)
                {
                    MessageBox.Show("Marcação removida com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SHOW_DATA();
                }
                else
                {
                    MessageBox.Show("Marcação inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            btnRemoveMarc.Visible = true;
            txtIdMarc.Visible = true;

            txtDataMarc.Visible = false;
            txtIdTipoMarc.Visible = false;
            btnAddMarc.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnAddMarc.Visible=true;
            txtIdTipoMarc.Visible = true;
            txtDataMarc.Visible = true;

            btnRemoveMarc.Visible = false;
            txtIdMarc.Visible = false;
        }

        private void btnAddMarc_Click(object sender, EventArgs e)
        {
            if (user.add_consulta(txtIdTipoMarc.Text,txtDataMarc.Text) == 0)
            {
               MessageBox.Show("Marcação adicionada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               SHOW_DATA();
            }
            else
            {
                MessageBox.Show("Falha na marcação", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
