namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtPalavra;
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            lblpalavra.Text = txtPalavra.Text.Trim();
            txtPalavra.Text = string.Empty;
            this.ActiveControl = txtPalavra;
        }

        private void txtPalavra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
