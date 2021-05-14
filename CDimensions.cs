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
    public partial class CDimensions : Form
    {
        public CDimensions(string measurement)
        {
            InitializeComponent();
            this.Text = measurement;
        }

        private void CalculateButtonHandler(object sender, EventArgs e)
        {
            double radius = Double.Parse(RadiusTextBox.Text);

            if (Text == "Perimeter")
            {
                double perimeter = 2 * Math.PI * radius;
                DisplayMeasure.Text = "Perimeter: " + perimeter.ToString("#.000");
            }
            else
            {
                double area = Math.PI * Math.Pow(radius, 2);
                DisplayMeasure.Text = "Area: " + area.ToString("#.000");
            }
        }

        private void ExitButtonHandler(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
