namespace CircodeAPPs
{
    partial class frmcaraecoroa
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
            pbxMoeda = new PictureBox();
            lblResultado = new Label();
            btnJogar = new Button();
            lblPlacar = new Label();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxMoeda).BeginInit();
            SuspendLayout();
            // 
            // pbxMoeda
            // 
            pbxMoeda.BackColor = Color.Transparent;
            pbxMoeda.Location = new Point(143, 305);
            pbxMoeda.Name = "pbxMoeda";
            pbxMoeda.Size = new Size(118, 112);
            pbxMoeda.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxMoeda.TabIndex = 0;
            pbxMoeda.TabStop = false;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.Yellow;
            lblResultado.Location = new Point(12, 327);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 18);
            lblResultado.TabIndex = 1;
            // 
            // btnJogar
            // 
            btnJogar.BackColor = Color.Gold;
            btnJogar.FlatStyle = FlatStyle.Flat;
            btnJogar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnJogar.ForeColor = Color.Yellow;
            btnJogar.Location = new Point(277, 12);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(127, 67);
            btnJogar.TabIndex = 3;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = false;
            btnJogar.Click += btnJogar_Click;
            // 
            // lblPlacar
            // 
            lblPlacar.AutoSize = true;
            lblPlacar.BackColor = Color.Transparent;
            lblPlacar.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlacar.ForeColor = Color.Yellow;
            lblPlacar.Location = new Point(12, 364);
            lblPlacar.Name = "lblPlacar";
            lblPlacar.Size = new Size(0, 18);
            lblPlacar.TabIndex = 4;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.Silver;
            btnFechar.Location = new Point(277, 85);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(127, 67);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // frmcaraecoroa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.catsorte;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(416, 450);
            Controls.Add(btnFechar);
            Controls.Add(lblPlacar);
            Controls.Add(btnJogar);
            Controls.Add(lblResultado);
            Controls.Add(pbxMoeda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmcaraecoroa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmcaraecoroa";
            ((System.ComponentModel.ISupportInitialize)pbxMoeda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxMoeda;
        private Label lblResultado;
        private Button btnJogar;
        private Label lblPlacar;
        private Button btnFechar;
    }
}