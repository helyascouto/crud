using CadastroProdutos.Class;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroProdutos
{
    public partial class FrameAlterar : Form
    {
        Funcionarios f = new Funcionarios();
        SqlConnection conexao;
        String comandoSql;
        SqlCommand executeSql;

        public FrameAlterar()
        {
            InitializeComponent();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limparCampos()
        {

            txtNome.Text = null;
            groupBox1.Text = null;
            txtTelefone.Text = null;
            txtSalario.Text = null;
            txtEmail.Text = null;
            dateTimePicker.Text = null;
            txtCidade.Text = null;
            comboBoxEstado.Text = null;
            txtCep.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BUTFIRE\source\repos\CadastroPessoas\CadastroPessoas\BD\DB_SistemaCadastro.mdf;Integrated Security=True;Connect Timeout=30");
                comandoSql = " SELECT * FROM TB_FUNCIONARIOS WHERE ID = @ID ";
                executeSql = new SqlCommand(comandoSql, conexao);

                executeSql.Parameters.AddWithValue("@ID", txtPesquisar.Text);
                conexao.Open();

                SqlDataReader dr = executeSql.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = dr["NOME"].ToString();
                    groupBox1.Text = dr["SEXO"].ToString();
                    txtTelefone.Text = dr["TELEFONE"].ToString();
                    txtSalario.Text = dr["SALARIO"].ToString();
                    txtEmail.Text = dr["EMAIL"].ToString();
                    dateTimePicker.Text = dr["NASCIMENTO"].ToString();
                    txtCidade.Text = dr["CIDADE"].ToString();
                    comboBoxEstado.Text = dr["ESTADO"].ToString();
                    txtCep.Text = dr["CEP"].ToString();


                }

                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Não existe Funcionario com esse Id!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexao.Close();
                executeSql = null;
                comandoSql = null;
            }

        }



        private void btnLinpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Deseja realmente alterar o Funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Funcionarios F = new Funcionarios();
                F.AlterarFuncionario(txtPesquisar.Text, txtNome.Text, groupBox1.Text, txtTelefone.Text, Convert.ToDouble(txtSalario.Text), txtEmail.Text, Convert.ToDateTime(dateTimePicker.Text), txtCidade.Text, comboBoxEstado.Text, txtCep.Text);
                limparCampos();
                txtPesquisar.Text = null;
            }

        }

        

        private void FrameAlterar_Load(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
        }

       
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {

                limparCampos();
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BUTFIRE\SistemaCadastro\CadastroPessoas\BD\DB_SistemaCadastro.mdf;Integrated Security=True");
                comandoSql = " SELECT * FROM TB_FUNCIONARIOS WHERE ID = @ID ";
                executeSql = new SqlCommand(comandoSql, conexao);

                executeSql.Parameters.AddWithValue("@ID", txtPesquisar.Text);
                conexao.Open();

                SqlDataReader dr = executeSql.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = dr["NOME"].ToString();
                    groupBox1.Text = dr["SEXO"].ToString();
                    txtTelefone.Text = dr["TELEFONE"].ToString();
                    txtSalario.Text = dr["SALARIO"].ToString();
                    txtEmail.Text = dr["EMAIL"].ToString();
                    dateTimePicker.Text = dr["NASCIMENTO"].ToString();
                    txtCidade.Text = dr["CIDADE"].ToString();
                    comboBoxEstado.Text = dr["ESTADO"].ToString();
                    txtCep.Text = dr["CEP"].ToString();


                }

                if (string.IsNullOrEmpty(txtNome.Text) != String.IsNullOrEmpty(txtPesquisar.Text))
                {

                    MessageBox.Show("Não existe Funcionário com esse Id!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexao.Close();
                executeSql = null;
                comandoSql = null;
            }
        }
    }
}
