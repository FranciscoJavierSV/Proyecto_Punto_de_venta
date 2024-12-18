namespace Punto_de_Venta
{
    partial class FCompra
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
            CVista = new SplitContainer();
            DArticulos = new DataGridView();
            BCancelar = new Button();
            button1 = new Button();
            TPago = new TextBox();
            TTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CVista).BeginInit();
            CVista.Panel1.SuspendLayout();
            CVista.Panel2.SuspendLayout();
            CVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DArticulos).BeginInit();
            SuspendLayout();
            // 
            // CVista
            // 
            CVista.Dock = DockStyle.Fill;
            CVista.Location = new Point(0, 0);
            CVista.Name = "CVista";
            // 
            // CVista.Panel1
            // 
            CVista.Panel1.Controls.Add(DArticulos);
            // 
            // CVista.Panel2
            // 
            CVista.Panel2.BackColor = Color.Thistle;
            CVista.Panel2.Controls.Add(BCancelar);
            CVista.Panel2.Controls.Add(button1);
            CVista.Panel2.Controls.Add(TPago);
            CVista.Panel2.Controls.Add(TTotal);
            CVista.Size = new Size(561, 359);
            CVista.SplitterDistance = 362;
            CVista.TabIndex = 0;
            // 
            // DArticulos
            // 
            DArticulos.BackgroundColor = Color.Thistle;
            DArticulos.BorderStyle = BorderStyle.Fixed3D;
            DArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DArticulos.Dock = DockStyle.Fill;
            DArticulos.Location = new Point(0, 0);
            DArticulos.Name = "DArticulos";
            DArticulos.RowHeadersWidth = 51;
            DArticulos.Size = new Size(362, 359);
            DArticulos.TabIndex = 0;
            // 
            // BCancelar
            // 
            BCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BCancelar.BackColor = Color.Firebrick;
            BCancelar.FlatStyle = FlatStyle.Popup;
            BCancelar.Font = new Font("Segoe UI", 15F);
            BCancelar.Location = new Point(21, 280);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(151, 49);
            BCancelar.TabIndex = 4;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(255, 251, 77);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(21, 209);
            button1.Name = "button1";
            button1.Size = new Size(151, 49);
            button1.TabIndex = 2;
            button1.Text = "Pagar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BPagar_Click;
            // 
            // TPago
            // 
            TPago.BackColor = SystemColors.ScrollBar;
            TPago.Dock = DockStyle.Top;
            TPago.Font = new Font("Segoe UI", 15F);
            TPago.Location = new Point(0, 34);
            TPago.Name = "TPago";
            TPago.PlaceholderText = "Pago: ";
            TPago.Size = new Size(195, 34);
            TPago.TabIndex = 1;
            // 
            // TTotal
            // 
            TTotal.BackColor = SystemColors.ScrollBar;
            TTotal.Dock = DockStyle.Top;
            TTotal.Font = new Font("Segoe UI", 15F);
            TTotal.Location = new Point(0, 0);
            TTotal.Name = "TTotal";
            TTotal.PlaceholderText = "Total: ";
            TTotal.ReadOnly = true;
            TTotal.Size = new Size(195, 34);
            TTotal.TabIndex = 0;
            // 
            // FCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 156, 192);
            ClientSize = new Size(561, 359);
            ControlBox = false;
            Controls.Add(CVista);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FCompra";
            CVista.Panel1.ResumeLayout(false);
            CVista.Panel2.ResumeLayout(false);
            CVista.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CVista).EndInit();
            CVista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DArticulos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer CVista;
        private DataGridView DArticulos;
        private TextBox TTotal;
        private TextBox TPago;
        private Button button1;
        private Button BCancelar;
    }
}