namespace WindowsFormsApp1
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.Chk1 = new System.Windows.Forms.CheckBox();
            this.Chk2 = new System.Windows.Forms.CheckBox();
            this.Chk3 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Tex1 = new System.Windows.Forms.Label();
            this.Radio1 = new System.Windows.Forms.RadioButton();
            this.Radio2 = new System.Windows.Forms.RadioButton();
            this.Radio3 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.NumUD1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.NumUD2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labelChk1 = new System.Windows.Forms.Label();
            this.radioChk = new System.Windows.Forms.Label();
            this.labelChk2 = new System.Windows.Forms.Label();
            this.labelChk3 = new System.Windows.Forms.Label();
            this.labelNumUD1 = new System.Windows.Forms.Label();
            this.labelNumUD2 = new System.Windows.Forms.Label();
            this.labelTex = new System.Windows.Forms.Label();
            this.labelButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Chk1
            // 
            this.Chk1.AutoSize = true;
            this.Chk1.Location = new System.Drawing.Point(12, 26);
            this.Chk1.Name = "Chk1";
            this.Chk1.Size = new System.Drawing.Size(97, 16);
            this.Chk1.TabIndex = 0;
            this.Chk1.Text = "チェックボックス１";
            this.Chk1.UseVisualStyleBackColor = true;
            this.Chk1.CheckedChanged += new System.EventHandler(this.Chk1_CheckedChanged);
            // 
            // Chk2
            // 
            this.Chk2.AutoSize = true;
            this.Chk2.Location = new System.Drawing.Point(13, 48);
            this.Chk2.Name = "Chk2";
            this.Chk2.Size = new System.Drawing.Size(97, 16);
            this.Chk2.TabIndex = 1;
            this.Chk2.Text = "チェックボックス２";
            this.Chk2.UseVisualStyleBackColor = true;
            this.Chk2.CheckedChanged += new System.EventHandler(this.Chk2_CheckedChanged);
            // 
            // Chk3
            // 
            this.Chk3.AutoSize = true;
            this.Chk3.Location = new System.Drawing.Point(12, 67);
            this.Chk3.Name = "Chk3";
            this.Chk3.Size = new System.Drawing.Size(97, 16);
            this.Chk3.TabIndex = 2;
            this.Chk3.Text = "チェックボックス３";
            this.Chk3.UseVisualStyleBackColor = true;
            this.Chk3.CheckedChanged += new System.EventHandler(this.Chk3_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 3;
            // 
            // Tex1
            // 
            this.Tex1.AutoSize = true;
            this.Tex1.Location = new System.Drawing.Point(196, 111);
            this.Tex1.Name = "Tex1";
            this.Tex1.Size = new System.Drawing.Size(41, 12);
            this.Tex1.TabIndex = 4;
            this.Tex1.Text = "テキスト";
            // 
            // Radio1
            // 
            this.Radio1.AutoSize = true;
            this.Radio1.Location = new System.Drawing.Point(13, 212);
            this.Radio1.Name = "Radio1";
            this.Radio1.Size = new System.Drawing.Size(85, 16);
            this.Radio1.TabIndex = 5;
            this.Radio1.TabStop = true;
            this.Radio1.Text = "ラジオボタン１";
            this.Radio1.UseVisualStyleBackColor = true;
            this.Radio1.CheckedChanged += new System.EventHandler(this.Radio1_CheckedChanged);
            // 
            // Radio2
            // 
            this.Radio2.AutoSize = true;
            this.Radio2.Location = new System.Drawing.Point(12, 235);
            this.Radio2.Name = "Radio2";
            this.Radio2.Size = new System.Drawing.Size(85, 16);
            this.Radio2.TabIndex = 6;
            this.Radio2.TabStop = true;
            this.Radio2.Text = "ラジオボタン２";
            this.Radio2.UseVisualStyleBackColor = true;
            this.Radio2.CheckedChanged += new System.EventHandler(this.Radio2_CheckedChanged);
            // 
            // Radio3
            // 
            this.Radio3.AutoSize = true;
            this.Radio3.Location = new System.Drawing.Point(12, 258);
            this.Radio3.Name = "Radio3";
            this.Radio3.Size = new System.Drawing.Size(85, 16);
            this.Radio3.TabIndex = 7;
            this.Radio3.TabStop = true;
            this.Radio3.Text = "ラジオボタン３";
            this.Radio3.UseVisualStyleBackColor = true;
            this.Radio3.CheckedChanged += new System.EventHandler(this.Radio3_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(237, 22);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // NumUD1
            // 
            this.NumUD1.AutoSize = true;
            this.NumUD1.Location = new System.Drawing.Point(196, 27);
            this.NumUD1.Name = "NumUD1";
            this.NumUD1.Size = new System.Drawing.Size(37, 12);
            this.NumUD1.TabIndex = 9;
            this.NumUD1.Text = "数値２";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(237, 61);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // NumUD2
            // 
            this.NumUD2.AutoSize = true;
            this.NumUD2.Location = new System.Drawing.Point(196, 63);
            this.NumUD2.Name = "NumUD2";
            this.NumUD2.Size = new System.Drawing.Size(37, 12);
            this.NumUD2.TabIndex = 11;
            this.NumUD2.Text = "数値２";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "ボタン１";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "ボタン２";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "ボタン３";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(319, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "ボタン４";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelChk1
            // 
            this.labelChk1.AutoSize = true;
            this.labelChk1.Location = new System.Drawing.Point(10, 111);
            this.labelChk1.Name = "labelChk1";
            this.labelChk1.Size = new System.Drawing.Size(84, 12);
            this.labelChk1.TabIndex = 16;
            this.labelChk1.Text = "チェックボックス１：";
            // 
            // radioChk
            // 
            this.radioChk.AutoSize = true;
            this.radioChk.Location = new System.Drawing.Point(15, 300);
            this.radioChk.Name = "radioChk";
            this.radioChk.Size = new System.Drawing.Size(65, 12);
            this.radioChk.TabIndex = 17;
            this.radioChk.Text = "ラジオボタン：";
            // 
            // labelChk2
            // 
            this.labelChk2.AutoSize = true;
            this.labelChk2.Location = new System.Drawing.Point(10, 136);
            this.labelChk2.Name = "labelChk2";
            this.labelChk2.Size = new System.Drawing.Size(84, 12);
            this.labelChk2.TabIndex = 18;
            this.labelChk2.Text = "チェックボックス２：";
            // 
            // labelChk3
            // 
            this.labelChk3.AutoSize = true;
            this.labelChk3.Location = new System.Drawing.Point(10, 162);
            this.labelChk3.Name = "labelChk3";
            this.labelChk3.Size = new System.Drawing.Size(84, 12);
            this.labelChk3.TabIndex = 19;
            this.labelChk3.Text = "チェックボックス３：";
            // 
            // labelNumUD1
            // 
            this.labelNumUD1.AutoSize = true;
            this.labelNumUD1.Location = new System.Drawing.Point(237, 162);
            this.labelNumUD1.Name = "labelNumUD1";
            this.labelNumUD1.Size = new System.Drawing.Size(43, 12);
            this.labelNumUD1.TabIndex = 20;
            this.labelNumUD1.Text = "数値１：";
            // 
            // labelNumUD2
            // 
            this.labelNumUD2.AutoSize = true;
            this.labelNumUD2.Location = new System.Drawing.Point(235, 188);
            this.labelNumUD2.Name = "labelNumUD2";
            this.labelNumUD2.Size = new System.Drawing.Size(43, 12);
            this.labelNumUD2.TabIndex = 21;
            this.labelNumUD2.Text = "数値２：";
            // 
            // labelTex
            // 
            this.labelTex.AutoSize = true;
            this.labelTex.Location = new System.Drawing.Point(237, 212);
            this.labelTex.Name = "labelTex";
            this.labelTex.Size = new System.Drawing.Size(47, 12);
            this.labelTex.TabIndex = 22;
            this.labelTex.Text = "テキスト：";
            // 
            // labelButton
            // 
            this.labelButton.AutoSize = true;
            this.labelButton.Location = new System.Drawing.Point(237, 359);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(68, 12);
            this.labelButton.TabIndex = 23;
            this.labelButton.Text = "押したボタン：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 383);
            this.Controls.Add(this.labelButton);
            this.Controls.Add(this.labelTex);
            this.Controls.Add(this.labelNumUD2);
            this.Controls.Add(this.labelNumUD1);
            this.Controls.Add(this.labelChk3);
            this.Controls.Add(this.labelChk2);
            this.Controls.Add(this.radioChk);
            this.Controls.Add(this.labelChk1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumUD2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.NumUD1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Radio3);
            this.Controls.Add(this.Radio2);
            this.Controls.Add(this.Radio1);
            this.Controls.Add(this.Tex1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Chk3);
            this.Controls.Add(this.Chk2);
            this.Controls.Add(this.Chk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Chk1;
        private System.Windows.Forms.CheckBox Chk2;
        private System.Windows.Forms.CheckBox Chk3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Tex1;
        private System.Windows.Forms.RadioButton Radio1;
        private System.Windows.Forms.RadioButton Radio2;
        private System.Windows.Forms.RadioButton Radio3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label NumUD1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label NumUD2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelChk1;
        private System.Windows.Forms.Label radioChk;
        private System.Windows.Forms.Label labelChk2;
        private System.Windows.Forms.Label labelChk3;
        private System.Windows.Forms.Label labelNumUD1;
        private System.Windows.Forms.Label labelNumUD2;
        private System.Windows.Forms.Label labelTex;
        private System.Windows.Forms.Label labelButton;
    }
}

