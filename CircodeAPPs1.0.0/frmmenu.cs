namespace CircodeAPPs
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
            frmsplash splash = new frmsplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(3000);
            splash.Close();
        }

        private void pbxFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxBuscaCEP_Click(object sender, EventArgs e)
        {
            frmbuscacep buscaCEP = new frmbuscacep();
            buscaCEP.Show();
        }
    }
}