using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Loja_de_jogos_God_games_Avaliacao.ConexaoBD;

namespace Loja_de_jogos_God_games_Avaliacao.Classes
{
    class ArmazenarJogo
    {
        public int codigo { get; set; }
        public String nomeJogo { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }
        public int codigo_cadastro_fk { get; set; }

        public ArmazenarJogo() { }
        public ArmazenarJogo(int codigo, String nomeJogo, double preco, int quantidade, int codigo_cadastro_fk)
        {
            this.codigo = codigo;
            this.nomeJogo = nomeJogo;
            this.preco = preco;
            this.quantidade = quantidade;
            this.codigo_cadastro_fk = codigo_cadastro_fk;
        }
        public void Cadastrar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectarBD.getConexao();
                string sql = "insert into ArmazenarJogo(nomeJogo,preco,quantidade,codigo_cadastro_fk) values" + "('" + this.nomeJogo + "','"+ this.preco + "','"+ this.quantidade +"','"+ this.codigo_cadastro_fk +"')";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                
                cmd.Parameters.Add(new NpgsqlParameter("@nomeJogo", this.nomeJogo));
                cmd.Parameters.Add(new NpgsqlParameter("@marca", this.preco));
                cmd.Parameters.Add(new NpgsqlParameter("@preco", this.quantidade));
                cmd.Parameters.Add(new NpgsqlParameter("@codigo_cadastro_fk", this.codigo));
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
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
        public List<ArmazenarJogo> Listar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectarBD.getConexao();
                string sql = "SELECT * FROM ArmazenarJogo";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                List<ArmazenarJogo> armazenarJogo = new List<ArmazenarJogo>();
                while(dr.Read())
                {
                    ArmazenarJogo novoJogo = new ArmazenarJogo();
                    novoJogo.codigo = Convert.ToInt16(dr["codigo"]);
                    novoJogo.nomeJogo = dr["nomeJogo"].ToString();
                    novoJogo.preco = Convert.ToDouble(dr["preco"]);
                    novoJogo.quantidade = Convert.ToInt16(dr["quantidade"]);
                    novoJogo.codigo_cadastro_fk = Convert.ToInt16(dr["codigo_cadastro_fk"]);

                    armazenarJogo.Add(novoJogo);

                }
                
                return armazenarJogo;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                if(conexao != null)
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
                string sql = "delete from ArmazenarJogo where " + " codigo" + "=" + this.codigo;
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add(new NpgsqlParameter("@codigo", this.codigo));
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
        public void Atualizar()
        {
            NpgsqlConnection conexao = null; 
            try
            {
                conexao = ConectarBD.getConexao();
                string sql = "update ArmazenarJogo set" + " preco " + " = " + this.preco + " , " + " quantidade " + " = " + this.quantidade + " where " + " codigo " + " = " + this.codigo;
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add(new NpgsqlParameter("@preco", this.preco));
                cmd.Parameters.Add(new NpgsqlParameter("@quantidade", this.quantidade));
                cmd.Parameters.Add(new NpgsqlParameter("@codigo", this.codigo));

                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if(conexao != null)
                {
                    conexao.Close();
                }
            }
        }
        public List<ArmazenarJogo> Pesquisar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectarBD.getConexao();
                string sql = "select codigo,nomeJogo,preco,quantidade,codigo_cadastro_fk from ArmazenarJogo where " + " codigo" + "=" + this.codigo;
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add(new NpgsqlParameter("@codigo", this.codigo));
                NpgsqlDataReader dr = cmd.ExecuteReader();

                List<ArmazenarJogo> armazenarJogo = new List<ArmazenarJogo>();
                while (dr.Read())
                {
                    ArmazenarJogo novoJogo = new ArmazenarJogo();
                    novoJogo.codigo = Convert.ToInt16(dr["codigo"]);
                    novoJogo.nomeJogo = dr["nomeJogo"].ToString();
                    novoJogo.preco = Convert.ToDouble(dr["preco"]);
                    novoJogo.quantidade = Convert.ToInt16(dr["quantidade"]);
                    novoJogo.codigo_cadastro_fk = Convert.ToInt16(dr["codigo_cadastro_fk"]);

                    armazenarJogo.Add(novoJogo);
                }

                return armazenarJogo;
                
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
