using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace W1T2BQ3
{
    public partial class CarregaAluno : System.Web.UI.Page
    {
        int id = 1; //(exemplo)
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCarregaAluno_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"select * from aluno where id =" + id.ToString();

                Conexao.Conectar();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Carrega dados da tabela gerada para a pagina
                    // txtID.Text = reader["id"].ToString(); ...
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = $"Falha: {ex.Message}";
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
    }
}