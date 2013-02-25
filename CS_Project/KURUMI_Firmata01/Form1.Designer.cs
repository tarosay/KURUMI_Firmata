namespace KURUMI_Firmata
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Black = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Violet = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.SkyBlue = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRead22 = new System.Windows.Forms.Button();
            this.btnDigitalRead = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Black
            // 
            this.Black.Location = new System.Drawing.Point(12, 12);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(75, 23);
            this.Black.TabIndex = 0;
            this.Black.Text = "黒";
            this.Black.UseVisualStyleBackColor = true;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(93, 12);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(75, 23);
            this.Blue.TabIndex = 1;
            this.Blue.Text = "青";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(174, 12);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(75, 23);
            this.Red.TabIndex = 2;
            this.Red.Text = "赤";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Violet
            // 
            this.Violet.Location = new System.Drawing.Point(255, 12);
            this.Violet.Name = "Violet";
            this.Violet.Size = new System.Drawing.Size(75, 23);
            this.Violet.TabIndex = 3;
            this.Violet.Text = "紫";
            this.Violet.UseVisualStyleBackColor = true;
            this.Violet.Click += new System.EventHandler(this.Violet_Click);
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(12, 41);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(75, 23);
            this.Green.TabIndex = 4;
            this.Green.Text = "緑";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // SkyBlue
            // 
            this.SkyBlue.Location = new System.Drawing.Point(93, 41);
            this.SkyBlue.Name = "SkyBlue";
            this.SkyBlue.Size = new System.Drawing.Size(75, 23);
            this.SkyBlue.TabIndex = 5;
            this.SkyBlue.Text = "水色";
            this.SkyBlue.UseVisualStyleBackColor = true;
            this.SkyBlue.Click += new System.EventHandler(this.SkyBlue_Click);
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(174, 41);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(75, 23);
            this.Yellow.TabIndex = 6;
            this.Yellow.Text = "黄";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // White
            // 
            this.White.Location = new System.Drawing.Point(255, 41);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(75, 23);
            this.White.TabIndex = 7;
            this.White.Text = "白";
            this.White.UseVisualStyleBackColor = true;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(318, 19);
            this.textBox1.TabIndex = 8;
            // 
            // btnRead22
            // 
            this.btnRead22.Location = new System.Drawing.Point(12, 70);
            this.btnRead22.Name = "btnRead22";
            this.btnRead22.Size = new System.Drawing.Size(110, 23);
            this.btnRead22.TabIndex = 9;
            this.btnRead22.Text = "AnalogRead A0";
            this.btnRead22.UseVisualStyleBackColor = true;
            this.btnRead22.Click += new System.EventHandler(this.btnRead22_Click);
            // 
            // btnDigitalRead
            // 
            this.btnDigitalRead.Location = new System.Drawing.Point(139, 70);
            this.btnDigitalRead.Name = "btnDigitalRead";
            this.btnDigitalRead.Size = new System.Drawing.Size(110, 23);
            this.btnDigitalRead.TabIndex = 10;
            this.btnDigitalRead.Text = "Digital Read";
            this.btnDigitalRead.UseVisualStyleBackColor = true;
            this.btnDigitalRead.Click += new System.EventHandler(this.btnDigitalRead_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(255, 70);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 11;
            this.btnOutput.Text = "PIN 2 H/L";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 124);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(29, 22);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "D2";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(47, 124);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(29, 22);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "D3";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(82, 124);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(29, 22);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "D4";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(117, 124);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(29, 22);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "D5";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(152, 124);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(29, 22);
            this.checkBox5.TabIndex = 19;
            this.checkBox5.Text = "D6";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(187, 124);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(29, 22);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.Text = "D7";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(318, 19);
            this.textBox2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 177);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnDigitalRead);
            this.Controls.Add(this.btnRead22);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.White);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.SkyBlue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Violet);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Black);
            this.Name = "Form1";
            this.Text = "KURUMI Firmata TEST";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Violet;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button SkyBlue;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRead22;
        private System.Windows.Forms.Button btnDigitalRead;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBox2;
    }
}

