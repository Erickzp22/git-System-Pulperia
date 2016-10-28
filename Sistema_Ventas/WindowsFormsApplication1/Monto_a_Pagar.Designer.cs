namespace WindowsFormsApplication1
{
    partial class Monto_a_Pagar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Monto = new System.Windows.Forms.Label();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.txt_Listo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 78);
            this.groupBox1.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gold;
            this.groupBox2.Controls.Add(this.txt_Listo);
            this.groupBox2.Controls.Add(this.txt_Monto);
            this.groupBox2.Controls.Add(this.Monto);
            this.groupBox2.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(79, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 180);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // Monto
            // 
            this.Monto.AutoSize = true;
            this.Monto.Location = new System.Drawing.Point(52, 22);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(161, 44);
            this.Monto.TabIndex = 2;
            this.Monto.Text = "Monto:";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(227, 19);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(266, 51);
            this.txt_Monto.TabIndex = 3;
            // 
            // txt_Listo
            // 
            this.txt_Listo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Listo.Location = new System.Drawing.Point(328, 101);
            this.txt_Listo.Name = "txt_Listo";
            this.txt_Listo.Size = new System.Drawing.Size(193, 61);
            this.txt_Listo.TabIndex = 6;
            this.txt_Listo.Text = "Listo";
            this.txt_Listo.UseVisualStyleBackColor = true;
            this.txt_Listo.Click += new System.EventHandler(this.txt_Listo_Click);
            // 
            // Monto_a_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(740, 370);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Monto_a_Pagar";
            this.Text = "Monto_a_Pagar";
            this.Load += new System.EventHandler(this.Monto_a_Pagar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button txt_Listo;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Label Monto;
    }
}