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
    public partial class Shape : Form
    {

        public string ShapeChosen;
        
        public Shape()
        {
            InitializeComponent();
        }

        private void TriangleHandler(object sender, EventArgs e)
        {
            this.ShapeChosen = "Triangle";
         
        }

        private void RectangleHandler(object sender, EventArgs e)
        {
            this.ShapeChosen = "Rectangle";
        }

 

        private void CircleHandler(object sender, EventArgs e)
        {
            this.ShapeChosen = "Circle";
        }

        private void NextButtonHandler(object sender, EventArgs e)
        {
            this.Hide();
            Measurement MeasurementForm = new Measurement(ShapeChosen);
            MeasurementForm.Show();
        }
    }
}
