namespace Aula_2
{
    partial class Crypto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPalavra = new TextBox();
            lblDigitePalavra = new Label();
            btnJogar = new Button();
            cu = new PictureBox();
            lblTentativas = new Label();
            txtTentativa = new TextBox();
            lblPalavraCripto = new Label();
            lblAcertouErrou = new Label();
            btnVerificar = new Button();
            txtLetra = new TextBox();
            btnFechar = new Button();
            pictureBox1 = new PictureBox();
            picheart1 = new PictureBox();
            picheart2 = new PictureBox();
            picheart3 = new PictureBox();
            picheart4 = new PictureBox();
            picheart5 = new PictureBox();
            picheart6 = new PictureBox();
            picheart7 = new PictureBox();
            picheart8 = new PictureBox();
            picheart9 = new PictureBox();
            picheart10 = new PictureBox();
            lblPalavraAcertos = new Label();
            ((System.ComponentModel.ISupportInitialize)cu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picheart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picheart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picheart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picheart4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picheart5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picheart6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picheart7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picheart8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picheart9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picheart10).BeginInit();
            SuspendLayout();
            // 
            // txtPalavra
            // 
            txtPalavra.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPalavra.ForeColor = Color.Black;
            txtPalavra.Location = new Point(25, 45);
            txtPalavra.Name = "txtPalavra";
            txtPalavra.PlaceholderText = "Palavra";
            txtPalavra.Size = new Size(246, 30);
            txtPalavra.TabIndex = 0;
            txtPalavra.UseSystemPasswordChar = true;
            // 
            // lblDigitePalavra
            // 
            lblDigitePalavra.AutoSize = true;
            lblDigitePalavra.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDigitePalavra.ForeColor = Color.White;
            lblDigitePalavra.Location = new Point(25, 19);
            lblDigitePalavra.Name = "lblDigitePalavra";
            lblDigitePalavra.Size = new Size(155, 23);
            lblDigitePalavra.TabIndex = 1;
            lblDigitePalavra.Text = "Digita uma Palavra";
            // 
            // btnJogar
            // 
            btnJogar.BackColor = Color.Lime;
            btnJogar.FlatStyle = FlatStyle.Popup;
            btnJogar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnJogar.ForeColor = Color.FromArgb(192, 255, 192);
            btnJogar.Location = new Point(311, 45);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(101, 48);
            btnJogar.TabIndex = 4;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = false;
            btnJogar.Click += btnJogar_Click;
            // 
            // cu
            // 
            cu.Image = Properties.Resources.black_cat;
            cu.Location = new Point(347, 161);
            cu.Name = "cu";
            cu.Size = new Size(259, 314);
            cu.SizeMode = PictureBoxSizeMode.Zoom;
            cu.TabIndex = 3;
            cu.TabStop = false;
            // 
            // lblTentativas
            // 
            lblTentativas.AutoSize = true;
            lblTentativas.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTentativas.ForeColor = Color.White;
            lblTentativas.Location = new Point(25, 82);
            lblTentativas.Name = "lblTentativas";
            lblTentativas.Size = new Size(92, 23);
            lblTentativas.TabIndex = 5;
            lblTentativas.Text = "Tentativas";
            // 
            // txtTentativa
            // 
            txtTentativa.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTentativa.ForeColor = Color.Black;
            txtTentativa.Location = new Point(25, 108);
            txtTentativa.Name = "txtTentativa";
            txtTentativa.PlaceholderText = "Tentativas";
            txtTentativa.Size = new Size(100, 30);
            txtTentativa.TabIndex = 2;
            // 
            // lblPalavraCripto
            // 
            lblPalavraCripto.AutoSize = true;
            lblPalavraCripto.BackColor = Color.Transparent;
            lblPalavraCripto.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPalavraCripto.ForeColor = Color.White;
            lblPalavraCripto.Location = new Point(94, 35);
            lblPalavraCripto.Name = "lblPalavraCripto";
            lblPalavraCripto.Size = new Size(156, 30);
            lblPalavraCripto.TabIndex = 6;
            lblPalavraCripto.Text = "Palavra Cripto";
            // 
            // lblAcertouErrou
            // 
            lblAcertouErrou.AutoSize = true;
            lblAcertouErrou.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcertouErrou.ForeColor = Color.White;
            lblAcertouErrou.Location = new Point(360, 150);
            lblAcertouErrou.Name = "lblAcertouErrou";
            lblAcertouErrou.Size = new Size(113, 23);
            lblAcertouErrou.TabIndex = 8;
            lblAcertouErrou.Text = "AcertouErrou";
            lblAcertouErrou.Click += lblAcertouErrou_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(0, 0, 192);
            btnVerificar.FlatStyle = FlatStyle.Popup;
            btnVerificar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerificar.ForeColor = Color.FromArgb(128, 128, 255);
            btnVerificar.Location = new Point(152, 231);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(109, 48);
            btnVerificar.TabIndex = 10;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtLetra
            // 
            txtLetra.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLetra.ForeColor = Color.Black;
            txtLetra.Location = new Point(37, 241);
            txtLetra.Name = "txtLetra";
            txtLetra.PlaceholderText = "Letra";
            txtLetra.Size = new Size(109, 30);
            txtLetra.TabIndex = 9;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.FromArgb(255, 128, 128);
            btnFechar.Location = new Point(84, 475);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(101, 48);
            btnFechar.TabIndex = 11;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.joystick1;
            pictureBox1.Location = new Point(395, 439);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // picheart1
            // 
            picheart1.Image = Properties.Resources.heart;
            picheart1.Location = new Point(12, 559);
            picheart1.Name = "picheart1";
            picheart1.Size = new Size(54, 56);
            picheart1.SizeMode = PictureBoxSizeMode.Zoom;
            picheart1.TabIndex = 14;
            picheart1.TabStop = false;
            // 
            // picheart2
            // 
            picheart2.Image = Properties.Resources.heart;
            picheart2.Location = new Point(71, 559);
            picheart2.Name = "picheart2";
            picheart2.Size = new Size(54, 56);
            picheart2.SizeMode = PictureBoxSizeMode.Zoom;
            picheart2.TabIndex = 15;
            picheart2.TabStop = false;
            // 
            // picheart3
            // 
            picheart3.Image = Properties.Resources.heart;
            picheart3.Location = new Point(131, 559);
            picheart3.Name = "picheart3";
            picheart3.Size = new Size(54, 56);
            picheart3.SizeMode = PictureBoxSizeMode.Zoom;
            picheart3.TabIndex = 16;
            picheart3.TabStop = false;
            // 
            // picheart4
            // 
            picheart4.Image = Properties.Resources.heart;
            picheart4.Location = new Point(191, 559);
            picheart4.Name = "picheart4";
            picheart4.Size = new Size(54, 56);
            picheart4.SizeMode = PictureBoxSizeMode.Zoom;
            picheart4.TabIndex = 17;
            picheart4.TabStop = false;
            // 
            // picheart5
            // 
            picheart5.Image = Properties.Resources.heart;
            picheart5.Location = new Point(251, 559);
            picheart5.Name = "picheart5";
            picheart5.Size = new Size(54, 56);
            picheart5.SizeMode = PictureBoxSizeMode.Zoom;
            picheart5.TabIndex = 18;
            picheart5.TabStop = false;
            // 
            // picheart6
            // 
            picheart6.Image = Properties.Resources.heart;
            picheart6.Location = new Point(311, 559);
            picheart6.Name = "picheart6";
            picheart6.Size = new Size(54, 56);
            picheart6.SizeMode = PictureBoxSizeMode.Zoom;
            picheart6.TabIndex = 19;
            picheart6.TabStop = false;
            // 
            // picheart7
            // 
            picheart7.Image = Properties.Resources.heart;
            picheart7.Location = new Point(371, 559);
            picheart7.Name = "picheart7";
            picheart7.Size = new Size(54, 56);
            picheart7.SizeMode = PictureBoxSizeMode.Zoom;
            picheart7.TabIndex = 20;
            picheart7.TabStop = false;
            // 
            // picheart8
            // 
            picheart8.Image = Properties.Resources.heart;
            picheart8.Location = new Point(432, 559);
            picheart8.Name = "picheart8";
            picheart8.Size = new Size(54, 56);
            picheart8.SizeMode = PictureBoxSizeMode.Zoom;
            picheart8.TabIndex = 21;
            picheart8.TabStop = false;
            // 
            // picheart9
            // 
            picheart9.Image = Properties.Resources.heart;
            picheart9.Location = new Point(492, 559);
            picheart9.Name = "picheart9";
            picheart9.Size = new Size(54, 56);
            picheart9.SizeMode = PictureBoxSizeMode.Zoom;
            picheart9.TabIndex = 22;
            picheart9.TabStop = false;
            // 
            // picheart10
            // 
            picheart10.Image = Properties.Resources.heart;
            picheart10.Location = new Point(552, 557);
            picheart10.Name = "picheart10";
            picheart10.Size = new Size(54, 56);
            picheart10.SizeMode = PictureBoxSizeMode.Zoom;
            picheart10.TabIndex = 23;
            picheart10.TabStop = false;
            // 
            // lblPalavraAcertos
            // 
            lblPalavraAcertos.AutoSize = true;
            lblPalavraAcertos.BackColor = Color.Transparent;
            lblPalavraAcertos.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPalavraAcertos.ForeColor = Color.White;
            lblPalavraAcertos.Location = new Point(94, 105);
            lblPalavraAcertos.Name = "lblPalavraAcertos";
            lblPalavraAcertos.RightToLeft = RightToLeft.No;
            lblPalavraAcertos.Size = new Size(211, 38);
            lblPalavraAcertos.TabIndex = 7;
            lblPalavraAcertos.Text = "PalavraAcertos";
            lblPalavraAcertos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Crypto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(643, 627);
            Controls.Add(picheart10);
            Controls.Add(picheart9);
            Controls.Add(picheart8);
            Controls.Add(picheart7);
            Controls.Add(picheart6);
            Controls.Add(picheart5);
            Controls.Add(picheart4);
            Controls.Add(picheart3);
            Controls.Add(picheart2);
            Controls.Add(picheart1);
            Controls.Add(pictureBox1);
            Controls.Add(btnFechar);
            Controls.Add(txtLetra);
            Controls.Add(btnVerificar);
            Controls.Add(lblAcertouErrou);
            Controls.Add(lblPalavraAcertos);
            Controls.Add(lblPalavraCripto);
            Controls.Add(lblTentativas);
            Controls.Add(txtTentativa);
            Controls.Add(cu);
            Controls.Add(btnJogar);
            Controls.Add(lblDigitePalavra);
            Controls.Add(txtPalavra);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "Crypto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minecraft 2";
            Load += Crypto_Load;
            ((System.ComponentModel.ISupportInitialize)cu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picheart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picheart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picheart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picheart4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picheart5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picheart6).EndInit();
            ((System.ComponentModel.ISupportInitialize)picheart7).EndInit();
            ((System.ComponentModel.ISupportInitialize)picheart8).EndInit();
            ((System.ComponentModel.ISupportInitialize)picheart9).EndInit();
            ((System.ComponentModel.ISupportInitialize)picheart10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPalavra;
        private Label lblDigitePalavra;
        private Button btnJogar;
        private PictureBox cu;
        private Label lblTentativas;
        private TextBox txtTentativa;
        private Label lblPalavraCripto;
        private Label lblAcertouErrou;
        private Button btnVerificar;
        private TextBox txtLetra;
        private Button btnFechar;
        private PictureBox pictureBox1;
        private PictureBox picheart1;
        private PictureBox picheart2;
        private PictureBox picheart3;
        private PictureBox picheart4;
        private PictureBox picheart5;
        private PictureBox picheart6;
        private PictureBox picheart7;
        private PictureBox picheart8;
        private PictureBox picheart9;
        private PictureBox picheart10;
        private Label lblPalavraAcertos;
    }
}