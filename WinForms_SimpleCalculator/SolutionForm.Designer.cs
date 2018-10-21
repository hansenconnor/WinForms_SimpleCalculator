namespace WinForms_SimpleCalculator
{
    partial class SolutionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionForm));
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Coral;
            this.ResultLabel.Location = new System.Drawing.Point(0, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(602, 366);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Result";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(602, 366);
            this.Controls.Add(this.ResultLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(618, 405);
            this.MinimumSize = new System.Drawing.Size(618, 405);
            this.Name = "SolutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solution";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
    }
}