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
            txtPalavra.Text = "";
            txtLetra.Text = "";
            txtTentativa.Text = "";
            lblPalavraCripto.Text = "";
            lblPalavraAcertos.Text = "";
            lblAcertouErrou.Text = "";
            palavraCriptoArray = null;
            tentativasRestantes = 0;
            txtPalavra.Enabled = true;
            txtTentativa.Enabled = true;
            btnJogar.Enabled = true;
            txtPalavra.Visible = true;
            txtPalavra.Focus();
            txtTentativa.Visible = true;
            btnJogar.Visible = true;
            lblTentativas.Visible = true;
            lblDigitePalavra.Visible = true;     
            txtLetra.Enabled = false;
            btnVerificar.Enabled = false;
            txtLetra.Visible = false;
            btnVerificar.Visible = false;
            picheart1.Visible = false;
            picheart2.Visible = false;
            picheart3.Visible = false;
            picheart4.Visible = false;
            picheart5.Visible = false;
            picheart6.Visible = false;
            picheart7.Visible = false;
            picheart8.Visible = false;
            picheart9.Visible = false;
            picheart10.Visible = false;
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

            if (!int.TryParse(txtTentativa.Text, out tentativasRestantes) || tentativasRestantes <= 0 || tentativasRestantes > 10)
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
            lblPalavraCripto.Text = $"Palavra ({palavraSecreta.Length} letras)";
            lblPalavraAcertos.Text = new string(palavraCriptoArray);
            lblAcertouErrou.Text = $"Você possui {tentativasRestantes} tentativas";
            txtPalavra.Enabled = false;
            txtPalavra.Visible = false;
            txtPalavra.Text = "";
            txtTentativa.Visible = false;
            txtTentativa.Enabled = false;
            txtTentativa.Text = "";
            btnJogar.Enabled = false;
            btnJogar.Visible = false;
            lblTentativas.Visible = false;
            lblDigitePalavra.Visible = false;

            switch(tentativasRestantes)
            {
                case 1:
                    picheart1.Visible = true;
                    break;
                case 2:
                    picheart1.Visible = true;
                    picheart2.Visible = true;
                    break;
                case 3:
                    picheart1.Visible = true;
                    picheart2.Visible = true;
                    picheart3.Visible = true;
                    break;
                case 4:
                    picheart1.Visible = true;
                    picheart2.Visible = true;
                    picheart3.Visible = true;
                    picheart4.Visible = true;
                    break;
                case 5:
                    picheart1.Visible = true;
                    picheart2.Visible = true;
                    picheart3.Visible = true;
                    picheart4.Visible = true;
                    picheart5.Visible = true;
                    break;
                case 6:
                    picheart1.Visible = true;
                    picheart2.Visible = true;
                    picheart3.Visible = true;
                    picheart4.Visible = true;
                    picheart5.Visible = true;
                    picheart6.Visible = true;
                    break;
                case 7:
                    picheart1.Visible = true;
                    picheart2.Visible = true;
                    picheart3.Visible = true;
                    picheart4.Visible = true;
                    picheart5.Visible = true;
                    picheart6.Visible = true;
                    picheart7.Visible = true;
                    break;
                case 8:
                    picheart1.Visible = true;
                    picheart2.Visible = true;
                    picheart3.Visible = true;
                    picheart4.Visible = true;
                    picheart5.Visible = true;
                    picheart6.Visible = true;
                    picheart7.Visible = true;
                    picheart8.Visible = true;
                    break;
                case 9:
                    picheart1.Visible = true;
                    picheart2.Visible = true;
                    picheart3.Visible = true;
                    picheart4.Visible = true;
                    picheart5.Visible = true;
                    picheart6.Visible = true;
                    picheart7.Visible = true;
                    picheart8.Visible = true;
                    picheart9.Visible = true;
                    break;
                default:
                    picheart1.Visible = true;
                    picheart2.Visible = true;
                    picheart3.Visible = true;
                    picheart4.Visible = true;
                    picheart5.Visible = true;
                    picheart6.Visible = true;
                    picheart7.Visible = true;
                    picheart8.Visible = true;
                    picheart9.Visible = true;
                    picheart10.Visible = true;
                    break;
            }

            txtLetra.Enabled = true;
            btnVerificar.Enabled = true;
            btnVerificar.Visible = true;       
            txtLetra.Visible = true;
            txtLetra.Focus();
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

            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                if (palavraSecreta[i] == letraDigitada && palavraCriptoArray[i] == '_')
                {
                    palavraCriptoArray[i] = letraDigitada;
                    acertouLetra = true;
                }
            }
            lblPalavraCripto.Text = $"Palavra ({palavraSecreta.Length} letras)";
            lblPalavraAcertos.Text = new string(palavraCriptoArray);

            if (acertouLetra)
            {
                lblAcertouErrou.Text = $"Você acertou! Tem {tentativasRestantes} tentativas.";
                if (new string(palavraCriptoArray) == palavraSecreta)
                {
                    MessageBox.Show($"Parabéns!!! Você acertou a palavra: {palavraSecreta}", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();
                }
            }
            else
            {
                tentativasRestantes--;
                switch(tentativasRestantes)
                {
                    case 0: picheart1.Visible = false; break;
                    case 1: picheart2.Visible = false; break;
                    case 2: picheart3.Visible = false; break;
                    case 3: picheart4.Visible = false; break;
                    case 4: picheart5.Visible = false; break;
                    case 5: picheart6.Visible = false; break;
                    case 6: picheart7.Visible = false; break;
                    case 7: picheart8.Visible = false; break;
                    case 8: picheart9.Visible = false; break;
                    case 9: picheart10.Visible = false; break;
                }

                lblAcertouErrou.Text = $"Você errou, tem {tentativasRestantes} tentativas.";
                if (tentativasRestantes <= 0)
                {
                    MessageBox.Show($"Terminou!!! A palavra secreta era: {palavraSecreta}", "Fim de jogo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ResetGame();
                }
            }
            txtLetra.Text = "";
            txtLetra.Focus();
        }

        private void lblAcertouErrou_Click(object sender, EventArgs e)
        {

        }
    }
}