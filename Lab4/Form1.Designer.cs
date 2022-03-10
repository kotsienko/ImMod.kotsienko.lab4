
namespace Lab4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edResolution = new System.Windows.Forms.NumericUpDown();
            this.edDensity = new System.Windows.Forms.NumericUpDown();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.edResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Разрешение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Плотность";
            // 
            // edResolution
            // 
            this.edResolution.Location = new System.Drawing.Point(106, 33);
            this.edResolution.Name = "edResolution";
            this.edResolution.Size = new System.Drawing.Size(120, 22);
            this.edResolution.TabIndex = 2;
            this.edResolution.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // edDensity
            // 
            this.edDensity.Location = new System.Drawing.Point(339, 33);
            this.edDensity.Name = "edDensity";
            this.edDensity.Size = new System.Drawing.Size(120, 22);
            this.edDensity.TabIndex = 3;
            this.edDensity.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(547, 24);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(112, 38);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Пуск";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(715, 24);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(112, 38);
            this.btStop.TabIndex = 5;
            this.btStop.Text = "Стоп";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1031, 535);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edResolution);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btStop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btStart);
            this.groupBox1.Controls.Add(this.edDensity);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 98);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edResolution;
        private System.Windows.Forms.NumericUpDown edDensity;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

