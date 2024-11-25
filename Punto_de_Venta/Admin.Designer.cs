namespace example
{
    partial class Admin
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
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonShadow;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 306);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.Location = new Point(43, 53);
            button3.Name = "button3";
            button3.Size = new Size(136, 62);
            button3.TabIndex = 9;
            button3.Text = "Mod Articulos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(43, 142);
            button2.Name = "button2";
            button2.Size = new Size(136, 64);
            button2.TabIndex = 8;
            button2.Text = "Ver Estadistica";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(43, 239);
            button1.Name = "button1";
            button1.Size = new Size(136, 48);
            button1.TabIndex = 7;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Salir_Admin;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 142);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(3, 419);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 6;
            label2.Text = "Controles de musica";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(182, 419);
            label3.Name = "label3";
            label3.Size = new Size(496, 28);
            label3.TabIndex = 7;
            label3.Text = "Eslogan........................................................................................................";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(676, 419);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 8;
            label4.Text = "Tiempo";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Admin";
            ShowIcon = false;
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}