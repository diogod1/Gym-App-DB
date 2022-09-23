using MySql.Data.MySqlClient;
using System.Data;

namespace GymLogIn
{
    public partial class frmGPagamentoUser : Form
    {

        MySqlConnection connection;
        MySqlDataReader reader;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        string sql;

        public frmGPagamentoUser()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            SHOW_DATA();
            txtTipo.Visible = false;
            txtMontante.Visible = false;
            txtMontante.Visible = false;
            btnAdd.Visible = false;
        }

        public void SHOW_DATA()
        {
            connection.Open();
            sql = "SELECT * FROM pagamento WHERE id_cliente = @id";
            adapter = new MySqlDataAdapter(sql, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@id", user.id);
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
            if (txtTipo.Text == "" || txtMontante.Text == "" || txtMontante.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(user.add_pagamento(txtTipo.Text,txtMontante.Text) == 0)
                {
                    MessageBox.Show("Pagamento registado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SHOW_DATA();
                }
                else
                {
                    MessageBox.Show("Falha no registo do Pagamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtTipo.Visible = true;
            txtMontante.Visible = true;
            txtMontante.Visible = true;
            btnAdd.Visible = true;
        }

        private void RadioRemover_CheckedChanged(object sender, EventArgs e)
        {
            txtTipo.Visible = false;
            txtMontante.Visible = false;
            txtMontante.Visible = false;
            btnAdd.Visible = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
        }

        private void GridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
