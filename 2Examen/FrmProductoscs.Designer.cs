namespace _2Examen
{
    partial class FrmProductoscs
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.ExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Existencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // ProductosDataGridView
            // 
            this.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDataGridView.Location = new System.Drawing.Point(2, 299);
            this.ProductosDataGridView.Name = "ProductosDataGridView";
            this.ProductosDataGridView.RowTemplate.Height = 25;
            this.ProductosDataGridView.Size = new System.Drawing.Size(799, 150);
            this.ProductosDataGridView.TabIndex = 4;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(204, 32);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(167, 23);
            this.CodigoTextBox.TabIndex = 5;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(204, 119);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(167, 23);
            this.PrecioTextBox.TabIndex = 6;
            // 
            // ExistenciaTextBox
            // 
            this.ExistenciaTextBox.Location = new System.Drawing.Point(204, 160);
            this.ExistenciaTextBox.Name = "ExistenciaTextBox";
            this.ExistenciaTextBox.Size = new System.Drawing.Size(167, 23);
            this.ExistenciaTextBox.TabIndex = 7;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(204, 74);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(167, 23);
            this.DescripcionTextBox.TabIndex = 8;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(170, 211);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 9;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(272, 211);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 10;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(383, 211);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 11;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProductoscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.ExistenciaTextBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.ProductosDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProductoscs";
            this.Text = "FrmProductoscs";
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView ProductosDataGridView;
        private TextBox CodigoTextBox;
        private TextBox PrecioTextBox;
        private TextBox ExistenciaTextBox;
        private TextBox DescripcionTextBox;
        private Button NuevoButton;
        private Button Guardar;
        private Button CancelarButton;
        private ErrorProvider errorProvider1;
    }
}