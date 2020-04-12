namespace Disc
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Close_button = new System.Windows.Forms.Button();
            this.Start_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.AngleTextBox = new System.Windows.Forms.TextBox();
            this.DepthCutTextBox = new System.Windows.Forms.TextBox();
            this.CentralCutTextBox = new System.Windows.Forms.TextBox();
            this.InsideDiameterTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.MainDiameterTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuildButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Close_button);
            this.groupBox1.Controls.Add(this.Start_button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 63);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Компас 3D";
            // 
            // Close_button
            // 
            this.Close_button.Location = new System.Drawing.Point(212, 19);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(131, 30);
            this.Close_button.TabIndex = 16;
            this.Close_button.Text = "Закрыть Компас 3D";
            this.Close_button.UseVisualStyleBackColor = true;
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(29, 19);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(131, 30);
            this.Start_button.TabIndex = 15;
            this.Start_button.Text = "Открыть Компас 3D";
            this.Start_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Задайте параметры для построения 3D-модели диска гантели:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WarningLabel);
            this.groupBox2.Controls.Add(this.AngleTextBox);
            this.groupBox2.Controls.Add(this.DepthCutTextBox);
            this.groupBox2.Controls.Add(this.CentralCutTextBox);
            this.groupBox2.Controls.Add(this.InsideDiameterTextBox);
            this.groupBox2.Controls.Add(this.WidthTextBox);
            this.groupBox2.Controls.Add(this.MainDiameterTextBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 264);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод параметров";
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(11, 236);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(161, 13);
            this.WarningLabel.TabIndex = 30;
            this.WarningLabel.Text = "Параметры введены неверно!";
            this.WarningLabel.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // AngleTextBox
            // 
            this.AngleTextBox.Location = new System.Drawing.Point(143, 199);
            this.AngleTextBox.Name = "AngleTextBox";
            this.AngleTextBox.Size = new System.Drawing.Size(100, 20);
            this.AngleTextBox.TabIndex = 29;
            this.AngleTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // DepthCutTextBox
            // 
            this.DepthCutTextBox.Location = new System.Drawing.Point(143, 164);
            this.DepthCutTextBox.Name = "DepthCutTextBox";
            this.DepthCutTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepthCutTextBox.TabIndex = 28;
            this.DepthCutTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // CentralCutTextBox
            // 
            this.CentralCutTextBox.Location = new System.Drawing.Point(143, 129);
            this.CentralCutTextBox.Name = "CentralCutTextBox";
            this.CentralCutTextBox.Size = new System.Drawing.Size(100, 20);
            this.CentralCutTextBox.TabIndex = 27;
            this.CentralCutTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // InsideDiameterTextBox
            // 
            this.InsideDiameterTextBox.Location = new System.Drawing.Point(143, 94);
            this.InsideDiameterTextBox.Name = "InsideDiameterTextBox";
            this.InsideDiameterTextBox.Size = new System.Drawing.Size(100, 20);
            this.InsideDiameterTextBox.TabIndex = 26;
            this.InsideDiameterTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(143, 59);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 25;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // MainDiameterTextBox
            // 
            this.MainDiameterTextBox.Location = new System.Drawing.Point(143, 23);
            this.MainDiameterTextBox.Name = "MainDiameterTextBox";
            this.MainDiameterTextBox.Size = new System.Drawing.Size(100, 20);
            this.MainDiameterTextBox.TabIndex = 24;
            this.MainDiameterTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(249, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "( от 1 до 10 градусов )";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(249, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "( от 5 до 10 мм )";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "( от 80 до D - 30 мм )";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "( 26 или 31 мм )";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "( от 26 до 69 мм )";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "( от 137 до 251 мм )";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Угол скругления рёбер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Толщина H";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Глубина выреза F";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Центральный вырез C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Внутренний диаметр B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Внешний диаметр D";
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(90, 397);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(219, 41);
            this.BuildButton.TabIndex = 20;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BuildButton);
            this.Name = "MainForm";
            this.Text = "Построитель";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AngleTextBox;
        private System.Windows.Forms.TextBox DepthCutTextBox;
        private System.Windows.Forms.TextBox CentralCutTextBox;
        private System.Windows.Forms.TextBox InsideDiameterTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox MainDiameterTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Label WarningLabel;
    }
}

