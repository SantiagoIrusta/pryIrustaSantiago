namespace pryIrustaSantiago
{
    partial class frmNombreJugador
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
            label2 = new Label();
            label3 = new Label();
            txtNombreJugador = new TextBox();
            btnJugar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 115);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(260, 9);
            label2.Name = "label2";
            label2.Size = new Size(241, 46);
            label2.TabIndex = 1;
            label2.Text = "JUEGO NUEVO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(30, 115);
            label3.Name = "label3";
            label3.Size = new Size(209, 31);
            label3.TabIndex = 2;
            label3.Text = "Ingrese su nombre:";
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreJugador.Location = new Point(274, 115);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(453, 34);
            txtNombreJugador.TabIndex = 3;
            // 
            // btnJugar
            // 
            btnJugar.BackColor = SystemColors.ActiveCaptionText;
            btnJugar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnJugar.ForeColor = SystemColors.ButtonFace;
            btnJugar.Location = new Point(595, 225);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(119, 41);
            btnJugar.TabIndex = 4;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveCaptionText;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(30, 225);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(119, 41);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmNombreJugador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 292);
            Controls.Add(btnSalir);
            Controls.Add(btnJugar);
            Controls.Add(txtNombreJugador);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNombreJugador";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombreJugador;
        private Button btnJugar;
        private Button btnSalir;
    }
}