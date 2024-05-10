namespace pryIrustaSantiago
{
    partial class frmJuego
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
            components = new System.ComponentModel.Container();
            timerEnemigo = new System.Windows.Forms.Timer(components);
            timerDisparo = new System.Windows.Forms.Timer(components);
            lblScore = new Label();
            SuspendLayout();
            // 
            // timerEnemigo
            // 
            timerEnemigo.Enabled = true;
            timerEnemigo.Interval = 500;
            timerEnemigo.Tick += timerEnemigo_Tick;
            // 
            // timerDisparo
            // 
            timerDisparo.Enabled = true;
            timerDisparo.Tick += timerDisparo_Tick;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = SystemColors.ButtonFace;
            lblScore.Font = new Font("Segoe UI", 10.8F);
            lblScore.ForeColor = Color.Red;
            lblScore.Location = new Point(834, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(22, 25);
            lblScore.TabIndex = 0;
            lblScore.Text = "0";
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(900, 800);
            Controls.Add(lblScore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmJuego";
            Text = "frmJuego";
            Load += frmJuego_Load;
            KeyDown += frmJuego_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerEnemigo;
        private System.Windows.Forms.Timer timerDisparo;
        private Label lblScore;
    }
}