namespace pryIrustaSantiago
{
    partial class frmFirma
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
            pbFirma = new PictureBox();
            btnGrabar = new Button();
            label1 = new Label();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFirma).BeginInit();
            SuspendLayout();
            // 
            // pbFirma
            // 
            pbFirma.BackColor = SystemColors.ButtonFace;
            pbFirma.Location = new Point(17, 104);
            pbFirma.Margin = new Padding(4);
            pbFirma.Name = "pbFirma";
            pbFirma.Size = new Size(801, 288);
            pbFirma.TabIndex = 0;
            pbFirma.TabStop = false;
            pbFirma.MouseMove += pbFirma_MouseMove;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(664, 410);
            btnGrabar.Margin = new Padding(4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(154, 70);
            btnGrabar.TabIndex = 1;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 38);
            label1.TabIndex = 2;
            label1.Text = "Dibuje aqui su firma";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(17, 410);
            btnBorrar.Margin = new Padding(4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(154, 70);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(859, 503);
            Controls.Add(btnBorrar);
            Controls.Add(label1);
            Controls.Add(btnGrabar);
            Controls.Add(pbFirma);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmFirma";
            Text = "FIRMA";
            Load += frmFirma_Load;
            ((System.ComponentModel.ISupportInitialize)pbFirma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFirma;
        private Button btnGrabar;
        private Label label1;
        private Button btnBorrar;
    }
}