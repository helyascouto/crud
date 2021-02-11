using CadastroProdutos;
using CadastroProdutos.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CadastroPessoas
{

    public partial class FrameVisualizar : Form
    {
        Funcionarios f = new Funcionarios();
        SqlConnection conexao;

        public void carregaDatagrid()
        {
            
            try

            {
                
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BUTFIRE\crud\CadastroPessoas\BD\DB_SistemaCadastro.mdf;Integrated Security=True;Connect Timeout=30");
                String comandoSql = "SELECT * FROM TB_FUNCIONARIOS";
                SqlDataAdapter da = new SqlDataAdapter(comandoSql, conexao);
                DataSet ds = new DataSet();

                conexao.Open();
                da.Fill(ds);
                dataGridViewPrincipal.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
            };
        }
        public FrameVisualizar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregaDatagrid();
            
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frameCadastro frm = new frameCadastro();
            frm.MdiParent = this;
            frm.Show();

        }

        private void pisquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridViewPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void impressao_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            this.dataGridViewPrincipal.Refresh();
        }
    }
}
