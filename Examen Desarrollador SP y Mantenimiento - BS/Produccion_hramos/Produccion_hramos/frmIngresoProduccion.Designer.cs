namespace Produccion_hramos
{
    partial class frmIngresoProduccion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SeccionTb = new System.Windows.Forms.TextBox();
            this.EstiloTb = new System.Windows.Forms.TextBox();
            this.TallaTb = new System.Windows.Forms.TextBox();
            this.ColorTb = new System.Windows.Forms.TextBox();
            this.CantidadTb = new System.Windows.Forms.TextBox();
            this.FechaDTP = new System.Windows.Forms.DateTimePicker();
            this.ProduccionDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProduccionDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estilo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(268, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Talla:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(480, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(575, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha:";
            // 
            // SeccionTb
            // 
            this.SeccionTb.Location = new System.Drawing.Point(44, 44);
            this.SeccionTb.Name = "SeccionTb";
            this.SeccionTb.Size = new System.Drawing.Size(152, 23);
            this.SeccionTb.TabIndex = 6;
            // 
            // EstiloTb
            // 
            this.EstiloTb.Location = new System.Drawing.Point(44, 118);
            this.EstiloTb.Name = "EstiloTb";
            this.EstiloTb.Size = new System.Drawing.Size(152, 23);
            this.EstiloTb.TabIndex = 7;
            // 
            // TallaTb
            // 
            this.TallaTb.Location = new System.Drawing.Point(268, 118);
            this.TallaTb.Name = "TallaTb";
            this.TallaTb.Size = new System.Drawing.Size(152, 23);
            this.TallaTb.TabIndex = 8;
            // 
            // ColorTb
            // 
            this.ColorTb.Location = new System.Drawing.Point(480, 118);
            this.ColorTb.Name = "ColorTb";
            this.ColorTb.Size = new System.Drawing.Size(152, 23);
            this.ColorTb.TabIndex = 9;
            // 
            // CantidadTb
            // 
            this.CantidadTb.Location = new System.Drawing.Point(44, 192);
            this.CantidadTb.Name = "CantidadTb";
            this.CantidadTb.Size = new System.Drawing.Size(152, 23);
            this.CantidadTb.TabIndex = 10;
            // 
            // FechaDTP
            // 
            this.FechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDTP.Location = new System.Drawing.Point(575, 44);
            this.FechaDTP.Name = "FechaDTP";
            this.FechaDTP.Size = new System.Drawing.Size(133, 23);
            this.FechaDTP.TabIndex = 11;
            // 
            // ProduccionDGV
            // 
            this.ProduccionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProduccionDGV.Location = new System.Drawing.Point(44, 243);
            this.ProduccionDGV.Name = "ProduccionDGV";
            this.ProduccionDGV.RowTemplate.Height = 25;
            this.ProduccionDGV.Size = new System.Drawing.Size(664, 220);
            this.ProduccionDGV.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(284, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(429, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(574, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmIngresoProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 475);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProduccionDGV);
            this.Controls.Add(this.FechaDTP);
            this.Controls.Add(this.CantidadTb);
            this.Controls.Add(this.ColorTb);
            this.Controls.Add(this.TallaTb);
            this.Controls.Add(this.EstiloTb);
            this.Controls.Add(this.SeccionTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIngresoProduccion";
            this.Text = "frmIngresoProduccion";
            ((System.ComponentModel.ISupportInitialize)(this.ProduccionDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox SeccionTb;
        private TextBox EstiloTb;
        private TextBox TallaTb;
        private TextBox ColorTb;
        private TextBox CantidadTb;
        private DateTimePicker FechaDTP;
        private DataGridView ProduccionDGV;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}