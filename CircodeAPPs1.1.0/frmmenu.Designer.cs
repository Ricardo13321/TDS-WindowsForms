namespace CircodeAPPs
{
    partial class frmmenu
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
            components = new System.ComponentModel.Container();
            pbxCalculadora = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pbxBuscaCEP = new PictureBox();
            label3 = new Label();
            pbxClima = new PictureBox();
            label4 = new Label();
            pbxCaraCoroa = new PictureBox();
            label5 = new Label();
            pbxDestino = new PictureBox();
            label6 = new Label();
            pbxFechar = new PictureBox();
            label7 = new Label();
            pbxCPF = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxCalculadora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBuscaCEP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxClima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCaraCoroa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxDestino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCPF).BeginInit();
            SuspendLayout();
            // 
            // pbxCalculadora
            // 
            pbxCalculadora.BackColor = Color.Transparent;
            pbxCalculadora.Image = Properties.Resources.office;
            pbxCalculadora.Location = new Point(12, 12);
            pbxCalculadora.Name = "pbxCalculadora";
            pbxCalculadora.Size = new Size(213, 269);
            pbxCalculadora.SizeMode = PictureBoxSizeMode.Zoom;
            pbxCalculadora.TabIndex = 0;
            pbxCalculadora.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(36, 284);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 1;
            label1.Text = "CALCULADORA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(306, 284);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 3;
            label2.Text = "BUSCA CEP";
            // 
            // pbxBuscaCEP
            // 
            pbxBuscaCEP.BackColor = Color.Transparent;
            pbxBuscaCEP.Image = Properties.Resources.mailbox;
            pbxBuscaCEP.Location = new Point(260, 12);
            pbxBuscaCEP.Name = "pbxBuscaCEP";
            pbxBuscaCEP.Size = new Size(213, 269);
            pbxBuscaCEP.SizeMode = PictureBoxSizeMode.Zoom;
            pbxBuscaCEP.TabIndex = 2;
            pbxBuscaCEP.TabStop = false;
            pbxBuscaCEP.Click += pbxBuscaCEP_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(568, 284);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 5;
            label3.Text = "TEMPO";
            // 
            // pbxClima
            // 
            pbxClima.BackColor = Color.Transparent;
            pbxClima.Image = Properties.Resources.storm;
            pbxClima.Location = new Point(497, 12);
            pbxClima.Name = "pbxClima";
            pbxClima.Size = new Size(213, 269);
            pbxClima.SizeMode = PictureBoxSizeMode.Zoom;
            pbxClima.TabIndex = 4;
            pbxClima.TabStop = false;
            pbxClima.Click += pbxClima_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(155, 587);
            label4.Name = "label4";
            label4.Size = new Size(181, 28);
            label4.TabIndex = 7;
            label4.Text = "CARA OU COROA";
            // 
            // pbxCaraCoroa
            // 
            pbxCaraCoroa.BackColor = Color.Transparent;
            pbxCaraCoroa.Image = Properties.Resources.dollar;
            pbxCaraCoroa.Location = new Point(136, 315);
            pbxCaraCoroa.Name = "pbxCaraCoroa";
            pbxCaraCoroa.Size = new Size(213, 269);
            pbxCaraCoroa.SizeMode = PictureBoxSizeMode.Zoom;
            pbxCaraCoroa.TabIndex = 6;
            pbxCaraCoroa.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(439, 587);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 9;
            label5.Text = "DESTINO";
            // 
            // pbxDestino
            // 
            pbxDestino.BackColor = Color.Transparent;
            pbxDestino.Image = Properties.Resources.destination;
            pbxDestino.Location = new Point(384, 315);
            pbxDestino.Name = "pbxDestino";
            pbxDestino.Size = new Size(213, 269);
            pbxDestino.SizeMode = PictureBoxSizeMode.Zoom;
            pbxDestino.TabIndex = 8;
            pbxDestino.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(697, 587);
            label6.Name = "label6";
            label6.Size = new Size(64, 28);
            label6.TabIndex = 11;
            label6.Text = "SAIR";
            // 
            // pbxFechar
            // 
            pbxFechar.BackColor = Color.Transparent;
            pbxFechar.Image = Properties.Resources.tiger;
            pbxFechar.Location = new Point(621, 315);
            pbxFechar.Name = "pbxFechar";
            pbxFechar.Size = new Size(213, 269);
            pbxFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFechar.TabIndex = 10;
            pbxFechar.TabStop = false;
            pbxFechar.Click += pbxFechar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(792, 284);
            label7.Name = "label7";
            label7.Size = new Size(142, 28);
            label7.TabIndex = 13;
            label7.Text = "VALIDA CPF";
            // 
            // pbxCPF
            // 
            pbxCPF.BackColor = Color.Transparent;
            pbxCPF.Image = Properties.Resources.file;
            pbxCPF.Location = new Point(744, 12);
            pbxCPF.Name = "pbxCPF";
            pbxCPF.Size = new Size(213, 269);
            pbxCPF.SizeMode = PictureBoxSizeMode.Zoom;
            pbxCPF.TabIndex = 12;
            pbxCPF.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(886, 600);
            label8.Name = "label8";
            label8.Size = new Size(140, 15);
            label8.TabIndex = 15;
            label8.Text = "Produced by Bigsoft";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(1, 601);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 16;
            label9.Text = "v1.0.1";
            // 
            // frmmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 625);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pbxCPF);
            Controls.Add(label6);
            Controls.Add(pbxFechar);
            Controls.Add(label5);
            Controls.Add(pbxDestino);
            Controls.Add(label4);
            Controls.Add(pbxCaraCoroa);
            Controls.Add(label3);
            Controls.Add(pbxClima);
            Controls.Add(label2);
            Controls.Add(pbxBuscaCEP);
            Controls.Add(label1);
            Controls.Add(pbxCalculadora);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbxCalculadora).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBuscaCEP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxClima).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCaraCoroa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxDestino).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCPF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxCalculadora;
        private Label label1;
        private Label label2;
        private PictureBox pbxBuscaCEP;
        private Label label3;
        private PictureBox pbxClima;
        private Label label4;
        private PictureBox pbxCaraCoroa;
        private Label label5;
        private PictureBox pbxDestino;
        private Label label6;
        private PictureBox pbxFechar;
        private Label label7;
        private PictureBox pbxCPF;
        private ContextMenuStrip contextMenuStrip1;
        private Label label8;
        private Label label9;
    }
}