using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GymLogIn
{
    public partial class frmLogin : Form
    {
        MySqlConnection connection;
        MySqlDataReader reader;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        string sql;


        public frmLogin()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != "" || txtUserName.Text != "")
            {
                if (user.login(txtUserName.Text, txtPassword.Text) == 0)
                {
                    if(user.id != 0)
                    {
                        this.Hide();
                        frmHomeUser fu = new frmHomeUser();
                        fu.ShowDialog();
                    }
                    else if(staff.id != 0)
                    {
                        this.Hide();
                        frmHomeStaff frm = new frmHomeStaff();
                        frm.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        frmHome fa = new frmHome();
                        fa.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Password incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRegister fr = new frmRegister();
            fr.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
