using MySql.Data.MySqlClient;
using System.Data;

namespace GymLogIn
{
    public partial class frmGAulasUser : Form
    {

        MySqlConnection connection;
        MySqlDataAdapter adapter;
        string sql;

        public frmGAulasUser()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            SHOW_DATA();
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
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RadioRemover_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void GridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }
    }
}
