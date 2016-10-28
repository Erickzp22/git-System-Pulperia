namespace WindowsFormsApplication1
{
    partial class Ventas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cancelarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.Label();
            this.txt_cod_barra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cantidad_items = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarVentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1228, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            
            // 
            // cancelarVentaToolStripMenuItem
            // 
            this.cancelarVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarToolStripMenuItem});
            this.cancelarVentaToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarVentaToolStripMenuItem.Name = "cancelarVentaToolStripMenuItem";
            this.cancelarVentaToolStripMenuItem.Size = new System.Drawing.Size(142, 21);
            this.cancelarVentaToolStripMenuItem.Text = "Cancelar Venta";
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.cancelarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monto:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(382, 496);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Location = new System.Drawing.Point(219, 22);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(42, 44);
            this.txt_total.TabIndex = 3;
            this.txt_total.Text = "0";
            // 
            // txt_cod_barra
            // 
            this.txt_cod_barra.Location = new System.Drawing.Point(914, 496);
            this.txt_cod_barra.Name = "txt_cod_barra";
            this.txt_cod_barra.Size = new System.Drawing.Size(27, 20);
            this.txt_cod_barra.TabIndex = 4;
            this.txt_cod_barra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cod_barra_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1228, 462);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo de Barras";
            this.Column1.MinimumWidth = 7;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gold;
            this.groupBox2.Controls.Add(this.txt_cantidad_items);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 78);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // txt_cantidad_items
            // 
            this.txt_cantidad_items.AutoSize = true;
            this.txt_cantidad_items.Location = new System.Drawing.Point(271, 22);
            this.txt_cantidad_items.Name = "txt_cantidad_items";
            this.txt_cantidad_items.Size = new System.Drawing.Size(42, 44);
            this.txt_cantidad_items.TabIndex = 3;
            this.txt_cantidad_items.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1228, 602);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_cod_barra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancelarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.TextBox txt_cod_barra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txt_cantidad_items;
        private System.Windows.Forms.Label label3;
    }
}