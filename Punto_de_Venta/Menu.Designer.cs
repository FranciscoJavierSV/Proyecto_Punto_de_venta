namespace example
{
    partial class Menu
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            txt2 = new TextBox();
            txt1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.ButtonShadow;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt2);
            groupBox1.Controls.Add(txt1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 306);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 142);
            label6.Name = "label6";
            label6.Size = new Size(112, 28);
            label6.TabIndex = 5;
            label6.Text = "Password: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 77);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 4;
            label5.Text = "User: ";
            // 
            // button1
            // 
            button1.Location = new Point(60, 227);
            button1.Name = "button1";
            button1.Size = new Size(136, 48);
            button1.TabIndex = 3;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += clic;
            // 
            // txt2
            // 
            txt2.Location = new Point(114, 142);
            txt2.Name = "txt2";
            txt2.Size = new Size(159, 34);
            txt2.TabIndex = 2;
            txt2.UseSystemPasswordChar = true;
            // 
            // txt1
            // 
            txt1.Location = new Point(114, 74);
            txt1.Name = "txt1";
            txt1.Size = new Size(159, 34);
            txt1.TabIndex = 1;
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
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(2, 419);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 2;
            label2.Text = "Controles de musica";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(195, 419);
            label3.Name = "label3";
            label3.Size = new Size(496, 28);
            label3.TabIndex = 3;
            label3.Text = "Eslogan........................................................................................................";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(688, 419);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 4;
            label4.Text = "Hora de Tie";
            // 
            // button2
            // 
            button2.Location = new Point(652, 11);
            button2.Name = "button2";
            button2.Size = new Size(136, 48);
            button2.TabIndex = 6;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Salir_Inicio;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Menu";
            Text = "Menu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button button1;
        private TextBox txt2;
        private TextBox txt1;
        private Button button2;
    }
}