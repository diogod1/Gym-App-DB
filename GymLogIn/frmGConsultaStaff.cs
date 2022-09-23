using MySql.Data.MySqlClient;
using System.Data;

namespace GymLogIn
{
    public partial class frmGConsultaStaff : Form
    {

        MySqlConnection connection;
        MySqlDataAdapter adapter;
        string sql;

        public frmGConsultaStaff()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            SHOW_DATA();
            txtIdConsulta.Visible = false;
            txtDataMarc.Visible = false;
            txtIdClienteMarc.Visible = false;
            txtIdTipoMarc.Visible = false;
            txtIdMarc.Visible = false;
            txtNomeConsulta.Visible = false;
            btnAddConsulta.Visible = false;
            btnRemoverConsulta.Visible = false;
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
            sql = "SELECT * FROM marcacao_consulta";
            adapter = new MySqlDataAdapter(sql, connection);
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
            if (txtNomeConsulta.Text == "")
            {
                MessageBox.Show("Introduza o nome da consulta que deseja adicionar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if( staff.add_consulta(txtNomeConsulta.Text) == 0)
                {
                    MessageBox.Show("Consulta adicionada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SHOW_DATA();
                }
                else
                {
                    MessageBox.Show("Falha ao adicionar consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtDataMarc.Visible = false;
            txtIdClienteMarc.Visible = false;
            txtIdTipoMarc.Visible = false;
            txtIdMarc.Visible = false;
            btnAddMarc.Visible = false;
            btnRemoveMarc.Visible = false;
            txtNomeConsulta.Visible = true;
            btnAddConsulta.Visible = true;
            txtIdConsulta.Visible = false;
            btnRemoverConsulta.Visible = false;
        }

        private void RadioRemover_CheckedChanged(object sender, EventArgs e)
        {

            btnRemoveMarc.Visible = false;
            txtIdMarc.Visible = false;
            txtDataMarc.Visible = false;
            txtIdClienteMarc.Visible = false;
            txtIdTipoMarc.Visible = false;
            btnAddMarc.Visible = false;
            txtNomeConsulta.Visible = false;
            btnAddConsulta.Visible = false;
            txtIdConsulta.Visible = true;
            btnRemoverConsulta.Visible = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(txtIdConsulta.Text == "")
            {
                MessageBox.Show("Introduza o id que deseja remover","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (staff.remove_consulta(Convert.ToInt16(txtIdConsulta.Text)) == 0)
                {
                    MessageBox.Show("Consulta removida com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SHOW_DATA();
                }
                else
                {
                    MessageBox.Show("Consulta inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemoveMarc_Click(object sender, EventArgs e)
        {
            if (txtIdMarc.Text == "")
            {
                MessageBox.Show("Introduza o id que deseja remover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (staff.remove_marcacao(Convert.ToInt16(txtIdMarc.Text)) == 0)
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
            txtIdClienteMarc.Visible = false;
            txtIdTipoMarc.Visible = false;
            btnAddMarc.Visible = false;
            txtNomeConsulta.Visible = false;
            btnAddConsulta.Visible = false;
            txtIdConsulta.Visible = false;
            btnRemoverConsulta.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnAddMarc.Visible=true;
            txtIdTipoMarc.Visible = true;
            txtDataMarc.Visible = true;
            txtIdClienteMarc.Visible = true;

            btnRemoveMarc.Visible = false;
            txtIdMarc.Visible = false;
            txtNomeConsulta.Visible = false;
            btnAddConsulta.Visible = false;
            txtIdConsulta.Visible = false;
            btnRemoverConsulta.Visible = false;
        }

        private void btnAddMarc_Click(object sender, EventArgs e)
        {
            if (staff.add_marcacao(txtIdClienteMarc.Text,txtIdTipoMarc.Text,txtDataMarc.Text) == 0)
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
