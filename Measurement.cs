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
    public partial class Measurement : Form
    {
        public string measurement;
        public Measurement(string Shape)
        {
            InitializeComponent();
            this.Text = Shape;
            
        }

        private void PerimeterButtonHandler(object sender, EventArgs e)
        {
            measurement = "Perimeter";
        }

        private void AreaButtonHandler(object sender, EventArgs e)
        {
            measurement = "Area";

        }

        private void NextButton2Handler(object sender, EventArgs e)
        {
            if (Text == "Triangle")
            {
                this.Hide();
                TriangleDimensions TriangleMeasure = new TriangleDimensions(measurement);
                TriangleMeasure.Show();
            }
            else if  (Text == "Rectangle") {

                this.Hide();
                RDimensions RectangleMeasure = new RDimensions(measurement);
                RectangleMeasure.Show();
            }
            else
            {
                this.Hide();
                CDimensions CircleMeasure = new CDimensions(measurement);
                CircleMeasure.Show();

            }

        }
    }
}
