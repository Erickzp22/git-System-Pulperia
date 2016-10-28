namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.btn_Cierre = new System.Windows.Forms.Button();
            this.btn_Administrador = new System.Windows.Forms.Button();
            this.btn_Vendedor = new System.Windows.Forms.Button();
            this.btn_Retiro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1248, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Abrir.Image = global::WindowsFormsApplication1.Properties.Resources.cierre2;
            this.btn_Abrir.Location = new System.Drawing.Point(9, 404);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(128, 128);
            this.btn_Abrir.TabIndex = 4;
            this.btn_Abrir.Text = "Abrir Caja";
            this.btn_Abrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.MouseLeave += new System.EventHandler(this.btn_Abrir_MouseLeave);
            this.btn_Abrir.MouseHover += new System.EventHandler(this.btn_Abrir_MouseHover);
            // 
            // btn_Cierre
            // 
            this.btn_Cierre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cierre.Image = global::WindowsFormsApplication1.Properties.Resources.Inicio1;
            this.btn_Cierre.Location = new System.Drawing.Point(9, 529);
            this.btn_Cierre.Name = "btn_Cierre";
            this.btn_Cierre.Size = new System.Drawing.Size(128, 128);
            this.btn_Cierre.TabIndex = 3;
            this.btn_Cierre.Text = "Cierre de caja";
            this.btn_Cierre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cierre.UseVisualStyleBackColor = true;
            this.btn_Cierre.MouseLeave += new System.EventHandler(this.btn_Cierre_MouseLeave);
            this.btn_Cierre.MouseHover += new System.EventHandler(this.btn_Cierre_MouseHover);
            // 
            // btn_Administrador
            // 
            this.btn_Administrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Administrador.Image = global::WindowsFormsApplication1.Properties.Resources.Administrador1;
            this.btn_Administrador.Location = new System.Drawing.Point(9, 279);
            this.btn_Administrador.Name = "btn_Administrador";
            this.btn_Administrador.Size = new System.Drawing.Size(128, 128);
            this.btn_Administrador.TabIndex = 2;
            this.btn_Administrador.Text = "Administrador";
            this.btn_Administrador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Administrador.UseVisualStyleBackColor = true;
            this.btn_Administrador.Click += new System.EventHandler(this.btn_Administrador_Click);
            this.btn_Administrador.MouseLeave += new System.EventHandler(this.btn_Administrador_MouseLeave);
            this.btn_Administrador.MouseHover += new System.EventHandler(this.btn_Administrador_MouseHover);
            // 
            // btn_Vendedor
            // 
            this.btn_Vendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vendedor.Image = global::WindowsFormsApplication1.Properties.Resources.vendedor1;
            this.btn_Vendedor.Location = new System.Drawing.Point(9, 28);
            this.btn_Vendedor.Name = "btn_Vendedor";
            this.btn_Vendedor.Size = new System.Drawing.Size(128, 128);
            this.btn_Vendedor.TabIndex = 1;
            this.btn_Vendedor.Text = "Vendedor";
            this.btn_Vendedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Vendedor.UseVisualStyleBackColor = true;
            this.btn_Vendedor.Click += new System.EventHandler(this.btn_Vendedor_Click);
            this.btn_Vendedor.MouseLeave += new System.EventHandler(this.btn_Vendedor_MouseLeave);
            this.btn_Vendedor.MouseHover += new System.EventHandler(this.btn_Vendedor_MouseHover);
            // 
            // btn_Retiro
            // 
            this.btn_Retiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Retiro.Image = global::WindowsFormsApplication1.Properties.Resources.Retirar1;
            this.btn_Retiro.Location = new System.Drawing.Point(9, 153);
            this.btn_Retiro.Name = "btn_Retiro";
            this.btn_Retiro.Size = new System.Drawing.Size(128, 128);
            this.btn_Retiro.TabIndex = 0;
            this.btn_Retiro.Text = "Retiro de efectivo";
            this.btn_Retiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Retiro.UseVisualStyleBackColor = true;
            this.btn_Retiro.MouseLeave += new System.EventHandler(this.btn_Retiro_MouseLeave);
            this.btn_Retiro.MouseHover += new System.EventHandler(this.btn_Retiro_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.LogoFF;
            this.pictureBox1.Location = new System.Drawing.Point(144, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1091, 618);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1012, 573);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1012, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hora:";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Hora.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.Location = new System.Drawing.Point(1072, 595);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(80, 21);
            this.lbl_Hora.TabIndex = 10;
            this.lbl_Hora.Text = "00:00:00";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Fecha.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(1081, 573);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(68, 21);
            this.lbl_Fecha.TabIndex = 9;
            this.lbl_Fecha.Text = "Fecha:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1248, 658);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Vendedor);
            this.Controls.Add(this.btn_Cierre);
            this.Controls.Add(this.btn_Abrir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Administrador);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_Retiro);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Retiro;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.Button btn_Cierre;
        private System.Windows.Forms.Button btn_Administrador;
        private System.Windows.Forms.Button btn_Vendedor;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Timer timer1;

    }
}

