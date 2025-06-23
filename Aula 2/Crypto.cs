namespace Aula_2
{
    public partial class Crypto : Form
    {

        private string palavraSecreta;
        private char[] palavraCriptoArray;
        private int tentativasRestantes;

        public Crypto()
        {
            InitializeComponent();
            ResetGame();
        }

        private void ResetGame()
        {
            palavraSecreta = "";
            palavraCriptoArray = null;
            tentativasRestantes = 0;
            txtPalavra.Text = "";
            txtLetra.Text = "";
            txtTentativa.Text = "";
            lblPalavraCripto.Text = "";
            lblPalavraAcertos.Text = "";
            lblAcertouErrou.Text = "";
            txtPalavra.Enabled = true;
            txtPalavra.Visible = true;
            txtTentativa.Enabled = true;
            txtTentativa.Visible = true;
            btnJogar.Enabled = true;
            btnJogar.Visible = true;
            lbLetra.Visible = false;
            txtLetra.Enabled = false;
            txtLetra.Visible = false;
            btnVerificar.Enabled = false;
            btnVerificar.Visible = false;
            picheart1.Image = null;
            picheart2.Image = null;
            picheart3.Image = null;
            picheart4.Image = null;
            picheart5.Image = null;
            picheart6.Image = null;
            picheart7.Image = null;
            picheart8.Image = null;
            picheart9.Image = null;
            picheart10.Image = null;
        }

        private void Crypto_Load(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPalavra.Text))
            {
                MessageBox.Show("Por favor, digite uma palara secreta!", "Palavra Secreta :3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            palavraSecreta = txtPalavra.Text.Trim().ToUpper();

            if (!int.TryParse(txtTentativa.Text, out tentativasRestantes) || tentativasRestantes <= 0)
            {
                MessageBox.Show("Por favor digite um número de tentativas maior que zero e menor que 10!", "Tentativas uwu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTentativa.Text = "";
                this.ActiveControl = txtTentativa;
                return;
            }
            palavraCriptoArray = new char[palavraSecreta.Length];

            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                palavraCriptoArray[i] = '_';
            }
            lblPalavraCripto.Text = $"Palavra ({palavraSecreta.Length} letras): {new string(palavraCriptoArray)}";
            lblPalavraAcertos.Text = new string(palavraCriptoArray);
            txtPalavra.Enabled = false;
            txtPalavra.Text = "";
            txtTentativa.Enabled = false;
            txtTentativa.Text = "";
            btnJogar.Enabled = false;

            /*switch(txtTentativa.Text)
            {
                case "1":
                    picheart1.Visible = true;
                case "2":
                    picheart2.Visible = true;
                    break;
            }*/

            txtLetra.Enabled = true;
            btnVerificar.Enabled = true;
            btnVerificar.Visible = true;
            txtLetra.Focus();
            txtLetra.Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (tentativasRestantes <= 0)
            {
                MessageBox.Show("O jogo acabou!", "Fim de jogo qwq", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
                return;
            }

            if (string.IsNullOrEmpty(txtLetra.Text) || txtLetra.Text.Length != 1)
            {
                MessageBox.Show("Por favor, digite apenas uma letra!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLetra.Text = "";
                txtLetra.Focus();
                return;
            }

            char letraDigitada = char.ToUpper(txtLetra.Text[0]);
            bool acertouLetra = false;

            for (int i = 1; i < palavraSecreta.Length; i++)
            {
                if (palavraSecreta[i] == letraDigitada && palavraCriptoArray[i] == '_')
                {
                    palavraCriptoArray[i] = letraDigitada;
                    acertouLetra = true;
                }
            }
            lblPalavraCripto.Text = $"Palavra ({palavraSecreta.Length} letras): {new string(palavraCriptoArray)}";
            lblPalavraAcertos.Text = new string(palavraCriptoArray);

            if (acertouLetra)
            {
                lblAcertouErrou.Text = $"Acertou!!! Tentativas restantes: {tentativasRestantes}";
                if (new string(palavraCriptoArray) == palavraSecreta)
                {
                    MessageBox.Show($"Parabéns!!! Você acertou a palavra: {palavraSecreta}", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();
                }
            } else {
                tentativasRestantes--;
                lblAcertouErrou.Text = $"Errou!!! Tentativas restantes: {tentativasRestantes}";
                if (tentativasRestantes <= 0)
                {
                    MessageBox.Show($"Terminou!!! A palavra secreta era: {palavraSecreta}", "Fim de jogo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ResetGame();
                }
            }
            txtLetra.Text = "";
            txtLetra.Focus();
        }
    }
}