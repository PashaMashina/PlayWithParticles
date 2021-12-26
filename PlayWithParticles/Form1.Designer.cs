namespace PlayWithParticles
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
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.labelDirection = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.tbSpread = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpread = new System.Windows.Forms.Label();
            this.tbPartPerTick = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPartPerTick)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(929, 582);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(947, 40);
            this.tbDirection.Maximum = 360;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(191, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(1144, 40);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(17, 13);
            this.labelDirection.TabIndex = 2;
            this.labelDirection.Text = "0°";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(968, 24);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(75, 13);
            this.lable1.TabIndex = 6;
            this.lable1.Text = "Направление";
            // 
            // tbSpread
            // 
            this.tbSpread.Location = new System.Drawing.Point(947, 104);
            this.tbSpread.Maximum = 360;
            this.tbSpread.Name = "tbSpread";
            this.tbSpread.Size = new System.Drawing.Size(191, 45);
            this.tbSpread.TabIndex = 7;
            this.tbSpread.Scroll += new System.EventHandler(this.tbSpread_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(968, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Разброс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(968, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Скорость";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(947, 172);
            this.tbSpeed.Maximum = 100;
            this.tbSpeed.Minimum = 10;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(191, 45);
            this.tbSpeed.TabIndex = 11;
            this.tbSpeed.Value = 10;
            this.tbSpeed.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelSpread
            // 
            this.labelSpread.AutoSize = true;
            this.labelSpread.Location = new System.Drawing.Point(1144, 104);
            this.labelSpread.Name = "labelSpread";
            this.labelSpread.Size = new System.Drawing.Size(17, 13);
            this.labelSpread.TabIndex = 12;
            this.labelSpread.Text = "0°";
            // 
            // tbPartPerTick
            // 
            this.tbPartPerTick.Location = new System.Drawing.Point(947, 236);
            this.tbPartPerTick.Maximum = 30;
            this.tbPartPerTick.Minimum = 1;
            this.tbPartPerTick.Name = "tbPartPerTick";
            this.tbPartPerTick.Size = new System.Drawing.Size(191, 45);
            this.tbPartPerTick.TabIndex = 13;
            this.tbPartPerTick.Value = 10;
            this.tbPartPerTick.Scroll += new System.EventHandler(this.tbPartPerTick_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(968, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Кол-во частиц в тик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 600);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Радиус цветосменятеля";
            // 
            // txtRadius
            // 
            this.txtRadius.AutoSize = true;
            this.txtRadius.Location = new System.Drawing.Point(148, 600);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(25, 13);
            this.txtRadius.TabIndex = 15;
            this.txtRadius.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 673);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPartPerTick);
            this.Controls.Add(this.labelSpread);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSpread);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.labelDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPartPerTick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TrackBar tbSpread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label labelSpread;
        private System.Windows.Forms.TrackBar tbPartPerTick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtRadius;
    }
}

