namespace CoffyApplication
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            menuStrip1 = new MenuStrip();
            coffyToolStripMenuItem = new ToolStripMenuItem();
            anaSayfaToolStripMenuItem = new ToolStripMenuItem();
            bizKimizToolStripMenuItem = new ToolStripMenuItem();
            bizeUlaşınToolStripMenuItem = new ToolStripMenuItem();
            menüToolStripMenuItem = new ToolStripMenuItem();
            blogToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { coffyToolStripMenuItem, anaSayfaToolStripMenuItem, bizKimizToolStripMenuItem, bizeUlaşınToolStripMenuItem, menüToolStripMenuItem, blogToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(779, 49);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // coffyToolStripMenuItem
            // 
            coffyToolStripMenuItem.Font = new Font("Script MT Bold", 20F, FontStyle.Bold | FontStyle.Italic);
            coffyToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            coffyToolStripMenuItem.Name = "coffyToolStripMenuItem";
            coffyToolStripMenuItem.Size = new Size(110, 45);
            coffyToolStripMenuItem.Text = "Coffy";
            // 
            // anaSayfaToolStripMenuItem
            // 
            anaSayfaToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            anaSayfaToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            anaSayfaToolStripMenuItem.Size = new Size(125, 45);
            anaSayfaToolStripMenuItem.Text = "🏠 Ana Sayfa";
            anaSayfaToolStripMenuItem.Click += anaSayfaToolStripMenuItem_Click;
            // 
            // bizKimizToolStripMenuItem
            // 
            bizKimizToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            bizKimizToolStripMenuItem.Name = "bizKimizToolStripMenuItem";
            bizKimizToolStripMenuItem.Size = new Size(128, 45);
            bizKimizToolStripMenuItem.Text = "📖 Biz Kimiz?";
            bizKimizToolStripMenuItem.Click += bizKimizToolStripMenuItem_Click;
            // 
            // bizeUlaşınToolStripMenuItem
            // 
            bizeUlaşınToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            bizeUlaşınToolStripMenuItem.Name = "bizeUlaşınToolStripMenuItem";
            bizeUlaşınToolStripMenuItem.Size = new Size(138, 45);
            bizeUlaşınToolStripMenuItem.Text = " 📞 Bize Ulaşın";
            bizeUlaşınToolStripMenuItem.Click += bizeUlaşınToolStripMenuItem_Click;
            // 
            // menüToolStripMenuItem
            // 
            menüToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            menüToolStripMenuItem.Size = new Size(96, 45);
            menüToolStripMenuItem.Text = "🍽 Menü";
            menüToolStripMenuItem.Click += menüToolStripMenuItem_Click;
            // 
            // blogToolStripMenuItem
            // 
            blogToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            blogToolStripMenuItem.Name = "blogToolStripMenuItem";
            blogToolStripMenuItem.Size = new Size(86, 45);
            blogToolStripMenuItem.Text = "📝 Blog";
            blogToolStripMenuItem.Click += blogToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(298, 62);
            label1.Name = "label1";
            label1.Size = new Size(199, 46);
            label1.TabIndex = 9;
            label1.Text = "Bize Ulaşın";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(24, 135);
            label2.Name = "label2";
            label2.Size = new Size(428, 150);
            label2.TabIndex = 10;
            label2.Text = "MÜŞTERİ HİZMETLERİ: 0 850 211 97 97\r\n\r\nŞİKAYET/ ÖNERİ HATTI: 0 850 211 97 97\r\n\r\nPİZZA RESTAURANTLARI A.Ş.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 319);
            label3.Name = "label3";
            label3.Size = new Size(716, 560);
            label3.TabIndex = 11;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 823);
            label4.Name = "label4";
            label4.Size = new Size(168, 100);
            label4.TabIndex = 12;
            label4.Text = "Coffy\r\nTek fiyatlı kahve noktası.\r\n\r\n\r\n\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bize Ulaşın";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem coffyToolStripMenuItem;
        private ToolStripMenuItem anaSayfaToolStripMenuItem;
        private ToolStripMenuItem bizKimizToolStripMenuItem;
        private ToolStripMenuItem bizeUlaşınToolStripMenuItem;
        private ToolStripMenuItem menüToolStripMenuItem;
        private ToolStripMenuItem blogToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}