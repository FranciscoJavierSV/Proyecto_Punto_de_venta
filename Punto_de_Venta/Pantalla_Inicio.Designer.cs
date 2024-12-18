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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_Inicio));
            LTiempo = new Label();
            Hora = new System.Windows.Forms.Timer(components);
            buttonclose = new Button();
            PControl = new Panel();
            buttonminim = new Button();
            buttonmaxim = new Button();
            PControl2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            BMusic_Play = new Button();
            BMusic_Stop = new Button();
            PControl.SuspendLayout();
            PControl2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LTiempo
            // 
            LTiempo.AutoSize = true;
            LTiempo.Dock = DockStyle.Right;
            LTiempo.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Italic);
            LTiempo.Location = new Point(695, 0);
            LTiempo.Name = "LTiempo";
            LTiempo.Size = new Size(105, 39);
            LTiempo.TabIndex = 3;
            LTiempo.Text = "Tiempo";
            // 
            // Hora
            // 
            Hora.Tick += timer1_Tick;
            // 
            // buttonclose
            // 
            buttonclose.AutoSize = true;
            buttonclose.BackColor = Color.Transparent;
            buttonclose.BackgroundImage = Punto_de_Venta.Properties.Resources.Cerrar;
            buttonclose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonclose.Cursor = Cursors.Hand;
            buttonclose.Dock = DockStyle.Right;
            buttonclose.FlatAppearance.BorderSize = 0;
            buttonclose.FlatStyle = FlatStyle.Flat;
            buttonclose.ForeColor = Color.Transparent;
            buttonclose.Location = new Point(765, 0);
            buttonclose.Margin = new Padding(0);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(35, 30);
            buttonclose.TabIndex = 5;
            buttonclose.UseVisualStyleBackColor = false;
            buttonclose.SizeChanged += button1_Click;
            buttonclose.Click += button1_Click;
            // 
            // PControl
            // 
            PControl.BackColor = Color.Transparent;
            PControl.Controls.Add(buttonminim);
            PControl.Controls.Add(buttonmaxim);
            PControl.Controls.Add(buttonclose);
            PControl.Dock = DockStyle.Top;
            PControl.Location = new Point(0, 0);
            PControl.Margin = new Padding(3, 2, 3, 2);
            PControl.Name = "PControl";
            PControl.Size = new Size(800, 30);
            PControl.TabIndex = 6;
            PControl.MouseDown += panel1_MouseDown;
            // 
            // buttonminim
            // 
            buttonminim.AutoSize = true;
            buttonminim.BackColor = Color.Transparent;
            buttonminim.BackgroundImage = Punto_de_Venta.Properties.Resources.Minimizar;
            buttonminim.BackgroundImageLayout = ImageLayout.Stretch;
            buttonminim.Cursor = Cursors.Hand;
            buttonminim.Dock = DockStyle.Right;
            buttonminim.FlatAppearance.BorderSize = 0;
            buttonminim.FlatAppearance.MouseDownBackColor = Color.White;
            buttonminim.FlatStyle = FlatStyle.Flat;
            buttonminim.ForeColor = Color.Transparent;
            buttonminim.Location = new Point(695, 0);
            buttonminim.Margin = new Padding(0);
            buttonminim.Name = "buttonminim";
            buttonminim.Size = new Size(35, 30);
            buttonminim.TabIndex = 7;
            buttonminim.UseVisualStyleBackColor = false;
            buttonminim.Click += buttonminim_Click;
            // 
            // buttonmaxim
            // 
            buttonmaxim.AutoSize = true;
            buttonmaxim.BackColor = Color.Transparent;
            buttonmaxim.BackgroundImage = Punto_de_Venta.Properties.Resources.Maximizar;
            buttonmaxim.BackgroundImageLayout = ImageLayout.Stretch;
            buttonmaxim.Cursor = Cursors.Hand;
            buttonmaxim.Dock = DockStyle.Right;
            buttonmaxim.FlatAppearance.BorderSize = 0;
            buttonmaxim.FlatStyle = FlatStyle.Flat;
            buttonmaxim.ForeColor = Color.Transparent;
            buttonmaxim.Location = new Point(730, 0);
            buttonmaxim.Margin = new Padding(0);
            buttonmaxim.Name = "buttonmaxim";
            buttonmaxim.Size = new Size(35, 30);
            buttonmaxim.TabIndex = 6;
            buttonmaxim.UseVisualStyleBackColor = false;
            buttonmaxim.Click += buttonmaxim_Click;
            // 
            // PControl2
            // 
            PControl2.BackColor = Color.Transparent;
            PControl2.Controls.Add(tableLayoutPanel1);
            PControl2.Controls.Add(LTiempo);
            PControl2.Dock = DockStyle.Bottom;
            PControl2.Location = new Point(0, 412);
            PControl2.Margin = new Padding(3, 2, 3, 2);
            PControl2.Name = "PControl2";
            PControl2.Size = new Size(800, 38);
            PControl2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Controls.Add(BMusic_Play, 0, 0);
            tableLayoutPanel1.Controls.Add(BMusic_Stop, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(88, 38);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // BMusic_Play
            // 
            BMusic_Play.Dock = DockStyle.Fill;
            BMusic_Play.FlatStyle = FlatStyle.Flat;
            BMusic_Play.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BMusic_Play.ForeColor = Color.Black;
            BMusic_Play.Location = new Point(3, 2);
            BMusic_Play.Margin = new Padding(3, 2, 3, 2);
            BMusic_Play.Name = "BMusic_Play";
            BMusic_Play.Size = new Size(38, 34);
            BMusic_Play.TabIndex = 4;
            BMusic_Play.Text = "▶";
            BMusic_Play.UseVisualStyleBackColor = true;
            BMusic_Play.Click += buttonPlay_Click;
            // 
            // BMusic_Stop
            // 
            BMusic_Stop.Dock = DockStyle.Fill;
            BMusic_Stop.FlatStyle = FlatStyle.Flat;
            BMusic_Stop.Location = new Point(47, 2);
            BMusic_Stop.Margin = new Padding(3, 2, 3, 2);
            BMusic_Stop.Name = "BMusic_Stop";
            BMusic_Stop.Size = new Size(38, 34);
            BMusic_Stop.TabIndex = 5;
            BMusic_Stop.Text = "■";
            BMusic_Stop.UseVisualStyleBackColor = true;
            BMusic_Stop.Click += buttonStop_Click;
            // 
            // Pantalla_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(PControl);
            Controls.Add(PControl2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pantalla_Inicio";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Click += Siguiente;
            PControl.ResumeLayout(false);
            PControl.PerformLayout();
            PControl2.ResumeLayout(false);
            PControl2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label LTiempo;
        private System.Windows.Forms.Timer Hora;
        private Button buttonclose;
        private Panel PControl;
        private Panel PControl2;
        private Button buttonmaxim;
        private Button buttonminim;
        private Button buttonPause;
        private Button BMusic_Stop;
        private Button BMusic_Play;
        private TableLayoutPanel tableLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
#endregion