using MySql.Data.MySqlClient;
using System.Data;

namespace GymLogIn
{
    public partial class frmGPagamento : Form
    {

        MySqlConnection connection;
        MySqlDataReader reader;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        string sql;

        public frmGPagamento()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            SHOW_DATA();
            txtId.Visible = false;
            txtTipo.Visible = false;
            txtIdCliente.Visible = false;
            txtMontante.Visible = false;
            btnRemover.Visible = false;
            btnAdd.Visible = false;
        }

        public void SHOW_DATA()
        {
            connection.Open();
            sql = "SELECT * FROM pagamento";
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
            if (txtTipo.Text == "" || txtMontante.Text == "" || txtIdCliente.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(Admin.add_pagamento(txtTipo.Text,txtMontante.Text,txtIdCliente.Text) == 0)
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
            txtIdCliente.Visible = true;
            btnAdd.Visible = true;
            txtId.Visible = false;
            btnRemover.Visible = false;
        }

        private void RadioRemover_CheckedChanged(object sender, EventArgs e)
        {
            txtTipo.Visible = false;
            txtMontante.Visible = false;
            txtIdCliente.Visible = false;
            btnAdd.Visible = false;
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
                if (Admin.remove_pagamento(txtId.Text) == 0)
                {
                    MessageBox.Show("Pagamento removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SHOW_DATA();
                }
                else
                {
                    MessageBox.Show("Falha na remoção do pagamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
