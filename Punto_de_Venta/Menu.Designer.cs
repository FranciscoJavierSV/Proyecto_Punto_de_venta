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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            BBack = new Button();
            BLog_In = new Button();
            TPassword = new TextBox();
            TUser = new TextBox();
            LEslogan = new Label();
            LTiempo = new Label();
            Hora = new System.Windows.Forms.Timer(components);
            TControl = new TableLayoutPanel();
            BMusic_Play = new Button();
            BMusic_Stop = new Button();
            TBotom = new TableLayoutPanel();
            PControl = new Panel();
            IMenu = new PictureBox();
            DPanel = new SplitContainer();
            label2 = new Label();
            ILogo = new PictureBox();
            TControl.SuspendLayout();
            TBotom.SuspendLayout();
            PControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DPanel).BeginInit();
            DPanel.Panel1.SuspendLayout();
            DPanel.Panel2.SuspendLayout();
            DPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ILogo).BeginInit();
            SuspendLayout();
            // 
            // BBack
            // 
            BBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BBack.AutoSize = true;
            BBack.Cursor = Cursors.Hand;
            BBack.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Bold | FontStyle.Italic);
            BBack.ForeColor = Color.Black;
            BBack.Location = new Point(35, 376);
            BBack.Name = "BBack";
            BBack.Size = new Size(136, 48);
            BBack.TabIndex = 6;
            BBack.Text = "Back";
            BBack.UseVisualStyleBackColor = true;
            BBack.Click += Salir_Inicio;
            // 
            // BLog_In
            // 
            BLog_In.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BLog_In.AutoSize = true;
            BLog_In.Cursor = Cursors.Hand;
            BLog_In.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Bold | FontStyle.Italic);
            BLog_In.ForeColor = Color.Black;
            BLog_In.Location = new Point(189, 376);
            BLog_In.Name = "BLog_In";
            BLog_In.Size = new Size(141, 48);
            BLog_In.TabIndex = 3;
            BLog_In.Text = "Log In";
            BLog_In.UseVisualStyleBackColor = true;
            BLog_In.Click += clic;
            // 
            // TPassword
            // 
            TPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TPassword.BackColor = SystemColors.ButtonFace;
            TPassword.Cursor = Cursors.IBeam;
            TPassword.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Italic);
            TPassword.Location = new Point(35, 232);
            TPassword.Name = "TPassword";
            TPassword.PlaceholderText = "Password";
            TPassword.Size = new Size(295, 47);
            TPassword.TabIndex = 2;
            TPassword.TextAlign = HorizontalAlignment.Center;
            TPassword.UseSystemPasswordChar = true;
            // 
            // TUser
            // 
            TUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TUser.BackColor = SystemColors.ButtonFace;
            TUser.Cursor = Cursors.IBeam;
            TUser.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Italic);
            TUser.Location = new Point(35, 176);
            TUser.Name = "TUser";
            TUser.PlaceholderText = "User";
            TUser.Size = new Size(295, 47);
            TUser.TabIndex = 1;
            TUser.TextAlign = HorizontalAlignment.Center;
            // 
            // LEslogan
            // 
            LEslogan.AutoSize = true;
            LEslogan.Dock = DockStyle.Fill;
            LEslogan.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LEslogan.ForeColor = SystemColors.ButtonFace;
            LEslogan.Location = new Point(223, 0);
            LEslogan.Name = "LEslogan";
            LEslogan.Size = new Size(709, 38);
            LEslogan.TabIndex = 3;
            LEslogan.Text = "\"Tu fragancia perfecta, al alcance de un clic\"";
            LEslogan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LTiempo
            // 
            LTiempo.AutoSize = true;
            LTiempo.BackColor = Color.Transparent;
            LTiempo.Dock = DockStyle.Fill;
            LTiempo.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Italic);
            LTiempo.ForeColor = SystemColors.Control;
            LTiempo.Location = new Point(938, 0);
            LTiempo.Name = "LTiempo";
            LTiempo.Size = new Size(159, 38);
            LTiempo.TabIndex = 4;
            LTiempo.Text = "Hora de Tie";
            LTiempo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Hora
            // 
            Hora.Tick += Hora_Tick;
            // 
            // TControl
            // 
            TControl.ColumnCount = 2;
            TControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            TControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            TControl.Controls.Add(BMusic_Play, 0, 0);
            TControl.Controls.Add(BMusic_Stop, 1, 0);
            TControl.Dock = DockStyle.Left;
            TControl.Location = new Point(0, 0);
            TControl.Margin = new Padding(3, 2, 3, 2);
            TControl.Name = "TControl";
            TControl.RowCount = 1;
            TControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TControl.Size = new Size(88, 33);
            TControl.TabIndex = 5;
            // 
            // BMusic_Play
            // 
            BMusic_Play.Dock = DockStyle.Fill;
            BMusic_Play.FlatStyle = FlatStyle.Flat;
            BMusic_Play.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BMusic_Play.ForeColor = SystemColors.Control;
            BMusic_Play.Location = new Point(3, 2);
            BMusic_Play.Margin = new Padding(3, 2, 3, 2);
            BMusic_Play.Name = "BMusic_Play";
            BMusic_Play.Size = new Size(38, 29);
            BMusic_Play.TabIndex = 4;
            BMusic_Play.Text = "▶";
            BMusic_Play.UseVisualStyleBackColor = true;
            BMusic_Play.Click += buttonPlay_Click;
            // 
            // BMusic_Stop
            // 
            BMusic_Stop.BackColor = Color.Transparent;
            BMusic_Stop.Dock = DockStyle.Fill;
            BMusic_Stop.FlatStyle = FlatStyle.Flat;
            BMusic_Stop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BMusic_Stop.ForeColor = SystemColors.Control;
            BMusic_Stop.Location = new Point(47, 2);
            BMusic_Stop.Margin = new Padding(3, 2, 3, 2);
            BMusic_Stop.Name = "BMusic_Stop";
            BMusic_Stop.Size = new Size(38, 29);
            BMusic_Stop.TabIndex = 5;
            BMusic_Stop.Text = "■";
            BMusic_Stop.UseVisualStyleBackColor = false;
            BMusic_Stop.Click += buttonStop_Click;
            // 
            // TBotom
            // 
            TBotom.BackColor = Color.Transparent;
            TBotom.ColumnCount = 3;
            TBotom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TBotom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            TBotom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            TBotom.Controls.Add(LEslogan, 1, 0);
            TBotom.Controls.Add(LTiempo, 2, 0);
            TBotom.Controls.Add(PControl, 0, 0);
            TBotom.Dock = DockStyle.Bottom;
            TBotom.Location = new Point(0, 514);
            TBotom.Margin = new Padding(3, 2, 3, 2);
            TBotom.Name = "TBotom";
            TBotom.RowCount = 1;
            TBotom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TBotom.Size = new Size(1100, 38);
            TBotom.TabIndex = 10;
            // 
            // PControl
            // 
            PControl.Controls.Add(TControl);
            PControl.ForeColor = SystemColors.Control;
            PControl.Location = new Point(3, 2);
            PControl.Margin = new Padding(3, 2, 3, 2);
            PControl.Name = "PControl";
            PControl.Size = new Size(180, 33);
            PControl.TabIndex = 12;
            // 
            // IMenu
            // 
            IMenu.Dock = DockStyle.Fill;
            IMenu.Image = (Image)resources.GetObject("IMenu.Image");
            IMenu.Location = new Point(0, 0);
            IMenu.Name = "IMenu";
            IMenu.Padding = new Padding(25, 25, 25, 25);
            IMenu.Size = new Size(364, 514);
            IMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            IMenu.TabIndex = 8;
            IMenu.TabStop = false;
            // 
            // DPanel
            // 
            DPanel.BackColor = Color.Transparent;
            DPanel.Dock = DockStyle.Fill;
            DPanel.Location = new Point(0, 0);
            DPanel.Name = "DPanel";
            // 
            // DPanel.Panel1
            // 
            DPanel.Panel1.Controls.Add(BLog_In);
            DPanel.Panel1.Controls.Add(BBack);
            DPanel.Panel1.Controls.Add(label2);
            DPanel.Panel1.Controls.Add(TUser);
            DPanel.Panel1.Controls.Add(TPassword);
            DPanel.Panel1.Controls.Add(IMenu);
            // 
            // DPanel.Panel2
            // 
            DPanel.Panel2.Controls.Add(ILogo);
            DPanel.Size = new Size(1100, 514);
            DPanel.SplitterDistance = 364;
            DPanel.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(71, 38);
            label2.Name = "label2";
            label2.Size = new Size(219, 38);
            label2.TabIndex = 8;
            label2.Text = "Bienvenido";
            // 
            // ILogo
            // 
            ILogo.Dock = DockStyle.Fill;
            ILogo.Image = Punto_de_Venta.Properties.Resources.FragannisLogo__2_;
            ILogo.InitialImage = Punto_de_Venta.Properties.Resources.FragannisLogo__2_;
            ILogo.Location = new Point(0, 0);
            ILogo.Name = "ILogo";
            ILogo.Padding = new Padding(25, 25, 25, 25);
            ILogo.Size = new Size(732, 514);
            ILogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ILogo.TabIndex = 0;
            ILogo.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Punto_de_Venta.Properties.Resources.fondopresentacion;
            ClientSize = new Size(1100, 552);
            ControlBox = false;
            Controls.Add(DPanel);
            Controls.Add(TBotom);
            DoubleBuffered = true;
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.Manual;
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            TControl.ResumeLayout(false);
            TBotom.ResumeLayout(false);
            TBotom.PerformLayout();
            PControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IMenu).EndInit();
            DPanel.Panel1.ResumeLayout(false);
            DPanel.Panel1.PerformLayout();
            DPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DPanel).EndInit();
            DPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ILogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label LEslogan;
        private Label LTiempo;
        private Button BLog_In;
        private TextBox TPassword;
        private TextBox TUser;
        private Button BBack;
        private System.Windows.Forms.Timer Hora;
        private TableLayoutPanel TControl;
        private Button BMusic_Play;
        private Button BMusic_Stop;
        private TableLayoutPanel TBotom;
        private Panel PControl;
        private PictureBox IMenu;
        private SplitContainer DPanel;
        private PictureBox ILogo;
        private Label label2;
    }
}