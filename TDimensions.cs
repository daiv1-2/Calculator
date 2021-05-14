using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class TriangleDimensions : Form
    {
        public TriangleDimensions(string measurement)
        {
            InitializeComponent();
            this.Text = measurement;
        }

        private void CalculateButtonHandler(object sender, EventArgs e)
        {

            double length1 = double.Parse(Length1TextBox.Text);
            double length2 = double.Parse(Length2TextBox.Text);
            double length3 = double.Parse(Length3TextBox.Text);
            double TPerimeter = length1 + length2 + length3;
            if (Text == "Perimeter")
            {
                DisplayMeasure.Text = "Perimeter: " + TPerimeter.ToString();
            }
            else
            {
                double s = TPerimeter / 2;
                double temp = s * (s - length1) * (s - length2) * (s - length3);
                double TArea = Math.Sqrt(temp);

                DisplayMeasure.Text = "Area:  " + TArea.ToString("#.000");
            }

        }

        private void ExitButtonHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
