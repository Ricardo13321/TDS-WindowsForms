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
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmbuscacep)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmbuscacep buscaCEP = new frmbuscacep();
            buscaCEP.Show();
        }

        private void pbxClima_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmclima)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmclima clima = new frmclima();
            clima.Show();
        }

        private void pbxCaraCoroa_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmcaraecoroa)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmcaraecoroa caracoroa = new frmcaraecoroa();
            caracoroa.Show();
        }

        private void pbxCPF_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmcpf)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmcpf validaCpf = new frmcpf();
            validaCpf.Show();
        }
    }
}