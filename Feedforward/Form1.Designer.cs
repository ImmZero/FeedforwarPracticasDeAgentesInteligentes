namespace Feedforward
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.Feedforward = new System.Windows.Forms.Button();
            this.lbs1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbxor = new System.Windows.Forms.RadioButton();
            this.rbejercicio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(61, 347);
            this.Tabla.Name = "Tabla";
            this.Tabla.RowHeadersWidth = 51;
            this.Tabla.RowTemplate.Height = 24;
            this.Tabla.Size = new System.Drawing.Size(724, 207);
            this.Tabla.TabIndex = 8;
            // 
            // Feedforward
            // 
            this.Feedforward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Feedforward.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedforward.Location = new System.Drawing.Point(337, 96);
            this.Feedforward.Name = "Feedforward";
            this.Feedforward.Size = new System.Drawing.Size(172, 63);
            this.Feedforward.TabIndex = 9;
            this.Feedforward.Text = "Feedforward";
            this.Feedforward.UseVisualStyleBackColor = false;
            this.Feedforward.Click += new System.EventHandler(this.Feedforward_Click);
            // 
            // lbs1
            // 
            this.lbs1.FormattingEnabled = true;
            this.lbs1.ItemHeight = 16;
            this.lbs1.Location = new System.Drawing.Point(865, 14);
            this.lbs1.Name = "lbs1";
            this.lbs1.Size = new System.Drawing.Size(311, 564);
            this.lbs1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESULTADOS";
            // 
            // rbxor
            // 
            this.rbxor.AutoSize = true;
            this.rbxor.Location = new System.Drawing.Point(48, 111);
            this.rbxor.Name = "rbxor";
            this.rbxor.Size = new System.Drawing.Size(56, 20);
            this.rbxor.TabIndex = 11;
            this.rbxor.TabStop = true;
            this.rbxor.Text = "XOR";
            this.rbxor.UseVisualStyleBackColor = true;
            // 
            // rbejercicio
            // 
            this.rbejercicio.AutoSize = true;
            this.rbejercicio.Location = new System.Drawing.Point(171, 111);
            this.rbejercicio.Name = "rbejercicio";
            this.rbejercicio.Size = new System.Drawing.Size(97, 20);
            this.rbejercicio.TabIndex = 12;
            this.rbejercicio.TabStop = true;
            this.rbejercicio.Text = "EJERCICIO";
            this.rbejercicio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 593);
            this.Controls.Add(this.rbejercicio);
            this.Controls.Add(this.rbxor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbs1);
            this.Controls.Add(this.Feedforward);
            this.Controls.Add(this.Tabla);
            this.Name = "Form1";
            this.Text = "RESULTADOS";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Button Feedforward;
        private System.Windows.Forms.ListBox lbs1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbxor;
        private System.Windows.Forms.RadioButton rbejercicio;
    }
}

