namespace HolaMundoForms.GUI.Menu
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_Registrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.Sucursales = new System.Windows.Forms.Button();
            this.Almacen = new System.Windows.Forms.Button();
            this.Proveedores = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Location = new System.Drawing.Point(-2, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 77);
            this.panel1.TabIndex = 9;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_salir.BackgroundImage = global::HolaMundoForms.Properties.Resources.check_2_icon;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_salir.Location = new System.Drawing.Point(424, 7);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(66, 65);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.BTN_Registrar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 59);
            this.panel2.TabIndex = 26;
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.BackgroundImage = global::HolaMundoForms.Properties.Resources._41pnj;
            this.BTN_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Registrar.Location = new System.Drawing.Point(8, -1);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(64, 64);
            this.BTN_Registrar.TabIndex = 98;
            this.BTN_Registrar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(91, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Menu\r\n";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.BackgroundImage = global::HolaMundoForms.Properties.Resources.Windows_Luna_icon5;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(345, 196);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 96);
            this.button6.TabIndex = 5;
            this.button6.Text = "Usuarios";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Sucursales
            // 
            this.Sucursales.BackColor = System.Drawing.Color.Teal;
            this.Sucursales.BackgroundImage = global::HolaMundoForms.Properties.Resources.Windows_Luna_icon3;
            this.Sucursales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sucursales.Location = new System.Drawing.Point(43, 196);
            this.Sucursales.Name = "Sucursales";
            this.Sucursales.Size = new System.Drawing.Size(96, 96);
            this.Sucursales.TabIndex = 4;
            this.Sucursales.Text = "Sucursales";
            this.Sucursales.UseVisualStyleBackColor = false;
            this.Sucursales.Click += new System.EventHandler(this.button5_Click);
            // 
            // Almacen
            // 
            this.Almacen.BackColor = System.Drawing.Color.Teal;
            this.Almacen.BackgroundImage = global::HolaMundoForms.Properties.Resources.Windows_Luna_icon2;
            this.Almacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Almacen.Location = new System.Drawing.Point(345, 74);
            this.Almacen.Name = "Almacen";
            this.Almacen.Size = new System.Drawing.Size(96, 96);
            this.Almacen.TabIndex = 3;
            this.Almacen.Text = "Almacen";
            this.Almacen.UseVisualStyleBackColor = false;
            this.Almacen.Click += new System.EventHandler(this.button4_Click);
            // 
            // Proveedores
            // 
            this.Proveedores.BackColor = System.Drawing.Color.Teal;
            this.Proveedores.BackgroundImage = global::HolaMundoForms.Properties.Resources.Windows_Luna_icon1;
            this.Proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Proveedores.Location = new System.Drawing.Point(194, 74);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(96, 96);
            this.Proveedores.TabIndex = 2;
            this.Proveedores.Text = " Proveedores";
            this.Proveedores.UseVisualStyleBackColor = false;
            this.Proveedores.Click += new System.EventHandler(this.button3_Click);
            // 
            // Clientes
            // 
            this.Clientes.BackColor = System.Drawing.Color.Teal;
            this.Clientes.BackgroundImage = global::HolaMundoForms.Properties.Resources.Windows_Luna_icon;
            this.Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clientes.Location = new System.Drawing.Point(43, 74);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(96, 96);
            this.Clientes.TabIndex = 1;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = false;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(194, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 96);
            this.button1.TabIndex = 27;
            this.button1.Text = " Productos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btn_salir;
            this.ClientSize = new System.Drawing.Size(506, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sucursales);
            this.Controls.Add(this.Almacen);
            this.Controls.Add(this.Proveedores);
            this.Controls.Add(this.Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Proveedores;
        private System.Windows.Forms.Button Almacen;
        private System.Windows.Forms.Button Sucursales;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_Registrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}