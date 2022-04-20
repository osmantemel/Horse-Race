namespace deneme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.atnumarasi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.oran1 = new System.Windows.Forms.Label();
            this.oran3 = new System.Windows.Forms.Label();
            this.oran2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tutar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metin = new System.Windows.Forms.Label();
            this.metin2 = new System.Windows.Forms.Label();
            this.metin3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(970, 39);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(971, 39);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-3, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(973, 39);
            this.label3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 298);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(107, 104);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 76);
            this.button1.TabIndex = 7;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(255, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(684, 76);
            this.label5.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(954, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 444);
            this.label11.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(954, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 45);
            this.label4.TabIndex = 16;
            this.label4.Text = "F";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(954, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 45);
            this.label6.TabIndex = 17;
            this.label6.Text = "H";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(954, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 45);
            this.label7.TabIndex = 18;
            this.label7.Text = "S";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(954, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 45);
            this.label8.TabIndex = 19;
            this.label8.Text = "İ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(954, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 45);
            this.label9.TabIndex = 20;
            this.label9.Text = "N";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(954, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 45);
            this.label10.TabIndex = 21;
            this.label10.Text = "İ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.tutar);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.oran2);
            this.panel1.Controls.Add(this.oran3);
            this.panel1.Controls.Add(this.oran1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.atnumarasi);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(263, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 352);
            this.panel1.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(107, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(315, 46);
            this.label12.TabIndex = 0;
            this.label12.Text = "İDDA.OSMAN";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(24, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 1;
            this.label13.Text = "1.AT ORAN:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(24, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "2.AT ORAN:";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(24, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "3.AT ORAN:";
            // 
            // atnumarasi
            // 
            this.atnumarasi.Location = new System.Drawing.Point(105, 224);
            this.atnumarasi.Name = "atnumarasi";
            this.atnumarasi.Size = new System.Drawing.Size(83, 22);
            this.atnumarasi.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(0, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(498, 14);
            this.label16.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(278, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 79);
            this.label17.TabIndex = 8;
            this.label17.Text = "OYNA KAZAN";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 68);
            this.button2.TabIndex = 9;
            this.button2.Text = "TAMAM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oran1
            // 
            this.oran1.BackColor = System.Drawing.Color.White;
            this.oran1.Location = new System.Drawing.Point(112, 74);
            this.oran1.Name = "oran1";
            this.oran1.Size = new System.Drawing.Size(100, 23);
            this.oran1.TabIndex = 10;
            // 
            // oran3
            // 
            this.oran3.BackColor = System.Drawing.Color.White;
            this.oran3.Location = new System.Drawing.Point(112, 120);
            this.oran3.Name = "oran3";
            this.oran3.Size = new System.Drawing.Size(100, 23);
            this.oran3.TabIndex = 11;
            // 
            // oran2
            // 
            this.oran2.BackColor = System.Drawing.Color.White;
            this.oran2.Location = new System.Drawing.Point(112, 97);
            this.oran2.Name = "oran2";
            this.oran2.Size = new System.Drawing.Size(100, 23);
            this.oran2.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(102, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 23);
            this.label18.TabIndex = 13;
            this.label18.Text = "AT NUMARASI";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(102, 261);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 23);
            this.label19.TabIndex = 14;
            this.label19.Text = "TUTAR:";
            // 
            // tutar
            // 
            this.tutar.Location = new System.Drawing.Point(105, 287);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(83, 22);
            this.tutar.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metin3);
            this.panel2.Controls.Add(this.metin2);
            this.panel2.Controls.Add(this.metin);
            this.panel2.Location = new System.Drawing.Point(137, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 346);
            this.panel2.TabIndex = 16;
            // 
            // metin
            // 
            this.metin.BackColor = System.Drawing.Color.Salmon;
            this.metin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metin.Location = new System.Drawing.Point(158, 42);
            this.metin.Name = "metin";
            this.metin.Size = new System.Drawing.Size(343, 74);
            this.metin.TabIndex = 0;
            this.metin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metin2
            // 
            this.metin2.BackColor = System.Drawing.Color.Tomato;
            this.metin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metin2.Location = new System.Drawing.Point(158, 116);
            this.metin2.Name = "metin2";
            this.metin2.Size = new System.Drawing.Size(343, 74);
            this.metin2.TabIndex = 1;
            this.metin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metin3
            // 
            this.metin3.BackColor = System.Drawing.Color.OrangeRed;
            this.metin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metin3.Location = new System.Drawing.Point(158, 187);
            this.metin3.Name = "metin3";
            this.metin3.Size = new System.Drawing.Size(343, 74);
            this.metin3.TabIndex = 2;
            this.metin3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1011, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AT YARIŞI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox atnumarasi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label oran2;
        private System.Windows.Forms.Label oran3;
        private System.Windows.Forms.Label oran1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tutar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label metin;
        private System.Windows.Forms.Label metin2;
        private System.Windows.Forms.Label metin3;
    }
}

