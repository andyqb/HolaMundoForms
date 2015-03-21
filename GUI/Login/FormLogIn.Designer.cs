namespace HolaMundoForms
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btningreso = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Entrar = new System.Windows.Forms.Button();
            this.BTN_nuevousuario = new System.Windows.Forms.Button();
            this.BTN_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // textuser
            // 
            this.textuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuser.Location = new System.Drawing.Point(52, 160);
            this.textuser.Margin = new System.Windows.Forms.Padding(4);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(180, 32);
            this.textuser.TabIndex = 1;
            this.textuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textuser_KeyPress);
            // 
            // textpassword
            // 
            this.textpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpassword.Location = new System.Drawing.Point(52, 251);
            this.textpassword.Margin = new System.Windows.Forms.Padding(4);
            this.textpassword.MaxLength = 20;
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = 'X';
            this.textpassword.Size = new System.Drawing.Size(180, 32);
            this.textpassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 62);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.HotTrack;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnsalir.Location = new System.Drawing.Point(769, 1);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(64, 64);
            this.btnsalir.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnsalir, "Opciones Windows\r\n");
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnactualizar.BackgroundImage")));
            this.btnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnactualizar.Location = new System.Drawing.Point(143, 18);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(64, 64);
            this.btnactualizar.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnactualizar, "Actualizar");
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(16, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 65);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btningreso
            // 
            this.btningreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btningreso.BackgroundImage")));
            this.btningreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningreso.ForeColor = System.Drawing.Color.Transparent;
            this.btningreso.Location = new System.Drawing.Point(456, 18);
            this.btningreso.Margin = new System.Windows.Forms.Padding(4);
            this.btningreso.Name = "btningreso";
            this.btningreso.Size = new System.Drawing.Size(64, 64);
            this.btningreso.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btningreso, "Login");
            this.btningreso.UseVisualStyleBackColor = true;
            this.btningreso.Click += new System.EventHandler(this.btningreso_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(345, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 160);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btningreso);
            this.panel1.Controls.Add(this.btnactualizar);
            this.panel1.Controls.Add(this.BTN_nuevousuario);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BTN_salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 94);
            this.panel1.TabIndex = 26;
            // 
            // BTN_Entrar
            // 
            this.BTN_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Entrar.Location = new System.Drawing.Point(769, 15);
            this.BTN_Entrar.Name = "BTN_Entrar";
            this.BTN_Entrar.Size = new System.Drawing.Size(64, 68);
            this.BTN_Entrar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.BTN_Entrar, "Favoritos");
            this.BTN_Entrar.UseVisualStyleBackColor = true;
            // 
            // BTN_nuevousuario
            // 
            this.BTN_nuevousuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_nuevousuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_nuevousuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_nuevousuario.Location = new System.Drawing.Point(182, 16);
            this.BTN_nuevousuario.Name = "BTN_nuevousuario";
            this.BTN_nuevousuario.Size = new System.Drawing.Size(10, 64);
            this.BTN_nuevousuario.TabIndex = 9;
            this.toolTip1.SetToolTip(this.BTN_nuevousuario, "Nuevo usuario");
            this.BTN_nuevousuario.UseVisualStyleBackColor = true;
            // 
            // BTN_salir
            // 
            this.BTN_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_salir.Location = new System.Drawing.Point(27, 18);
            this.BTN_salir.Name = "BTN_salir";
            this.BTN_salir.Size = new System.Drawing.Size(64, 64);
            this.BTN_salir.TabIndex = 11;
            this.toolTip1.SetToolTip(this.BTN_salir, "Salir");
            this.BTN_salir.UseVisualStyleBackColor = true;
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(551, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.BTN_Entrar);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Orange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogIn";
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btningreso;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_nuevousuario;
        private System.Windows.Forms.Button BTN_salir;
        private System.Windows.Forms.Button BTN_Entrar;
    }
}