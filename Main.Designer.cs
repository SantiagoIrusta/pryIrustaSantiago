namespace pryIrustaSantiago
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            firmaToolStripMenuItem = new ToolStripMenuItem();
            galagaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { firmaToolStripMenuItem, galagaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(788, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // firmaToolStripMenuItem
            // 
            firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            firmaToolStripMenuItem.Size = new Size(60, 24);
            firmaToolStripMenuItem.Text = "Firma";
            firmaToolStripMenuItem.Click += firmaToolStripMenuItem_Click;
            // 
            // galagaToolStripMenuItem
            // 
            galagaToolStripMenuItem.Name = "galagaToolStripMenuItem";
            galagaToolStripMenuItem.Size = new Size(70, 24);
            galagaToolStripMenuItem.Text = "Galaga";
            galagaToolStripMenuItem.Click += galagaToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(788, 315);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "BIENVENIDO!";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem firmaToolStripMenuItem;
        private ToolStripMenuItem galagaToolStripMenuItem;
    }
}
