namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        int freq = 0;
        int duration = 0;
        int wordsPerMin = 0;
       

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
            this.components = new System.ComponentModel.Container();
            this.translateButton = new System.Windows.Forms.Button();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.notationLable = new System.Windows.Forms.Label();
            this.notationStyle = new System.Windows.Forms.ComboBox();
            this.speedBox = new System.Windows.Forms.ComboBox();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.FrequencyLabel = new System.Windows.Forms.Label();
            this.frequencyBox = new System.Windows.Forms.ComboBox();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.playButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(17, 375);
            this.translateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(120, 28);
            this.translateButton.TabIndex = 0;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            this.translateButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.trackBar1);
            this.settingsGroupBox.Controls.Add(this.notationLable);
            this.settingsGroupBox.Controls.Add(this.notationStyle);
            this.settingsGroupBox.Controls.Add(this.speedBox);
            this.settingsGroupBox.Controls.Add(this.SpeedLabel);
            this.settingsGroupBox.Controls.Add(this.FrequencyLabel);
            this.settingsGroupBox.Controls.Add(this.frequencyBox);
            this.settingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsGroupBox.Location = new System.Drawing.Point(615, 108);
            this.settingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsGroupBox.Size = new System.Drawing.Size(335, 278);
            this.settingsGroupBox.TabIndex = 1;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            this.settingsGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 164);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Maximum = 6;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(289, 56);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // notationLable
            // 
            this.notationLable.AutoSize = true;
            this.notationLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notationLable.Location = new System.Drawing.Point(8, 110);
            this.notationLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notationLable.Name = "notationLable";
            this.notationLable.Size = new System.Drawing.Size(104, 17);
            this.notationLable.TabIndex = 10;
            this.notationLable.Text = "Notation Style :";
            // 
            // notationStyle
            // 
            this.notationStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.notationStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notationStyle.FormattingEnabled = true;
            this.notationStyle.Items.AddRange(new object[] {
            "* and - ",
            "\'dit\' and \'dah\'"});
            this.notationStyle.Location = new System.Drawing.Point(136, 103);
            this.notationStyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notationStyle.Name = "notationStyle";
            this.notationStyle.Size = new System.Drawing.Size(160, 26);
            this.notationStyle.TabIndex = 9;
            // 
            // speedBox
            // 
            this.speedBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.speedBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.speedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedBox.FormattingEnabled = true;
            this.speedBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40"});
            this.speedBox.Location = new System.Drawing.Point(136, 63);
            this.speedBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(137, 25);
            this.speedBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.speedBox, "Enter a value between 5 - 60");
            this.speedBox.Leave += new System.EventHandler(this.speedBox_Leave);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLabel.Location = new System.Drawing.Point(8, 66);
            this.SpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(102, 17);
            this.SpeedLabel.TabIndex = 6;
            this.SpeedLabel.Text = "Speed / WPM :";
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.AutoSize = true;
            this.FrequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrequencyLabel.Location = new System.Drawing.Point(8, 23);
            this.FrequencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(119, 17);
            this.FrequencyLabel.TabIndex = 5;
            this.FrequencyLabel.Text = "Frequency in Hz :";
            // 
            // frequencyBox
            // 
            this.frequencyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyBox.FormattingEnabled = true;
            this.frequencyBox.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.frequencyBox.Location = new System.Drawing.Point(136, 20);
            this.frequencyBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frequencyBox.Name = "frequencyBox";
            this.frequencyBox.Size = new System.Drawing.Size(137, 25);
            this.frequencyBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.frequencyBox, "Enter a value between 100 - 1000");
            this.frequencyBox.Leave += new System.EventHandler(this.comboBox1_Leave);
            this.frequencyBox.Validating += new System.ComponentModel.CancelEventHandler(this.frequencyBox_Validating);
            this.frequencyBox.Validated += new System.EventHandler(this.frequencyBox_Validated);
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.inputBox);
            this.inputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGroupBox.Location = new System.Drawing.Point(17, 16);
            this.inputGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputGroupBox.Size = new System.Drawing.Size(589, 170);
            this.inputGroupBox.TabIndex = 5;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(15, 28);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(557, 120);
            this.inputBox.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(16, 25);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(557, 120);
            this.outputBox.TabIndex = 0;
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputBox);
            this.outputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputGroupBox.Location = new System.Drawing.Point(17, 206);
            this.outputGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputGroupBox.Size = new System.Drawing.Size(589, 162);
            this.outputGroupBox.TabIndex = 6;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(145, 375);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(120, 28);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(273, 375);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(120, 28);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 416);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.translateButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Morse Code Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.ComboBox frequencyBox;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label FrequencyLabel;
        private System.Windows.Forms.ComboBox speedBox;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox notationStyle;
        private System.Windows.Forms.Label notationLable;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

