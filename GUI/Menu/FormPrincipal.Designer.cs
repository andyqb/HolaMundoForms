namespace Holamundoforms
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_operacion = new System.Windows.Forms.ComboBox();
            this.NUD_numero1 = new System.Windows.Forms.NumericUpDown();
            this.NUD_numero2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_sumar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_numero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_numero2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnsalir.Location = new System.Drawing.Point(433, 14);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(40, 33);
            this.btnsalir.TabIndex = 23;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CB_operacion);
            this.groupBox2.Controls.Add(this.btnsalir);
            this.groupBox2.Controls.Add(this.NUD_numero1);
            this.groupBox2.Controls.Add(this.NUD_numero2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 166);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese los datos de la sumadora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(19, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operación:";
            // 
            // CB_operacion
            // 
            this.CB_operacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_operacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_operacion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CB_operacion.FormattingEnabled = true;
            this.CB_operacion.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Divide #1/#2"});
            this.CB_operacion.Location = new System.Drawing.Point(143, 114);
            this.CB_operacion.Name = "CB_operacion";
            this.CB_operacion.Size = new System.Drawing.Size(121, 29);
            this.CB_operacion.TabIndex = 6;
            // 
            // NUD_numero1
            // 
            this.NUD_numero1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NUD_numero1.DecimalPlaces = 2;
            this.NUD_numero1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_numero1.Location = new System.Drawing.Point(144, 78);
            this.NUD_numero1.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NUD_numero1.Name = "NUD_numero1";
            this.NUD_numero1.Size = new System.Drawing.Size(120, 24);
            this.NUD_numero1.TabIndex = 5;
            // 
            // NUD_numero2
            // 
            this.NUD_numero2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NUD_numero2.DecimalPlaces = 2;
            this.NUD_numero2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_numero2.Location = new System.Drawing.Point(144, 37);
            this.NUD_numero2.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NUD_numero2.Name = "NUD_numero2";
            this.NUD_numero2.Size = new System.Drawing.Size(120, 24);
            this.NUD_numero2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Numero #2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numero #1:";
            // 
            // BTN_sumar
            // 
            this.BTN_sumar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_sumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_sumar.FlatAppearance.BorderSize = 2;
            this.BTN_sumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_sumar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_sumar.ForeColor = System.Drawing.Color.Black;
            this.BTN_sumar.Location = new System.Drawing.Point(155, 198);
            this.BTN_sumar.Name = "BTN_sumar";
            this.BTN_sumar.Size = new System.Drawing.Size(97, 33);
            this.BTN_sumar.TabIndex = 25;
            this.BTN_sumar.Text = "Enter";
            this.BTN_sumar.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(509, 270);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTN_sumar);
            this.ForeColor = System.Drawing.Color.Orange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_numero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_numero2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_operacion;
        private System.Windows.Forms.NumericUpDown NUD_numero1;
        private System.Windows.Forms.NumericUpDown NUD_numero2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_sumar;
    }
}

