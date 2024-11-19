namespace example
{
    partial class Usuario
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nombre del usuario";
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(264, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(524, 392);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(197, 419);
            label3.Name = "label3";
            label3.Size = new Size(496, 28);
            label3.TabIndex = 4;
            label3.Text = "Eslogan........................................................................................................";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(3, 419);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 5;
            label2.Text = "Controles de musica";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(694, 419);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 6;
            label4.Text = "Hora de Tie";
            // 
            // button1
            // 
            button1.Location = new Point(43, 239);
            button1.Name = "button1";
            button1.Size = new Size(136, 48);
            button1.TabIndex = 7;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(153, 321);
            label5.Name = "label5";
            label5.Size = new Size(63, 28);
            label5.TabIndex = 7;
            label5.Text = "Total: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(12, 321);
            label7.Name = "label7";
            label7.Size = new Size(96, 28);
            label7.TabIndex = 8;
            label7.Text = "Subtotal: ";
            // 
            // button2
            // 
            button2.Location = new Point(43, 142);
            button2.Name = "button2";
            button2.Size = new Size(136, 64);
            button2.TabIndex = 8;
            button2.Text = "Generar Venta";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(43, 53);
            button3.Name = "button3";
            button3.Size = new Size(136, 62);
            button3.TabIndex = 9;
            button3.Text = "Ver carrito";
            button3.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            Name = "Usuario";
            Text = "Usuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button button1;
        private Label label5;
        private Button button3;
        private Button button2;
        private Label label7;
    }
}