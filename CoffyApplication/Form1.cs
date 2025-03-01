namespace CoffyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 AnamenuForm = new Form1();
            this.Hide();
            AnamenuForm.Show();  // Yeni formu aç
        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menü formunu aç
            Form2 menuForm = new Form2();
            this.Hide();
            menuForm.Show();  // Yeni formu aç
        }

        private void bizKimizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menü formunu aç
            Form3 bizKimiz = new Form3();
            this.Hide();
            bizKimiz.Show();  // Yeni formu aç
        }

        private void bizeUlaþýnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 bizeUlaþýn = new Form4();
            this.Hide();
            bizeUlaþýn.Show();
        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 blogTool = new Form5();
            this.Hide();
            blogTool.Show();
        }
    }
}
