namespace CircodeAPPs
{
    partial class frmclima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmclima));
            btnPesquisar = new Button();
            label1 = new Label();
            txtCidade = new TextBox();
            lblUmidade = new Label();
            lblDescricao = new Label();
            lblTemperatura = new Label();
            lblCidade = new Label();
            btnFechar = new Button();
            lblPressao = new Label();
            lblPais = new Label();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(0, 192, 0);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.ForeColor = Color.Lime;
            btnPesquisar.Location = new Point(266, 23);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(201, 41);
            btnPesquisar.TabIndex = 0;
            btnPesquisar.Text = "PESQUISAR";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 1;
            label1.Text = "DIGITE UMA CIDADE";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(8, 41);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(240, 23);
            txtCidade.TabIndex = 2;
            // 
            // lblUmidade
            // 
            lblUmidade.AutoSize = true;
            lblUmidade.BackColor = Color.Transparent;
            lblUmidade.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUmidade.ForeColor = Color.Lime;
            lblUmidade.Location = new Point(12, 274);
            lblUmidade.Name = "lblUmidade";
            lblUmidade.Size = new Size(0, 28);
            lblUmidade.TabIndex = 14;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricao.ForeColor = Color.Lime;
            lblDescricao.Location = new Point(12, 244);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(0, 28);
            lblDescricao.TabIndex = 11;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.BackColor = Color.Transparent;
            lblTemperatura.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTemperatura.ForeColor = Color.Lime;
            lblTemperatura.Location = new Point(12, 213);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(0, 28);
            lblTemperatura.TabIndex = 10;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.BackColor = Color.Transparent;
            lblCidade.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.ForeColor = Color.Lime;
            lblCidade.Location = new Point(12, 185);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(0, 28);
            lblCidade.TabIndex = 9;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(192, 0, 0);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.Red;
            btnFechar.Location = new Point(266, 94);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(201, 41);
            btnFechar.TabIndex = 15;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblPressao
            // 
            lblPressao.AutoSize = true;
            lblPressao.BackColor = Color.Transparent;
            lblPressao.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPressao.ForeColor = Color.Lime;
            lblPressao.Location = new Point(12, 302);
            lblPressao.Name = "lblPressao";
            lblPressao.Size = new Size(0, 28);
            lblPressao.TabIndex = 17;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.BackColor = Color.Transparent;
            lblPais.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPais.ForeColor = Color.Lime;
            lblPais.Location = new Point(12, 330);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(0, 28);
            lblPais.TabIndex = 18;
            // 
            // frmclima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(509, 366);
            Controls.Add(lblPais);
            Controls.Add(lblPressao);
            Controls.Add(btnFechar);
            Controls.Add(lblUmidade);
            Controls.Add(lblDescricao);
            Controls.Add(lblTemperatura);
            Controls.Add(lblCidade);
            Controls.Add(txtCidade);
            Controls.Add(label1);
            Controls.Add(btnPesquisar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmclima";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmclima";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisar;
        private Label label1;
        private TextBox txtCidade;
        private Label lblUmidade;
        private Label label9;
        private Label lblDescricao;
        private Label lblTemperatura;
        private Label lblCidade;
        private Button btnFechar;
        private Label lblPressao;
        private Label lblPais;
    }
}