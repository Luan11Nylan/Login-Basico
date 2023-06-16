using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemalogin
{
    public partial class FormLogin : Form
    {
        public static bool cancelar = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;
            if (CadastroUsuario.Login(nome, senha))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Acesso negado!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar = true;
            this.Close();
        }
    }
}
