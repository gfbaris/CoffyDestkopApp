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
            AnamenuForm.Show();  // Yeni formu a�
        }

        private void men�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Men� formunu a�
            Form2 menuForm = new Form2();
            this.Hide();
            menuForm.Show();  // Yeni formu a�
        }

        private void bizKimizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Men� formunu a�
            Form3 bizKimiz = new Form3();
            this.Hide();
            bizKimiz.Show();  // Yeni formu a�
        }

        private void bizeUla��nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 bizeUla��n = new Form4();
            this.Hide();
            bizeUla��n.Show();
        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 blogTool = new Form5();
            this.Hide();
            blogTool.Show();
        }
    }
}
