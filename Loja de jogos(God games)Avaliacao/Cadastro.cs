using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_de_jogos_God_games_Avaliacao
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void lblSenha2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            {
                if (txtNomeFunc.Text == string.Empty)
                {
                    MessageBox.Show("O campo nome não pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtUsuario.Text == string.Empty)
                {
                    MessageBox.Show("O campo usuario não pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtSenha1.Text == string.Empty)
                {
                    MessageBox.Show("O campo senha não pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtSenha2.Text == string.Empty)
                {
                    MessageBox.Show("O campo Digite novamente não pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtSenha1.Text != txtSenha2.Text)
                {
                    MessageBox.Show("As senhas nao se coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtcodigo_Cadastro.Text == string.Empty)
                {
                    MessageBox.Show("O campo código não pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                try
                {
                    int codigo_cadastro = int.Parse(txtcodigo_Cadastro.Text);
                    string nome = txtNomeFunc.Text;
                    string senha = txtSenha1.Text;
                    string usuario = txtUsuario.Text;

                    Classes.Cadastro objCadastro = new Classes.Cadastro();

                    objCadastro.codigo_cadastro = codigo_cadastro;
                    objCadastro.nome = nome;
                    objCadastro.senha = senha;
                    objCadastro.usuario = usuario;

                    objCadastro.Cadastrar();

                    MessageBox.Show("operação realizada com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar cadastrar." + ex.Message, "falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodexc.Text);

                Classes.Cadastro objExlcuir = new Classes.Cadastro();
                objExlcuir.codigo_cadastro = codigo;

                objExlcuir.Excluir();

                MessageBox.Show("operação realizada com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar excluir." + ex.Message, "falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
