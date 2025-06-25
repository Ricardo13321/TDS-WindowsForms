namespace CircodeAPPs
{
    partial class frmbuscacep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnPesquisar = new Button();
            txtCEP = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnFechar = new Button();
            label5 = new Label();
            label6 = new Label();
            lblUF = new Label();
            lblCidade = new Label();
            lblBairro = new Label();
            lblComplemento = new Label();
            lblEndereco = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 0;
            label1.Text = "Digite um CEP";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(0, 192, 0);
            btnPesquisar.BackgroundImageLayout = ImageLayout.Stretch;
            btnPesquisar.FlatStyle = FlatStyle.Popup;
            btnPesquisar.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(308, 12);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(201, 41);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtCEP
            // 
            txtCEP.BackColor = Color.White;
            txtCEP.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCEP.ForeColor = Color.Lime;
            txtCEP.Location = new Point(25, 56);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(245, 36);
            txtCEP.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(25, 262);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 3;
            label2.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(25, 296);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 4;
            label3.Text = "Complemento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(25, 334);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 5;
            label4.Text = "Bairro";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(192, 0, 0);
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.Red;
            btnFechar.Location = new Point(308, 86);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(201, 37);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(25, 374);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 7;
            label5.Text = "Cidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(25, 411);
            label6.Name = "label6";
            label6.Size = new Size(38, 28);
            label6.TabIndex = 8;
            label6.Text = "UF";
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.BackColor = Color.Transparent;
            lblUF.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUF.ForeColor = Color.Lime;
            lblUF.Location = new Point(200, 411);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(0, 28);
            lblUF.TabIndex = 13;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.BackColor = Color.Transparent;
            lblCidade.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCidade.ForeColor = Color.Lime;
            lblCidade.Location = new Point(200, 374);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(0, 28);
            lblCidade.TabIndex = 12;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.BackColor = Color.Transparent;
            lblBairro.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblBairro.ForeColor = Color.Lime;
            lblBairro.Location = new Point(200, 334);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(0, 28);
            lblBairro.TabIndex = 11;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.BackColor = Color.Transparent;
            lblComplemento.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblComplemento.ForeColor = Color.Lime;
            lblComplemento.Location = new Point(200, 296);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(0, 28);
            lblComplemento.TabIndex = 10;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.BackColor = Color.Transparent;
            lblEndereco.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndereco.ForeColor = Color.Lime;
            lblEndereco.Location = new Point(200, 262);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(0, 28);
            lblEndereco.TabIndex = 9;
            // 
            // frmbuscacep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.gatoemo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(591, 457);
            Controls.Add(lblUF);
            Controls.Add(lblCidade);
            Controls.Add(lblBairro);
            Controls.Add(lblComplemento);
            Controls.Add(lblEndereco);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnFechar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCEP);
            Controls.Add(btnPesquisar);
            Controls.Add(label1);
            ForeColor = Color.Lime;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmbuscacep";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmbuscacep";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPesquisar;
        private TextBox txtCEP;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnFechar;
        private Label label5;
        private Label label6;
        private Label lblUF;
        private Label lblCidade;
        private Label lblBairro;
        private Label lblComplemento;
        private Label lblEndereco;
    }
}