namespace WinForms_SimpleCalculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.unitsRadioGroup = new System.Windows.Forms.GroupBox();
            this.radioPoundsFeet = new System.Windows.Forms.RadioButton();
            this.radioKilogramsMeters = new System.Windows.Forms.RadioButton();
            this.mass1 = new System.Windows.Forms.NumericUpDown();
            this.mass2 = new System.Windows.Forms.NumericUpDown();
            this.distance = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.unitsRadioGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gravitational Attraction Calculator";
            // 
            // unitsRadioGroup
            // 
            this.unitsRadioGroup.BackColor = System.Drawing.Color.Transparent;
            this.unitsRadioGroup.Controls.Add(this.radioPoundsFeet);
            this.unitsRadioGroup.Controls.Add(this.radioKilogramsMeters);
            this.unitsRadioGroup.ForeColor = System.Drawing.Color.White;
            this.unitsRadioGroup.Location = new System.Drawing.Point(96, 82);
            this.unitsRadioGroup.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.unitsRadioGroup.Name = "unitsRadioGroup";
            this.unitsRadioGroup.Size = new System.Drawing.Size(200, 74);
            this.unitsRadioGroup.TabIndex = 1;
            this.unitsRadioGroup.TabStop = false;
            this.unitsRadioGroup.Text = "Units for Calculation";
            // 
            // radioPoundsFeet
            // 
            this.radioPoundsFeet.AutoSize = true;
            this.radioPoundsFeet.Location = new System.Drawing.Point(7, 44);
            this.radioPoundsFeet.Name = "radioPoundsFeet";
            this.radioPoundsFeet.Size = new System.Drawing.Size(106, 17);
            this.radioPoundsFeet.TabIndex = 1;
            this.radioPoundsFeet.Text = "Pounds and Feet";
            this.radioPoundsFeet.UseVisualStyleBackColor = true;
            // 
            // radioKilogramsMeters
            // 
            this.radioKilogramsMeters.AutoSize = true;
            this.radioKilogramsMeters.Checked = true;
            this.radioKilogramsMeters.Location = new System.Drawing.Point(7, 20);
            this.radioKilogramsMeters.Name = "radioKilogramsMeters";
            this.radioKilogramsMeters.Size = new System.Drawing.Size(126, 17);
            this.radioKilogramsMeters.TabIndex = 0;
            this.radioKilogramsMeters.TabStop = true;
            this.radioKilogramsMeters.Text = "Kilograms and Meters";
            this.radioKilogramsMeters.UseVisualStyleBackColor = true;
            // 
            // mass1
            // 
            this.mass1.Location = new System.Drawing.Point(176, 162);
            this.mass1.Name = "mass1";
            this.mass1.Size = new System.Drawing.Size(120, 20);
            this.mass1.TabIndex = 2;
            // 
            // mass2
            // 
            this.mass2.Location = new System.Drawing.Point(176, 188);
            this.mass2.Name = "mass2";
            this.mass2.Size = new System.Drawing.Size(120, 20);
            this.mass2.TabIndex = 3;
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(176, 215);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(120, 20);
            this.distance.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mass 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(100, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mass 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Distance";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Transparent;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(190, 300);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 45, 3, 60);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(106, 41);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(96, 300);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 41);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(372, 238);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(135, 41);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(100, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Where should we send your calculation?";
            // 
            // emailField
            // 
            this.emailField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.emailField.Location = new System.Drawing.Point(103, 263);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(193, 20);
            this.emailField.TabIndex = 5;
            this.emailField.Text = "ex: name@mail.com";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 366);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.mass2);
            this.Controls.Add(this.mass1);
            this.Controls.Add(this.unitsRadioGroup);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(618, 405);
            this.MinimumSize = new System.Drawing.Size(618, 405);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.unitsRadioGroup.ResumeLayout(false);
            this.unitsRadioGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox unitsRadioGroup;
        private System.Windows.Forms.RadioButton radioPoundsFeet;
        private System.Windows.Forms.RadioButton radioKilogramsMeters;
        private System.Windows.Forms.NumericUpDown mass1;
        private System.Windows.Forms.NumericUpDown mass2;
        private System.Windows.Forms.NumericUpDown distance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailField;
    }
}

