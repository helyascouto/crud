using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroProdutos.Class
{
    public class Funcionarios
    {
        [Required, StringLength(70, MinimumLength = 5)]
        public String nome { get; set; }
        [Required]
        public String telefone { get; set; }
        [Required, EmailAddress]
        public String email { get; set; }
        [Required]
        public DateTime nascimento { get; set; }
        [Required]
        public String cidade { get; set; }
        [Required]
        public Double salario { get; set; }
        [Required]
        public String estado { get; set; }
        [Required]
        public String cep { get; set; }

        public String sexo { get; set; }
        

        

        SqlCommand executeSql;
        SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BUTFIRE\SistemaCadastro\CadastroPessoas\BD\DB_SistemaCadastro.mdf;Integrated Security=True");
        SqlDataAdapter da;
        String comandoSql;
        DataSet ds;




        public void AlterarFuncionario( String ID , String NOME, String SEXO, String TELEFONE, Double SALARIO,
            String EMAIL, DateTime NASCIMENTO, String CIDADE, String ESTADO, String CEP)
        {
            try
            {
                comandoSql = "UPDATE TB_FUNCIONARIOS  SET NOME = @NOME , SEXO = @SEXO, TELEFONE = @TELEFONE," +
                    " SALARIO = @SALARIO, EMAIL = @EMAIL,NASCIMENTO = @NASCIMENTO, CIDADE = @CIDADE, ESTADO = @ESTADO, CEP = @CEP  WHERE ID = @ID";
                executeSql = new SqlCommand(comandoSql, conexao);
                executeSql.Parameters.AddWithValue("@ID", ID);
                executeSql.Parameters.AddWithValue("@NOME", NOME);
                executeSql.Parameters.AddWithValue("@SEXO", SEXO);
                executeSql.Parameters.AddWithValue("@TELEFONE", TELEFONE);
                executeSql.Parameters.AddWithValue("@SALARIO", Convert.ToDouble(SALARIO));
                executeSql.Parameters.AddWithValue("@EMAIL", EMAIL);
                executeSql.Parameters.AddWithValue("@NASCIMENTO", Convert.ToDateTime(NASCIMENTO));
                executeSql.Parameters.AddWithValue("@CIDADE", CIDADE);
                executeSql.Parameters.AddWithValue("@ESTADO", ESTADO);
                executeSql.Parameters.AddWithValue("@CEP", CEP);

                conexao.Open();
                executeSql.ExecuteNonQuery();

                MessageBox.Show("Funcionário Alterado com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                conexao.Close();
                conexao = null;
                executeSql = null;

            }

        }

        public void ExcluirFuncionario(String id)
        {
            try
            {
                comandoSql = "DELETE FROM TB_FUNCIONARIOS WHERE ID = @ID";
                executeSql = new SqlCommand(comandoSql, conexao);
                executeSql.Parameters.AddWithValue("@ID", id);

                conexao.Open();
                executeSql.ExecuteNonQuery();


                MessageBox.Show("Funcionario Excluido com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                executeSql = null;

            }
        }



    }
}
