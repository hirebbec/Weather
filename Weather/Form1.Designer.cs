namespace Weather
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            CityComboBox = new ComboBox();
            button1 = new Button();
            temperatureLabel = new Label();
            temperatureBox = new TextBox();
            descritionLabel = new Label();
            descritionBox = new TextBox();
            WindSpeedLabel = new Label();
            windSpeedBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 130);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Укажите город";
            // 
            // CityComboBox
            // 
            CityComboBox.FormattingEnabled = true;
            CityComboBox.Items.AddRange(new object[] { "London", "Moscow" });
            CityComboBox.Location = new Point(89, 153);
            CityComboBox.Name = "CityComboBox";
            CityComboBox.Size = new Size(151, 28);
            CityComboBox.TabIndex = 1;
            CityComboBox.Text = " ";
            // 
            // button1
            // 
            button1.Location = new Point(89, 195);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 2;
            button1.Text = "Узнать погоду";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new Point(362, 45);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(100, 20);
            temperatureLabel.TabIndex = 3;
            temperatureLabel.Text = "Температура";
            // 
            // temperatureBox
            // 
            temperatureBox.Location = new Point(362, 68);
            temperatureBox.Name = "temperatureBox";
            temperatureBox.Size = new Size(155, 27);
            temperatureBox.TabIndex = 4;
            // 
            // descritionLabel
            // 
            descritionLabel.AutoSize = true;
            descritionLabel.Location = new Point(362, 131);
            descritionLabel.Name = "descritionLabel";
            descritionLabel.Size = new Size(79, 20);
            descritionLabel.TabIndex = 5;
            descritionLabel.Text = "Описание";
            // 
            // descritionBox
            // 
            descritionBox.Location = new Point(362, 154);
            descritionBox.Name = "descritionBox";
            descritionBox.Size = new Size(155, 27);
            descritionBox.TabIndex = 6;
            // 
            // WindSpeedLabel
            // 
            WindSpeedLabel.AutoSize = true;
            WindSpeedLabel.Location = new Point(362, 228);
            WindSpeedLabel.Name = "WindSpeedLabel";
            WindSpeedLabel.Size = new Size(116, 20);
            WindSpeedLabel.TabIndex = 7;
            WindSpeedLabel.Text = "Скорость ветра";
            // 
            // windSpeedBox
            // 
            windSpeedBox.Location = new Point(362, 251);
            windSpeedBox.Name = "windSpeedBox";
            windSpeedBox.Size = new Size(155, 27);
            windSpeedBox.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 348);
            Controls.Add(windSpeedBox);
            Controls.Add(WindSpeedLabel);
            Controls.Add(descritionBox);
            Controls.Add(descritionLabel);
            Controls.Add(temperatureBox);
            Controls.Add(temperatureLabel);
            Controls.Add(button1);
            Controls.Add(CityComboBox);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CityComboBox;
        private Button button1;
        private Label temperatureLabel;
        private TextBox temperatureBox;
        private Label descritionLabel;
        private TextBox descritionBox;
        private Label WindSpeedLabel;
        private TextBox windSpeedBox;
    }
}