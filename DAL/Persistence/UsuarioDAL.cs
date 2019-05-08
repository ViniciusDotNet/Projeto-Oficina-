using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.MODEL;

namespace DAL.Persistence
{
    public class UsuarioDAL : Conexao
    {
        // metodo para gravar os dados
        public void Gravar(Usuario u)
        {
            try
            {
                AbriConexao();
                Cmd = new SqlCommand("insert into Usuario(Nome,Endereco,Email) values(@v1,@v2,@v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", u.Nome);
                Cmd.Parameters.AddWithValue("@v2", u.Endereco);
                Cmd.Parameters.AddWithValue("@v3", u.Email);

                Cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar usuario" + ex.Message);
            }

            finally
            {
                FecharConexao();
            }

        }

        // metodo para atualizar os dados 
        public void AtualizarDados(Usuario u)
        {
            try
            {
                AbriConexao();

                Cmd = new SqlCommand("Update  Usuario set Nome=@v1, Endereco=@v2, Email=@v3 where Codigo=@v4", Con);

                Cmd.Parameters.AddWithValue("@v1", u.Nome);
                Cmd.Parameters.AddWithValue("@v2", u.Endereco);
                Cmd.Parameters.AddWithValue("@v3", u.Email);
                Cmd.Parameters.AddWithValue("@v4", u.Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar o usuario" + ex.Message);
            }
            finally
            {
                FecharConexao();

            }
        }

        // metodo para excluir
        public void Excluir(int Codigo)
        {
            try
            {
                AbriConexao();
                Cmd = new SqlCommand("delete  from Usuario where codigo = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {

                throw new Exception("Erro ao Excluir Usuario" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // metodo para efetuar bucar pelo codigo (ID) do usuario
        public Usuario Pesquisarporcodigo(int Codigo)
        {
            try
            {
                AbriConexao();

                Cmd = new SqlCommand("select * from Usuario where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Dr = Cmd.ExecuteReader(); // leitura dos dados

                Usuario u = null; // dedica um espaço na memória do sistema 

                if (Dr.Read())
                {
                    u = new Usuario();

                    u.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    u.Nome = Convert.ToString(Dr["Nome"]);
                    u.Endereco = Convert.ToString(Dr["Endereco"]);
                    u.Email = Convert.ToString(Dr["Email"]);
                }

                return u;
            }

            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar Usuario" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // metodo para listar 
        public List<Usuario> Listar()
        {
            try
            {
                AbriConexao();

                Cmd = new SqlCommand("select * from Usuario", Con);

                //METODO PARA LER 
                Dr = Cmd.ExecuteReader();

                List<Usuario> lista = new List<Usuario>();

                while (Dr.Read())
                {
                    Usuario u = new Usuario();

                    u.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    u.Nome = Convert.ToString(Dr["Nome"]);
                    u.Endereco = Convert.ToString(Dr["Endereco"]);
                    u.Email = Convert.ToString(Dr["Email"]);

                    lista.Add(u);
                }

                return lista;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Listar Usuarios" + ex.Message);
            }

            finally
            {
                FecharConexao();
            }
        }
    }
}
