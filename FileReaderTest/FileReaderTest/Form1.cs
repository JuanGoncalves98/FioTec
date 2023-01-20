using System.IO.Compression;

namespace FileReaderTest
{
    public partial class Form1 : Form
    {
        Controle controle;

        public Form1()
        {
            InitializeComponent();
            controle = new Controle();
        }

        private void btnLocalizarArquivo_Click(object sender, EventArgs e)
        {
            fileDialogLocalizar.ShowDialog();
            txtPath.Text = fileDialogLocalizar.FileName;
            btnCarregarArquivo.Enabled = true;
        }

        private void btnCarregarArquivo_Click(object sender, EventArgs e)
        {
            lstConteudoLido.Items.AddRange(File.ReadAllLines(txtPath.Text));
            btnCarregarArquivo.Enabled = false;
        }

        private void btnInserirBD_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstConteudoLido.Items.Count; i++)
            {
                controle.inserir(lstConteudoLido.Items[i].ToString());
            }
        }
    }
}