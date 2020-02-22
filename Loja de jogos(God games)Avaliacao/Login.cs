using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja_de_jogos_God_games_Avaliacao.Classes;

namespace Loja_de_jogos_God_games_Avaliacao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {

            this.Hide();
            Cadastro f = new Cadastro();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int codigo_usuario = int.Parse(txtCodigoUsuario.Text);
            String usuario = txtUsuario.Text;
            String senha = txtSenha.Text;

            Classes.Cadastro objCadastro = new Classes.Cadastro();

            objCadastro.codigo_cadastro = codigo_usuario;
            objCadastro.usuario = usuario;
            objCadastro.senha = senha;
            objCadastro.Entrar();
            if (objCadastro.tem == true)
            {
                Form1 form1 = new Form1();
                form1.value = txtCodigoUsuario.Text;
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao tentar logar.", "falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }
    }
}
