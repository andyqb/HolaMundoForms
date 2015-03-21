namespace HolaMundoForms.Catalogos
{
    partial class Sucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursales));
            this.nombresuc = new System.Windows.Forms.TextBox();
            this.codigosuc = new System.Windows.Forms.NumericUpDown();
            this.NuevoUsusario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.direcc = new System.Windows.Forms.TextBox();
            this.resp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Registrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.codigosuc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombresuc
            // 
            this.nombresuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombresuc.Location = new System.Drawing.Point(228, 124);
            this.nombresuc.Margin = new System.Windows.Forms.Padding(2);
            this.nombresuc.Name = "nombresuc";
            this.nombresuc.Size = new System.Drawing.Size(253, 32);
            this.nombresuc.TabIndex = 122;
            this.nombresuc.TextChanged += new System.EventHandler(this.nombresuc_TextChanged);
            // 
            // codigosuc
            // 
            this.codigosuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.codigosuc.Location = new System.Drawing.Point(228, 83);
            this.codigosuc.Margin = new System.Windows.Forms.Padding(2);
            this.codigosuc.Name = "codigosuc";
            this.codigosuc.Size = new System.Drawing.Size(90, 32);
            this.codigosuc.TabIndex = 120;
            this.codigosuc.ValueChanged += new System.EventHandler(this.codigosuc_ValueChanged);
            // 
            // NuevoUsusario
            // 
            this.NuevoUsusario.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoUsusario.Location = new System.Drawing.Point(11, 83);
            this.NuevoUsusario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NuevoUsusario.Name = "NuevoUsusario";
            this.NuevoUsusario.Size = new System.Drawing.Size(157, 32);
            this.NuevoUsusario.TabIndex = 119;
            this.NuevoUsusario.Text = "No. Sucursal";
            this.NuevoUsusario.Click += new System.EventHandler(this.NuevoUsusario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 83);
            this.panel1.TabIndex = 118;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(12, 10);
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
            this.btnsalir.Location = new System.Drawing.Point(516, 10);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(65, 65);
            this.btnsalir.TabIndex = 117;
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // direcc
            // 
            this.direcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direcc.Location = new System.Drawing.Point(228, 169);
            this.direcc.Margin = new System.Windows.Forms.Padding(2);
            this.direcc.Multiline = true;
            this.direcc.Name = "direcc";
            this.direcc.Size = new System.Drawing.Size(253, 150);
            this.direcc.TabIndex = 126;
            this.direcc.TextChanged += new System.EventHandler(this.direcc_TextChanged);
            // 
            // resp
            // 
            this.resp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp.Location = new System.Drawing.Point(228, 344);
            this.resp.Margin = new System.Windows.Forms.Padding(2);
            this.resp.Name = "resp";
            this.resp.Size = new System.Drawing.Size(253, 32);
            this.resp.TabIndex = 128;
            this.resp.TextChanged += new System.EventHandler(this.resp_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 32);
            this.label4.TabIndex = 129;
            this.label4.Text = "Nombre sucursal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 130;
            this.label1.Text = "Dirección";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 344);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 32);
            this.label2.TabIndex = 131;
            this.label2.Text = "Responsable";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.label6.Size = new System.Drawing.Size(189, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sucursales";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.BTN_Registrar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 71);
            this.panel2.TabIndex = 132;
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btnsalir;
            this.ClientSize = new System.Drawing.Size(602, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resp);
            this.Controls.Add(this.direcc);
            this.Controls.Add(this.nombresuc);
            this.Controls.Add(this.codigosuc);
            this.Controls.Add(this.NuevoUsusario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sucursales";
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.Sucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codigosuc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombresuc;
        private System.Windows.Forms.NumericUpDown codigosuc;
        private System.Windows.Forms.Label NuevoUsusario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox direcc;
        private System.Windows.Forms.TextBox resp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Registrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}