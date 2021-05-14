
namespace Calculator
{
    partial class RDimensions

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
            this.RectangleHeightLabel = new System.Windows.Forms.Label();
            this.RectangleWidthLabel = new System.Windows.Forms.Label();
            this.RectangleHeight = new System.Windows.Forms.TextBox();
            this.RectangleWidth = new System.Windows.Forms.TextBox();
            this.RectangleArea = new System.Windows.Forms.Label();
            this.RectanglePerimeter = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DisplayMeasure = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RectangleHeightLabel
            // 
            this.RectangleHeightLabel.AutoSize = true;
            this.RectangleHeightLabel.Location = new System.Drawing.Point(85, 60);
            this.RectangleHeightLabel.Name = "RectangleHeightLabel";
            this.RectangleHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.RectangleHeightLabel.TabIndex = 0;
            this.RectangleHeightLabel.Text = "Height:";
            // 
            // RectangleWidthLabel
            // 
            this.RectangleWidthLabel.AutoSize = true;
            this.RectangleWidthLabel.Location = new System.Drawing.Point(88, 102);
            this.RectangleWidthLabel.Name = "RectangleWidthLabel";
            this.RectangleWidthLabel.Size = new System.Drawing.Size(35, 13);
            this.RectangleWidthLabel.TabIndex = 1;
            this.RectangleWidthLabel.Text = "Width";
            // 
            // RectangleHeight
            // 
            this.RectangleHeight.Location = new System.Drawing.Point(155, 60);
            this.RectangleHeight.Name = "RectangleHeight";
            this.RectangleHeight.Size = new System.Drawing.Size(100, 20);
            this.RectangleHeight.TabIndex = 2;
            // 
            // RectangleWidth
            // 
            this.RectangleWidth.Location = new System.Drawing.Point(155, 94);
            this.RectangleWidth.Name = "RectangleWidth";
            this.RectangleWidth.Size = new System.Drawing.Size(100, 20);
            this.RectangleWidth.TabIndex = 3;
            // 
            // RectangleArea
            // 
            this.RectangleArea.Location = new System.Drawing.Point(0, 0);
            this.RectangleArea.Name = "RectangleArea";
            this.RectangleArea.Size = new System.Drawing.Size(100, 23);
            this.RectangleArea.TabIndex = 9;
            // 
            // RectanglePerimeter
            // 
            this.RectanglePerimeter.Location = new System.Drawing.Point(0, 0);
            this.RectanglePerimeter.Name = "RectanglePerimeter";
            this.RectanglePerimeter.Size = new System.Drawing.Size(100, 23);
            this.RectanglePerimeter.TabIndex = 8;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(128, 136);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButtonHandler);
            // 
            // DisplayMeasure
            // 
            this.DisplayMeasure.AutoSize = true;
            this.DisplayMeasure.Location = new System.Drawing.Point(318, 80);
            this.DisplayMeasure.Name = "DisplayMeasure";
            this.DisplayMeasure.Size = new System.Drawing.Size(0, 13);
            this.DisplayMeasure.TabIndex = 7;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(233, 136);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonHandler);
            // 
            // RDimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 208);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplayMeasure);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.RectanglePerimeter);
            this.Controls.Add(this.RectangleArea);
            this.Controls.Add(this.RectangleWidth);
            this.Controls.Add(this.RectangleHeight);
            this.Controls.Add(this.RectangleWidthLabel);
            this.Controls.Add(this.RectangleHeightLabel);
            this.Name = "RDimensions";
            this.Text = "RectangleDimensions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RectangleHeightLabel;
        private System.Windows.Forms.Label RectangleWidthLabel;
        private System.Windows.Forms.TextBox RectangleHeight;
        private System.Windows.Forms.TextBox RectangleWidth;
        private System.Windows.Forms.Label RectangleArea;
        private System.Windows.Forms.Label RectanglePerimeter;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label DisplayMeasure;
        private System.Windows.Forms.Button ExitButton;
    }
}