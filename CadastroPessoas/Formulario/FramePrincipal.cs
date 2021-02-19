using CadastroPessoas;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using SistemaCadastro;

namespace CadastroProdutos
{
    public partial class FramePrincipal : Form
    {


        public FramePrincipal()
        {
            InitializeComponent();
            FrameVisualizar f = new FrameVisualizar();
            f.carregaDatagrid();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
           
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MdiPrincipal_Load(object sender, EventArgs e)
        {
             
            
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            frameCadastro frm = new frameCadastro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int largura = printDocument1.DefaultPageSettings.Bounds.Width;
            int altura = printDocument1.DefaultPageSettings.Bounds.Height;
            int x = 50;
            int y = 50;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameVisualizar frm = new FrameVisualizar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void printSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frameCadastro frm = new frameCadastro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrameAlterar frm = new FrameAlterar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrameExcluir frm = new FrameExcluir();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrameVisualizar frm = new FrameVisualizar();
            frm.MdiParent = this;
            frm.Show();
               
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Rep_impressao rep = new Rep_impressao();
            rep.MdiParent = this;
            rep.Show();
        }
    }
}
