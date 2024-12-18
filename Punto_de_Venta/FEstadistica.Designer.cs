namespace Punto_de_Venta
{
    partial class FEstadistica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            PSeparador = new SplitContainer();
            ChartDatos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            PTotal = new Panel();
            LTotal = new Label();
            TDatos = new DataGridView();
            Tpanel = new TableLayoutPanel();
            RDiario = new RadioButton();
            RMensual = new RadioButton();
            BBuscar = new Button();
            TFecha = new TextBox();
            RTotal = new RadioButton();
            BConfirmar = new Button();
            BSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)PSeparador).BeginInit();
            PSeparador.Panel1.SuspendLayout();
            PSeparador.Panel2.SuspendLayout();
            PSeparador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChartDatos).BeginInit();
            PTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TDatos).BeginInit();
            Tpanel.SuspendLayout();
            SuspendLayout();
            // 
            // PSeparador
            // 
            PSeparador.Dock = DockStyle.Fill;
            PSeparador.Location = new Point(0, 0);
            PSeparador.Name = "PSeparador";
            // 
            // PSeparador.Panel1
            // 
            PSeparador.Panel1.BackColor = Color.Transparent;
            PSeparador.Panel1.Controls.Add(ChartDatos);
            PSeparador.Panel1.Controls.Add(PTotal);
            PSeparador.Panel1.Controls.Add(TDatos);
            // 
            // PSeparador.Panel2
            // 
            PSeparador.Panel2.BackColor = Color.Transparent;
            PSeparador.Panel2.Controls.Add(Tpanel);
            PSeparador.Size = new Size(674, 399);
            PSeparador.SplitterDistance = 473;
            PSeparador.TabIndex = 1;
            // 
            // ChartDatos
            // 
            ChartDatos.BackColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            ChartDatos.ChartAreas.Add(chartArea2);
            ChartDatos.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            ChartDatos.Legends.Add(legend2);
            ChartDatos.Location = new Point(0, 0);
            ChartDatos.Name = "ChartDatos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            ChartDatos.Series.Add(series2);
            ChartDatos.Size = new Size(473, 351);
            ChartDatos.TabIndex = 2;
            ChartDatos.Text = "chart1";
            // 
            // PTotal
            // 
            PTotal.Controls.Add(LTotal);
            PTotal.Dock = DockStyle.Bottom;
            PTotal.Location = new Point(0, 351);
            PTotal.Name = "PTotal";
            PTotal.Size = new Size(473, 48);
            PTotal.TabIndex = 1;
            // 
            // LTotal
            // 
            LTotal.Dock = DockStyle.Fill;
            LTotal.Font = new Font("Segoe UI", 23F);
            LTotal.Location = new Point(0, 0);
            LTotal.Name = "LTotal";
            LTotal.Size = new Size(473, 48);
            LTotal.TabIndex = 1;
            // 
            // TDatos
            // 
            TDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TDatos.Dock = DockStyle.Fill;
            TDatos.Location = new Point(0, 0);
            TDatos.Name = "TDatos";
            TDatos.Size = new Size(473, 399);
            TDatos.TabIndex = 3;
            // 
            // Tpanel
            // 
            Tpanel.ColumnCount = 1;
            Tpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tpanel.Controls.Add(RDiario, 0, 0);
            Tpanel.Controls.Add(BSalir, 0, 6);
            Tpanel.Controls.Add(RMensual, 0, 3);
            Tpanel.Controls.Add(TFecha, 0, 1);
            Tpanel.Controls.Add(RTotal, 0, 4);
            Tpanel.Controls.Add(BConfirmar, 0, 5);
            Tpanel.Controls.Add(BBuscar, 0, 2);
            Tpanel.Dock = DockStyle.Fill;
            Tpanel.Font = new Font("Segoe UI", 18F);
            Tpanel.Location = new Point(0, 0);
            Tpanel.Name = "Tpanel";
            Tpanel.RowCount = 7;
            Tpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            Tpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            Tpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            Tpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            Tpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            Tpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            Tpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            Tpanel.Size = new Size(197, 399);
            Tpanel.TabIndex = 3;
            // 
            // RDiario
            // 
            RDiario.AutoSize = true;
            RDiario.Dock = DockStyle.Fill;
            RDiario.Location = new Point(3, 3);
            RDiario.Name = "RDiario";
            RDiario.Size = new Size(191, 51);
            RDiario.TabIndex = 2;
            RDiario.TabStop = true;
            RDiario.Text = "Diario";
            RDiario.TextAlign = ContentAlignment.MiddleCenter;
            RDiario.UseVisualStyleBackColor = true;
            // 
            // RMensual
            // 
            RMensual.AutoSize = true;
            RMensual.Dock = DockStyle.Fill;
            RMensual.Location = new Point(3, 174);
            RMensual.Name = "RMensual";
            RMensual.Size = new Size(191, 51);
            RMensual.TabIndex = 1;
            RMensual.TabStop = true;
            RMensual.Text = "Mensual";
            RMensual.TextAlign = ContentAlignment.MiddleCenter;
            RMensual.UseVisualStyleBackColor = true;
            // 
            // BBuscar
            // 
            BBuscar.AutoSize = true;
            BBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BBuscar.Dock = DockStyle.Fill;
            BBuscar.Font = new Font("Segoe UI", 25F);
            BBuscar.Location = new Point(3, 117);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(191, 51);
            BBuscar.TabIndex = 5;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // TFecha
            // 
            TFecha.BackColor = SystemColors.ScrollBar;
            TFecha.Location = new Point(3, 60);
            TFecha.Name = "TFecha";
            TFecha.PlaceholderText = "Fecha/Usuario";
            TFecha.Size = new Size(191, 39);
            TFecha.TabIndex = 6;
            // 
            // RTotal
            // 
            RTotal.AutoSize = true;
            RTotal.Dock = DockStyle.Fill;
            RTotal.Location = new Point(3, 231);
            RTotal.Name = "RTotal";
            RTotal.Size = new Size(191, 51);
            RTotal.TabIndex = 7;
            RTotal.TabStop = true;
            RTotal.Text = "Total";
            RTotal.TextAlign = ContentAlignment.MiddleCenter;
            RTotal.UseVisualStyleBackColor = true;
            // 
            // BConfirmar
            // 
            BConfirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BConfirmar.Dock = DockStyle.Fill;
            BConfirmar.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BConfirmar.Location = new Point(3, 288);
            BConfirmar.Name = "BConfirmar";
            BConfirmar.Size = new Size(191, 51);
            BConfirmar.TabIndex = 3;
            BConfirmar.Text = "Confirmar";
            BConfirmar.UseVisualStyleBackColor = true;
            BConfirmar.Click += BConfirmar_Click;
            // 
            // BSalir
            // 
            BSalir.AutoSize = true;
            BSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BSalir.Dock = DockStyle.Fill;
            BSalir.Font = new Font("Segoe UI", 25F);
            BSalir.Location = new Point(3, 345);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(191, 51);
            BSalir.TabIndex = 0;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // FEstadistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(674, 399);
            ControlBox = false;
            Controls.Add(PSeparador);
            Name = "FEstadistica";
            Text = "Estadistica";
            WindowState = FormWindowState.Maximized;
            PSeparador.Panel1.ResumeLayout(false);
            PSeparador.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PSeparador).EndInit();
            PSeparador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ChartDatos).EndInit();
            PTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TDatos).EndInit();
            Tpanel.ResumeLayout(false);
            Tpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer PSeparador;
        private RadioButton RDiario;
        private RadioButton RMensual;
        private TableLayoutPanel Tpanel;
        private Button BBuscar;
        private Button BConfirmar;
        private TextBox TFecha;
        private RadioButton RTotal;
        private Button BSalir;
        private Panel PTotal;
        private Label LTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDatos;
        private DataGridView TDatos;
    }
}