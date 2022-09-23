using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GymLogIn
{
    public static class Admin
    {

        public static int id;
        public static string nome;
        public static string password;
        public static string username;

        public static int Id
        {
            get { return id; }
            set { id = value; }
        }

        public static string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public static string Password
        {
            get { return password; }
            set { password = value; }
        }

        public static string Username
        {
            get { return username; }
            set { username = value; }
        }

        public static int adiciona_cliente(string txtUsername, string txtPassword, string txtNome)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            sql = "SELECT * FROM users WHERE username = @username";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", txtUsername);
            connection.Open();
            string username = "";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                username = Convert.ToString((reader["id_users"]));
            }
            connection.Close();
            if (username == "")
            {
                sql = "insert into users (username, nome, password, cargo) values (@username, @nome, @password, @cargo)";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", txtUsername);
                command.Parameters.AddWithValue("@nome", txtNome);
                command.Parameters.AddWithValue("@password", txtPassword);
                command.Parameters.AddWithValue("@cargo", "C");
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
        }

        public static int remove_cliente(string txtId)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            sql = "SELECT * FROM users WHERE id_users = @id_users";
            command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id_users", Convert.ToInt32(txtId));
            connection.Open();
            int id = 0;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32((reader["id_users"]));
            }
            connection.Close();
            if (id > 0)
            {
                sql = "delete from users where id_users = @id";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
        }

        public static int adiciona_func(string txtNomeFunc, string txtUsernameFunc, string txtPasswordFunc)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            sql = "SELECT * FROM users WHERE username = @username";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", txtUsernameFunc);
            connection.Open();
            string username = "";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                username = Convert.ToString((reader["id_users"]));
            }
            connection.Close();
            if (username == "")
            {
                sql = "insert into users (username, nome, password, cargo) values (@username, @nome, @password, @cargo)";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", txtUsernameFunc);
                command.Parameters.AddWithValue("@nome", txtNomeFunc);
                command.Parameters.AddWithValue("@password", txtPasswordFunc);
                command.Parameters.AddWithValue("@cargo","S");
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
        }

        public static int remove_func(int txtIdFunc)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            sql = "SELECT * FROM users WHERE id_users = @id_users AND cargo = 'S'";
            command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id_users", Convert.ToInt32(txtIdFunc));
            connection.Open();
            int id = 0;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32((reader["id_users"]));
            }
            connection.Close();
            if (id > 0)
            {
                sql = "delete from users where id_users = @id";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
        }

        public static int add_consulta(string txtNomeConsulta)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            MySqlDataAdapter adapter;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            if (txtNomeConsulta != "")
            {
                sql = "insert into consultas (nome) values (@nome)";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nome", txtNomeConsulta);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
        }

        public static int remove_consulta(int txtId)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            sql = "SELECT * FROM consultas WHERE id_consulta = @id";
            command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id", txtId);
            connection.Open();
            int id = 0;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32((reader["id_consulta"]));
            }
            connection.Close();
            if (id > 0)
            {
                sql = "delete from consultas where id_consulta = @id";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
            return 0;
        }

        public static int add_marcacao(string txtIdClienteMarc,string txtIdTipoMarc, string txtDataMarc)
        {

            MySqlConnection connection;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            if (txtIdClienteMarc != "" || txtIdTipoMarc != "" || txtDataMarc != "")
            {
                sql = "insert into marcacao_consulta (id_cliente,id_consulta,data) values (@id_cliente,@id_consulta,@data)";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id_cliente", Convert.ToInt16(txtIdClienteMarc));
                command.Parameters.AddWithValue("@id_consulta", Convert.ToInt16(txtIdTipoMarc));
                command.Parameters.AddWithValue("@data", txtDataMarc);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
            
                return 1;
            }
        }


        public static int remove_marcacao(int txtIdMarc)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            sql = "SELECT * FROM marcacao_consulta WHERE id_marcacao = @id";
            command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id", txtIdMarc);
            connection.Open();
            int id = 0;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32((reader["id_marcacao"]));
            }
            connection.Close();
            if (id > 0)
            {
                sql = "delete from marcacao_consulta where id_marcacao = @id";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
            return 0;
        }

        public static int adiciona_aula(string txtNome, string txtDataAula)
        {
            MySqlConnection connection;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            if (txtNome != "" || txtDataAula != "")
            {
                sql = "insert into aulas (nome,data) values (@nome,@data)";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nome", txtNome);
                command.Parameters.AddWithValue("@data", txtDataAula);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
            connection.Close();
            return 0;
        }

        public static int remove_aula(string txtId)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            sql = "SELECT * FROM aulas WHERE id_aula = @id";
            command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id", Convert.ToInt32(txtId));
            connection.Open();
            int id = 0;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32((reader["id_aula"]));
            }
            connection.Close();
            if (id > 0)
            {
                sql = "delete from aulas where id_aula = @id";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
        }

        public static int adiciona_manutencao(string txtNome, string txtHora)
        {
            MySqlConnection connection;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            if (txtNome != "" || txtHora != "")
            {
                sql = "insert into manutencao (tipo,hora) values (@tipo,@hora)";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@tipo", txtNome);
                command.Parameters.AddWithValue("@hora", txtHora);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
        }

        public static int remove_manutencao(string txtId)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            sql = "SELECT * FROM manutencao WHERE id_manutencao = @id";
            command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id", Convert.ToInt32(txtId));
            connection.Open();
            int id = 0;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32((reader["id_manutencao"]));
            }
            connection.Close();
            if (id > 0)
            {
                sql = "delete from manutencao where id_manutencao = @id";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
        }

        public static int add_pagamento(string tipo,string montante, string id_cliente)
        {
            MySqlConnection connection;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            if (tipo != "" || montante != "")
            {
                sql = "insert into pagamento (id_cliente, tipo, montante, data) values (@id_cliente, @tipo, @montante, curdate());";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@tipo", tipo);
                command.Parameters.AddWithValue("@montante", montante);
                command.Parameters.AddWithValue("@id_cliente", Convert.ToInt16(id_cliente));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
        }

        public static int remove_pagamento(string txtId)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            sql = "SELECT * FROM pagamento WHERE id_pagamento = @id";
            command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id", Convert.ToInt32(txtId));
            connection.Open();
            int id = 0;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32((reader["id_pagamento"]));
            }
            connection.Close();
            if (id > 0)
            {
                sql = "delete from pagamento where id_pagamento = @id";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
        }

    }
}
