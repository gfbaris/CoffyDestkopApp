using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffyApplication
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            linkLabel1.Text = "YouTube Kanalım";
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://www.youtube.com/channel/UCyzyjsNKraXmdSOr_8jQ2MQ");
            
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = e.Link.LinkData.ToString();
            try
            {
                Process.Start(link);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Link açılırken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
