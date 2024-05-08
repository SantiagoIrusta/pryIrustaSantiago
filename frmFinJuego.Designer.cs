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
            label1.Font = new Font("Segoe UI", 20.25F);
            label1.Location = new Point(104, 57);
            label1.Name = "label1";
            label1.Size = new Size(186, 37);
            label1.TabIndex = 0;
            label1.Text = "¡FELICIDADES!";
            // 
            // lblNombreJugador
            // 
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.Font = new Font("Segoe UI", 20.25F);
            lblNombreJugador.Location = new Point(288, 57);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new Size(206, 37);
            lblNombreJugador.TabIndex = 1;
            lblNombreJugador.Text = "nombreJugador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F);
            label2.Location = new Point(230, 111);
            label2.Name = "label2";
            label2.Size = new Size(140, 37);
            label2.TabIndex = 2;
            label2.Text = "GANASTE!";
            // 
            // frmFinJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(598, 204);
            Controls.Add(label2);
            Controls.Add(lblNombreJugador);
            Controls.Add(label1);
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