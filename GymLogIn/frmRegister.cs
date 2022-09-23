using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GymLogIn
{
    public partial class frmRegister : Form
    {

        MySqlConnection connection;
        MySqlDataReader reader;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        string sql;


        public frmRegister()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Clear();
            txtPassword.Clear();
            txtUserName.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fr = new frmLogin();
            fr.ShowDialog();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            sql = "SELECT * FROM users WHERE username = @username";

            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", txtUserName.Text);
            connection.Open();
            int id = -1;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["id_users"]);
            }
          
            if (id > 0)
            {
                MessageBox.Show("Username já existe!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                connection.Close();
            }
            else
            {
                connection.Close();
                if (String.Equals(txtPassword.Text,txtConfirmPassword.Text)) //verifcar as passwords
                {
                    try
                    {
                        //inserir registo na base de dados
                        connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
                        sql = "insert into users (username, nome, password) values (@username, '', @password)";
                        command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@username", txtUserName.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);
                        connection.Open();
                        command.ExecuteNonQuery();

                        //Criar objeto user
                        //user.nome = txtUserName.Text;
                        //user.password = txtPassword.Text;

                        //mudar para aplicaçao
                        this.Hide();
                        frmLogin f2 = new frmLogin(); //trocar de form
                        f2.ShowDialog();
                        connection.Close();
                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("As password's não coincidem!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            connection.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
