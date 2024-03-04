namespace tahmin_oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBasla = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTahmin = new System.Windows.Forms.Button();
            this.labelMesaj = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBasla
            // 
            this.buttonBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBasla.Location = new System.Drawing.Point(25, 22);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(96, 40);
            this.buttonBasla.TabIndex = 0;
            this.buttonBasla.Text = "Başla";
            this.buttonBasla.UseVisualStyleBackColor = true;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 199);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 45);
            this.textBox1.TabIndex = 1;
            // 
            // buttonTahmin
            // 
            this.buttonTahmin.Location = new System.Drawing.Point(362, 273);
            this.buttonTahmin.Name = "buttonTahmin";
            this.buttonTahmin.Size = new System.Drawing.Size(75, 40);
            this.buttonTahmin.TabIndex = 2;
            this.buttonTahmin.Text = "Tahmin Et";
            this.buttonTahmin.UseVisualStyleBackColor = true;
            this.buttonTahmin.Click += new System.EventHandler(this.buttonTahmin_Click_1);
            // 
            // labelMesaj
            // 
            this.labelMesaj.AutoSize = true;
            this.labelMesaj.Location = new System.Drawing.Point(301, 45);
            this.labelMesaj.Name = "labelMesaj";
            this.labelMesaj.Size = new System.Drawing.Size(0, 16);
            this.labelMesaj.TabIndex = 3;
            this.labelMesaj.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(626, 228);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "5 Hakkınız Kaldı!";
            this.linkLabel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelMesaj);
            this.Controls.Add(this.buttonTahmin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonBasla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTahmin;
        private System.Windows.Forms.Label labelMesaj;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

