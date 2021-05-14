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
    public partial class RDimensions : Form
    {
        public RDimensions(string measurement)
        {
            InitializeComponent();
            this.Text = measurement;
        }

        private void CalculateButtonHandler(object sender, EventArgs e)
        {
            double width = double.Parse(RectangleWidth.Text);
            double height = double.Parse(RectangleHeight.Text);
            if (Text == "Perimeter")
            {
                double perimeter = 2 * (height + width);
                DisplayMeasure.Text = "Perimeter: " + perimeter;

            }
            else
            { 
                double area = height * width;
                DisplayMeasure.Text = "Area: " + area;
            }
        }

        private void ExitButtonHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
