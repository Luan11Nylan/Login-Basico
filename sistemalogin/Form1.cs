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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object Label_BoasVindas { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            
            while (CadastroUsuario.UsuarioLogado == null)
            {
                Visible = false;
                f.ShowDialog();

                if (FormLogin.cancelar)
                {
                    Application.Exit();
                    return;
                }
            }

            label_BoasVindas.Text = "Bem vindo(a) \n" + CadastroUsuario.UsuarioLogado.Nome;
            Visible = true;
        }
    }
}
