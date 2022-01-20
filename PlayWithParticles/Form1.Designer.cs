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
            this.tbRadTp = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.colorMenu = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.Label();
            this.txtPerTick = new System.Windows.Forms.Label();
            this.txtSizeTP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPartPerTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRadTp)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(929, 582);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
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
            this.tbDirection.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.labelDirection.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDirection.ForeColor = System.Drawing.Color.White;
            this.labelDirection.Location = new System.Drawing.Point(1144, 40);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(17, 13);
            this.labelDirection.TabIndex = 2;
            this.labelDirection.Text = "0°";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lable1.ForeColor = System.Drawing.Color.White;
            this.lable1.Location = new System.Drawing.Point(968, 24);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(75, 13);
            this.lable1.TabIndex = 6;
            this.lable1.Text = "Направление";
            // 
            // tbSpread
            // 
            this.tbSpread.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(968, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Разброс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(968, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Скорость";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.labelSpread.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSpread.ForeColor = System.Drawing.Color.White;
            this.labelSpread.Location = new System.Drawing.Point(1144, 104);
            this.labelSpread.Name = "labelSpread";
            this.labelSpread.Size = new System.Drawing.Size(17, 13);
            this.labelSpread.TabIndex = 12;
            this.labelSpread.Text = "0°";
            // 
            // tbPartPerTick
            // 
            this.tbPartPerTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPartPerTick.Location = new System.Drawing.Point(947, 236);
            this.tbPartPerTick.Maximum = 50;
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
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(968, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Кол-во частиц в тик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(968, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Радиус цветосменятеля";
            // 
            // txtRadius
            // 
            this.txtRadius.AutoSize = true;
            this.txtRadius.Location = new System.Drawing.Point(1104, 454);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(25, 13);
            this.txtRadius.TabIndex = 15;
            this.txtRadius.Text = "100";
            // 
            // tbRadTp
            // 
            this.tbRadTp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbRadTp.Location = new System.Drawing.Point(947, 297);
            this.tbRadTp.Maximum = 350;
            this.tbRadTp.Name = "tbRadTp";
            this.tbRadTp.Size = new System.Drawing.Size(191, 45);
            this.tbRadTp.TabIndex = 16;
            this.tbRadTp.Value = 100;
            this.tbRadTp.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(968, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Размер портала";
            // 
            // colorMenu
            // 
            this.colorMenu.Color = System.Drawing.Color.Blue;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Blue;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColor.Location = new System.Drawing.Point(960, 348);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(178, 103);
            this.btnColor.TabIndex = 18;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkMagenta;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(960, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 95);
            this.button1.TabIndex = 19;
            this.button1.Text = "Включить гравитацию для тяжёлых частиц";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtSpeed
            // 
            this.txtSpeed.AutoSize = true;
            this.txtSpeed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSpeed.ForeColor = System.Drawing.Color.White;
            this.txtSpeed.Location = new System.Drawing.Point(1144, 172);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(19, 13);
            this.txtSpeed.TabIndex = 20;
            this.txtSpeed.Text = "10";
            // 
            // txtPerTick
            // 
            this.txtPerTick.AutoSize = true;
            this.txtPerTick.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPerTick.ForeColor = System.Drawing.Color.White;
            this.txtPerTick.Location = new System.Drawing.Point(1144, 236);
            this.txtPerTick.Name = "txtPerTick";
            this.txtPerTick.Size = new System.Drawing.Size(19, 13);
            this.txtPerTick.TabIndex = 21;
            this.txtPerTick.Text = "10";
            // 
            // txtSizeTP
            // 
            this.txtSizeTP.AutoSize = true;
            this.txtSizeTP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSizeTP.ForeColor = System.Drawing.Color.White;
            this.txtSizeTP.Location = new System.Drawing.Point(1144, 297);
            this.txtSizeTP.Name = "txtSizeTP";
            this.txtSizeTP.Size = new System.Drawing.Size(25, 13);
            this.txtSizeTP.TabIndex = 22;
            this.txtSizeTP.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1173, 615);
            this.Controls.Add(this.txtSizeTP);
            this.Controls.Add(this.txtPerTick);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRadTp);
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
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Тест частиц";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPartPerTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRadTp)).EndInit();
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
        private System.Windows.Forms.TrackBar tbRadTp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorMenu;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtSpeed;
        private System.Windows.Forms.Label txtPerTick;
        private System.Windows.Forms.Label txtSizeTP;
    }
}

