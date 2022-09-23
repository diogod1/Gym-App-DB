using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymLogIn
{
    public partial class frmGContaUser : Form
    {
        public frmGContaUser()
        {
            InitializeComponent();
            txtInNome.Visible = false;
            txtInPassword.Visible = false;
            txtInUsername.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label4.Visible = false;
            btnEditar.Visible = false;

            txtOutNome.Text = user.nome;
            txtOutPassword.Text = user.password;
            txtOutUsername.Text = user.username;
        }

        private void chckbxEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxEditar.Checked)
            {
                txtInNome.Visible = true;
                txtInPassword.Visible = true;
                txtInUsername.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label4.Visible = true;
                btnEditar.Visible = true;
            }
            else
            {
                txtInNome.Visible = false;
                txtInPassword.Visible = false;
                txtInUsername.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label4.Visible = false;
                btnEditar.Visible = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem a certeza que pretende editar os seus dados?","Aviso",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                user.editar_dados(txtInUsername.Text, txtInNome.Text, txtInPassword.Text);
                MessageBox.Show("Dados registados");
            }
            else
            {
                MessageBox.Show("Operação cancelada");
            }
        }
    }
}
