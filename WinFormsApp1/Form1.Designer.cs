namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAcao = new Button();
            label1 = new Label();
            txtPalavra = new TextBox();
            btnFechar = new Button();
            lblpalavra = new Label();
            SuspendLayout();
            // 
            // btnAcao
            // 
            btnAcao.BackColor = Color.Black;
            btnAcao.FlatStyle = FlatStyle.Flat;
            btnAcao.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcao.ForeColor = Color.Red;
            btnAcao.Location = new Point(299, 73);
            btnAcao.Name = "btnAcao";
            btnAcao.Size = new Size(93, 35);
            btnAcao.TabIndex = 0;
            btnAcao.Text = "AÇÃO";
            btnAcao.UseVisualStyleBackColor = false;
            btnAcao.Click += btnAcao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(230, 35);
            label1.TabIndex = 1;
            label1.Text = "Digite uma palavra";
            // 
            // txtPalavra
            // 
            txtPalavra.BackColor = Color.Black;
            txtPalavra.ForeColor = Color.Red;
            txtPalavra.Location = new Point(12, 73);
            txtPalavra.Name = "txtPalavra";
            txtPalavra.Size = new Size(230, 23);
            txtPalavra.TabIndex = 2;
            txtPalavra.TextChanged += txtPalavra_TextChanged;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(192, 0, 0);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.Red;
            btnFechar.Location = new Point(299, 126);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(93, 35);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // lblpalavra
            // 
            lblpalavra.AutoSize = true;
            lblpalavra.BackColor = Color.Transparent;
            lblpalavra.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpalavra.ForeColor = Color.Red;
            lblpalavra.Location = new Point(12, 378);
            lblpalavra.Name = "lblpalavra";
            lblpalavra.Size = new Size(0, 35);
            lblpalavra.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(404, 442);
            Controls.Add(lblpalavra);
            Controls.Add(btnFechar);
            Controls.Add(txtPalavra);
            Controls.Add(label1);
            Controls.Add(btnAcao);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "uwu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcao;
        private Label label1;
        private TextBox txtPalavra;
        private Button btnFechar;
        private Label lblpalavra;
    }
}
