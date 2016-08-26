namespace WindowsClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getTempButton = new System.Windows.Forms.Button();
            this.getForecastButton = new System.Windows.Forms.Button();
            this.day1LowTextBox = new System.Windows.Forms.TextBox();
            this.day1HighTextBox = new System.Windows.Forms.TextBox();
            this.day1DetailsTextBox = new System.Windows.Forms.TextBox();
            this.day2LowTextBox = new System.Windows.Forms.TextBox();
            this.day2HighTextBox = new System.Windows.Forms.TextBox();
            this.day2DetailsTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.saveForecastButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(93, 13);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(194, 20);
            this.cityTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "City :";
            // 
            // getTempButton
            // 
            this.getTempButton.Location = new System.Drawing.Point(29, 60);
            this.getTempButton.Name = "getTempButton";
            this.getTempButton.Size = new System.Drawing.Size(148, 23);
            this.getTempButton.TabIndex = 2;
            this.getTempButton.Text = "Get the Temperature";
            this.getTempButton.UseVisualStyleBackColor = true;
            this.getTempButton.Click += new System.EventHandler(this.getTempButton_Click);
            // 
            // getForecastButton
            // 
            this.getForecastButton.Location = new System.Drawing.Point(29, 100);
            this.getForecastButton.Name = "getForecastButton";
            this.getForecastButton.Size = new System.Drawing.Size(148, 23);
            this.getForecastButton.TabIndex = 3;
            this.getForecastButton.Text = "Get the forecast";
            this.getForecastButton.UseVisualStyleBackColor = true;
            this.getForecastButton.Click += new System.EventHandler(this.getForecastButton_Click);
            // 
            // day1LowTextBox
            // 
            this.day1LowTextBox.Location = new System.Drawing.Point(106, 138);
            this.day1LowTextBox.Name = "day1LowTextBox";
            this.day1LowTextBox.Size = new System.Drawing.Size(100, 20);
            this.day1LowTextBox.TabIndex = 4;
            // 
            // day1HighTextBox
            // 
            this.day1HighTextBox.Location = new System.Drawing.Point(106, 165);
            this.day1HighTextBox.Name = "day1HighTextBox";
            this.day1HighTextBox.Size = new System.Drawing.Size(100, 20);
            this.day1HighTextBox.TabIndex = 5;
            // 
            // day1DetailsTextBox
            // 
            this.day1DetailsTextBox.Location = new System.Drawing.Point(106, 192);
            this.day1DetailsTextBox.Name = "day1DetailsTextBox";
            this.day1DetailsTextBox.Size = new System.Drawing.Size(100, 20);
            this.day1DetailsTextBox.TabIndex = 6;
            // 
            // day2LowTextBox
            // 
            this.day2LowTextBox.Location = new System.Drawing.Point(106, 219);
            this.day2LowTextBox.Name = "day2LowTextBox";
            this.day2LowTextBox.Size = new System.Drawing.Size(100, 20);
            this.day2LowTextBox.TabIndex = 7;
            // 
            // day2HighTextBox
            // 
            this.day2HighTextBox.Location = new System.Drawing.Point(106, 246);
            this.day2HighTextBox.Name = "day2HighTextBox";
            this.day2HighTextBox.Size = new System.Drawing.Size(100, 20);
            this.day2HighTextBox.TabIndex = 8;
            // 
            // day2DetailsTextBox
            // 
            this.day2DetailsTextBox.Location = new System.Drawing.Point(106, 273);
            this.day2DetailsTextBox.Name = "day2DetailsTextBox";
            this.day2DetailsTextBox.Size = new System.Drawing.Size(100, 20);
            this.day2DetailsTextBox.TabIndex = 9;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(106, 305);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Day1Low";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Day1High";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Day1Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Day2Low";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Day2High";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Day2Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Author";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(226, 60);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(104, 13);
            this.temperatureLabel.TabIndex = 18;
            this.temperatureLabel.Text = "The temperature is...";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // saveForecastButton
            // 
            this.saveForecastButton.Location = new System.Drawing.Point(383, 138);
            this.saveForecastButton.Name = "saveForecastButton";
            this.saveForecastButton.Size = new System.Drawing.Size(75, 23);
            this.saveForecastButton.TabIndex = 20;
            this.saveForecastButton.Text = "Save";
            this.saveForecastButton.UseVisualStyleBackColor = true;
            this.saveForecastButton.Click += new System.EventHandler(this.saveForecastButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 337);
            this.Controls.Add(this.saveForecastButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.day2DetailsTextBox);
            this.Controls.Add(this.day2HighTextBox);
            this.Controls.Add(this.day2LowTextBox);
            this.Controls.Add(this.day1DetailsTextBox);
            this.Controls.Add(this.day1HighTextBox);
            this.Controls.Add(this.day1LowTextBox);
            this.Controls.Add(this.getForecastButton);
            this.Controls.Add(this.getTempButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getTempButton;
        private System.Windows.Forms.Button getForecastButton;
        private System.Windows.Forms.TextBox day1LowTextBox;
        private System.Windows.Forms.TextBox day1HighTextBox;
        private System.Windows.Forms.TextBox day1DetailsTextBox;
        private System.Windows.Forms.TextBox day2LowTextBox;
        private System.Windows.Forms.TextBox day2HighTextBox;
        private System.Windows.Forms.TextBox day2DetailsTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveForecastButton;
    }
}

