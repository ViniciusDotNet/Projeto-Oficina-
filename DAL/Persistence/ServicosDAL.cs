using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.MODEL;
namespace DAL.Persistence
{
    public class ServicosDAL : Conexao
    {

        public void GravarTipoServico(Servicos s)
        {
            try
            {
                AbriConexao();
                Cmd = new SqlCommand("insert into Servicos(TipoServico,DescricaoServico,StatuServico) values(@v1,@v2,@v3)", Con);

                Cmd.Parameters.AddWithValue("@V1", s.TipoServico);
                Cmd.Parameters.AddWithValue("@v2",s.DescricaoServico);
                Cmd.Parameters.AddWithValue("@v3", s.Statuservico);
                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar o Tipo de Serviço" + ex.Message);
            }

            finally
            {
                FecharConexao();

            }
        }


        public void AtualizarServico(Servicos s)
        {
            try
            {
                AbriConexao();
                Cmd = new SqlCommand("update  Servicos  set  TipoServico=@v1,DescricaoServico=@v2, StatuServico=@v3", Con);

                Cmd.Parameters.AddWithValue("@V1", s.TipoServico);
                Cmd.Parameters.AddWithValue("@V2", s.DescricaoServico);
                Cmd.Parameters.AddWithValue("@V3", s.Statuservico);
              
                Cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {

                throw new Exception("Erro ao Atualizar Serviço" + ex.Message);
            }

            finally
            {
                FecharConexao();
            }
        }


        public void ExcluirServico(int codigo)
        {
            try
            {
                AbriConexao();
                Cmd = new SqlCommand("delete from Servicos  where codigo=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir Serviço" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        public Servicos PesquisarServicoporCodigo(int codigoservico)
        {
            try
            {
                AbriConexao();

                Cmd = new SqlCommand("select * from Servicos where codigoservico=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", codigoservico);

                Dr = Cmd.ExecuteReader(); //  cmd= objeto de comando criado , Dr= objeto para leitura de dados  leitura dos dados 

                Servicos s = null;

                if (Dr.Read())
                {
                    s = new Servicos();

                    s.codigoservico = Convert.ToInt32(Dr["codigoservico"]);
                    s.TipoServico = Convert.ToString(Dr["TipoServico"]);
                    s.DescricaoServico = Convert.ToString(Dr["DescricaoServico"]);
                    s.Statuservico = Convert.ToString(Dr["StatuServico"]);
                    
                }

                return s;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pequisar o Servico por Código" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        public List<Servicos> ListarServico()
        {
            try
            {
                AbriConexao();
                Cmd = new SqlCommand("select * from Servicos", Con);

                Dr = Cmd.ExecuteReader();

                List<Servicos> lista = new List<Servicos>();

                while (Dr.Read())
                {
                    Servicos s = new Servicos();

                    s.codigoservico = Convert.ToInt32(Dr["codigoservico"]);
                    s.TipoServico = Convert.ToString(Dr["TipoServico"]);
                    s.DescricaoServico = Convert.ToString(Dr["DescricaoServico"]);
                    s.Statuservico = Convert.ToString(Dr["StatuServico"]);
                    

                    lista.Add(s);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Listar Serviço" + ex.Message);

            }
            finally
            {
                FecharConexao();
            }

        }


    }
}

