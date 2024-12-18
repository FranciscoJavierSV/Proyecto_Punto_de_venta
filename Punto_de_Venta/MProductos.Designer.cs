namespace BaseDatos
{
    partial class MProductos
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
            Menu = new Label();
            BAgregar = new Button();
            BEliminar = new Button();
            BModificar = new Button();
            splitContainer1 = new SplitContainer();
            panel5 = new Panel();
            BVerRegistro = new Button();
            panel1 = new Panel();
            BBuscar = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            BSalir = new Button();
            panelseparacion = new Panel();
            GTabla = new Panel();
            TablaDatos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Existencias = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewTextBoxColumn();
            GControl = new Panel();
            PControl3 = new Panel();
            TDescripcion = new TextBox();
            PControl4 = new Panel();
            BConfirmar = new Button();
            TId = new TextBox();
            PControl2 = new Panel();
            TImagen = new TextBox();
            BImagen = new Button();
            PControl1 = new Panel();
            TExistencias = new TextBox();
            TPrecio = new TextBox();
            TNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            GTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaDatos).BeginInit();
            GControl.SuspendLayout();
            PControl3.SuspendLayout();
            PControl4.SuspendLayout();
            PControl2.SuspendLayout();
            PControl1.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = Color.Transparent;
            Menu.Font = new Font("Segoe UI", 25F);
            Menu.ForeColor = SystemColors.ButtonFace;
            Menu.Location = new Point(0, 100);
            Menu.Name = "Menu";
            Menu.Size = new Size(175, 63);
            Menu.TabIndex = 0;
            Menu.Text = "Menu";
            Menu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BAgregar
            // 
            BAgregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BAgregar.BackColor = Color.Plum;
            BAgregar.Dock = DockStyle.Top;
            BAgregar.Font = new Font("Segoe UI", 15F);
            BAgregar.ForeColor = SystemColors.ButtonFace;
            BAgregar.Location = new Point(0, 280);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(175, 58);
            BAgregar.TabIndex = 1;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // BEliminar
            // 
            BEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BEliminar.BackColor = Color.Plum;
            BEliminar.Dock = DockStyle.Top;
            BEliminar.Font = new Font("Segoe UI", 15F);
            BEliminar.ForeColor = SystemColors.ButtonFace;
            BEliminar.Location = new Point(0, 364);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(175, 58);
            BEliminar.TabIndex = 2;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = false;
            BEliminar.Click += BEliminar_Click;
            // 
            // BModificar
            // 
            BModificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BModificar.BackColor = Color.Plum;
            BModificar.Dock = DockStyle.Top;
            BModificar.Font = new Font("Segoe UI", 15F);
            BModificar.ForeColor = SystemColors.ButtonFace;
            BModificar.Location = new Point(0, 448);
            BModificar.Name = "BModificar";
            BModificar.Size = new Size(175, 58);
            BModificar.TabIndex = 3;
            BModificar.Text = "Modificar";
            BModificar.UseVisualStyleBackColor = false;
            BModificar.Click += BModificar_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Transparent;
            splitContainer1.Panel1.Controls.Add(panel5);
            splitContainer1.Panel1.Controls.Add(BVerRegistro);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(BBuscar);
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(BModificar);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(BEliminar);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(BAgregar);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(BSalir);
            splitContainer1.Panel1.Controls.Add(panelseparacion);
            splitContainer1.Panel1.Controls.Add(Menu);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(GTabla);
            splitContainer1.Panel2.Controls.Add(GControl);
            splitContainer1.Size = new Size(890, 599);
            splitContainer1.SplitterDistance = 175;
            splitContainer1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 674);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(175, 26);
            panel5.TabIndex = 12;
            // 
            // BVerRegistro
            // 
            BVerRegistro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BVerRegistro.BackColor = Color.Plum;
            BVerRegistro.Dock = DockStyle.Top;
            BVerRegistro.Font = new Font("Segoe UI", 15F);
            BVerRegistro.ForeColor = SystemColors.ButtonFace;
            BVerRegistro.Location = new Point(0, 616);
            BVerRegistro.Name = "BVerRegistro";
            BVerRegistro.Size = new Size(175, 58);
            BVerRegistro.TabIndex = 5;
            BVerRegistro.Text = "Ver Registros";
            BVerRegistro.UseVisualStyleBackColor = false;
            BVerRegistro.Click += BVerRegistro_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 590);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 26);
            panel1.TabIndex = 11;
            // 
            // BBuscar
            // 
            BBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BBuscar.BackColor = Color.Plum;
            BBuscar.Dock = DockStyle.Top;
            BBuscar.Font = new Font("Segoe UI", 15F);
            BBuscar.ForeColor = SystemColors.ButtonFace;
            BBuscar.Location = new Point(0, 532);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(175, 58);
            BBuscar.TabIndex = 4;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = false;
            BBuscar.Click += BBuscar_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 506);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(175, 26);
            panel4.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 422);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 26);
            panel3.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 338);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 26);
            panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Punto_de_Venta.Properties.Resources.Fragannislogo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // BSalir
            // 
            BSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BSalir.BackColor = Color.MediumOrchid;
            BSalir.Dock = DockStyle.Bottom;
            BSalir.Font = new Font("Segoe UI", 15F);
            BSalir.ForeColor = SystemColors.ButtonFace;
            BSalir.Location = new Point(0, 541);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(175, 58);
            BSalir.TabIndex = 6;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = false;
            BSalir.Click += B_Salir;
            // 
            // panelseparacion
            // 
            panelseparacion.Location = new Point(0, 163);
            panelseparacion.Margin = new Padding(2);
            panelseparacion.Name = "panelseparacion";
            panelseparacion.Size = new Size(175, 26);
            panelseparacion.TabIndex = 7;
            // 
            // GTabla
            // 
            GTabla.AutoScroll = true;
            GTabla.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GTabla.Controls.Add(TablaDatos);
            GTabla.Dock = DockStyle.Fill;
            GTabla.Location = new Point(0, 224);
            GTabla.Name = "GTabla";
            GTabla.Padding = new Padding(0, 10, 0, 0);
            GTabla.Size = new Size(711, 375);
            GTabla.TabIndex = 0;
            // 
            // TablaDatos
            // 
            TablaDatos.AllowUserToAddRows = false;
            TablaDatos.AllowUserToDeleteRows = false;
            TablaDatos.AllowUserToResizeColumns = false;
            TablaDatos.AllowUserToResizeRows = false;
            TablaDatos.BackgroundColor = Color.Orchid;
            TablaDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaDatos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Precio, Existencias, Descripcion, Imagen });
            TablaDatos.Dock = DockStyle.Top;
            TablaDatos.EditMode = DataGridViewEditMode.EditProgrammatically;
            TablaDatos.GridColor = Color.DarkMagenta;
            TablaDatos.Location = new Point(0, 10);
            TablaDatos.Name = "TablaDatos";
            TablaDatos.ReadOnly = true;
            TablaDatos.RowHeadersWidth = 51;
            TablaDatos.Size = new Size(694, 400);
            TablaDatos.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // Existencias
            // 
            Existencias.HeaderText = "Existencias";
            Existencias.MinimumWidth = 6;
            Existencias.Name = "Existencias";
            Existencias.ReadOnly = true;
            Existencias.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Imagen
            // 
            Imagen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Imagen.HeaderText = "Imagen";
            Imagen.MinimumWidth = 6;
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            // 
            // GControl
            // 
            GControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GControl.Controls.Add(PControl3);
            GControl.Controls.Add(PControl2);
            GControl.Controls.Add(PControl1);
            GControl.Dock = DockStyle.Top;
            GControl.Location = new Point(0, 0);
            GControl.Name = "GControl";
            GControl.Size = new Size(711, 224);
            GControl.TabIndex = 1;
            // 
            // PControl3
            // 
            PControl3.Controls.Add(TDescripcion);
            PControl3.Controls.Add(PControl4);
            PControl3.Dock = DockStyle.Fill;
            PControl3.Location = new Point(0, 94);
            PControl3.Name = "PControl3";
            PControl3.Size = new Size(711, 130);
            PControl3.TabIndex = 4;
            // 
            // TDescripcion
            // 
            TDescripcion.BackColor = Color.Thistle;
            TDescripcion.Dock = DockStyle.Fill;
            TDescripcion.Font = new Font("Segoe UI", 11F);
            TDescripcion.ForeColor = SystemColors.Info;
            TDescripcion.Location = new Point(151, 0);
            TDescripcion.Multiline = true;
            TDescripcion.Name = "TDescripcion";
            TDescripcion.PlaceholderText = "Descripcion";
            TDescripcion.Size = new Size(560, 130);
            TDescripcion.TabIndex = 1;
            // 
            // PControl4
            // 
            PControl4.Controls.Add(BConfirmar);
            PControl4.Controls.Add(TId);
            PControl4.Dock = DockStyle.Left;
            PControl4.Location = new Point(0, 0);
            PControl4.Name = "PControl4";
            PControl4.Size = new Size(151, 130);
            PControl4.TabIndex = 0;
            // 
            // BConfirmar
            // 
            BConfirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BConfirmar.BackColor = Color.Plum;
            BConfirmar.Dock = DockStyle.Bottom;
            BConfirmar.Font = new Font("Segoe UI", 15F);
            BConfirmar.ForeColor = SystemColors.ButtonFace;
            BConfirmar.Location = new Point(0, 74);
            BConfirmar.Name = "BConfirmar";
            BConfirmar.Size = new Size(151, 56);
            BConfirmar.TabIndex = 5;
            BConfirmar.Text = "Confirmar";
            BConfirmar.UseVisualStyleBackColor = false;
            BConfirmar.Click += BConfirmar_Click;
            // 
            // TId
            // 
            TId.BackColor = Color.Thistle;
            TId.Dock = DockStyle.Top;
            TId.Font = new Font("Segoe UI", 15F);
            TId.ForeColor = SystemColors.Menu;
            TId.Location = new Point(0, 0);
            TId.Name = "TId";
            TId.PlaceholderText = "ID";
            TId.Size = new Size(151, 34);
            TId.TabIndex = 4;
            // 
            // PControl2
            // 
            PControl2.Controls.Add(TImagen);
            PControl2.Controls.Add(BImagen);
            PControl2.Dock = DockStyle.Top;
            PControl2.Location = new Point(0, 51);
            PControl2.Name = "PControl2";
            PControl2.Size = new Size(711, 43);
            PControl2.TabIndex = 3;
            // 
            // TImagen
            // 
            TImagen.BackColor = Color.Thistle;
            TImagen.Dock = DockStyle.Fill;
            TImagen.Font = new Font("Segoe UI", 18F);
            TImagen.ForeColor = SystemColors.Info;
            TImagen.Location = new Point(0, 0);
            TImagen.Name = "TImagen";
            TImagen.PlaceholderText = "Imagen";
            TImagen.Size = new Size(550, 39);
            TImagen.TabIndex = 2;
            // 
            // BImagen
            // 
            BImagen.BackColor = Color.MediumPurple;
            BImagen.Dock = DockStyle.Right;
            BImagen.Font = new Font("Segoe UI", 15F);
            BImagen.Location = new Point(550, 0);
            BImagen.Name = "BImagen";
            BImagen.Size = new Size(161, 43);
            BImagen.TabIndex = 3;
            BImagen.Text = "Cargar";
            BImagen.UseVisualStyleBackColor = false;
            BImagen.Click += BImagen_Click;
            // 
            // PControl1
            // 
            PControl1.Controls.Add(TExistencias);
            PControl1.Controls.Add(TPrecio);
            PControl1.Controls.Add(TNombre);
            PControl1.Dock = DockStyle.Top;
            PControl1.Location = new Point(0, 0);
            PControl1.Name = "PControl1";
            PControl1.Padding = new Padding(0, 10, 0, 0);
            PControl1.Size = new Size(711, 51);
            PControl1.TabIndex = 2;
            // 
            // TExistencias
            // 
            TExistencias.BackColor = Color.Thistle;
            TExistencias.Dock = DockStyle.Right;
            TExistencias.Font = new Font("Segoe UI", 15F);
            TExistencias.ForeColor = SystemColors.Info;
            TExistencias.Location = new Point(421, 10);
            TExistencias.Name = "TExistencias";
            TExistencias.PlaceholderText = "Existencias";
            TExistencias.Size = new Size(145, 34);
            TExistencias.TabIndex = 4;
            // 
            // TPrecio
            // 
            TPrecio.BackColor = Color.Thistle;
            TPrecio.Dock = DockStyle.Right;
            TPrecio.Font = new Font("Segoe UI", 15F);
            TPrecio.ForeColor = SystemColors.Info;
            TPrecio.Location = new Point(566, 10);
            TPrecio.Name = "TPrecio";
            TPrecio.PlaceholderText = "Precio";
            TPrecio.Size = new Size(145, 34);
            TPrecio.TabIndex = 2;
            // 
            // TNombre
            // 
            TNombre.BackColor = Color.Thistle;
            TNombre.Dock = DockStyle.Fill;
            TNombre.Font = new Font("Segoe UI", 15F);
            TNombre.ForeColor = SystemColors.Info;
            TNombre.Location = new Point(0, 10);
            TNombre.Name = "TNombre";
            TNombre.PlaceholderText = "Nombre";
            TNombre.Size = new Size(711, 34);
            TNombre.TabIndex = 1;
            // 
            // MProductos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(107, 92, 148);
            ClientSize = new Size(890, 599);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Name = "MProductos";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "MArticulos";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            GTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablaDatos).EndInit();
            GControl.ResumeLayout(false);
            PControl3.ResumeLayout(false);
            PControl3.PerformLayout();
            PControl4.ResumeLayout(false);
            PControl4.PerformLayout();
            PControl2.ResumeLayout(false);
            PControl2.PerformLayout();
            PControl1.ResumeLayout(false);
            PControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Menu;
        private Button BAgregar;
        private Button BEliminar;
        private Button BModificar;
        private SplitContainer splitContainer1;
        private Panel GTabla;
        private TextBox TExistencias;
        private TextBox TNombre;
        private TextBox TPrecio;
        private Panel GControl;
        private DataGridView TablaDatos;
        private Button BSalir;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Existencias;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Imagen;
        private Panel PControl1;
        private Panel PControl2;
        private Button BImagen;
        private TextBox TImagen;
        private Panel PControl3;
        private TextBox TDescripcion;
        private Panel PControl4;
        private Button BConfirmar;
        private TextBox TId;
        private Panel panelseparacion;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Button BVerRegistro;
        private Panel panel1;
        private Button BBuscar;
        private Panel panel5;
        private PictureBox pictureBox1;
    }
}