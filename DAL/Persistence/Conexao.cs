using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL.Persistence
{
    public class Conexao
    {
        // Declaração dos atributos da conexão
        protected SqlConnection Con;

        protected SqlCommand Cmd;

        protected SqlDataReader Dr;

        // Metodos da conexao 
        protected void AbriConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
                Con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }


}
