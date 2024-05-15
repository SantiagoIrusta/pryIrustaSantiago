namespace pryIrustaSantiago
{
    partial class frmFinJuego
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
            label1 = new Label();
            lblNombreJugador = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(112, 80);
            label1.Name = "label1";
            label1.Size = new Size(194, 46);
            label1.TabIndex = 0;
            label1.Text = "¡Felicidades";
            // 
            // lblNombreJugador
            // 
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.BackColor = Color.Transparent;
            lblNombreJugador.Font = new Font("Segoe UI", 20.25F);
            lblNombreJugador.ForeColor = SystemColors.ButtonFace;
            lblNombreJugador.Location = new Point(312, 80);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new Size(258, 46);
            lblNombreJugador.TabIndex = 1;
            lblNombreJugador.Text = "nombreJugador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(240, 147);
            label2.Name = "label2";
            label2.Size = new Size(175, 46);
            label2.TabIndex = 2;
            label2.Text = "GANASTE!";
            // 
            // frmFinJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(683, 272);
            Controls.Add(label2);
            Controls.Add(lblNombreJugador);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmFinJuego";
            Text = "frmFinJuego";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombreJugador;
        private Label label2;
    }
}