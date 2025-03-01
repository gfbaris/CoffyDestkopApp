namespace CoffyApplication
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            menuStrip1 = new MenuStrip();
            coffyToolStripMenuItem = new ToolStripMenuItem();
            anaSayfaToolStripMenuItem = new ToolStripMenuItem();
            bizKimizToolStripMenuItem = new ToolStripMenuItem();
            bizeUlaşınToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menüToolStripMenuItem = new ToolStripMenuItem();
            blogToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            label7 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaptionText;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { coffyToolStripMenuItem, anaSayfaToolStripMenuItem, bizKimizToolStripMenuItem, bizeUlaşınToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem1, menüToolStripMenuItem, blogToolStripMenuItem, toolStripMenuItem3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(779, 49);
            menuStrip1.TabIndex = 7;
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
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.ForeColor = SystemColors.ButtonFace;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(96, 45);
            toolStripMenuItem2.Text = "🍽 Menü";
            toolStripMenuItem2.Click += menüToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.ForeColor = SystemColors.ButtonFace;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(86, 45);
            toolStripMenuItem1.Text = "📝 Blog";
            // 
            // menüToolStripMenuItem
            // 
            menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            menüToolStripMenuItem.Size = new Size(96, 45);
            menüToolStripMenuItem.Text = "🍽 Menü";
            menüToolStripMenuItem.Click += menüToolStripMenuItem_Click;
            // 
            // blogToolStripMenuItem
            // 
            blogToolStripMenuItem.Name = "blogToolStripMenuItem";
            blogToolStripMenuItem.Size = new Size(86, 45);
            blogToolStripMenuItem.Text = "📝 Blog";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(14, 45);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 25.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(279, 69);
            label7.Name = "label7";
            label7.Size = new Size(225, 47);
            label7.TabIndex = 17;
            label7.Text = "Biz Kimiz ?";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 135);
            label1.Name = "label1";
            label1.Size = new Size(300, 480);
            label1.TabIndex = 18;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(menuStrip1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biz Kimiz ?";
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
        private Label label7;
        private Label label1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}