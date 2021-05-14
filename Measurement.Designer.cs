
namespace Calculator
{
    partial class Measurement
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
            this.PerimeterButton = new System.Windows.Forms.Button();
            this.AreaButton = new System.Windows.Forms.Button();
            this.NextButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose what you want to calculate:";
            // 
            // PerimeterButton
            // 
            this.PerimeterButton.Location = new System.Drawing.Point(98, 120);
            this.PerimeterButton.Name = "PerimeterButton";
            this.PerimeterButton.Size = new System.Drawing.Size(75, 23);
            this.PerimeterButton.TabIndex = 1;
            this.PerimeterButton.Text = "Perimeter";
            this.PerimeterButton.UseVisualStyleBackColor = true;
            this.PerimeterButton.Click += new System.EventHandler(this.PerimeterButtonHandler);
            // 
            // AreaButton
            // 
            this.AreaButton.Location = new System.Drawing.Point(243, 120);
            this.AreaButton.Name = "AreaButton";
            this.AreaButton.Size = new System.Drawing.Size(75, 23);
            this.AreaButton.TabIndex = 2;
            this.AreaButton.Text = "Area";
            this.AreaButton.UseVisualStyleBackColor = true;
            this.AreaButton.Click += new System.EventHandler(this.AreaButtonHandler);
            // 
            // NextButton2
            // 
            this.NextButton2.Location = new System.Drawing.Point(171, 172);
            this.NextButton2.Name = "NextButton2";
            this.NextButton2.Size = new System.Drawing.Size(75, 23);
            this.NextButton2.TabIndex = 3;
            this.NextButton2.Text = "Next";
            this.NextButton2.UseVisualStyleBackColor = true;
            this.NextButton2.Click += new System.EventHandler(this.NextButton2Handler);
            // 
            // Measurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 286);
            this.Controls.Add(this.NextButton2);
            this.Controls.Add(this.AreaButton);
            this.Controls.Add(this.PerimeterButton);
            this.Controls.Add(this.label1);
            this.Name = "Measurement";
            this.Text = "Measurements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PerimeterButton;
        private System.Windows.Forms.Button AreaButton;
        private System.Windows.Forms.Button NextButton2;
    }
}