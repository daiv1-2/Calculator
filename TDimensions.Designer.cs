
namespace Calculator
{
    partial class TriangleDimensions
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
            this.label1 = new System.Windows.Forms.Label();
            this.Length1Label = new System.Windows.Forms.Label();
            this.Length2Label = new System.Windows.Forms.Label();
            this.Length3Label = new System.Windows.Forms.Label();
            this.Length1TextBox = new System.Windows.Forms.TextBox();
            this.Length2TextBox = new System.Windows.Forms.TextBox();
            this.Length3TextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.TriangleAreaLabel = new System.Windows.Forms.Label();
            this.TrianglePerimeterLabel = new System.Windows.Forms.Label();
            this.DisplayMeasure = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Length1Label
            // 
            this.Length1Label.AutoSize = true;
            this.Length1Label.Location = new System.Drawing.Point(66, 62);
            this.Length1Label.Name = "Length1Label";
            this.Length1Label.Size = new System.Drawing.Size(46, 13);
            this.Length1Label.TabIndex = 1;
            this.Length1Label.Text = "Length1";
            // 
            // Length2Label
            // 
            this.Length2Label.AutoSize = true;
            this.Length2Label.Location = new System.Drawing.Point(66, 105);
            this.Length2Label.Name = "Length2Label";
            this.Length2Label.Size = new System.Drawing.Size(46, 13);
            this.Length2Label.TabIndex = 2;
            this.Length2Label.Text = "Length2";
            // 
            // Length3Label
            // 
            this.Length3Label.AutoSize = true;
            this.Length3Label.Location = new System.Drawing.Point(66, 151);
            this.Length3Label.Name = "Length3Label";
            this.Length3Label.Size = new System.Drawing.Size(46, 13);
            this.Length3Label.TabIndex = 3;
            this.Length3Label.Text = "Length3";
            // 
            // Length1TextBox
            // 
            this.Length1TextBox.Location = new System.Drawing.Point(128, 62);
            this.Length1TextBox.Name = "Length1TextBox";
            this.Length1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Length1TextBox.TabIndex = 4;
            // 
            // Length2TextBox
            // 
            this.Length2TextBox.Location = new System.Drawing.Point(128, 105);
            this.Length2TextBox.Name = "Length2TextBox";
            this.Length2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Length2TextBox.TabIndex = 5;
            // 
            // Length3TextBox
            // 
            this.Length3TextBox.Location = new System.Drawing.Point(128, 148);
            this.Length3TextBox.Name = "Length3TextBox";
            this.Length3TextBox.Size = new System.Drawing.Size(100, 20);
            this.Length3TextBox.TabIndex = 6;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(128, 192);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButtonHandler);
            // 
            // TriangleAreaLabel
            // 
            this.TriangleAreaLabel.AutoSize = true;
            this.TriangleAreaLabel.Location = new System.Drawing.Point(291, 78);
            this.TriangleAreaLabel.Name = "TriangleAreaLabel";
            this.TriangleAreaLabel.Size = new System.Drawing.Size(0, 13);
            this.TriangleAreaLabel.TabIndex = 8;
            // 
            // TrianglePerimeterLabel
            // 
            this.TrianglePerimeterLabel.AutoSize = true;
            this.TrianglePerimeterLabel.Location = new System.Drawing.Point(291, 123);
            this.TrianglePerimeterLabel.Name = "TrianglePerimeterLabel";
            this.TrianglePerimeterLabel.Size = new System.Drawing.Size(0, 13);
            this.TrianglePerimeterLabel.TabIndex = 9;
            // 
            // DisplayMeasure
            // 
            this.DisplayMeasure.AutoSize = true;
            this.DisplayMeasure.Location = new System.Drawing.Point(294, 105);
            this.DisplayMeasure.Name = "DisplayMeasure";
            this.DisplayMeasure.Size = new System.Drawing.Size(0, 13);
            this.DisplayMeasure.TabIndex = 10;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(247, 191);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonHandler);
            // 
            // TriangleDimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 260);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplayMeasure);
            this.Controls.Add(this.TrianglePerimeterLabel);
            this.Controls.Add(this.TriangleAreaLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Length3TextBox);
            this.Controls.Add(this.Length2TextBox);
            this.Controls.Add(this.Length1TextBox);
            this.Controls.Add(this.Length3Label);
            this.Controls.Add(this.Length2Label);
            this.Controls.Add(this.Length1Label);
            this.Controls.Add(this.label1);
            this.Name = "TriangleDimensions";
            this.Text = "TriangleDimensions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Length1Label;
        private System.Windows.Forms.Label Length2Label;
        private System.Windows.Forms.Label Length3Label;
        private System.Windows.Forms.TextBox Length1TextBox;
        private System.Windows.Forms.TextBox Length2TextBox;
        private System.Windows.Forms.TextBox Length3TextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label TriangleAreaLabel;
        private System.Windows.Forms.Label TrianglePerimeterLabel;
        private System.Windows.Forms.Label DisplayMeasure;
        private System.Windows.Forms.Button ExitButton;
    }
}