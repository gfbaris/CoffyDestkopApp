using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffyApplication
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void bizeUlaşınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 bizeUlaşın = new Form4();
            this.Hide();
            bizeUlaşın.Show();
        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 blogTool = new Form5();
            this.Hide();
            blogTool.Show();
        }
    }
}
