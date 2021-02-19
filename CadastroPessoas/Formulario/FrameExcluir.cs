using CadastroProdutos.Class;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroProdutos
{
    public partial class FrameExcluir : Form

    {
        SqlConnection conexao;
        String comandoSql;
        SqlCommand executeSql;

        public FrameExcluir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limparCampos()
        {
            txtNome.Text = null;
            txtEmail.Text = null;
            dateTimePicker.Text = null;
            txtCidade.Text = null;
            comboBoxEstado.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BUTFIRE\SistemaCadastro\CadastroPessoas\BD\DB_SistemaCadastro.mdf;Integrated Security=True");
                comandoSql = "SELECT * FROM TB_FUNCIONARIOS WHERE ID = @ID ";
                executeSql = new SqlCommand(comandoSql, conexao);
                executeSql.Parameters.AddWithValue("@ID", txtPesquisar.Text);

                conexao.Open();
                SqlDataReader dr = executeSql.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = dr["NOME"].ToString();
                    txtEmail.Text = dr["EMAIL"].ToString();
                    dateTimePicker.Text = dr["NASCIMENTO"].ToString();
                    txtCidade.Text = dr["CIDADE"].ToString();
                    comboBoxEstado.Text = dr["ESTADO"].ToString();
                }

                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Não existe Funcionário com esse Id!","Informação",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,"Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            finally
            {
                conexao.Close();
                conexao = null;
                executeSql = null;

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("Deseja realmente alterar o Funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    Funcionarios f = new Funcionarios();
                    f.ExcluirFuncionario(txtPesquisar.Text);
                    limparCampos();
                }



                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrameExcluir_Load(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
