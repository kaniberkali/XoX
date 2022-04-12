
namespace XoX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 41);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(349, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "XoX";
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 47);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(120, 120);
            this.b1.TabIndex = 2;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.Oyna);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(138, 47);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(120, 120);
            this.b2.TabIndex = 3;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.Oyna);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(264, 47);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(120, 120);
            this.b3.TabIndex = 4;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.Oyna);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(264, 173);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(120, 120);
            this.b6.TabIndex = 7;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.Oyna);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(138, 173);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(120, 120);
            this.b5.TabIndex = 6;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.Oyna);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 173);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(120, 120);
            this.b4.TabIndex = 5;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.Oyna);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(264, 299);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(120, 120);
            this.b9.TabIndex = 10;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.Oyna);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(138, 299);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(120, 120);
            this.b8.TabIndex = 9;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.Oyna);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 299);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(120, 120);
            this.b7.TabIndex = 8;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.Oyna);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Oynama Sırası :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(180, 423);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(202, 30);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Oynanılacak Simge :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 39);
            this.label4.TabIndex = 14;
            this.label4.Text = "O";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Oyuncu 1 : 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Oyuncu 2 : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(394, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XoX";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

