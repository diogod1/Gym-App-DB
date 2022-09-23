using System.Runtime.InteropServices;

namespace GymLogIn
{
    public partial class frmHomeUser : Form
    {
        public frmHomeUser()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<NovoForm>() where NovoForm : Form, new()
        {
            Form formulario;
            formulario = panel4.Controls.OfType<NovoForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new NovoForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel4.Controls.Add(formulario);
                panel4.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fl = new frmLogin();
            fl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmGContaUser>();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picboxMin_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmGConsultaUser>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmGAulasUser>();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<frmGPagamentoUser>();
        }
    }
}