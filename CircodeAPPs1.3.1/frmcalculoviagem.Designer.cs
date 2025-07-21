namespace CircodeAPPs
{
    partial class frmcalculoviagem
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtDistancia = new TextBox();
            button1 = new Button();
            cdbTipo = new ComboBox();
            label2 = new Label();
            txtAutonomia = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblLitrosGasto = new Label();
            lblGastoTotal = new Label();
            lblTempo = new Label();
            label7 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cat_silly;
            pictureBox1.Location = new Point(330, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(194, 28);
            label1.TabIndex = 1;
            label1.Text = "DISTÂNCIA (Km)";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(12, 61);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(259, 23);
            txtDistancia.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(527, 12);
            button1.Name = "button1";
            button1.Size = new Size(127, 47);
            button1.TabIndex = 3;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cdbTipo
            // 
            cdbTipo.FormattingEnabled = true;
            cdbTipo.Items.AddRange(new object[] { "ÁLCOOL", "GASOLINA COMUM", "GASOLINA ADITIVADA", "DIESEL" });
            cdbTipo.Location = new Point(12, 145);
            cdbTipo.Name = "cdbTipo";
            cdbTipo.Size = new Size(121, 23);
            cdbTipo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(220, 28);
            label2.TabIndex = 5;
            label2.Text = "AUTONOMIA (Km/L)";
            // 
            // txtAutonomia
            // 
            txtAutonomia.Location = new Point(12, 228);
            txtAutonomia.Name = "txtAutonomia";
            txtAutonomia.Size = new Size(259, 23);
            txtAutonomia.TabIndex = 6;
            // 
            // lblLitrosGasto
            // 
            lblLitrosGasto.AutoSize = true;
            lblLitrosGasto.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblLitrosGasto.Location = new Point(12, 274);
            lblLitrosGasto.Name = "lblLitrosGasto";
            lblLitrosGasto.Size = new Size(0, 28);
            lblLitrosGasto.TabIndex = 7;
            // 
            // lblGastoTotal
            // 
            lblGastoTotal.AutoSize = true;
            lblGastoTotal.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblGastoTotal.Location = new Point(12, 319);
            lblGastoTotal.Name = "lblGastoTotal";
            lblGastoTotal.Size = new Size(0, 28);
            lblGastoTotal.TabIndex = 8;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTempo.Location = new Point(12, 366);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(0, 28);
            lblTempo.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 114);
            label7.Name = "label7";
            label7.Size = new Size(259, 28);
            label7.TabIndex = 11;
            label7.Text = "TIPO DE COMBUSTÍVEL";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(527, 98);
            button2.Name = "button2";
            button2.Size = new Size(127, 47);
            button2.TabIndex = 12;
            button2.Text = "SAIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmcalculoviagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(675, 497);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(lblTempo);
            Controls.Add(lblGastoTotal);
            Controls.Add(lblLitrosGasto);
            Controls.Add(txtAutonomia);
            Controls.Add(label2);
            Controls.Add(cdbTipo);
            Controls.Add(button1);
            Controls.Add(txtDistancia);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmcalculoviagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmcalculoviagem";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtDistancia;
        private Button button1;
        private ComboBox cdbTipo;
        private Label label2;
        private TextBox txtAutonomia;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblLitrosGasto;
        private Label lblGastoTotal;
        private Label lblTempo;
        private Label label7;
        private Button button2;
    }
}