namespace WindowsFormsApp52
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Razmer = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.KarX = new System.Windows.Forms.TrackBar();
            this.KarY = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Razmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarY)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 386);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Рисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Razmer
            // 
            this.Razmer.Location = new System.Drawing.Point(650, 125);
            this.Razmer.Maximum = 100;
            this.Razmer.Name = "Razmer";
            this.Razmer.Size = new System.Drawing.Size(133, 45);
            this.Razmer.TabIndex = 2;
            this.Razmer.ValueChanged += new System.EventHandler(this.Razmer_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер";
            // 
            // KarX
            // 
            this.KarX.Location = new System.Drawing.Point(650, 201);
            this.KarX.Name = "KarX";
            this.KarX.Size = new System.Drawing.Size(133, 45);
            this.KarX.TabIndex = 4;
            this.KarX.ValueChanged += new System.EventHandler(this.KarX_ValueChanged);
            // 
            // KarY
            // 
            this.KarY.Location = new System.Drawing.Point(650, 286);
            this.KarY.Name = "KarY";
            this.KarY.Size = new System.Drawing.Size(133, 45);
            this.KarY.TabIndex = 5;
            this.KarY.ValueChanged += new System.EventHandler(this.KarY_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Расположение по Х";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(664, 261);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(107, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Расположение по Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KarY);
            this.Controls.Add(this.KarX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Razmer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Razmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label3;
        public System.Windows.Forms.TrackBar Razmer;
        public System.Windows.Forms.TrackBar KarX;
        public System.Windows.Forms.TrackBar KarY;
    }
}

