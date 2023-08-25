namespace Atividade3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void criarNovoArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter texto1;
            string caminho = "D:\\Gabriel INF221\\2508 txt\\teste3.txt";

            texto1 = File.CreateText(caminho);

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter texto1;
            string caminho = "D:\\Gabriel INF221\\2508 txt\\teste3.txt";
            texto1 = File.CreateText(caminho);

            texto1.WriteLine(richTextBox1.Text);

            texto1.Close();
        }

        private void abrirNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caminho = "D:\\Gabriel INF221\\2508 txt\\teste3.txt";
            System.Diagnostics.Process.Start("notepad", caminho);
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamReader texto2;
            string caminho = "D:\\Gabriel INF221\\2508 txt\\teste3.txt";
            texto2 = File.OpenText(caminho);

            string AllText = texto2.ReadToEnd();

            richTextBox1.Text = AllText;

            texto2.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}