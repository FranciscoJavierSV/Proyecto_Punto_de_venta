using System.Drawing.Text;

namespace example
{
    partial class Pantalla_Inicio
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
            label1 = new Label();
            label2 = new Label();
            Tiempo = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(66, 39);
            label1.Name = "label1";
            label1.Size = new Size(272, 46);
            label1.TabIndex = 0;
            label1.Text = "Pantalla de Inicio";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 419);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 1;
            label2.Text = "Controles de musica";
            // 
            // Tiempo
            // 
            Tiempo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Tiempo.AutoSize = true;
            Tiempo.Font = new Font("Segoe UI", 20F);
            Tiempo.Location = new Point(681, 410);
            Tiempo.Name = "Tiempo";
            Tiempo.Size = new Size(107, 37);
            Tiempo.TabIndex = 3;
            Tiempo.Text = "Tiempo";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25F);
            label5.Location = new Point(215, 183);
            label5.Name = "label5";
            label5.Size = new Size(374, 46);
            label5.TabIndex = 4;
            label5.Text = "Presione para continuar";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Pantalla_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(Tiempo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Pantalla_Inicio";
            Text = "Pantalla_Inicio";
            Click += Siguiente;

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private void Cambios()
        {
            PrivateFontCollection lala = new PrivateFontCollection();
            lala.AddFontFile("Resources/Fonts/Mistral.ttf");
            custom = new Font(lala.Families[0], 15);
            Font mia = new Font("Resources/Fonts/Mistral.ttf",15);
            label1.Font = custom;
            label2.Font = custom;
            Tiempo.Font = custom;
            label5.Font = custom;
        }

        private Label label1;
        private Label label2;
        private Label Tiempo;
        private Label label5;
        private Font custom;
        private System.Windows.Forms.Timer timer1;
    }
}