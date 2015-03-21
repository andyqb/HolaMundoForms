namespace HolaMundoForms.Catalogos
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txt_Nombre_completo = new System.Windows.Forms.TextBox();
            this.txt_Cod_producto = new System.Windows.Forms.TextBox();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.nud_Precio = new System.Windows.Forms.NumericUpDown();
            this.nud_Costo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NuevoUsusario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Registrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Costo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 330);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 80);
            this.panel1.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(17, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 65);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnsalir.Location = new System.Drawing.Point(617, 7);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(65, 65);
            this.btnsalir.TabIndex = 26;
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // txt_Nombre_completo
            // 
            this.txt_Nombre_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre_completo.Location = new System.Drawing.Point(248, 129);
            this.txt_Nombre_completo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nombre_completo.Name = "txt_Nombre_completo";
            this.txt_Nombre_completo.Size = new System.Drawing.Size(434, 32);
            this.txt_Nombre_completo.TabIndex = 34;
            // 
            // txt_Cod_producto
            // 
            this.txt_Cod_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cod_producto.Location = new System.Drawing.Point(268, 90);
            this.txt_Cod_producto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cod_producto.Name = "txt_Cod_producto";
            this.txt_Cod_producto.Size = new System.Drawing.Size(253, 32);
            this.txt_Cod_producto.TabIndex = 33;
            this.txt_Cod_producto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtp_Fecha.Location = new System.Drawing.Point(116, 259);
            this.dtp_Fecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(375, 32);
            this.dtp_Fecha.TabIndex = 38;
            // 
            // nud_Precio
            // 
            this.nud_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Precio.Location = new System.Drawing.Point(116, 172);
            this.nud_Precio.Margin = new System.Windows.Forms.Padding(2);
            this.nud_Precio.Name = "nud_Precio";
            this.nud_Precio.Size = new System.Drawing.Size(90, 32);
            this.nud_Precio.TabIndex = 39;
            this.nud_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nud_Costo
            // 
            this.nud_Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Costo.Location = new System.Drawing.Point(116, 216);
            this.nud_Costo.Margin = new System.Windows.Forms.Padding(2);
            this.nud_Costo.Name = "nud_Costo";
            this.nud_Costo.Size = new System.Drawing.Size(90, 32);
            this.nud_Costo.TabIndex = 40;
            this.nud_Costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 32);
            this.label5.TabIndex = 120;
            this.label5.Text = "Código del producto";
            // 
            // NuevoUsusario
            // 
            this.NuevoUsusario.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoUsusario.Location = new System.Drawing.Point(11, 128);
            this.NuevoUsusario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NuevoUsusario.Name = "NuevoUsusario";
            this.NuevoUsusario.Size = new System.Drawing.Size(209, 32);
            this.NuevoUsusario.TabIndex = 121;
            this.NuevoUsusario.Text = "Nombre completo";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 122;
            this.label1.Text = "Precio";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 123;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 124;
            this.label4.Text = "Fecha";
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.BackgroundImage = global::HolaMundoForms.Properties.Resources._41pnj;
            this.BTN_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Registrar.Location = new System.Drawing.Point(13, 4);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(64, 64);
            this.BTN_Registrar.TabIndex = 97;
            this.BTN_Registrar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(91, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Productos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.BTN_Registrar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 71);
            this.panel2.TabIndex = 125;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btnsalir;
            this.ClientSize = new System.Drawing.Size(694, 410);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NuevoUsusario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_Costo);
            this.Controls.Add(this.nud_Precio);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.txt_Nombre_completo);
            this.Controls.Add(this.txt_Cod_producto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Costo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_Nombre_completo;
        private System.Windows.Forms.TextBox txt_Cod_producto;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.NumericUpDown nud_Precio;
        private System.Windows.Forms.NumericUpDown nud_Costo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NuevoUsusario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Registrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;

    }
}