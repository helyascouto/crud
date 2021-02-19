using CadastroProdutos.Class;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace CadastroProdutos
{
    public partial class frameCadastro : Form

    {
        SqlCommand executeSql;
        SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BUTFIRE\SistemaCadastro\CadastroPessoas\BD\DB_SistemaCadastro.mdf;Integrated Security=True");
        SqlDataAdapter da;
        String comandoSql;
        DataSet ds;
        Funcionarios f = new Funcionarios();





        public frameCadastro()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frameCadastro_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void limparCampos()
        {
            txtNome.Text = null;
            txtTelefone.Text = null;
            txtSalario.Text = null;
            txtEmail.Text = null;
            dateTimePicker.Text = null;
            txtCidade.Text = null;
            comboBoxEstado.Text = null;
            txtCep.Text = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            f.nome = txtNome.Text;
            f.sexo = groupBox1.Text;
            f.telefone = txtTelefone.Text;
            f.email = txtEmail.Text;
            f.nascimento = Convert.ToDateTime(dateTimePicker.Text);
            f.cidade = txtCidade.Text;
            f.estado = comboBoxEstado.Text;
            f.cep = txtCep.Text;

            try
            {
                f.salario = Convert.ToDouble(txtSalario.Text);
            }
            catch (Exception)
            {
                sb.Append("O campo salario é obrigatório." + "\n");
            }





            List<ValidationResult> listaErro = new List<ValidationResult>();
            ValidationContext contexto = new ValidationContext(f);
            bool validado = Validator.TryValidateObject(f, contexto, listaErro, true);
            //

            if (validado)
            {

                comandoSql = " INSERT INTO  TB_FUNCIONARIOS (" +
                    "NOME , SEXO, TELEFONE, SALARIO, EMAIL,NASCIMENTO, CIDADE, ESTADO,CEP ) " +
                    "VALUES (@NOME,@SEXO, @TELEFONE, @SALARIO, @EMAIL,@NASCIMENTO, @CIDADE, @ESTADO, @CEP) ";
                executeSql = new SqlCommand(comandoSql, conexao);
                executeSql.Parameters.AddWithValue("@NOME", f.nome);
                executeSql.Parameters.AddWithValue("@SEXO", f.sexo);
                executeSql.Parameters.AddWithValue("@TELEFONE", f.telefone);
                executeSql.Parameters.AddWithValue("@SALARIO", f.salario);
                executeSql.Parameters.AddWithValue("@EMAIL", f.email);
                executeSql.Parameters.AddWithValue("@NASCIMENTO", f.nascimento);
                executeSql.Parameters.AddWithValue("@CIDADE", f.cidade);
                executeSql.Parameters.AddWithValue("@ESTADO", f.estado);
                executeSql.Parameters.AddWithValue("@CEP", f.cep);


                conexao.Open();
                executeSql.ExecuteNonQuery();

                MessageBox.Show("Cadastro Salvo com Suceso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();

                conexao.Close();
                conexao = null;
                executeSql = null;


            }
            else
            {


                foreach (ValidationResult erro in listaErro)
                {
                    sb.Append(erro.ErrorMessage + "\n");
                }

                lbErro.Text = sb.ToString();
            }


        }

        private void btnLinpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }



}
