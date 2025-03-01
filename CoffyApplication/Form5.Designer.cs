namespace CoffyApplication
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            menuStrip1 = new MenuStrip();
            coffyToolStripMenuItem = new ToolStripMenuItem();
            anaSayfaToolStripMenuItem = new ToolStripMenuItem();
            bizKimizToolStripMenuItem = new ToolStripMenuItem();
            bizeUlaşınToolStripMenuItem = new ToolStripMenuItem();
            menüToolStripMenuItem = new ToolStripMenuItem();
            blogToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            menuStrip1.Size = new Size(802, 49);
            menuStrip1.TabIndex = 9;
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
            label1.Location = new Point(341, 66);
            label1.Name = "label1";
            label1.Size = new Size(93, 46);
            label1.TabIndex = 10;
            label1.Text = "Blog";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Peru;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(6, 24);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(238, 23);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Youtube Kanalımız Yayında..";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(758, 60);
            label2.TabIndex = 12;
            label2.Text = resources.GetString("label2.Text");
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Location = new Point(21, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 136);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonFace;
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(21, 289);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(767, 153);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(536, 23);
            label4.TabIndex = 13;
            label4.Text = "Bu Dünya hepimizin, Coffy’de çözümün bir parçası olmak istiyor…";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 53);
            label3.Name = "label3";
            label3.Size = new Size(729, 80);
            label3.TabIndex = 12;
            label3.Text = resources.GetString("label3.Text");
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonFace;
            groupBox3.BackgroundImageLayout = ImageLayout.None;
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(21, 467);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(767, 196);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(6, 23);
            label5.Name = "label5";
            label5.Size = new Size(303, 23);
            label5.TabIndex = 13;
            label5.Text = "COFFY Ankara’da Sizlerle Buluşuyor!\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 59);
            label6.Name = "label6";
            label6.Size = new Size(697, 120);
            label6.TabIndex = 12;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 509);
            label7.Name = "label7";
            label7.Size = new Size(9, 180);
            label7.TabIndex = 16;
            label7.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(823, 450);
            Controls.Add(label7);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blog";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private LinkLabel linkLabel1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}