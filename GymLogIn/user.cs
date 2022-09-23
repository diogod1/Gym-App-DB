using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GymLogIn
{
    public static class user
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

        public static int login(string txtUserName, string txtPassword)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            MySqlDataAdapter adapter;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            string sql = "SELECT * FROM users WHERE username = @username";

            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", txtUserName);
            connection.Open();
            string pass = " ";
            string username = "";
            string nome = "";
            string cargo = "";
            int id = 0;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                pass = Convert.ToString(reader["password"]);
                username = Convert.ToString(reader["username"]);
                nome = Convert.ToString(reader["nome"]);
                cargo = Convert.ToString(reader["cargo"]);
                id = Convert.ToInt32(reader["id_users"]);
            }

            if (String.Equals(txtPassword, pass))
            {
                if(cargo == "S")
                {
                    staff.id = id;
                    staff.nome = nome ;
                    staff.username = username ;
                    staff.password = pass ;

                    Admin.id = 0;
                    user.id = 0;
                    return 0;

                }
                else if(cargo == "A")
                {
                    Admin.id = id;
                    Admin.nome = nome;
                    Admin.username = username;
                    Admin.password = pass;

                    user.id = 0;
                    staff.id = 0;
                    return 0;
                }
                else if(cargo == "C")
                {
                    user.id = id;
                    user.Password = pass;
                    user.Username = username;
                    user.Nome = nome;

                    Admin.id=0;
                    staff.id = 0;
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                connection.Close();
                return 1;
            }
            return 1;
        }

        public static int add_consulta(string txtidConsulta, string txtdata)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            MySqlDataAdapter adapter;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            if (txtidConsulta != "")
            {
                sql = "insert into marcacao_consulta (id_cliente,id_consulta,data) values (@id_cliente,@id_consulta,@data)";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id_cliente", user.id);
                command.Parameters.AddWithValue("@id_consulta", Convert.ToInt32(txtidConsulta));
                command.Parameters.AddWithValue("@data", txtdata);
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

        public static int remover_consulta(string txtIdmarcacao)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            sql = "SELECT * FROM marcacao_consulta WHERE id_marcacao = @id AND id_cliente = @id_c";
            command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id", txtIdmarcacao);
            command.Parameters.AddWithValue("@id_c", user.id);
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
        }

        public static int editar_dados(string username,string nome,string password)
        {
            MySqlConnection connection;
            MySqlDataReader reader;
            MySqlCommand command;
            string sql;

            connection = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");
            sql = "update users set username = @username where id_users = @id";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            sql = "update users set password = @password where id_users = @id";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            sql = "update users set nome = @nome where id_users = @id";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return 0;
        }

        public static int add_pagamento(string tipo, string montante)
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
                command.Parameters.AddWithValue("@id_cliente", user.id);
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