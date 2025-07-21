namespace CircodeAPPs
{
    partial class frmcpf
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
            btnVerificar = new Button();
            btnFechar = new Button();
            lblResultado = new Label();
            mtxtCpf = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(168, 28);
            label1.TabIndex = 0;
            label1.Text = "Digite o CPF";
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.Lime;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerificar.ForeColor = Color.FromArgb(0, 192, 0);
            btnVerificar.Location = new Point(427, 15);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(141, 41);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.FromArgb(192, 0, 0);
            btnFechar.Location = new Point(427, 86);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(141, 41);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 108);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 28);
            lblResultado.TabIndex = 4;
            // 
            // mtxtCpf
            // 
            mtxtCpf.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mtxtCpf.Location = new Point(12, 46);
            mtxtCpf.Mask = "000.000.000-00";
            mtxtCpf.Name = "mtxtCpf";
            mtxtCpf.Size = new Size(204, 36);
            mtxtCpf.TabIndex = 5;
            mtxtCpf.KeyPress += mtxtCpf_KeyPress;
            // 
            // frmcpf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gatoemo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(591, 457);
            Controls.Add(mtxtCpf);
            Controls.Add(lblResultado);
            Controls.Add(btnFechar);
            Controls.Add(btnVerificar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmcpf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmcpf";
            Load += frmcpf_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVerificar;
        private Button btnFechar;
        private Label lblResultado;
        private MaskedTextBox mtxtCpf;
    }
}