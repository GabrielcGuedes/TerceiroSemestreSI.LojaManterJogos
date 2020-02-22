using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Loja_de_jogos_God_games_Avaliacao.ConexaoBD;

namespace Loja_de_jogos_God_games_Avaliacao
{
    public partial class Form1 : Form
    {
        public string value { get; set; }
        public Form1()
        {
            InitializeComponent();
        } 
        private void Form1_Load(object sender, EventArgs e)
        {
            txtCod.Text = value;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeJogo = txtNomeJogo.Text;
                int codigo_cadastro_fk = int.Parse(txtCod.Text);
                double preco = double.Parse(txtPreco.Text);
                int quantidade = int.Parse(txtQtd.Text);

                Classes.ArmazenarJogo objJogo = new Classes.ArmazenarJogo();

                objJogo.nomeJogo = nomeJogo;
                objJogo.codigo_cadastro_fk = codigo_cadastro_fk;
                objJogo.preco = preco;
                objJogo.quantidade = quantidade;

                objJogo.Cadastrar();

                MessageBox.Show("operação realizada com sucesso!");
                    
             } catch(Exception ex)
            {
                MessageBox.Show("Erro ao tentar cadastrar." + ex.Message, "falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Classes.ArmazenarJogo objJogo = new Classes.ArmazenarJogo();

            dgvJogo.DataSource = objJogo.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
                try
                {
                    int codigo = int.Parse(txtCodigoJogo.Text);

                    Classes.ArmazenarJogo objJogo = new Classes.ArmazenarJogo();
                    objJogo.codigo = codigo;

                    objJogo.Excluir();

                    MessageBox.Show("operação realizada com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar excluir." + ex.Message, "falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigoJogo.Text);
                double preco = double.Parse(txtPreco.Text);
                int quantidade = int.Parse(txtQtd.Text);

                Classes.ArmazenarJogo objJogo = new Classes.ArmazenarJogo();
                objJogo.codigo = codigo;
                objJogo.preco = preco;
                objJogo.quantidade = quantidade;

                objJogo.Atualizar();

                MessageBox.Show("operação realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar. " + ex.Message, "falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigoJogo.Text);


                Classes.ArmazenarJogo objJogo = new Classes.ArmazenarJogo();
                objJogo.codigo = codigo;
                dgvJogo.DataSource = objJogo.Pesquisar();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar pesquisar. " + ex.Message, "falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Closed += (s, args) => this.Close();
            NpgsqlConnection conexao = null;
            conexao = ConectarBD.getConexao();
            if (conexao == null)
            {
                conexao.Close();
            }
            f.Show();
        }

        private void btnInstruções_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrar:Nome do Jogo - Preço - Quantidade\nPesquisar:Codigo Jogo\nListar:Pressionar o propío botão\nAtualizar:Codigo Jogo - Preço - Quantidade\nExcluir:Codigo Jogo");
        }
    }
}
