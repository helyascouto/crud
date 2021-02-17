using CadastroProdutos;
using CadastroProdutos.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;


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
                SqlCommand executeSql;

                executeSql = new SqlCommand(comandoSql, conexao);

                conexao.Open();

                SqlDataReader dr = executeSql.ExecuteReader();

                while (dr.Read())
                {
                    
                    dataGridViewPrincipal.Rows.Add(dr["ID"].ToString(), dr["NOME"].ToString(), dr["SEXO"].ToString(), dr["TELEFONE"].ToString(), dr["SALARIO"].ToString(),
                     dr["NASCIMENTO"].ToString(), dr["CIDADE"].ToString(), dr["ESTADO"].ToString(), dr["CEP"].ToString());

     

                }

                

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

         
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
            
           

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dataGridViewPrincipal.Height;
            Bitmap folha;
            String texto = "Funcionários";
            Font fonte = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            Pen lapis = new Pen(Color.Black, 5);
            Brush corTexto = new SolidBrush(Color.Red);
            Point pontoInicial = new Point(50, 50);

            // Formatação do documento

            Rectangle area = printDocument1.DefaultPageSettings.Bounds;
            int x = printDocument1.DefaultPageSettings.Bounds.X;
            int y = printDocument1.DefaultPageSettings.Bounds.Y;
            int altura = printDocument1.DefaultPageSettings.Bounds.Height;
            int largura = printDocument1.DefaultPageSettings.Bounds.Width;
            Rectangle areaTitulo = new Rectangle(0, 100 ,largura , 50 );
            Rectangle areaImpressa = new Rectangle(x, y, largura , 200);
            
            StringFormat formatoTitulo = new StringFormat();
            formatoTitulo.Alignment = StringAlignment.Center;
            formatoTitulo.LineAlignment = StringAlignment.Center;

            dataGridViewPrincipal.Height = dataGridViewPrincipal.RowCount * dataGridViewPrincipal.RowTemplate.Height * 2;
            folha = new Bitmap(dataGridViewPrincipal.Width, dataGridViewPrincipal.Height);


            texto = "Funcionários: Elias \n" +
                     "sexo : masculino \n" +
                     " fghfghfgh";
                     


            e.Graphics.DrawString(texto,fonte,corTexto,areaTitulo,formatoTitulo);
            dataGridViewPrincipal.DrawToBitmap(folha, areaImpressa);
           // e.Graphics.DrawImage(folha, 5,200);

            dataGridViewPrincipal.Height = height;

           
    
        }
    }
}
