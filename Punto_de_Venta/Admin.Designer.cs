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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            GUsuario = new GroupBox();
            BEstadistica = new Button();
            BModificar = new Button();
            BLog_Out = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            LTiempo = new Label();
            LEslogan = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BMusic_Stop = new Button();
            BMusic_Play = new Button();
            SUsuario = new SplitContainer();
            PArticulos = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            GArticulo10 = new GroupBox();
            LArticulo10 = new Label();
            PArticulo10 = new PictureBox();
            GArticulo9 = new GroupBox();
            LArticulo9 = new Label();
            PArticulo9 = new PictureBox();
            GArticulo8 = new GroupBox();
            LArticulo8 = new Label();
            PArticulo8 = new PictureBox();
            GArticulo7 = new GroupBox();
            LArticulo7 = new Label();
            PArticulo7 = new PictureBox();
            GArticulo6 = new GroupBox();
            LArticulo6 = new Label();
            PArticulo6 = new PictureBox();
            GArticulo5 = new GroupBox();
            LArticulo5 = new Label();
            PArticulo5 = new PictureBox();
            GArticulo4 = new GroupBox();
            LArticulo4 = new Label();
            PArticulo4 = new PictureBox();
            GArticulo3 = new GroupBox();
            LArticulo3 = new Label();
            PArticulo3 = new PictureBox();
            GArticulo2 = new GroupBox();
            LArticulo2 = new Label();
            PArticulo2 = new PictureBox();
            GArticulo1 = new GroupBox();
            LArticulo1 = new Label();
            PArticulo1 = new PictureBox();
            Hora = new System.Windows.Forms.Timer(components);
            GUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SUsuario).BeginInit();
            SUsuario.Panel1.SuspendLayout();
            SUsuario.Panel2.SuspendLayout();
            SUsuario.SuspendLayout();
            PArticulos.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            GArticulo10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PArticulo10).BeginInit();
            GArticulo9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PArticulo9).BeginInit();
            GArticulo8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PArticulo8).BeginInit();
            GArticulo7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PArticulo7).BeginInit();
            GArticulo6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PArticulo6).BeginInit();
            GArticulo5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PArticulo5).BeginInit();
            GArticulo4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PArticulo4).BeginInit();
            GArticulo3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PArticulo3).BeginInit();
            GArticulo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PArticulo2).BeginInit();
            GArticulo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PArticulo1).BeginInit();
            SuspendLayout();
            // 
            // GUsuario
            // 
            GUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GUsuario.BackColor = Color.Transparent;
            GUsuario.Controls.Add(BEstadistica);
            GUsuario.Controls.Add(BModificar);
            GUsuario.Controls.Add(BLog_Out);
            GUsuario.Controls.Add(label1);
            GUsuario.Controls.Add(pictureBox1);
            GUsuario.Dock = DockStyle.Fill;
            GUsuario.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            GUsuario.Location = new Point(0, 0);
            GUsuario.Margin = new Padding(3, 4, 3, 4);
            GUsuario.Name = "GUsuario";
            GUsuario.Padding = new Padding(3, 4, 3, 4);
            GUsuario.Size = new Size(261, 587);
            GUsuario.TabIndex = 1;
            GUsuario.TabStop = false;
            GUsuario.Text = "Admin";
            // 
            // BEstadistica
            // 
            BEstadistica.Anchor = AnchorStyles.None;
            BEstadistica.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BEstadistica.Location = new Point(19, 354);
            BEstadistica.Margin = new Padding(3, 4, 3, 4);
            BEstadistica.Name = "BEstadistica";
            BEstadistica.Size = new Size(230, 105);
            BEstadistica.TabIndex = 9;
            BEstadistica.Text = "Estadistica de Ventas";
            BEstadistica.UseVisualStyleBackColor = true;
            BEstadistica.Click += Estadistica;
            // 
            // BModificar
            // 
            BModificar.Anchor = AnchorStyles.None;
            BModificar.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BModificar.Location = new Point(19, 213);
            BModificar.Margin = new Padding(3, 4, 3, 4);
            BModificar.Name = "BModificar";
            BModificar.Size = new Size(230, 100);
            BModificar.TabIndex = 8;
            BModificar.Text = "Modificar Articulos";
            BModificar.UseVisualStyleBackColor = true;
            BModificar.Click += Mod_Articulos;
            // 
            // BLog_Out
            // 
            BLog_Out.Anchor = AnchorStyles.Bottom;
            BLog_Out.BackColor = Color.IndianRed;
            BLog_Out.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BLog_Out.Location = new Point(57, 496);
            BLog_Out.Margin = new Padding(3, 4, 3, 4);
            BLog_Out.Name = "BLog_Out";
            BLog_Out.Size = new Size(153, 53);
            BLog_Out.TabIndex = 7;
            BLog_Out.Text = "Log Out";
            BLog_Out.UseVisualStyleBackColor = false;
            BLog_Out.Click += Salir_Usuario;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(69, 12);
            label1.Name = "label1";
            label1.Size = new Size(0, 51);
            label1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Punto_de_Venta.Properties.Resources.Fragannislogo;
            pictureBox1.Location = new Point(3, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(LTiempo, 2, 0);
            tableLayoutPanel1.Controls.Add(LEslogan, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 587);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(952, 50);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // LTiempo
            // 
            LTiempo.Dock = DockStyle.Fill;
            LTiempo.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Italic);
            LTiempo.ForeColor = SystemColors.Control;
            LTiempo.Location = new Point(811, 0);
            LTiempo.Name = "LTiempo";
            LTiempo.Size = new Size(138, 50);
            LTiempo.TabIndex = 8;
            LTiempo.Text = "Hora de Tie";
            LTiempo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LEslogan
            // 
            LEslogan.AutoSize = true;
            LEslogan.Dock = DockStyle.Fill;
            LEslogan.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LEslogan.ForeColor = SystemColors.ButtonFace;
            LEslogan.Location = new Point(193, 0);
            LEslogan.Name = "LEslogan";
            LEslogan.Size = new Size(612, 50);
            LEslogan.TabIndex = 7;
            LEslogan.Text = "\"Tu fragancia perfecta, al alcance de un clic\"";
            LEslogan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 44);
            panel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(BMusic_Stop, 1, 0);
            tableLayoutPanel2.Controls.Add(BMusic_Play, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(100, 44);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // BMusic_Stop
            // 
            BMusic_Stop.BackColor = Color.Transparent;
            BMusic_Stop.FlatStyle = FlatStyle.Flat;
            BMusic_Stop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BMusic_Stop.ForeColor = SystemColors.Control;
            BMusic_Stop.Location = new Point(53, 3);
            BMusic_Stop.Name = "BMusic_Stop";
            BMusic_Stop.Size = new Size(44, 38);
            BMusic_Stop.TabIndex = 5;
            BMusic_Stop.Text = "■";
            BMusic_Stop.UseVisualStyleBackColor = false;
            BMusic_Stop.Click += BMusic_Stop_Click;
            // 
            // BMusic_Play
            // 
            BMusic_Play.FlatStyle = FlatStyle.Flat;
            BMusic_Play.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BMusic_Play.ForeColor = SystemColors.Control;
            BMusic_Play.Location = new Point(3, 3);
            BMusic_Play.Name = "BMusic_Play";
            BMusic_Play.Size = new Size(44, 38);
            BMusic_Play.TabIndex = 4;
            BMusic_Play.Text = "▶";
            BMusic_Play.UseVisualStyleBackColor = true;
            BMusic_Play.Click += BMusic_Play_Click;
            // 
            // SUsuario
            // 
            SUsuario.BackColor = Color.Transparent;
            SUsuario.Dock = DockStyle.Fill;
            SUsuario.Location = new Point(0, 0);
            SUsuario.Margin = new Padding(3, 4, 3, 4);
            SUsuario.Name = "SUsuario";
            // 
            // SUsuario.Panel1
            // 
            SUsuario.Panel1.Controls.Add(PArticulos);
            // 
            // SUsuario.Panel2
            // 
            SUsuario.Panel2.Controls.Add(GUsuario);
            SUsuario.Size = new Size(952, 587);
            SUsuario.SplitterDistance = 686;
            SUsuario.SplitterWidth = 5;
            SUsuario.TabIndex = 12;
            // 
            // PArticulos
            // 
            PArticulos.AutoScroll = true;
            PArticulos.AutoSize = true;
            PArticulos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PArticulos.Controls.Add(tableLayoutPanel3);
            PArticulos.Dock = DockStyle.Fill;
            PArticulos.Location = new Point(0, 0);
            PArticulos.Margin = new Padding(3, 4, 3, 4);
            PArticulos.Name = "PArticulos";
            PArticulos.Size = new Size(686, 587);
            PArticulos.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.BackColor = Color.FromArgb(215, 160, 224);
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(GArticulo10, 2, 4);
            tableLayoutPanel3.Controls.Add(GArticulo9, 1, 4);
            tableLayoutPanel3.Controls.Add(GArticulo8, 2, 3);
            tableLayoutPanel3.Controls.Add(GArticulo7, 1, 3);
            tableLayoutPanel3.Controls.Add(GArticulo6, 2, 2);
            tableLayoutPanel3.Controls.Add(GArticulo5, 1, 2);
            tableLayoutPanel3.Controls.Add(GArticulo4, 2, 1);
            tableLayoutPanel3.Controls.Add(GArticulo3, 1, 1);
            tableLayoutPanel3.Controls.Add(GArticulo2, 2, 0);
            tableLayoutPanel3.Controls.Add(GArticulo1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(665, 2000);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // GArticulo10
            // 
            GArticulo10.AutoSize = true;
            GArticulo10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GArticulo10.Controls.Add(LArticulo10);
            GArticulo10.Controls.Add(PArticulo10);
            GArticulo10.Dock = DockStyle.Fill;
            GArticulo10.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            GArticulo10.Location = new Point(335, 1604);
            GArticulo10.Margin = new Padding(3, 4, 3, 4);
            GArticulo10.Name = "GArticulo10";
            GArticulo10.Padding = new Padding(3, 4, 3, 4);
            GArticulo10.Size = new Size(193, 392);
            GArticulo10.TabIndex = 29;
            GArticulo10.TabStop = false;
            GArticulo10.Text = "Nombre del Articulo";
            // 
            // LArticulo10
            // 
            LArticulo10.BackColor = Color.LightSteelBlue;
            LArticulo10.Dock = DockStyle.Fill;
            LArticulo10.Location = new Point(3, 271);
            LArticulo10.Name = "LArticulo10";
            LArticulo10.Size = new Size(187, 117);
            LArticulo10.TabIndex = 1;
            LArticulo10.Text = "Descripcion";
            // 
            // PArticulo10
            // 
            PArticulo10.BackColor = Color.Transparent;
            PArticulo10.Dock = DockStyle.Top;
            PArticulo10.Location = new Point(3, 31);
            PArticulo10.Margin = new Padding(3, 4, 3, 4);
            PArticulo10.Name = "PArticulo10";
            PArticulo10.Size = new Size(187, 240);
            PArticulo10.SizeMode = PictureBoxSizeMode.StretchImage;
            PArticulo10.TabIndex = 0;
            PArticulo10.TabStop = false;
            // 
            // GArticulo9
            // 
            GArticulo9.AutoSize = true;
            GArticulo9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GArticulo9.Controls.Add(LArticulo9);
            GArticulo9.Controls.Add(PArticulo9);
            GArticulo9.Dock = DockStyle.Fill;
            GArticulo9.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            GArticulo9.Location = new Point(136, 1604);
            GArticulo9.Margin = new Padding(3, 4, 3, 4);
            GArticulo9.Name = "GArticulo9";
            GArticulo9.Padding = new Padding(3, 4, 3, 4);
            GArticulo9.Size = new Size(193, 392);
            GArticulo9.TabIndex = 28;
            GArticulo9.TabStop = false;
            GArticulo9.Text = "Nombre del Articulo";
            // 
            // LArticulo9
            // 
            LArticulo9.BackColor = Color.LightSteelBlue;
            LArticulo9.Dock = DockStyle.Fill;
            LArticulo9.Location = new Point(3, 271);
            LArticulo9.Name = "LArticulo9";
            LArticulo9.Size = new Size(187, 117);
            LArticulo9.TabIndex = 1;
            LArticulo9.Text = "Descripcion";
            // 
            // PArticulo9
            // 
            PArticulo9.BackColor = Color.Transparent;
            PArticulo9.Dock = DockStyle.Top;
            PArticulo9.Location = new Point(3, 31);
            PArticulo9.Margin = new Padding(3, 4, 3, 4);
            PArticulo9.Name = "PArticulo9";
            PArticulo9.Size = new Size(187, 240);
            PArticulo9.SizeMode = PictureBoxSizeMode.StretchImage;
            PArticulo9.TabIndex = 0;
            PArticulo9.TabStop = false;
            // 
            // GArticulo8
            // 
            GArticulo8.AutoSize = true;
            GArticulo8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GArticulo8.Controls.Add(LArticulo8);
            GArticulo8.Controls.Add(PArticulo8);
            GArticulo8.Dock = DockStyle.Fill;
            GArticulo8.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            GArticulo8.Location = new Point(335, 1204);
            GArticulo8.Margin = new Padding(3, 4, 3, 4);
            GArticulo8.Name = "GArticulo8";
            GArticulo8.Padding = new Padding(3, 4, 3, 4);
            GArticulo8.Size = new Size(193, 392);
            GArticulo8.TabIndex = 27;
            GArticulo8.TabStop = false;
            GArticulo8.Text = "Nombre del Articulo";
            // 
            // LArticulo8
            // 
            LArticulo8.BackColor = Color.LightSteelBlue;
            LArticulo8.Dock = DockStyle.Fill;
            LArticulo8.Location = new Point(3, 271);
            LArticulo8.Name = "LArticulo8";
            LArticulo8.Size = new Size(187, 117);
            LArticulo8.TabIndex = 1;
            LArticulo8.Text = "Descripcion";
            // 
            // PArticulo8
            // 
            PArticulo8.BackColor = Color.Transparent;
            PArticulo8.Dock = DockStyle.Top;
            PArticulo8.Location = new Point(3, 31);
            PArticulo8.Margin = new Padding(3, 4, 3, 4);
            PArticulo8.Name = "PArticulo8";
            PArticulo8.Size = new Size(187, 240);
            PArticulo8.SizeMode = PictureBoxSizeMode.StretchImage;
            PArticulo8.TabIndex = 0;
            PArticulo8.TabStop = false;
            // 
            // GArticulo7
            // 
            GArticulo7.AutoSize = true;
            GArticulo7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GArticulo7.Controls.Add(LArticulo7);
            GArticulo7.Controls.Add(PArticulo7);
            GArticulo7.Dock = DockStyle.Fill;
            GArticulo7.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            GArticulo7.Location = new Point(136, 1204);
            GArticulo7.Margin = new Padding(3, 4, 3, 4);
            GArticulo7.Name = "GArticulo7";
            GArticulo7.Padding = new Padding(3, 4, 3, 4);
            GArticulo7.Size = new Size(193, 392);
            GArticulo7.TabIndex = 26;
            GArticulo7.TabStop = false;
            GArticulo7.Text = "Nombre del Articulo";
            // 
            // LArticulo7
            // 
            LArticulo7.BackColor = Color.LightSteelBlue;
            LArticulo7.Dock = DockStyle.Fill;
            LArticulo7.Location = new Point(3, 271);
            LArticulo7.Name = "LArticulo7";
            LArticulo7.Size = new Size(187, 117);
            LArticulo7.TabIndex = 1;
            LArticulo7.Text = "Descripcion";
            // 
            // PArticulo7
            // 
            PArticulo7.BackColor = Color.Transparent;
            PArticulo7.Dock = DockStyle.Top;
            PArticulo7.Location = new Point(3, 31);
            PArticulo7.Margin = new Padding(3, 4, 3, 4);
            PArticulo7.Name = "PArticulo7";
            PArticulo7.Size = new Size(187, 240);
            PArticulo7.SizeMode = PictureBoxSizeMode.StretchImage;
            PArticulo7.TabIndex = 0;
            PArticulo7.TabStop = false;
            // 
            // GArticulo6
            // 
            GArticulo6.AutoSize = true;
            GArticulo6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GArticulo6.Controls.Add(LArticulo6);
            GArticulo6.Controls.Add(PArticulo6);
            GArticulo6.Dock = DockStyle.Fill;
            GArticulo6.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            GArticulo6.Location = new Point(335, 804);
            GArticulo6.Margin = new Padding(3, 4, 3, 4);
            GArticulo6.Name = "GArticulo6";
            GArticulo6.Padding = new Padding(3, 4, 3, 4);
            GArticulo6.Size = new Size(193, 392);
            GArticulo6.TabIndex = 25;
            GArticulo6.TabStop = false;
            GArticulo6.Text = "Nombre del Articulo";
            // 
            // LArticulo6
            // 
            LArticulo6.BackColor = Color.LightSteelBlue;
            LArticulo6.Dock = DockStyle.Fill;
            LArticulo6.Location = new Point(3, 271);
            LArticulo6.Name = "LArticulo6";
            LArticulo6.Size = new Size(187, 117);
            LArticulo6.TabIndex = 1;
            LArticulo6.Text = "Descripcion";
            // 
            // PArticulo6
            // 
            PArticulo6.BackColor = Color.Transparent;
            PArticulo6.Dock = DockStyle.Top;
            PArticulo6.Location = new Point(3, 31);
            PArticulo6.Margin = new Padding(3, 4, 3, 4);
            PArticulo6.Name = "PArticulo6";
            PArticulo6.Size = new Size(187, 240);
            PArticulo6.SizeMode = PictureBoxSizeMode.StretchImage;
            PArticulo6.TabIndex = 0;
            PArticulo6.TabStop = false;
            // 
            // GArticulo5
            // 
            GArticulo5.AutoSize = true;
            GArticulo5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GArticulo5.Controls.Add(LArticulo5);
            GArticulo5.Controls.Add(PArticulo5);
            GArticulo5.Dock = DockStyle.Fill;
            GArticulo5.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            GArticulo5.Location = new Point(136, 804);
            GArticulo5.Margin = new Padding(3, 4, 3, 4);
            GArticulo5.Name = "GArticulo5";
            GArticulo5.Padding = new Padding(3, 4, 3, 4);
            GArticulo5.Size = new Size(193, 392);
            GArticulo5.TabIndex = 24;
            GArticulo5.TabStop = false;
            GArticulo5.Text = "Nombre del Articulo";
            // 
            // LArticulo5
            // 
            LArticulo5.BackColor = Color.LightSteelBlue;
            LArticulo5.Dock = DockStyle.Fill;
            LArticulo5.Location = new Point(3, 271);
            LArticulo5.Name = "LArticulo5";
            LArticulo5.Size = new Size(187, 117);
            LArticulo5.TabIndex = 1;
            LArticulo5.Text = "Descripcion";
            // 
            // PArticulo5
            // 
            PArticulo5.BackColor = Color.Transparent;
            PArticulo5.Dock = DockStyle.Top;
            PArticulo5.Location = new Point(3, 31);
            PArticulo5.Margin = new Padding(3, 4, 3, 4);
            PArticulo5.Name = "PArticulo5";
            PArticulo5.Size = new Size(187, 240);
            PArticulo5.SizeMode = PictureBoxSizeMode.StretchImage;
            PArticulo5.TabIndex = 0;
            PArticulo5.TabStop = false;
            // 
            // GArticulo4
            // 
            GArticulo4.AutoSize = true;
            GArticulo4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GArticulo4.Controls.Add(LArticulo4);
            GArticulo4.Controls.Add(PArticulo4);
            GArticulo4.Dock = DockStyle.Fill;
            GArticulo4.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            GArticulo4.Location = new Point(335, 404);
            GArticulo4.Margin = new Padding(3, 4, 3, 4);
            GArticulo4.Name = "GArticulo4";
            GArticulo4.Padding = new Padding(3, 4, 3, 4);
            GArticulo4.Size = new Size(193, 392);
            GArticulo4.TabIndex = 23;
            GArticulo4.TabStop = false;
            GArticulo4.Text = "Nombre del Articulo";
            // 
            // LArticulo4
            // 
            LArticulo4.BackColor = Color.LightSteelBlue;
            LArticulo4.Dock = DockStyle.Fill;
            LArticulo4.Location = new Point(3, 271);
            LArticulo4.Name = "LArticulo4";
            LArticulo4.Size = new Size(187, 117);
            LArticulo4.TabIndex = 1;
            LArticulo4.Text = "Descripcion";
            // 
            // PArticulo4
            // 
            PArticulo4.BackColor = Color.Transparent;
            PArticulo4.Dock = DockStyle.Top;
            PArticulo4.Location = new Point(3, 31);
            PArticulo4.Margin = new Padding(3, 4, 3, 4);
            PArticulo4.Name = "PArticulo4";
            PArticulo4.Size = new Size(187, 240);
            PArticulo4.SizeMode = PictureBoxSizeMode.StretchImage;
            PArticulo4.TabIndex = 0;
            PArticulo4.TabStop = false;
            // 
            // GArticulo3
            // 
            GArticulo3.AutoSize = true;
            GArticulo3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GArticulo3.Controls.Add(LArticulo3);
            GArticulo3.Controls.Add(PArticulo3);
            GArticulo3.Dock = DockStyle.Fill;
            GArticulo3.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            GArticulo3.Location = new Point(136, 404);
            GArticulo3.Margin = new Padding(3, 4, 3, 4);
            GArticulo3.Name = "GArticulo3";
            GArticulo3.Padding = new Padding(3, 4, 3, 4);
            GArticulo3.Size = new Size(193, 392);
            GArticulo3.TabIndex = 22;
            GArticulo3.TabStop = false;
            GArticulo3.Text = "Nombre del Articulo";
            // 
            // LArticulo3
            // 
            LArticulo3.BackColor = Color.LightSteelBlue;
            LArticulo3.Dock = DockStyle.Fill;
            LArticulo3.Location = new Point(3, 271);
            LArticulo3.Name = "LArticulo3";
            LArticulo3.Size = new Size(187, 117);
            LArticulo3.TabIndex = 1;
            LArticulo3.Text = "Descripcion";
            // 
            // PArticulo3
            // 
            PArticulo3.BackColor = Color.Transparent;
            PArticulo3.Dock = DockStyle.Top;
            PArticulo3.Location = new Point(3, 31);
            PArticulo3.Margin = new Padding(3, 4, 3, 4);
            PArticulo3.Name = "PArticulo3";
            PArticulo3.Size = new Size(187, 240);
            PArticulo3.SizeMode = PictureBoxSizeMode.StretchImage;
            PArticulo3.TabIndex = 0;
            PArticulo3.TabStop = false;
            // 
            // GArticulo2
            // 
            GArticulo2.AutoSize = true;
            GArticulo2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GArticulo2.Controls.Add(LArticulo2);
            GArticulo2.Controls.Add(PArticulo2);
            GArticulo2.Dock = DockStyle.Fill;
            GArticulo2.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            GArticulo2.Location = new Point(335, 4);
            GArticulo2.Margin = new Padding(3, 4, 3, 4);
            GArticulo2.Name = "GArticulo2";
            GArticulo2.Padding = new Padding(3, 4, 3, 4);
            GArticulo2.Size = new Size(193, 392);
            GArticulo2.TabIndex = 21;
            GArticulo2.TabStop = false;
            GArticulo2.Text = "Nombre del Articulo";
            // 
            // LArticulo2
            // 
            LArticulo2.BackColor = Color.LightSteelBlue;
            LArticulo2.Dock = DockStyle.Fill;
            LArticulo2.Location = new Point(3, 271);
            LArticulo2.Name = "LArticulo2";
            LArticulo2.Size = new Size(187, 117);
            LArticulo2.TabIndex = 1;
            LArticulo2.Text = "Descripcion";
            // 
            // PArticulo2
            // 
            PArticulo2.BackColor = Color.Transparent;
            PArticulo2.Dock = DockStyle.Top;
            PArticulo2.Location = new Point(3, 31);
            PArticulo2.Margin = new Padding(3, 4, 3, 4);
            PArticulo2.Name = "PArticulo2";
            PArticulo2.Size = new Size(187, 240);
            PArticulo2.SizeMode = PictureBoxSizeMode.StretchImage;
            PArticulo2.TabIndex = 0;
            PArticulo2.TabStop = false;
            // 
            // GArticulo1
            // 
            GArticulo1.AutoSize = true;
            GArticulo1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GArticulo1.Controls.Add(LArticulo1);
            GArticulo1.Controls.Add(PArticulo1);
            GArticulo1.Dock = DockStyle.Fill;
            GArticulo1.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            GArticulo1.Location = new Point(136, 4);
            GArticulo1.Margin = new Padding(3, 4, 3, 4);
            GArticulo1.Name = "GArticulo1";
            GArticulo1.Padding = new Padding(3, 4, 3, 4);
            GArticulo1.Size = new Size(193, 392);
            GArticulo1.TabIndex = 20;
            GArticulo1.TabStop = false;
            GArticulo1.Text = "Nombre del Articulo";
            // 
            // LArticulo1
            // 
            LArticulo1.BackColor = Color.LightSteelBlue;
            LArticulo1.Dock = DockStyle.Fill;
            LArticulo1.Location = new Point(3, 271);
            LArticulo1.Name = "LArticulo1";
            LArticulo1.Size = new Size(187, 117);
            LArticulo1.TabIndex = 1;
            LArticulo1.Text = "Descripcion";
            // 
            // PArticulo1
            // 
            PArticulo1.BackColor = Color.Transparent;
            PArticulo1.Dock = DockStyle.Top;
            PArticulo1.Location = new Point(3, 31);
            PArticulo1.Margin = new Padding(3, 4, 3, 4);
            PArticulo1.Name = "PArticulo1";
            PArticulo1.Size = new Size(187, 240);
            PArticulo1.SizeMode = PictureBoxSizeMode.StretchImage;
            PArticulo1.TabIndex = 0;
            PArticulo1.TabStop = false;
            // 
            // Hora
            // 
            Hora.Tick += Hora_Tick;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = Punto_de_Venta.Properties.Resources.fondopresentacion;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(952, 637);
            ControlBox = false;
            Controls.Add(SUsuario);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            FormClosed += Menu_cerrado;
            GUsuario.ResumeLayout(false);
            GUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            SUsuario.Panel1.ResumeLayout(false);
            SUsuario.Panel1.PerformLayout();
            SUsuario.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SUsuario).EndInit();
            SUsuario.ResumeLayout(false);
            PArticulos.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            GArticulo10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PArticulo10).EndInit();
            GArticulo9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PArticulo9).EndInit();
            GArticulo8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PArticulo8).EndInit();
            GArticulo7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PArticulo7).EndInit();
            GArticulo6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PArticulo6).EndInit();
            GArticulo5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PArticulo5).EndInit();
            GArticulo4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PArticulo4).EndInit();
            GArticulo3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PArticulo3).EndInit();
            GArticulo2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PArticulo2).EndInit();
            GArticulo1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PArticulo1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GUsuario;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LEslogan;
        private Label LTiempo;
        private SplitContainer SUsuario;
        private Panel PArticulos;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox GArticulo1;
        private PictureBox PArticulo1;
        private Label LArticulo1;
        private Button BEstadistica;
        private Button BModificar;
        private Button BLog_Out;
        private GroupBox GArticulo2;
        private Label LArticulo2;
        private PictureBox PArticulo2;
        private GroupBox GArticulo10;
        private Label LArticulo10;
        private PictureBox PArticulo10;
        private GroupBox GArticulo9;
        private Label LArticulo9;
        private PictureBox PArticulo9;
        private GroupBox GArticulo8;
        private Label LArticulo8;
        private PictureBox PArticulo8;
        private GroupBox GArticulo7;
        private Label LArticulo7;
        private PictureBox PArticulo7;
        private GroupBox GArticulo6;
        private Label LArticulo6;
        private PictureBox PArticulo6;
        private GroupBox GArticulo5;
        private Label LArticulo5;
        private PictureBox PArticulo5;
        private GroupBox GArticulo4;
        private Label LArticulo4;
        private PictureBox PArticulo4;
        private GroupBox GArticulo3;
        private Label LArticulo3;
        private PictureBox PArticulo3;
        private System.Windows.Forms.Timer Hora;
        private Button BMusic_Stop;
        private Button BMusic_Play;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
    }
}