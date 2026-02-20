namespace CRM
{
    partial class F_authentification
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
            panel1 = new Panel();
            radioButton_hors_ligne = new RadioButton();
            button_quitter = new Button();
            button_connexion = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton_hors_ligne);
            panel1.Controls.Add(button_quitter);
            panel1.Controls.Add(button_connexion);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 461);
            panel1.TabIndex = 0;
            // 
            // radioButton_hors_ligne
            // 
            radioButton_hors_ligne.AutoSize = true;
            radioButton_hors_ligne.Font = new Font("Segoe UI", 12F);
            radioButton_hors_ligne.Location = new Point(12, 12);
            radioButton_hors_ligne.Name = "radioButton_hors_ligne";
            radioButton_hors_ligne.Size = new Size(141, 25);
            radioButton_hors_ligne.TabIndex = 2;
            radioButton_hors_ligne.TabStop = true;
            radioButton_hors_ligne.Text = "Mode hors ligne";
            radioButton_hors_ligne.UseVisualStyleBackColor = true;
            // 
            // button_quitter
            // 
            button_quitter.Font = new Font("Segoe UI", 12F);
            button_quitter.Location = new Point(12, 399);
            button_quitter.Name = "button_quitter";
            button_quitter.Size = new Size(150, 50);
            button_quitter.TabIndex = 1;
            button_quitter.Text = "Quitter";
            button_quitter.UseVisualStyleBackColor = true;
            button_quitter.Click += button_quitter_Click;
            // 
            // button_connexion
            // 
            button_connexion.Font = new Font("Segoe UI", 12F);
            button_connexion.Location = new Point(322, 399);
            button_connexion.Name = "button_connexion";
            button_connexion.Size = new Size(150, 50);
            button_connexion.TabIndex = 0;
            button_connexion.Text = "Connexion";
            button_connexion.UseVisualStyleBackColor = true;
            button_connexion.Click += button_connexion_Click;
            // 
            // F_authentification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(panel1);
            Name = "F_authentification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BCRM";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_connexion;
        private RadioButton radioButton_hors_ligne;
        private Button button_quitter;
    }
}
