namespace _2Examen
{
    partial class FrmPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pedido = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Pedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ";
            // 
            // Pedido
            // 
            this.Pedido.Controls.Add(this.label3);
            this.Pedido.Controls.Add(this.Descripcion);
            this.Pedido.Controls.Add(this.label2);
            this.Pedido.Controls.Add(this.textBox3);
            this.Pedido.Controls.Add(this.DescripcionTextBox);
            this.Pedido.Controls.Add(this.CodigoTextBox);
            this.Pedido.Location = new System.Drawing.Point(137, 79);
            this.Pedido.Name = "Pedido";
            this.Pedido.Size = new System.Drawing.Size(498, 119);
            this.Pedido.TabIndex = 1;
            this.Pedido.TabStop = false;
            this.Pedido.Text = "Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(260, 47);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(69, 15);
            this.Descripcion.TabIndex = 4;
            this.Descripcion.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 2;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(344, 44);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(100, 23);
            this.DescripcionTextBox.TabIndex = 1;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(76, 22);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(100, 23);
            this.CodigoTextBox.TabIndex = 0;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(197, 34);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(346, 23);
            this.NombreTextBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.Pedido);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            this.Pedido.ResumeLayout(false);
            this.Pedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox Pedido;
        private TextBox NombreTextBox;
        private Label label3;
        private Label Descripcion;
        private Label label2;
        private TextBox textBox3;
        private TextBox DescripcionTextBox;
        private TextBox CodigoTextBox;
        private DataGridView dataGridView1;
        private Button button1;
    }
}