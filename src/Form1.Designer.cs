namespace Lab6
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
            this.tbMoscow = new System.Windows.Forms.TextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.tbWorld = new System.Windows.Forms.TextBox();
            this.tbVlad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMoscow
            // 
            this.tbMoscow.Location = new System.Drawing.Point(241, 111);
            this.tbMoscow.Name = "tbMoscow";
            this.tbMoscow.Size = new System.Drawing.Size(462, 31);
            this.tbMoscow.TabIndex = 0;
            this.tbMoscow.TextChanged += new System.EventHandler(this.tbMoscow_TextChanged);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(818, 687);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(159, 81);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "ПУСК!";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(1005, 687);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(159, 81);
            this.bStop.TabIndex = 2;
            this.bStop.Text = "СТОП!";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // tbWorld
            // 
            this.tbWorld.Location = new System.Drawing.Point(241, 197);
            this.tbWorld.Name = "tbWorld";
            this.tbWorld.Size = new System.Drawing.Size(462, 31);
            this.tbWorld.TabIndex = 3;
            this.tbWorld.TextChanged += new System.EventHandler(this.tbWorld_TextChanged);
            // 
            // tbVlad
            // 
            this.tbVlad.Location = new System.Drawing.Point(241, 287);
            this.tbVlad.Name = "tbVlad";
            this.tbVlad.Size = new System.Drawing.Size(462, 31);
            this.tbVlad.TabIndex = 4;
            this.tbVlad.TextChanged += new System.EventHandler(this.tbVlad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(235, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Москва";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(235, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Мир";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(235, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Владивосток";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 811);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVlad);
            this.Controls.Add(this.tbWorld);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tbMoscow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMoscow;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.TextBox tbWorld;
        private System.Windows.Forms.TextBox tbVlad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

