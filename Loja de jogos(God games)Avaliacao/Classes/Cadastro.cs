using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Loja_de_jogos_God_games_Avaliacao.ConexaoBD;

namespace Loja_de_jogos_God_games_Avaliacao.Classes
{
    class Cadastro
    {
        public int codigo_cadastro { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }

        public Cadastro() { }
        public Cadastro(string nome, String usuario, string senha, int codigo_cadastro)
        {
            this.codigo_cadastro = codigo_cadastro;
            this.nome = nome;
            this.usuario = usuario;
            this.senha = senha;

        }
        public void Cadastrar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectarBD.getConexao();
                string sql = "insert into Cadastro(codigo_cadastro,nome,usuario,senha) values" + "('" + this.codigo_cadastro + "','" + this.nome + "','" + this.usuario + "','" + this.senha + "')";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add(new NpgsqlParameter("@codigo_cadastro", this.codigo_cadastro));
                cmd.Parameters.Add(new NpgsqlParameter("@nome", this.nome));
                cmd.Parameters.Add(new NpgsqlParameter("@usuario", this.usuario));
                cmd.Parameters.Add(new NpgsqlParameter("@senha", this.senha));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }
        public void Excluir()
        {
            NpgsqlConnection conexao = null;
            try
            {

                conexao = ConectarBD.getConexao();
                string sql = "delete from Cadastro where " + " codigo_cadastro" + "=" + this.codigo_cadastro;
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add(new NpgsqlParameter("@codigo_cadastro", this.codigo_cadastro));
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }

        }
        public bool tem { get; set; }
        public bool Entrar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                
                conexao = ConectarBD.getConexao();
                String sql = ("Select * from Cadastro where usuario = '" + this.usuario + "' and senha= '" + this.senha + "' and codigo_cadastro= '" + this.codigo_cadastro + "'");
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add(new NpgsqlParameter("@usuario", this.usuario));
                cmd.Parameters.Add(new NpgsqlParameter("@senha", this.senha));
                cmd.Parameters.Add(new NpgsqlParameter("@codigo_cadastro", this.codigo_cadastro));
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }
                return tem;




            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }

        }
    }
}

